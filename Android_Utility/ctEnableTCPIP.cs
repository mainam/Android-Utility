﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Utility.Utils;
using System.Threading;
using System.Text.RegularExpressions;

namespace Android_Utility
{
    public partial class ctEnableTCPIP : UserControl
    {
        private UtilEvent utilEvent;

        public ctEnableTCPIP(UtilEvent utilEvent)
        {
            InitializeComponent();
            this.utilEvent = utilEvent;
        }

        private ctListOfDevice listofdevice;
        public ctListOfDevice ListOfDevice
        {
            get
            {
                return listofdevice;
            }
            set
            {
                listofdevice = value;
            }
        }

        private void ctEnableTCPIP_SizeChanged(object sender, EventArgs e)
        {
            btnConnect.Left = (this.Width - btnConnect.Width) / 2;
            btnConnect.Top = (this.Height - btnConnect.Height) / 2;
        }

        Thread threadRunAdb;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                utilEvent.AbortThread(threadRunAdb, utilEvent.InsertLog);
                threadRunAdb = new Thread(delegate ()
                {
                    try
                    {

                        AdbCommand adb = new AdbCommand();
                        String ip = "";
                        adb.OutputTextRunADB += (a, b) =>
                        {
                            try
                            {
                                var sourceString = a.ToString();
                                if (String.IsNullOrWhiteSpace(sourceString))
                                    return;
                                var match = Regex.Match(sourceString, @"\b(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\b");
                                if (match.Success && ip == "")
                                {
                                    ip = match.Captures[0].ToString();
                                    utilEvent.InsertLog("IP: " + ip, b);
                                }
                                else
                                {
                                    if (!sourceString.ToLower().Contains("process with an"))
                                        utilEvent.InsertLog(a, b);
                                }
                            }
                            catch (Exception)
                            {
                            }
                        };
                        adb.ExecuteCommandSync("adb -s " + listofdevice.CurrentDevice.SerialNumber + " shell ifconfig wlan0", true);
                        adb.ExecuteCommandSync("adb -s " + listofdevice.CurrentDevice.SerialNumber + " tcpip 5555", true);
                        adb.ExecuteCommandSync("adb connect " + ip, true);
                    }
                    catch (Exception)
                    {

                    }
                });
                threadRunAdb.Start();
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }
    }
}

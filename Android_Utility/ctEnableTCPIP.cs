using System;
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

        public void setTempIP()
        {
            txtIP.DataText = MLLib.Windows.Registry.ReadKey(Constant.IPTCPIP);
        }

        private void ctEnableTCPIP_SizeChanged(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        Thread threadRunAdb;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var match = Regex.Match(txtIP.DataText, @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                if (match.Success)
                {

                    utilEvent.AbortThread(threadRunAdb, utilEvent.InsertLog);
                    threadRunAdb = new Thread(delegate ()
                    {
                        try
                        {
                            AdbCommand adb = new AdbCommand();
                            adb.OutputTextRunADB += utilEvent.InsertLog;
                            adb.ExecuteCommandSync("adb connect " + txtIP.DataText, true);
                            MLLib.Windows.Registry.WriteKey(Constant.IPTCPIP, txtIP.DataText);
                        }
                        catch (Exception)
                        {

                        }
                    });
                    threadRunAdb.Start();
                }
                else
                {
                    utilEvent.InsertLog("Please enter IP of your device ", UtilLog.LogType.Error);
                }


            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }

        private void btnTurnOnAndConnect_Click(object sender, EventArgs e)
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
                                    MLLib.Windows.Registry.WriteKey(Constant.IPTCPIP, ip);
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

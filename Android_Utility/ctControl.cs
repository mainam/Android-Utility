using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using MLLib.Controls;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctControl : UserControl
    {
        AdbCommand RunAdb;
        UtilEvent utilEvent;
        public ctControl(UtilEvent utilEvent)
        {
            InitializeComponent();
            this.utilEvent = utilEvent;
            RunAdb = new AdbCommand();
            RunAdb.OutputTextRunADB += utilEvent.InsertLog;
        }

        private ctListOfDevice _listofdevice;
        public ctListOfDevice ListOfDevice
        {
            get
            {
                return _listofdevice;
            }
            set
            {
                _listofdevice = value;
            }
        }


        private void ctRunADB_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                RunAdb.ExecuteCommandSync("adb devices");
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }

        private void ctKillAdb_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                RunAdb.ExecuteCommandSync("taskkill /im adb.exe /f");
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }

        private void ctRebootDownload_Click(object sender, EventArgs e)
        {
            if (ListOfDevice.CurrentDevice != null)
            {
                try
                {
                    if (ListOfDevice.CurrentDevice.IsOffline)
                    {
                        MessageBox.Show("Device is offline");
                        utilEvent.InsertLog("Reboot to download mode but device is offline", UtilLog.LogType.Text);
                        return;
                    }
                    ListOfDevice.CurrentDevice.Reboot("download");
                    utilEvent.InsertLog("Reboot to download mode", UtilLog.LogType.Text);
                }
                catch (Exception)
                {
                    utilEvent.InsertLog("Exception occur when reboot to download mode device", UtilLog.LogType.Error);
                }
            }
        }

        private void ctRebootUpload_Click(object sender, EventArgs e)
        {
            if (ListOfDevice.CurrentDevice != null)
            {
                try
                {
                    if (ListOfDevice.CurrentDevice.IsOffline)
                    {
                        MessageBox.Show("Device is offline");
                        utilEvent.InsertLog("Reboot to upload mode but device is offline", UtilLog.LogType.Text);
                        return;
                    }
                    ListOfDevice.CurrentDevice.Reboot("upload");
                    utilEvent.InsertLog("Reboot to upload mode", UtilLog.LogType.Text);
                }
                catch (Exception)
                {
                    utilEvent.InsertLog("Exception occur when reboot to upload mode device", UtilLog.LogType.Error);
                } 
            }
        }

    }
}

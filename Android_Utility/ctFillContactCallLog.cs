using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using MLLib.Controls;

namespace Android_Utility
{
    public partial class ctFillContactCallLog : UserControl
    {
        AdbCommand adb;
        AdbCommand logcat;

        public ctFillContactCallLog()
        {
            InitializeComponent();

            adb = new AdbCommand();

            logcat = new AdbCommand();
            logcat.OutputTextRunADB += (a, b) =>
            {
                if (a != null)
                {
                    String text = a.ToString();
                    if (text.Contains("AndroidUtility"))
                    {
                        utilEvent.InsertLog(text, Utils.UtilLog.LogType.Success);
                    }
                }
            };

        }

        public Utils.UtilEvent utilEvent
        {
            get;
            set;
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
                if (listofdevice != null && listofdevice.CurrentDevice!=null)
                {
                    listofdevice.CurrentDevice.ExecuteAdbCommand(logcat, " logcat -c ", true);
                    listofdevice.CurrentDevice.ExecuteAdbCommand(logcat, " logcat -s \"AndroidUtility\"", false);
                    listofdevice.ChangeDevice += (a, b) => {
                        installservice = false;
                    };
                }

            }
        }


        bool installservice = false;

        private void btnFillCallLog_Click(object sender, EventArgs e)
        {
            if (listofdevice == null || listofdevice.CurrentDevice == null)
            {
                utilEvent.InsertLog("Please select device to fill call log", Utils.UtilLog.LogType.Error);
                return;
            }
            if (txtMissed.Text == "0" && txtOutGoing.Text == "0" && txtInComing.Text == "0")
            {
                utilEvent.InsertLog("Please input number missed, incoming of outgoing to fill", Utils.UtilLog.LogType.Info);
                utilEvent.InsertLog("Please input number missed, incoming of outgoing to fill", Utils.UtilLog.LogType.Info);
                utilEvent.InsertLog("Please input number missed, incoming of outgoing to fill", Utils.UtilLog.LogType.Info);
                return;
            }

            utilEvent.InsertLog("Fill data calllog", Utils.UtilLog.LogType.Text);
            new Thread(delegate()
            {
                try
                {
                    if (InstallService())
                    {
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg CALLLOG:MISSED_TYPE:" + txtMissed.Text, false);
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg CALLLOG:INCOMING_TYPE:" + txtInComing.Text, false);
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg CALLLOG:OUTGOING_TYPE:" + txtOutGoing.Text, false);
                    }
                }
                catch (Exception e1)
                {
                    utilEvent.InsertLog(e1.Message, Utils.UtilLog.LogType.Error);
                    utilEvent.InsertLog("Exception occur, can't fill call log", Utils.UtilLog.LogType.Error);
                }

            }).Start();

        }

        object obj = new object();
        bool InstallService()
        {
            lock (obj)
            {
                if (!installservice)
                {
                    utilEvent.InsertLog("Wating for install service", Utils.UtilLog.LogType.Text);
                    Program.saveFile(Application.StartupPath + "\\androidutility.apk", global::Android_Utility.Properties.Resources.AndroidUtility);
                    var c = listofdevice.SyncServiceInstant;
                    if (!c.IsOpen)
                        c.Open();
                    c.PushFile(Application.StartupPath + "\\androidutility.apk", DataConfig.GetDataConfig.TempFolderPushApk + "temp.apk", new SyncImplement());
                    listofdevice.CurrentDevice.InstallRemotePackage(DataConfig.GetDataConfig.TempFolderPushApk + "temp.apk", true);
                    utilEvent.InsertLog("Install service success", Utils.UtilLog.LogType.Success);
                    utilEvent.InsertLog("Please wait to fill data", Utils.UtilLog.LogType.Text);
                    return installservice = true;
                }
                return installservice;
            }
        }


        private void txtMissed_EventKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }


        private void txtMissed_EventKeyLeave(object sender, EventArgs e)
        {
            var textbox = sender as ctTextBox;
            if (textbox.Text == "")
                textbox.Text = "0";
        }

        private void btnFillContact_Click(object sender, EventArgs e)
        {
            if(listofdevice==null || listofdevice.CurrentDevice==null)
            {
                utilEvent.InsertLog("Please select device to fill contact", Utils.UtilLog.LogType.Error);
                return;
            }
            if (txtContact.Text == "0")
            {
                utilEvent.InsertLog("Please input number contact to fill", Utils.UtilLog.LogType.Info);               
                return;
            }
            utilEvent.InsertLog("Fill data contact", Utils.UtilLog.LogType.Text);
            new Thread(delegate()
            {
                try
                {
                    if (InstallService())
                    {
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg CONTACT:" + txtContact.Text, false);
                    }
                }
                catch (Exception e1)
                {
                    utilEvent.InsertLog(e1.Message, Utils.UtilLog.LogType.Error);
                    utilEvent.InsertLog("Exception occur, can't fill call log", Utils.UtilLog.LogType.Error);
                }

            }).Start();
        }

        private void btnFillSMS_Click(object sender, EventArgs e)
        {
            if (txtSent.Text == "0" && txtInbox.Text == "0")
            {
                utilEvent.InsertLog("Please input number sms to fill", Utils.UtilLog.LogType.Info);
                return;
            }

            utilEvent.InsertLog("Fill data sms", Utils.UtilLog.LogType.Text);
            new Thread(delegate()
            {
                try
                {
                    if (InstallService())
                    {
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg SMS_SENT:" + txtSent.Text, false);
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am startservice -n ngocnam.info.androidutility/.AndroidUtility_Service --es arg SMS_INBOX:" + txtInbox.Text, false);
                    }
                }
                catch (Exception e1)
                {
                    utilEvent.InsertLog(e1.Message, Utils.UtilLog.LogType.Error);
                    utilEvent.InsertLog("Exception occur, Can't set android utility service is default app to read sms.", Utils.UtilLog.LogType.Error);
                }

            }).Start();

        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            new Thread(delegate()
            {
                try
                {
                    if (InstallService())
                    {
                        utilEvent.InsertLog("Set android utility service is default app to read sms. Please confirm in device", Utils.UtilLog.LogType.Text);
                        listofdevice.CurrentDevice.ExecuteAdbCommand(adb, "shell am start -a android.provider.Telephony.ACTION_CHANGE_DEFAULT -e package ngocnam.info.androidutility", false);
                    }
                }
                catch (Exception e1)
                {
                    utilEvent.InsertLog(e1.Message, Utils.UtilLog.LogType.Error);
                    utilEvent.InsertLog("Exception occur, Can't set android utility service is default app to read sms.", Utils.UtilLog.LogType.Error);
                }

            }).Start();
        }
    }
}

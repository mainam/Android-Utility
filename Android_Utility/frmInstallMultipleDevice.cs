using Android_Utility.Utils;
using MLLib;
using MLLib.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Android_Utility
{
    public partial class frmInstallMultipleDevice : mlForm
    {
        UtilEvent utilEvent;
        public frmInstallMultipleDevice()
        {
            InitializeComponent();
            utilEvent = new UtilEvent(UpdateStatusOneItem, InsertLog, ShowProcessOneItem, CloseProcessOneItem, null, null, UtilMessage.ShowMessage, UtilMemory.ClearMemory, UtilThread.AbortThread, null);
            this.Text = this.mlHeader.Title = "INSTALL APK - ANDROID UTILITY V" + Application.ProductVersion;
            this.StartPosition = FormStartPosition.CenterParent;
            tabFunction_SelectedIndexChanged(null, null);
            listofdevice.chbAutoReload.Visible = false;
            listofdevice.MultipleSelect = true;
            listofdevice.LoadDevice(true);
            this.shadowtype = ShadowType.Pro;
            this.BorderShadowColor = Color.LightPink;
        }

        private void CloseProcessOneItem()
        {
        }

        private void ShowProcessOneItem()
        {
        }
        object obj = new object();
        private void InsertLog(Object Log, UtilLog.LogType type)
        {
            lock (obj)
            {
                UtilLog.InsertLog(this, richTextBox1, type, Log);
            }
        }


        private void UpdateStatusOneItem(string status)
        {
        }

        private void mlHeader_IconClick(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void tabFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFunction.SelectedTab == tpInstall)
            {
                if (tpInstall.Controls.Count == 0)
                {
                    ctInstallMultipleDevice install = new ctInstallMultipleDevice(utilEvent);
                    install.ListOfDevice = listofdevice;
                    install.Dock = DockStyle.Fill;
                    tpInstall.Controls.Add(install);
                }
            }
        }

        private void frmInstallMultipleDevice_Load(object sender, System.EventArgs e)
        {
            RemoutDevice(null);
            listofdevice.LoadDevice(true);
        }


        Thread threadRunAdb;
        private void RemoutDevice(string SerialNumber)
        {
            try
            {
                utilEvent.AbortThread(threadRunAdb, utilEvent.InsertLog);
                threadRunAdb = new Thread(delegate()
                {
                    AdbCommand adb = new AdbCommand();
                    adb.OutputTextRunADB += utilEvent.InsertLog;
                    if (SerialNumber != null)
                    {
                        adb.ExecuteCommandSync("adb -s " + SerialNumber + " remount", true);
                        adb.ExecuteCommandSync("adb -s " + SerialNumber + " shell su 0 setenforce 0", true);
                    }
                    else
                    {
                        adb.ExecuteCommandSync("adb devices ", true);
                    }
                });
                threadRunAdb.Start();
            }
            catch (Exception e)
            {
                utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
            }
        }
    }
}

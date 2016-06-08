using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Managed.Adb;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctInstallApkFromLocal : UserControl
    {
        public string folderpush = "";
        public UtilEvent utilEvent;
        public ctInstallApkFromLocal()
        {
            InitializeComponent();
        }


        public void SetPath(string path)
        {
            ctOpenFileDialog1.Value = path;
        }

        public String FileName
        {
            get
            {
                return ctOpenFileDialog1.Value;
            }
            set
            {
                ctOpenFileDialog1.Value = value;
            }
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
                if (_listofdevice != null)
                {
                    _listofdevice.ChangeDevice += _listofdevice_ChangeDevice;
                }
            }
        }

        private void _listofdevice_ChangeDevice(object sender, EventArgs e)
        {
            utilEvent.AbortThread(installFromLocal, utilEvent.InsertLog);
            utilEvent.CloseProcessOneItem();
        }

        private Thread installFromLocal;

        private void btnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListOfDevice.CurrentDevice == null)
                {
                    utilEvent.ShowMessage("Please select device to install apk");
                    return;
                }
                if (FileName == "")
                {
                    utilEvent.ShowMessage("Please select apk file");
                    return;
                }

                installFromLocal = new Thread(delegate()
                {
                    Thread.Sleep(1000);
                    UtilInstall.Install(ListOfDevice.SyncServiceInstant, ListOfDevice.CurrentDevice, FileName.Trim(), folderpush + "temp.apk", false, utilEvent.UpdateStatusOneItem, utilEvent.InsertLog, utilEvent.CloseProcessOneItem, utilEvent.ShowMessage, utilEvent.ClearMem);
                });
                installFromLocal.Start();
                utilEvent.ShowProcessOneItem();
            }
            catch (Exception e2)
            {
                utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctInstallApkFromLink : UserControl
    {
        public string folderpush = "", folderdownload = "";

        public UtilEvent utilEvent;
        public ctInstallApkFromLink()
        {
            InitializeComponent();
        }

        private void DataConfig_changeTempFolderDownloadApk(object sender, EventArgs e)
        {
            folderdownload = sender.ToString();
        }

        private void DataConfig_changeTempFolderPushApk(object sender, EventArgs e)
        {
            folderpush = sender.ToString();
            if (!folderpush.EndsWith("/"))
                folderpush += "/";
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
            utilEvent.AbortThread(installFromLink, utilEvent.InsertLog);
            utilEvent.CloseProcessOneItem();
        }
        private Thread installFromLink;

        public Color TextHintColor
        {
            get
            {
                return ctTextBox1.TextHintColor;
            }
            set
            {
                ctTextBox1.TextHintColor = value;
            }
        }

        public String Link
        {
            get
            {
                return ctTextBox1.Text;
            }
            set
            {
                ctTextBox1.Text = value;
            }
        }

        private void btnInstall_ButtonClick(object sender, EventArgs e)
        {
            if (Link.Trim() == "" || !Link.Trim().EndsWith(".apk"))
            {
                MessageBox.Show("Please input link to apk file");
                return;
            }

            var link = folderdownload + @"\tempapk" + DateTime.Now.ToString("ddMMyyyyhhmmsstt") + ".apk";
            installFromLink = new Thread(delegate ()
            {
                Thread.Sleep(1000);
                UtilInstall.DownloadAndInstall(ListOfDevice.SyncServiceInstant, ListOfDevice.CurrentDevice, Link, link, "", folderpush + "temp.apk", utilEvent.UpdateStatusOneItem, utilEvent.InsertLog, utilEvent.ShowMessage, utilEvent.CloseProcessOneItem, utilEvent.ClearMem);
            });
            installFromLink.Start();
            utilEvent.ShowProcessOneItem();
        }
    }
}

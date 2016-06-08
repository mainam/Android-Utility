using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctInstallApk : UserControl
    {
        public UtilEvent utilEvent;

        public ctInstallApk(ctListOfDevice listofdevice, UtilEvent utilEvent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.utilEvent = utilEvent;

            ctInstallApkFromLink1.folderpush = ctInstallApkFromLocal1.folderpush = DataConfig.GetDataConfig.TempFolderPushApk;
            ctInstallApkFromLink1.folderdownload = DataConfig.GetDataConfig.TempFolderDownloadApk;
            ctInstallApkFromLink1.utilEvent = utilEvent;
            ctInstallApkFromLocal1.utilEvent = utilEvent;
            ctInstallApkFromLocal1.ListOfDevice = listofdevice;
            ctInstallApkFromLink1.ListOfDevice = listofdevice;

            DataConfig.changeTempFolderPushApk += DataConfig_changeTempFolderPushApk;
            DataConfig.changeTempFolderDownloadApk += DataConfig_changeTempFolderDownloadApk;

        }

        private void DataConfig_changeTempFolderDownloadApk(object sender, EventArgs e)
        {
            ctInstallApkFromLink1.folderdownload = sender.ToString();
        }

        private void DataConfig_changeTempFolderPushApk(object sender, EventArgs e)
        {
            var folder = sender.ToString();
            if (!folder.EndsWith("/"))
                folder += "/";
            ctInstallApkFromLink1.folderpush = ctInstallApkFromLocal1.folderpush = folder;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            frmInstallMultipleDevice frm = new frmInstallMultipleDevice();
            frm.Show();
        }

        public void SetPathLocal(string path)
        {
            ctInstallApkFromLocal1.SetPath(path);
        }

        public void SetLink(string link)
        {
            ctInstallApkFromLink1.Link = link;
        }
    }
}

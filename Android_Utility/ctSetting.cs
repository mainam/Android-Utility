using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MLLib.Windows;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctSetting : UserControl
    {
        public ctSetting()
        {
            InitializeComponent();
            txtFolderTempPushApk.Text = DataConfig.GetDataConfig.TempFolderPushApk;
            txtFolderSaveApk.Value = DataConfig.GetDataConfig.TempFolderDownloadApk;
            txtFolderDefaultSendFile.Text = DataConfig.GetDataConfig.FolderDefaultSendFile;
        }

        public event InsertLogDelegate OutputLog;
        void SendLog(string text, UtilLog.LogType type)
        {
            if (OutputLog != null)
                OutputLog(text, type);
        }
        
        private void btnSaveSettingFolderPushAPK_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.WriteKey(Constant.TEMP_FOLDER_PUSH_APK, txtFolderTempPushApk.Text);
                DataConfig.GetDataConfig.TempFolderPushApk = txtFolderTempPushApk.Text;
                SendLog("Save folder push apk success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Save folder push apk failed", UtilLog.LogType.Error);
            }
        }

        public void btnCancelSettingFolderPushAPK_Click(object sender, EventArgs e)
        {
            try
            {
                txtFolderTempPushApk.Text = DataConfig.GetDataConfig.TempFolderPushApk;
                SendLog("Load folder push apk success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Load folder push apk failed", UtilLog.LogType.Error);
            }
        }

        private void btnSaveFolderSaveApk_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.WriteKey(Constant.FOLDER_SAVE_APK, txtFolderSaveApk.Value);
                DataConfig.GetDataConfig.TempFolderDownloadApk = txtFolderSaveApk.Value;
                SendLog("Save folder download apk success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Save folder download apk success", UtilLog.LogType.Error);

            }
        }

        public void btnCancelFolderSaveApk_Click(object sender, EventArgs e)
        {
            try
            {
                txtFolderSaveApk.Value = DataConfig.GetDataConfig.TempFolderDownloadApk;
                SendLog("Load folder save apk success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Load folder save apk failed", UtilLog.LogType.Error);
            }
        }

        public void btnCancelFolderDefaultSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                txtFolderDefaultSendFile.Text = DataConfig.GetDataConfig.FolderDefaultSendFile;
                SendLog("Load folder send file success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Load folder send file failed", UtilLog.LogType.Error);
            }
        }

        private void btnSaveFolderDefaultSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.WriteKey(Constant.FOLDER_SEND_FILE, txtFolderDefaultSendFile.Text);
                DataConfig.GetDataConfig.FolderDefaultSendFile = txtFolderDefaultSendFile.Text;
                SendLog("Save folder send file success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Save folder send file failed", UtilLog.LogType.Error);
            }
        }

        private void btnSaveDefaultFolderMyFile_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.WriteKey(Constant.FOLDER_MY_FILE, txtFolderDefaultMyFile.Text);
                DataConfig.GetDataConfig.FolderDefaultMyfile = txtFolderDefaultMyFile.Text;
                SendLog("Save default folder myfile success", UtilLog.LogType.Success);
            }
            catch (Exception)
            {
                SendLog("Save default folder myfile failed", UtilLog.LogType.Error);
            }

        }

        public void btnCancelFolderDefaultMyFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveServerLink_Click(object sender, EventArgs e)
        {

        }
    }
}

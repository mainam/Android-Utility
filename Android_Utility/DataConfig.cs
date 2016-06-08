using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android_Utility
{
    public class DataConfig
    {
              //folder temp push apk
        string tempFolderPushApk;
        public static event EventHandler changeTempFolderPushApk;
        public String TempFolderPushApk
        {
            get
            {
                if (String.IsNullOrEmpty(tempFolderPushApk))
                    return "/sdcard/";
                return tempFolderPushApk;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    tempFolderPushApk = "/sdcard/";
                }
                else
                {
                    tempFolderPushApk = value.Trim();
                }
                if (changeTempFolderPushApk != null)
                    changeTempFolderPushApk(value, null);
            }
        }

        //folder temp download apk
        string tempFolderDownloadApk;
        public static event EventHandler changeTempFolderDownloadApk;
        public String TempFolderDownloadApk
        {
            get
            {
                if (String.IsNullOrEmpty(tempFolderPushApk))
                    return @"C:\Windows\Temp\";
                return tempFolderDownloadApk;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    tempFolderDownloadApk = @"C:\Windows\Temp\";
                }
                else
                {
                    tempFolderDownloadApk = value.Trim();
                }
                if (changeTempFolderDownloadApk != null)
                    changeTempFolderDownloadApk(value, null);
            }
        }


        //folder default send file
        string folderDefaultSendFile;
        public static event EventHandler changeFolderDefaultSendFile;
        public String FolderDefaultSendFile
        {
            get
            {
                if (String.IsNullOrEmpty(tempFolderPushApk))
                    return "/sdcard/";
                return folderDefaultSendFile;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    folderDefaultSendFile = "/sdcard/";
                }
                else
                {
                    folderDefaultSendFile = value.Trim();
                }
                if (changeFolderDefaultSendFile != null)
                    changeFolderDefaultSendFile(value, null);
            }
        }

        //folder default send file
        string folderDefaultMyfile;
        public static event EventHandler changeFolderDefaultMyFile;
        public String FolderDefaultMyfile
        {
            get
            {
                if (String.IsNullOrEmpty(tempFolderPushApk))
                    return "/sdcard/";
                return folderDefaultMyfile;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    folderDefaultMyfile = "/sdcard/";
                }
                else
                {
                    folderDefaultMyfile = value.Trim();
                }
                if (changeFolderDefaultMyFile != null)
                    changeFolderDefaultMyFile(value, null);
            }
        }

        static DataConfig dataConfig;

        public static DataConfig GetDataConfig
        {
            get
            {
                if (dataConfig == null)
                {
                    dataConfig = new DataConfig();


                    var temp = "";

                    temp = MLLib.Windows.Registry.ReadKey(Constant.FOLDER_SAVE_APK);
                    dataConfig.TempFolderDownloadApk = String.IsNullOrEmpty(temp) ? @"C:\Windows\Temp\" : temp.Trim();

                    temp = MLLib.Windows.Registry.ReadKey(Constant.FOLDER_SEND_FILE);
                    dataConfig.FolderDefaultSendFile = String.IsNullOrEmpty(temp) ? "/sdcard/" : temp.Trim();

                    temp = MLLib.Windows.Registry.ReadKey(Constant.FOLDER_MY_FILE);
                    dataConfig.FolderDefaultMyfile = String.IsNullOrEmpty(temp) ? "/sdcard/" : temp.Trim();

                    temp = MLLib.Windows.Registry.ReadKey(Constant.TEMP_FOLDER_PUSH_APK);
                    dataConfig.TempFolderPushApk = (String.IsNullOrEmpty(temp) || temp == "/data/local/tmp/") ? "/sdcard/" : temp.Trim();
                }
                return dataConfig;
            }
        }
    }
}

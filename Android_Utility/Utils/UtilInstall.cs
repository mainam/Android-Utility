using Managed.Adb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Android_Utility.Utils
{
    public class UtilInstall
    {
        public static bool Install(SyncService syncServiceInstant, Device device, string locallink, string remotelink, bool showerror, UpdateStatusOneItemDelegate UpdateStatus, InsertLogDelegate InsertLog, CloseProcessOneItemDelegate CloseProcess, ShowMessageDelegate ShowMessage, ClearMemDelegate ClearMem)
        {
            try
            {
                if (!syncServiceInstant.IsOpen)
                    syncServiceInstant.Open();

                UpdateStatus("Pushing...");
                //string remotelink = "/mnt/shell/emulated/0/temp.apk";

                InsertLog("Pushing apk", UtilLog.LogType.Text);
                syncServiceInstant.PushFile(locallink, remotelink, new SyncImplement());
                InsertLog("Push file to \"" + remotelink + "\" success", UtilLog.LogType.Success);

                UpdateStatus("Installing...");

                InsertLog("Installing apk", UtilLog.LogType.Text);
                device.InstallRemotePackage(remotelink, true);
                InsertLog("Install file from \"" + remotelink + "\" success\n", UtilLog.LogType.Success);
                CloseProcess();
            }
            catch (Exception e)
            {
                InsertLog(e.Message, UtilLog.LogType.Error);
                if (showerror)
                    ShowMessage("Install apk failed");
                return false;
            }
            finally
            {
                CloseProcess();
                ClearMem();
            }
            return true;
        }

        public static bool DownloadApk(string link, string savetolink, string cookies, InsertLogDelegate InsertLog, ShowMessageDelegate ShowMessage)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Cookie: " + cookies);
                webClient.DownloadFile(link, savetolink);
                return true;
            }
            catch (Exception e)
            {
                InsertLog(e.Message, UtilLog.LogType.Error);
                ShowMessage(e.Message);
                return false;
            }
        }

        public static void DownloadAndInstall(SyncService syncServiceInstant, Device device, String link, string downloadto, string cookie, string remotelink, UpdateStatusOneItemDelegate UpdateStatus, InsertLogDelegate InsertLog, ShowMessageDelegate ShowMessage, CloseProcessOneItemDelegate CloseProcess, ClearMemDelegate ClearMem)
        {
            UpdateStatus("Downloading apk");
            InsertLog("Download file apk", UtilLog.LogType.Text);
            if (UtilInstall.DownloadApk(link, downloadto, cookie, InsertLog, ShowMessage))
            {
                InsertLog("Download file success to \"" + downloadto + "\"", UtilLog.LogType.Success);
                UtilInstall.Install(syncServiceInstant, device, downloadto, remotelink, false, UpdateStatus, InsertLog, CloseProcess, ShowMessage, ClearMem);
            }
            else
            {
                CloseProcess();
            }
            ClearMem();

        }


    }
}

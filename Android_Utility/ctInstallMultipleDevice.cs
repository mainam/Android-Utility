using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Android_Utility.Utils;
using System.Threading;
using Managed.Adb;
using System.IO;

namespace Android_Utility
{
    public partial class ctInstallMultipleDevice : UserControl
    {
        public Utils.UtilEvent utilEvent;
        string txtRemotePath = "";
        public ctInstallMultipleDevice(UtilEvent utilEvent)
        {
            InitializeComponent();
            this.utilEvent = utilEvent;
            this.Dock = DockStyle.Fill;
            txtRemotePath = DataConfig.GetDataConfig.FolderDefaultSendFile;
            DataConfig.changeFolderDefaultSendFile += DataConfig_changeFolderDefaultSendFile;
        }

        void DataConfig_changeFolderDefaultSendFile(object sender, EventArgs e)
        {
            txtRemotePath = DataConfig.GetDataConfig.FolderDefaultSendFile;
        }

        private void lvReceiverFile_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Delete.Index)
            {
                try
                {
                    if (e.RowIndex >= 0 && e.RowIndex < lvReceiverFile.Rows.Count)
                    {
                        if (btnInstall.ButtonDataText == "Stop")
                        {
                            utilEvent.InsertLog("Please stop install file before remove any file in list", UtilLog.LogType.Text);
                            return;
                        }
                        lvReceiverFile.Rows.RemoveAt(e.RowIndex);
                    }
                }
                catch (Exception)
                {
                    utilEvent.InsertLog("Can't remove this row", UtilLog.LogType.Error);
                }
            }
        }

        private void lvReceiverFile_DragEnter(object sender, DragEventArgs e)
        {
            lvReceiverFile.Visible = false;
        }

        private void InstallFile(List<Device> listdevice)
        {
            utilEvent.AbortThread(installFileThread, utilEvent.InsertLog);


            installFileThread = new Thread(delegate()
            {
                try
                {
                    Dictionary<Device, SyncService> hash = new Dictionary<Device, SyncService>();
                    listofdevice.LoadDevice(false);

                    //var c = listofdevice.SyncServiceInstant;
                    while (lvReceiverFile.Rows.Count != 0)
                    {
                        String file = lvReceiverFile.Rows[0].Cells["FileName"].Value.ToString();
                        foreach (var item in listdevice)
                        {
                            if (item == null)
                            {
                                continue;
                            }

                            SyncService s = null;
                            if (hash.ContainsKey(item))
                            {
                                s = hash[item];
                                if (s == null)
                                {
                                    s = new SyncService(item);
                                    hash[item] = s;
                                }
                            }
                            else
                            {
                                s = new SyncService(item);
                                hash[item] = s;
                            }

                            if (!s.IsOpen)
                                s.Open();
                            if (!s.IsOpen)
                            {
                                utilEvent.InsertLog("Can't open service with device " + item.SerialNumber, UtilLog.LogType.Error);
                            }

                            try
                            {
                                utilEvent.UpdateStatusOneItem(string.Format("Device {0}: Pushing...", item.SerialNumber));
                                string remotelink = txtRemotePath + Path.GetFileName(file);
                                utilEvent.InsertLog(string.Format("Device {0}: Pushing file to {1} ", item.SerialNumber, remotelink), UtilLog.LogType.Text);
                                s.PushFile(file, remotelink, new SyncImplement());
                                utilEvent.InsertLog(string.Format("Device {0}: Pushing file to {1} success", item.SerialNumber, remotelink), UtilLog.LogType.Text);
                                utilEvent.InsertLog(string.Format("Device {0}: Install from {1}", item.SerialNumber, remotelink), UtilLog.LogType.Text);
                                item.InstallRemotePackage(remotelink, true);
                                utilEvent.InsertLog(string.Format("Device {0}: Install from {1} success", item.SerialNumber, remotelink), UtilLog.LogType.Text);
                            }
                            catch (Exception e)
                            {
                                utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
                                utilEvent.InsertLog(string.Format("Device {0}: Install file {1} failed", item.SerialNumber, file), UtilLog.LogType.Text);
                            }
                        }
                        this.Invoke(new EventHandler(delegate
                        {
                            lvReceiverFile.Rows.RemoveAt(0);
                        }));


                    }
                    utilEvent.UpdateStatusOneItem("Install all files to device");
                    InstallFile(false);
                }
                catch (Exception e)
                {
                    utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
                }
            });
            installFileThread.Start();
        }
        private Thread installFileThread;
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
                if (listofdevice != null)
                {
                    listofdevice.ChangeDevice += _listofdevice_ChangeDevice;
                }
            }
        }

        private void _listofdevice_ChangeDevice(object sender, EventArgs e)
        {
            utilEvent.AbortThread(installFileThread, utilEvent.InsertLog);
            if (btnInstall.ButtonDataText == "Stop")
                InstallFile(false);
        }

        private void InstallFile(bool Start)
        {
            this.Invoke(new EventHandler(delegate
            {
                lvReceiverFile.Visible = lvReceiverFile.Rows.Count != 0;

                if (Start)
                {
                    if (lvReceiverFile.Rows.Count == 0)
                    {
                        utilEvent.InsertLog("Drag and drop files to install", UtilLog.LogType.Info);
                        return;
                    }
                    var listdevice = listofdevice.ListDeviceSelected;
                    if (listdevice.Count == 0)
                    {
                        utilEvent.InsertLog("Please select list device to install", UtilLog.LogType.Error);
                        return;
                    }

                    utilEvent.UpdateStatusOneItem("Start install File");
                    btnInstall.ButtonDataText = "Stop";
                    btnClear.Enabled = false;
                    listofdevice.Enabled = false;
                    InstallFile(listdevice);
                }
                else
                {
                    listofdevice.Enabled = true;
                    utilEvent.InsertLog("Stop install file", UtilLog.LogType.Text);
                    utilEvent.AbortThread(installFileThread, utilEvent.InsertLog);
                    btnClear.Enabled = true;
                    btnInstall.ButtonDataText = "Install";
                }
            }));
        }


        private void btnInstallFile_ButtonClick(object sender, EventArgs e)
        {
            InstallFile(btnInstall.ButtonDataText == "Install");
        }

        private void pnInstallFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var listCurrentFile = lvReceiverFile.Rows.Cast<DataGridViewRow>().Select(x => x.Cells["FileName"].Value.ToString()).ToList();

            foreach (string file in files)
            {
                if (!listCurrentFile.Contains(file))
                {
                    listCurrentFile.Add(file);
                    lvReceiverFile.Rows.Add(file);
                }
            }

            if (lvReceiverFile.Rows.Count > 0)
            {
                lvReceiverFile.Visible = true;
            }
        }

        private void pnInstallFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pnInstallFile_DragLeave(object sender, EventArgs e)
        {
            if (lvReceiverFile.Rows.Count > 0)
                lvReceiverFile.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnInstall.ButtonDataText == "Install")
            {

                if (lvReceiverFile.Rows.Count != 0)
                {
                    lvReceiverFile.Rows.Clear();
                    utilEvent.InsertLog("Clear all files in list", UtilLog.LogType.Text);
                }
                else
                {
                    utilEvent.InsertLog("List file is empty", UtilLog.LogType.Text);
                }
                lvReceiverFile.Visible = lvReceiverFile.Rows.Count != 0;
            }
        }

        private void PasteFile()
        {
            var listfile = Clipboard.GetFileDropList();
            var listCurrentFile = lvReceiverFile.Rows.Cast<DataGridViewRow>().Select(x => x.Cells["FileName"].Value.ToString()).ToList();

            foreach (string file in listfile)
            {
                if (file.ToLower().EndsWith(".apk"))
                {
                    if (!listCurrentFile.Contains(file))
                    {
                        listCurrentFile.Add(file);
                        lvReceiverFile.Rows.Add(file);
                    }
                }
            }

            if (lvReceiverFile.Rows.Count > 0 && !lvReceiverFile.Visible)
            {
                lvReceiverFile.Visible = true;
            }


        }
        private void ItemsListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                PasteFile();
            }
        }

        private void ctInstallFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (pnInstallFile.Focus())
                {
                    PasteFile();
                }
            }
        }

        

    }
}

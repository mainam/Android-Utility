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
using System.IO;

namespace Android_Utility
{
    public partial class ctSendFile : UserControl
    {
        public Utils.UtilEvent utilEvent;
        public ctSendFile()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            txtRemotePath.Text = DataConfig.GetDataConfig.FolderDefaultSendFile;
            DataConfig.changeFolderDefaultSendFile += DataConfig_changeFolderDefaultSendFile;
        }

       
        void DataConfig_changeFolderDefaultSendFile(object sender, EventArgs e)
        {
            txtRemotePath.Text = DataConfig.GetDataConfig.FolderDefaultSendFile;
        }

        private void lvReceiverFile_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Delete.Index)
            {
                try
                {
                    if (e.RowIndex >= 0 && e.RowIndex < lvReceiverFile.Rows.Count)
                    {
                        if (btnSendFile.ButtonDataText == "Stop")
                        {
                            utilEvent.InsertLog("Please stop send file before remove any file in list", UtilLog.LogType.Text);
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
        private void SendFile()
        {
            utilEvent.AbortThread(sendFileThread, utilEvent.InsertLog);

            sendFileThread = new Thread(delegate()
            {
                try
                {
                    var c = listofdevice.SyncServiceInstant;
                    while (lvReceiverFile.Rows.Count != 0)
                    {
                        String file = lvReceiverFile.Rows[0].Cells["FileName"].Value.ToString();
                        if (c == null)
                        {
                            utilEvent.InsertLog("Stop send file, Sync service null", UtilLog.LogType.Text);
                            break;
                        }
                        if (!c.IsOpen)
                            c.Open();
                        try
                        {
                            utilEvent.UpdateStatusOneItem("Pushing...");
                            string remotelink = txtRemotePath.Text + Path.GetFileName(file);

                            utilEvent.InsertLog("Pushing file", UtilLog.LogType.Text);
                            c.PushFile(file, remotelink, new SyncImplement());
                            utilEvent.InsertLog("Push file to \"" + remotelink + "\" success", UtilLog.LogType.Text);
                        }
                        catch (Exception e)
                        {
                            utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
                        }
                        this.Invoke(new EventHandler(delegate
                        {
                            lvReceiverFile.Rows.RemoveAt(0);
                        }));
                    }
                    utilEvent.UpdateStatusOneItem("Sent all files to device");
                    SendFile(false);
                }
                catch (Exception e)
                {
                    utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
                }
            });
            sendFileThread.Start();
        }
        private Thread sendFileThread;
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
            utilEvent.AbortThread(sendFileThread, utilEvent.InsertLog);
            if (btnSendFile.ButtonDataText == "Stop")
                SendFile(false);
        }

        private void SendFile(bool Start)
        {


            this.Invoke(new EventHandler(delegate
            {
                lvReceiverFile.Visible = lvReceiverFile.Rows.Count != 0;

                if (Start)
                {
                    if (lvReceiverFile.Rows.Count == 0)
                    {
                        utilEvent.InsertLog("Drag and drop files to send", UtilLog.LogType.Text);
                        return;
                    }

                    utilEvent.UpdateStatusOneItem("Start Send File");
                    txtRemotePath.Enabled = false;
                    txtRemotePath.BorderColor = Color.GreenYellow;
                    btnSendFile.ButtonDataText = "Stop";
                    btnClear.Enabled = false;
                    SendFile();
                }
                else
                {
                    utilEvent.InsertLog("Stop send file", UtilLog.LogType.Text);
                    utilEvent.AbortThread(sendFileThread, utilEvent.InsertLog);
                    btnClear.Enabled = true;
                    btnSendFile.ButtonDataText = "Send";
                    txtRemotePath.Enabled = true;
                    txtRemotePath.BorderColor = Color.White;
                }
            }));
        }


        private void btnSendFile_ButtonClick(object sender, EventArgs e)
        {
            SendFile(btnSendFile.ButtonDataText == "Send");
        }

        private void pnSendFile_DragDrop(object sender, DragEventArgs e)
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

        private void pnSendFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pnSendFile_DragLeave(object sender, EventArgs e)
        {
            if (lvReceiverFile.Rows.Count > 0)
                lvReceiverFile.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnSendFile.ButtonDataText == "Send")
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
                if (!listCurrentFile.Contains(file))
                {
                    listCurrentFile.Add(file);
                    lvReceiverFile.Rows.Add(file);
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

        private void ctSendFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (pnSendFile.Focus())
                {
                    PasteFile();
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Utility.Utils;
using System.Threading;
using System.IO;
using Android_Utility.ADBmanager.Receivers;

namespace Android_Utility
{
    public partial class ctFillFileMedia : UserControl
    {
        public UtilEvent utilEvent;
        public ctFillFileMedia()
        {
            InitializeComponent();
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
                if (listofdevice != null)
                {
                    listofdevice.ChangeDevice += _listofdevice_ChangeDevice;
                }
            }
        }

        private void _listofdevice_ChangeDevice(object sender, EventArgs e)
        {
            //utilEvent.AbortThread(threadFillData, utilEvent.InsertLog);

            utilEvent.CloseProcessOneItem();
            utilEvent.CloseProcessManyItem();
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            if (txtFileDes.Value == "")
            {
                MessageBox.Show("Please select file to find data");
                return;
            }
            try
            {
                FillData();
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                _listofdevice_ChangeDevice(null, null);
            }
        }

        void FillData()
        {
            if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
            {
                var file = new System.IO.FileInfo(txtFileDes.Value);
                if (!file.Exists)
                {
                    utilEvent.InsertLog("File not found", UtilLog.LogType.Error);
                    return;
                }
                var length = file.Length;
                int current = 0;

                utilEvent.InsertLog("Start fill data", UtilLog.LogType.Text);

                var foldercontainer = txtFolderContainer.Text.Trim().ToLower();
                if (!foldercontainer.EndsWith("/"))
                    foldercontainer += "/";

                threadFillData = new Thread(delegate()
                {
                    try
                    {
                        Thread.Sleep(500);

                        var ext = Path.GetExtension(txtFileDes.Value);
                        var filename2 = Path.GetFileNameWithoutExtension(txtFileDes.Value).Replace(" ", "_");

                        var output = new Android_Utility.ADBmanager.Receivers.ExecuteShellReceiver();
                        try
                        {
                            var c = listofdevice.SyncServiceInstant;
                            if (c == null)
                            {
                                utilEvent.InsertLog("Stop send file, Sync service null", UtilLog.LogType.Text);
                                return;
                            }
                            if (!c.IsOpen)
                                c.Open();

                            var temp = foldercontainer + filename2 + ext;

                            utilEvent.UpdateStatusManyItem(0, "Preparing file");
                            utilEvent.InsertLog("Preparing file", UtilLog.LogType.Success);
                            var filename = txtFileDes.Value;
                            c.PushFile(filename, temp, new SyncImplement());
                            utilEvent.InsertLog("Prepared file success", UtilLog.LogType.Success);

                            utilEvent.UpdateStatusOneItem("Fill data");
                            utilEvent.InsertLog("Fill Data", UtilLog.LogType.Success);


                            int i = 0;
                            while (true)
                            {
                                current += 1;
                                utilEvent.UpdateStatusManyItem(current, "Fill Data");
                                if (current >= nbTotalFile.Value)
                                    break;
                                if (i == 1000)
                                    i = 0;
                                i++;
                                var text = DateTime.Now.ToString("ddMMyyyyhhmmsstt") + i;
                                var receiver = new ExecuteShellReceiver();
                                listofdevice.CurrentDevice.ExecuteShellCommand("cp " + temp + " " + foldercontainer + filename2 + text + ext, receiver);
                            }
                            utilEvent.InsertLog("Fill Data Success", UtilLog.LogType.Success);
                        }
                        catch (Exception e1)
                        {
                            utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                            utilEvent.InsertLog("Can't fill data. Please try again", UtilLog.LogType.Error);
                        }
                    }
                    catch (Exception)
                    {

                    }

                    utilEvent.CloseProcessManyItem();
                });
                threadFillData.Start();

                utilEvent.ShowProcessManyItem(Convert.ToInt32(nbTotalFile.Value), 0, (a, b) =>
                {
                    utilEvent.InsertLog("Progress has been stoped by user", UtilLog.LogType.Text);
                    _listofdevice_ChangeDevice(null, null);
                });
            }
        }

        public Thread threadFillData { get; set; }
    }
}

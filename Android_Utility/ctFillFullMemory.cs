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
using Android_Utility.ADBmanager.Receivers;
using System.Threading;
using System.IO;

namespace Android_Utility
{
    public partial class ctFillFullMemory : UserControl
    {
        public UtilEvent utilEvent;
        Thread threadFillData;

        public ctFillFullMemory()
        {
            InitializeComponent();
            cbType.Text = "Gb";
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
            utilEvent.AbortThread(threadFillData, utilEvent.InsertLog);

            utilEvent.CloseProcessOneItem();
            utilEvent.CloseProcessManyItem();
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileDes.Value == "")
                {
                    MessageBox.Show("Please select file to find data");
                    return;
                }

                if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
                {
                    var receiver = new ExecuteShellReceiver();
                    listofdevice.CurrentDevice.ExecuteShellCommand("mkdir " + "/sdcard/filldata/", receiver);
                    utilEvent.InsertLog("Create new folder success", UtilLog.LogType.Success);
                }
                else
                {
                    utilEvent.InsertLog("Device null or offile", UtilLog.LogType.Error);
                    return;
                }
            }
            catch (Exception e2)
            {
                utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
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
                var maxsize = Convert.ToInt64(nbTotalSize.Value);
                switch (cbType.Text)
                {
                    case "Gb":
                        maxsize = maxsize * 1024 * 1024 * 1024;
                        break;
                    case "Mb":
                        maxsize = maxsize * 1024 * 1024;
                        break;
                    case "Kb":
                        maxsize = maxsize * 1024;
                        break;
                }

                utilEvent.InsertLog("Start fill data", UtilLog.LogType.Text);
                var maxtime = Convert.ToInt32(maxsize / length);

                threadFillData = new Thread(delegate()
                {
                    try
                    {
                        Thread.Sleep(500);


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

                            utilEvent.UpdateStatusManyItem(0, "Preparing file");
                            utilEvent.InsertLog("Preparing file", UtilLog.LogType.Success);
                            var filename = txtFileDes.Value;
                            c.PushFile(filename, "/sdcard/filldata/data.dat", new SyncImplement());
                            utilEvent.InsertLog("Prepared file success", UtilLog.LogType.Success);

                            utilEvent.UpdateStatusOneItem("Fill data");
                            utilEvent.InsertLog("Fill Data", UtilLog.LogType.Success);

                            int i = 0;
                            while (true)
                            {
                                current += 1;
                                utilEvent.UpdateStatusManyItem(current, "Fill Data");
                                if (current >= maxtime)
                                    break;
                                if (i == 1000)
                                    i = 0;
                                i++;
                                var text = DateTime.Now.ToString("ddMMyyyyhhmmsstt") + i;
                                var receiver = new ExecuteShellReceiver();
                                listofdevice.CurrentDevice.ExecuteShellCommand("cp /sdcard/filldata/data.dat /sdcard/filldata/data" + text + ".dat", receiver);
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

                utilEvent.ShowProcessManyItem(maxtime, 0, (a, b) =>
                {
                    utilEvent.InsertLog("Progress has been stoped by user", UtilLog.LogType.Text);
                    _listofdevice_ChangeDevice(null, null);
                });
            }
        }

    }
}

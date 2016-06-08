using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Managed.Adb;
using System.Threading;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctPackageMgr : UserControl
    {

        public UtilEvent utilEvent;
        public ctPackageMgr()
        {
            InitializeComponent();
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
                    if (_listofdevice.CurrentDevice != null)
                    {
                        timer1_Tick(null, null);
                        StartTimer(true);
                    }

                    _listofdevice.ChangeDevice += _listofdevice_ChangeDevice;
                }
            }
        }

        private object obj = new Object();
        public void StartTimer(bool start)
        {
            lock (obj)
            {
                timeStart = start;
                if (start)
                    timer1.Start();
                else
                    timer1.Stop();
            }
        }

        bool timeStart = false;
        private void _listofdevice_ChangeDevice(object sender, EventArgs e)
        {
            try
            {

                listcurrentpackage.Clear();
                txtSearchPackage_EventTextChange(null, null);

                utilEvent.AbortThread(threadLoadPackage, utilEvent.InsertLog);
                utilEvent.CloseProcessOneItem();

                if (ListOfDevice.CurrentDevice == null && timeStart)
                {
                    StartTimer(false);
                }
                else
                {
                    if (!timeStart)
                        StartTimer(true);
                }
                System.GC.Collect();
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }

        Thread threadLoadPackage;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var device = ListOfDevice.CurrentDevice;

                if (device != null && device.IsOnline)
                {
                    utilEvent.AbortThread(threadLoadPackage, utilEvent.InsertLog);

                    threadLoadPackage = new Thread(delegate()
                      {
                          PackageManager package = new PackageManager(device);
                          package.RefreshPackages();
                          ComparePackage(package.Packages);
                      });
                    threadLoadPackage.Start();
                    System.GC.Collect();
                }
            }
            catch (Exception)
            {

            }
        }

        private Dictionary<String, string> listcurrentpackage = new Dictionary<string, string>();
        public void ComparePackage(Dictionary<String, String> listnew)
        {
            bool change = false;
            if (listnew.Count != listcurrentpackage.Count)
            {
                listcurrentpackage = listnew;
                change = true;
            }
            else
            {
                var list1 = listnew.Select(x => x.Key + "=" + x.Value);
                var list2 = listcurrentpackage.Select(x => x.Key + "=" + x.Value);
                if (list1.Except(list2).Count() != 0)
                {
                    listcurrentpackage = listnew;
                    change = true;
                }
            }
            if (change)
                txtSearchPackage_EventTextChange(null, null);
        }



        void RemoveSystemAppOutput(object sender, EventArgs e)
        {
            utilEvent.InsertLog(sender, UtilLog.LogType.Text);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                if (e.ColumnIndex == Uninstall.Index)
                {
                    try
                    {
                        var package = dataGridView1.Rows[e.RowIndex].Cells[Package.Name].Value.ToString();
                        var path = dataGridView1.Rows[e.RowIndex].Cells[Path.Name].Value.ToString();
                        if (MessageBox.Show("Do you want to uninstall this app\n(" + package + ")", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (path.StartsWith("/system/"))
                            {
                                ListOfDevice.CurrentDevice.RemoveRemotePackage(path);
                                utilEvent.InsertLog("System app has been removed, you must reboot your device", UtilLog.LogType.Text);
                            }
                            else
                            {
                                ListOfDevice.CurrentDevice.UninstallPackage(package);
                                utilEvent.InsertLog("Uninstall package " + package + " success", UtilLog.LogType.Text);
                            }
                        }
                    }
                    catch (Exception e2)
                    {
                        utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

                if (e.ColumnIndex == SaveTo.Index)
                {
                    try
                    {
                        var path = dataGridView1.Rows[e.RowIndex].Cells[Path.Name].Value.ToString();
                        Package_PullFile(path);
                    }
                    catch (Exception e2)
                    {
                        utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

                if (e.ColumnIndex == ForceStop.Index)
                {
                    try
                    {
                        var package = dataGridView1.Rows[e.RowIndex].Cells[Package.Name].Value.ToString();
                        if (MessageBox.Show("Do you want to Force Stop this app\n(" + package + ")", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            ListOfDevice.CurrentDevice.ForceStopPackage(package);
                            utilEvent.InsertLog("Force Stop package " + package + " success", UtilLog.LogType.Text);
                        }
                    }
                    catch (Exception e2)
                    {
                        utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

                if (e.ColumnIndex == ClearData.Index)
                {
                    try
                    {
                        var package = dataGridView1.Rows[e.RowIndex].Cells[Package.Name].Value.ToString();
                        if (MessageBox.Show("Do you want to Clear User Data of this app\n(" + package + ")", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            ListOfDevice.CurrentDevice.ClearDataPackage(package);
                            utilEvent.InsertLog("Clear User Data for package " + package + " success", UtilLog.LogType.Text);
                        }
                    }
                    catch (Exception e2)
                    {
                        utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
                    }
                    return;
                }
            }
        }

        Thread threadSearch, threadPullFile;
        private void txtSearchPackage_EventTextChange(object sender, EventArgs e)
        {
            try
            {
                threadSearch.Abort();
                threadSearch = null;
            }
            catch (Exception)
            {
                threadSearch = null;
            }

            threadSearch = new Thread(delegate()
                        {
                            try
                            {
                                var text = txtSearchPackage.Text.ToLower().Trim();
                                Thread.Sleep(200);
                                var listtemp = listcurrentpackage.Where(x => x.Value.ToLower().Contains(text));
                                this.Invoke(new EventHandler(delegate
            {
                dataGridView1.Rows.Clear();
                foreach (var item in listtemp)
                {
                    dataGridView1.Rows.Add(new String[] { item.Value, item.Key });
                }
            }));
                            }
                            catch (Exception)
                            {

                            }
                        });
            try
            {
                threadSearch.Start();
            }
            catch (Exception)
            {
            }
        }


        private void Package_PullFile(object sender)
        {
            if (sender == null)
            {
                utilEvent.InsertLog("Not exist file in this device", UtilLog.LogType.Text);
                return;
            }
            if (ListOfDevice.CurrentDevice == null || !ListOfDevice.CurrentDevice.IsOnline)
            {
                utilEvent.InsertLog("Device null or offile, please check again", UtilLog.LogType.Text);
                return;
            }

            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Apk file|*.apk";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    utilEvent.InsertLog("Start pull file", UtilLog.LogType.Text);
                    threadPullFile = new Thread(delegate()
                    {
                        Thread.Sleep(500);
                        utilEvent.UpdateStatusOneItem("Pull File");
                        //AdbCommand adb = new AdbCommand();
                        //adb.OutputTextRunADB += utilEvent.InsertLog;
                        
                        //var c = ctListOfDevice.SyncServiceInstant;

                        try
                        {
                            AdbCommand adb = new AdbCommand();
                            adb.OutputTextRunADB += utilEvent.InsertLog;
                            ListOfDevice.CurrentDevice.PullFile(sender.ToString(), save.FileName, adb);
                            //if (c == null)
                            //{
                            //    utilEvent.InsertLog("Stop send file, Sync service null", UtilLog.LogType.Info);
                            //    return;
                            //}
                            //if (!c.IsOpen)
                            //    c.Open();

                            //c.PullFile(sender.ToString(), save.FileName, new SyncImplement());
                            utilEvent.InsertLog("Pull file to " + save.FileName + " success", UtilLog.LogType.Text);
                        }
                        catch (Exception e1)
                        {
                            utilEvent.InsertLog(e1.Message, UtilLog.LogType.Text);
                            utilEvent.InsertLog("Pull file to " + save.FileName + " failed", UtilLog.LogType.Text);
                        }

                        utilEvent.CloseProcessOneItem();
                    });
                    threadPullFile.Start();
                    utilEvent.ShowProcessOneItem();
                }
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                utilEvent.InsertLog("Pull file failed", UtilLog.LogType.Error);
                return;
            }
        }
    }
}

using Android_Utility.ADBmanager.Receivers;
using Android_Utility.Progress;
using Android_Utility.Utils;
using Managed.Adb;
using MLLib;
using MLLib.Theme;
using MLLib.Windows;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Android_Utility
{
    public partial class frmFormMain : mlForm
    {
        private Thread threadRunAdb;

        private string folderdownload = "";
        private string folderpush = "";

        private frmProgressOneItem ProgressOneItem;
        private frmProgressManyItem ProgressManyItem;

        private event EventHandler OnPushFileClick;

        UtilEvent utilEvent;
        string currentpath = "";
        string currentlink = "";

        bool isOpen = false;


        public frmFormMain(string arg, ShadowType shadowtype)
        {
            InitializeComponent();
            this.shadowtype = ShadowType.Pro;
            utilEvent = new UtilEvent(UpdateStatusOneItem, InsertLog, ShowProcessOneItem, CloseProcessOneItem, ShowProcessManyItem, CloseProcessManyItem, UtilMessage.ShowMessage, UtilMemory.ClearMemory, UtilThread.AbortThread, UpdateStatusManyItem);

            SetupArg(arg);
            ButtonTitle btn = new ButtonTitle();
            btn.Image = global::Android_Utility.Properties.Resources.btn_unfold_o;
            btn.Click += btn_Click;
            this.AddButtonTitle(btn);
            SetTooltip(btn.Controls[0], "Click to update new version");
            this.Text = this.mlHeader.Title = "ANDROID UTILITY V" + Application.ProductVersion;
            this.KeyPreview = true;
            tabFunction.SelectedIndex = 0;
            tabFunction_SelectedIndexChanged(null, null);
            DataConfig.changeTempFolderPushApk += DataConfig_changeTempFolderPullApk;
            DataConfig.changeTempFolderDownloadApk += DataConfig_changeTempFolderDownloadApk;
            var config = DataConfig.GetDataConfig;
            this.KeyDown += frmFormMain_KeyDown;

            if (!isOpen)
            {
                isOpen = true;
            }

        }

        void SetupArg(string arg)
        {
            try
            {

                if (arg == null || arg.Trim() == "")
                    return;
                arg = arg.Trim().ToLower();
                if (arg.StartsWith("android:"))
                {
                    arg = arg.Substring("android:".Length);
                    arg = arg.Trim();
                }
                if (arg.StartsWith("http://") || arg.StartsWith("https://"))
                {
                    currentlink = arg;
                    InsertLog("Inserted link: " + arg, UtilLog.LogType.Text);
                }
                else
                {
                    currentpath = arg;
                    InsertLog("Inserted file: " + arg, UtilLog.LogType.Text);
                }
            }
            catch (Exception e)
            {
                utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
            }
        }

        void frmFormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                if (!tabFunction.TabPages.Contains(tpSendFile))
                    tabFunction.TabPages.Insert(2, tpSendFile);
                else
                    tabFunction.TabPages.Remove(tpSendFile);
                if (!tabFunction.TabPages.Contains(tpMyFile))
                    tabFunction.TabPages.Insert(3, tpMyFile);
                else
                    tabFunction.TabPages.Remove(tpMyFile);
            }
        }


        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("file://107.113.53.35/common/5.USERS/ngoc.nam/PROJECT/ANDROID_UTILITY/Android%20Utility.application");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please contact ngoc.nam@samsung.com to resolve this problem");
            }
        }


        private void DataConfig_changeTempFolderDownloadApk(object sender, EventArgs e)
        {
            folderdownload = sender.ToString();
        }

        private void DataConfig_changeTempFolderPullApk(object sender, EventArgs e)
        {
            folderpush = sender.ToString();
            if (!folderpush.EndsWith("/"))
                folderpush += "/";
        }


        private static readonly Object obj = new Object();
        private void InsertLog(Object Log, UtilLog.LogType type)
        {
            lock (obj)
            {
                UtilLog.InsertLog(this, richTextBox1, type, Log);
            }
        }

        private void mlHeader_IconClick(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        #region ShowProcess
        private void UpdateStatusOneItem(string status)
        {
            if (ProgressOneItem != null)
                ProgressOneItem.Update(status);
        }
        private void SetDateManyItem(int max, int rerun)
        {
            if (ProgressManyItem != null)
                ProgressManyItem.SetValue(max, rerun);
        }

        private void UpdateStatusManyItem(int item, string status)
        {
            if (ProgressManyItem != null)
                ProgressManyItem.Update(item, status);
        }

        private void ShowProcessOneItem()
        {
            if (ProgressOneItem != null && ProgressOneItem.showing)
                return;
            ProgressOneItem = new frmProgressOneItem();
            ProgressOneItem.ShowProcess();
        }
        private void ShowProcessManyItem(int max, int rerun, EventHandler cancel)
        {
            if (ProgressManyItem != null && ProgressManyItem.showing)
                return;
            ProgressManyItem = new frmProgressManyItem(max, rerun);
            ProgressManyItem.Cancel += cancel;
            ProgressManyItem.ShowProcess();
        }
        private void CloseProcessOneItem()
        {
            try
            {
                this.Invoke(new EventHandler(delegate
                {
                    try
                    {
                        if (ProgressOneItem != null && ProgressOneItem.showing)
                        {
                            ProgressOneItem.CloseProcess();
                            ProgressOneItem = null;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }));
            }
            catch (Exception e)
            {
                utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
            }
        }

        private void CloseProcessManyItem()
        {
            this.Invoke(new EventHandler(delegate
            {
                try
                {
                    if (ProgressManyItem != null && ProgressManyItem.showing)
                    {
                        ProgressManyItem.CloseProcess();
                        ProgressManyItem = null;
                    }
                }
                catch (Exception)
                {

                }
            }));
        }
        #endregion


        private void listofdevice_ChangeDevice(object sender, EventArgs e)
        {
            try
            {
                utilEvent.InsertLog("Current device has been changed", UtilLog.LogType.Text);
                CloseProcessOneItem();
                CloseProcessManyItem();
                utilEvent.AbortThread(threadRunAdb, utilEvent.InsertLog);

                if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline && (tabFunction.SelectedTab == tpMyFile || tabFunction.SelectedTab == tpSendFile || tabFunction.SelectedTab == tpPackage))
                    RemoutDevice(listofdevice.CurrentDevice.SerialNumber);
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }


        private void tabFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = tabFunction.SelectedTab;
            if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline && (tabFunction.SelectedTab == tpMyFile || tabFunction.SelectedTab == tpSendFile || tabFunction.SelectedTab == tpPackage))
                RemoutDevice(listofdevice.CurrentDevice.SerialNumber);
            if (tab == tpInstall)
            {
                if (tab.Controls.Count == 0)
                {
                    ctInstallApk install = new ctInstallApk(listofdevice, utilEvent);
                    tab.Controls.Add(install);
                }
                if (currentpath != "")
                    ((ctInstallApk)tab.Controls[0]).SetPathLocal(currentpath);
                if (currentlink != "")
                    ((ctInstallApk)tab.Controls[0]).SetLink(currentlink);
                currentlink = currentpath = "";

                return;
            }
            else
                if (tab.Controls.Count == 0 || tab == tpMyFile || tab == tpSendFile)
            {
                if (tab == tpSendFile)
                {
                    ctSendFile sendfile = new ctSendFile();
                    sendfile.utilEvent = utilEvent;
                    sendfile.ListOfDevice = listofdevice;
                    tab.Controls.Add(sendfile);
                    OnPushFileClick += (a, b) =>
                    {
                        if (a != null)
                        {
                            tabFunction.SelectedTab = tpSendFile;
                            sendfile.txtRemotePath.Text = a.ToString();
                        }

                    };
                    return;
                }



                if (tab == tpControls)
                {
                    ctControl control = new ctControl(utilEvent);
                    control.ListOfDevice = listofdevice;
                    control.Dock = DockStyle.Fill;
                    tab.Controls.Add(control);
                    return;
                }

                if (tab == tpPackage)
                {
                    ctPackageMgr package = new ctPackageMgr();
                    package.utilEvent = utilEvent;
                    package.ListOfDevice = listofdevice;

                    tabFunction.SelectedIndexChanged += delegate
                    {
                        package.StartTimer(tabFunction.SelectedTab == tpPackage);
                    };
                    package.Dock = DockStyle.Fill;
                    tab.Controls.Add(package);
                    return;
                }

                if (tab == tpSetting)
                {
                    ctSetting setting = new ctSetting();
                    setting.Dock = DockStyle.Fill;
                    setting.OutputLog += utilEvent.InsertLog;
                    tab.Controls.Add(setting);
                    tabFunction.SelectedIndexChanged += delegate
                    {
                        if (tabFunction.SelectedTab == tpSetting)
                        {
                            setting.btnCancelFolderDefaultSendFile.PerformClick();
                            setting.btnCancelFolderSaveApk.PerformClick();
                            setting.btnCancelSettingFolderPushAPK.PerformClick();
                            setting.btnCancelFolderDefaultMyFile.PerformClick();
                        }
                    };
                    return;
                }
                if (tab == tpMyFile)
                {
                    try
                    {
                        //if (listofdevice.CurrentDevice == null)
                        //{
                        //    tabFunction.SelectedIndex = tabFunction.TabPages.IndexOf(tpInstall);
                        //    return;
                        //}

                        if (tab.Controls.Count > 0)
                            return;

                        ctMyFile myFile = new ctMyFile(listofdevice);
                        myFile.CloseTab += (a, b) =>
                        {
                            if (tabFunction.SelectedTab == tpMyFile)
                            {
                                tabFunction.SelectedIndex = tabFunction.TabPages.IndexOf(tpInstall);
                                tabFunction_SelectedIndexChanged(null, null);
                            }
                        };
                        myFile.utilEvent = utilEvent;
                        myFile.AllowDrop = true;
                        myFile.Dock = DockStyle.Fill;
                        myFile.OnPushFileClick += (a, b) =>
                        {
                            if (OnPushFileClick != null)
                            {
                                OnPushFileClick(a, b);
                            }
                        };

                        DataConfig.changeFolderDefaultMyFile += (a, b) =>
                        {
                            myFile.SetPath(DataConfig.GetDataConfig.FolderDefaultMyfile);
                        };
                        tab.Controls.Add(myFile);
                    }
                    catch (Exception e1)
                    {
                        tab.Controls.Clear();
                        utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                    }
                    return;

                }
                if (tab == tpDocument)
                {
                    try
                    {
                        ctDocument document = new ctDocument();
                        document.Dock = DockStyle.Fill;
                        tab.Controls.Add(document);
                    }
                    catch (Exception e1)
                    {
                        tab.Controls.Clear();
                        utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                    }
                    return;
                }
                if (tab == tpWhatsNew)
                {
                    try
                    {
                        ctWhatsNew whatsnew = new ctWhatsNew();
                        whatsnew.Dock = DockStyle.Fill;
                        tab.Controls.Add(whatsnew);
                    }
                    catch (Exception e1)
                    {
                        tab.Controls.Clear();
                        utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

                if (tab == tpFillData)
                {
                    try
                    {
                        //ctFillFullMemory filldata = new ctFillFullMemory();
                        //filldata.utilEvent = this.utilEvent;
                        //filldata.ListOfDevice = this.listofdevice;
                        //filldata.Dock = DockStyle.Fill;
                        //tab.Controls.Add(filldata);
                        ctFillData filldata = new ctFillData();
                        filldata.Dock = DockStyle.Fill;
                        filldata.utilEvent = this.utilEvent;
                        filldata.ListOfDevice = this.listofdevice;
                        filldata.SelectTab();
                        tab.Controls.Add(filldata);


                    }
                    catch (Exception e1)
                    {
                        tab.Controls.Clear();
                        utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

            }
        }



        #region detect use change
        private const int WM_DEVICECHANGE = 0x0219;                 // device change event 
        private const int DBT_DEVICEARRIVAL = 0x8000;               // system detected a new device 
        private const int DBT_DEVICEREMOVEPENDING = 0x8003;         // about to remove, still available 

        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;        // device is gone 

        private const int DBT_DEVTYP_PORT = 0x00000003;      // serial, parallel 

        protected override void WndProc(ref Message m)
        {
            int devType;
            base.WndProc(ref m);
            try
            {
                if (m.Msg == MLLib.Windows.MessageHelper.WM_COPYDATA)
                {
                    try
                    {
                        base.ActiveForm();
                        var data = ((MLLib.Windows.MessageHelper.COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(MLLib.Windows.MessageHelper.COPYDATASTRUCT))).lpData;
                        SetupArg(data);
                        tabFunction.SelectedIndex = 0;
                        tabFunction_SelectedIndexChanged(null, null);
                    }
                    catch (Exception e)
                    {
                        InsertLog(e.Message, UtilLog.LogType.Error);
                    }
                    return;
                }

                switch (m.WParam.ToInt32())
                {

                    case DBT_DEVICEARRIVAL:

                        devType = Marshal.ReadInt32(m.LParam, 4);

                        if (devType == DBT_DEVTYP_PORT)
                        {
                            listofdevice.timer1_Tick(null, null);
                        }

                        break;

                    case DBT_DEVICEREMOVECOMPLETE:

                        devType = Marshal.ReadInt32(m.LParam, 4);
                        if (devType == DBT_DEVTYP_PORT)
                        {
                            listofdevice.timer1_Tick(null, null);
                        }
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion


        private void frmFormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            listofdevice_ChangeDevice(null, null);
        }

        private void RemoutDevice(string SerialNumber)
        {
            try
            {
                utilEvent.AbortThread(threadRunAdb, utilEvent.InsertLog);
                threadRunAdb = new Thread(delegate ()
                {
                    try
                    {

                        AdbCommand adb = new AdbCommand();
                        adb.OutputTextRunADB += utilEvent.InsertLog;
                        if (SerialNumber != null)
                        {
                            adb.ExecuteCommandSync("adb -s " + SerialNumber + " remount", true);
                            adb.ExecuteCommandSync("adb -s " + SerialNumber + " shell su 0 setenforce 0", true);
                        }
                        else
                        {
                            adb.ExecuteCommandSync("adb devices ", true);
                        }
                    }
                    catch (Exception)
                    {

                    }
                });
                threadRunAdb.Start();
            }
            catch (Exception e)
            {
                utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
            }
        }

        private void tabFunction_SelectedIndexChanging(object sender, MLLib.Controls.ctTabControl.SelectedIndexChangingEventArgs e)
        {
            //var tab = e.TabPage;

            //if (tab == tpSendFile)
            //{
            //    MessageBox.Show("This feature has been disabled. Please contact ngoc.nam if you have any question");
            //    e.Cancel = true;
            //    return;
            //}


            //if (tab == tpMyFile)
            //{
            //    MessageBox.Show("This feature has been disabled. Please contact ngoc.nam if you have any question");
            //    e.Cancel = true;
            //    return;

            //}
        }

        private void frmFormMain_Load(object sender, EventArgs e)
        {
            listofdevice.LoadDevice(true);
            RemoutDevice(null);
            new Thread(delegate ()
                {
                    try
                    {
                        //using (var context = new DbLogDataContext())
                        //{
                        //    var newversion = context.Configs.SingleOrDefault(x => x.Key == Constant.CURRENT_VERSION);
                        //    if (newversion.Value.CompareTo(Application.ProductVersion) == 1)
                        //    {
                        utilEvent.InsertLog("Checking new version available on server....", UtilLog.LogType.Success);
                        Process.Start("file://107.113.53.35/common/5.USERS/ngoc.nam/PROJECT/ANDROID_UTILITY/Android%20Utility.application");
                        //    }
                        //}
                    }
                    catch (Exception e1)
                    {
                        utilEvent.InsertLog("Can't check upgrade new version", UtilLog.LogType.Error);
                    }

                    Thread.Sleep(1000);
                    if (MLLib.Windows.Registry.ReadKey(Constant.CURRENT_VERSION) != Application.ProductVersion)
                    {
                        MLLib.Windows.Registry.WriteKey(Constant.CURRENT_VERSION, Application.ProductVersion);
                        this.Invoke(new EventHandler((a, b) =>
                        {
                            frmWhatsNew frm = new frmWhatsNew()
                            {
                                ShowPinButton = false,
                                ShowIcon = false,
                                shadowtype = ShadowType.Pro,
                                StartPosition = FormStartPosition.CenterParent,
                                AllowMaximize = false,
                                AllowMinimize = false,
                                HideFooter = true
                            };

                            frm.ShowDialog();
                        }));
                    }
                }).Start();
        }

    }
}

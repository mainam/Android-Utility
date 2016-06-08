using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Managed.Adb;
using Android_Utility.ADBmanager.Receivers;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.Collections.Specialized;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctMyFile : UserControl
    {
        public event EventHandler OnPushFileClick;
        private ListBox lb1;
        private bool IsAddedLB = false;
        private List<string> autocomplete;
        public UtilEvent utilEvent;
        Thread threadPullFile, threadDeleteFile, threadCopyFile;

        public event EventHandler CloseTab;


        public static Dictionary<string, string> ListType = new Dictionary<string, string>()
        {
            {"conf","conf.png" },
            {"apk","apk.png"},
            {"7z","7z.png"},
            {"asp","asp.png"},
            {"avi","avi.png"},
            {"bat","bat.png"},
            {"bin","bin.png"},
            {"bmp","bmp.png"},
            {"c","c.png"},
            {"cab","cab.png"},
            {"cpp","cpp.png"},
            {"cs","cs.png"},
            {"css","css.png"},
            {"csv","csv.png"},
            {"db","db.png"},
            {"dbf","dbf.png"},
            {"dmg","dmg.png"},
            {"dmp","dmp.png"},
            {"doc","doc.png"},
            {"docx","docx.png"},
            {"exe","exe.png"},
            {"flv","flv.png"},
            {"folder","folder.png"},
            {"gif","gif.png"},
            {"h","h.png"},
            {"htm","htm.png"},
            {"html","html.png"},
            {"ico","ico.png"},
            {"ini","ini.png"},
            {"iso","iso.png"},
            {"jar","jar.png"},
            {"java","java.png"},
            {"jpg","jpg.png"},
            {"js","js.png"},
            {"jsp","jsp.png"},
            {"lnk","lnk.png"},
            {"log","log.png"},
            {"mdf","mdf.png"},
            {"mid","mid.png"},
            {"mov","mov.png"},
            {"mp3","mp3.png"},
            {"mp4","mp4.png"},
            {"obj","obj.png"},
            {"pdf","pdf.png"},
            {"php","php.png"},
            {"png","png.png"},
            {"ppt","ppt.png"},
            {"pptx","pptx.png"},
            {"psd","psd.png"},
            {"py","py.png"},
            {"rar","rar.png"},
            {"rom","rom.png"},
            {"rtf","rtf.png"},
            {"sh","sh.png"},
            {"sql","sql.png"},
            {"svg","svg.png"},
            {"swf","swf.png"},
            {"sys","sys.png"},
            {"tar","tar.png"},
            {"thm","thm.png"},
            {"tif","tif.png"},
            {"tmp","tmp.png"},
            {"ttf","ttf.png"},
            {"txt","txt.png"},
            {"vb","vb.png"},
            {"wav","wav.png"},
            {"xls","xls.png"},
            {"xlsx","xlsx.png"},
            {"xml","xml.png"},
            {"zip","zip.png"},
            {"app","app.png"},
            {"key","key.png"},
            {"rt","rt.png"},
            {"so","so.png"},
            {"r","r.png"},
            {"id","id.png"},
            {"license","licence.png"},
            {"licence","licence.png"}
        };
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
            if (CloseTab != null)
                CloseTab(null, null);
            utilEvent.AbortThread(threadPullFile, utilEvent.InsertLog);
            utilEvent.AbortThread(threadDeleteFile, utilEvent.InsertLog);
            utilEvent.AbortThread(threadCopyFile, utilEvent.InsertLog);

            utilEvent.CloseProcessOneItem();
            utilEvent.CloseProcessManyItem();
        }


        public ctMyFile(ctListOfDevice listoffile)
        {
            InitializeComponent();
            this.ListOfDevice = listoffile;
            historyPrev = new Stack<string>();
            historyNext = new Stack<string>();
            ListView_SetSpacing(lvMyFile, 120, 120);
            this.DragDrop += CtMyFile_DragDrop;
            this.DragEnter += CtMyFile_DragEnter;
            this.DragOver += CtMyFile_DragOver;
            autocomplete = new List<string>() { };
            lb1 = new ListBox();
            lb1.ItemHeight = 20;
            lb1.IntegralHeight = false;
            lb1.Visible = false;
            txtPath.Leave += TxtPath_Leave;
            lb1.VisibleChanged += Lb1_VisibleChanged;
            lb1.MouseMove += Lb1_MouseMove;
            lb1.MouseDown += Lb1_MouseDown;
            btnGo_Click(null, null);
        }

        public void SetPath(string path)
        {
            txtPath.Text = path;
            btnGo_Click(null, null);
        }


        private void Lb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex > -1)
            {
                txtPath.Text = lb1.SelectedItem.ToString();
                lb1.Visible = false;
                txtPath.Focus();
                txtPath.Select(Text.Length, 0);
            }
        }

        private void Lb1_MouseMove(object sender, MouseEventArgs e)
        {
            if (lb1.Items.Count > 0)
            {
                int x = lb1.IndexFromPoint(e.Location);
                if (x >= 0)
                {
                    lb1.SelectedIndex = x;
                }
            }
        }

        private void Lb1_VisibleChanged(object sender, EventArgs e)
        {
            if (!lb1.Visible)
            {
                lb1.Items.Clear();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (txtPath.Focused)
                {
                    if (lb1.SelectedIndex > -1)
                    {
                        txtPath.Text = lb1.SelectedItem.ToString();
                        lb1.Visible = false;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void TxtPath_Leave(object sender, EventArgs e)
        {
            if (!lb1.Focused)
            {
                lb1.Visible = false;
            }
        }
        public static string UnUnicodeText(string s)
        {
            s = s.ToLower();
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            s = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            s = s.Replace(" ", "");
            s = s.Replace("\n", "");
            s = s.Replace("\t", "");
            s = s.Replace("\r", "");
            return s;
        }

        private void CtMyFile_DragOver(object sender, DragEventArgs e)
        {
            var point = lvMyFile.PointToClient(new Point(e.X, e.Y));
            var item = lvMyFile.GetItemAt(point.X, point.Y);
            if (item != null)
            {
                switch (lvMyFile.SelectedItems.Count)
                {
                    case 1:
                        if (lvMyFile.SelectedItems[0] != item)
                        {
                            lvMyFile.SelectedItems.Clear();
                            item.Selected = true;

                        }
                        break;
                    case 0:
                        item.Selected = true;
                        break;
                    default:
                        lvMyFile.SelectedItems.Clear();
                        item.Selected = true;
                        break;
                }
            }
            else
                lvMyFile.SelectedItems.Clear();
        }

        private void CtMyFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CtMyFile_DragDrop(object sender, DragEventArgs e)
        {
            var currentPath = "";
            if (lvMyFile.Tag == null)
                return;
            currentPath = lvMyFile.Tag.ToString();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Count() == 0)
                return;


            if (lvMyFile.SelectedItems.Count == 1 && lvMyFile.SelectedItems[0].ImageKey == "folder.png")
                currentPath += lvMyFile.SelectedItems[0].Text + "/";
            MyFile_OnPasteFile(currentPath, files.ToList());
        }


        public void ListView_SetSpacing(ListView listview, short cx, short cy)
        {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            // http://msdn.microsoft.com/en-us/library/bb761176(VS.85).aspx
            // minimum spacing = 4
            SendMessage(listview.Handle, LVM_SETICONSPACING,
            IntPtr.Zero, (IntPtr)MakeLong(cx, cy));

            // http://msdn.microsoft.com/en-us/library/bb775085(VS.85).aspx
            // DOESN'T WORK!
            // can't find ListView_SetIconSpacing in dll comctl32.dll
            //ListView_SetIconSpacing(listView.Handle, 5, 5);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public int MakeLong(short lowPart, short highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }

        Stack<string> historyPrev;
        Stack<string> historyNext;
        private void btnGo_Click(object sender, EventArgs e)
        {
            historyNext.Clear();
            Reload();
        }

        public void Reload()
        {
            if (txtPath.Text == "")
                txtPath.Text = "/";

            OpenPath(txtPath.Text);
        }

        bool changepath = true;
        List<string> listcurrentfile = new List<string>();
        public void OpenPath(string path)
        {
            try
            {

                lb1.Visible = false;
                changepath = false;
                txtPath.Text = path.Trim();
                if (!txtPath.Text.EndsWith("/"))
                    txtPath.Text += "/";
                lvMyFile.Tag = txtPath.Text;
                var key = txtPath.Text.ToLower();
                if (autocomplete.Contains(key))
                {
                    autocomplete.Remove(key);
                }
                else
                {
                    if (autocomplete.Count > 50)
                        autocomplete.Remove(autocomplete.Last());
                }
                autocomplete.Add(key);

                if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.State == DeviceState.Online)
                {
                    new Thread(delegate()
                    {
                        try
                        {
                            var receiver = new ListFileReceiver();
                            listofdevice.CurrentDevice.ExecuteShellCommand("ls {0} -l".With(txtPath.Text.ToArgumentSafe()), receiver);
                            Application.DoEvents();
                            if (receiver.ListFile.Count == 0 && listcurrentfile.Count == 0)
                                return;
                            BindData(receiver);
                        }
                        catch (Exception e1)
                        {
                            utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                            ClearAllItem();
                        }
                    }).Start();
                }
                UpdateButtonHistory();
                changepath = true;
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
        }


        private void ClearAllItem()
        {
            try
            {
                this.Invoke(new EventHandler((a, b) =>
                {
                    lvMyFile.Items.Clear();
                    listcurrentfile.Clear();
                }));
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }
            listcurrentfile.Clear();
        }
        void BindData(ListFileReceiver receiver)
        {
            this.Invoke(new EventHandler((c, d) =>
            {
                try
                {

                    if (receiver.ListFile.Count == 0)
                    {
                        lvMyFile.Items.Clear();
                        listcurrentfile.Clear();
                    }
                    else
                    {
                        var list1 = receiver.ListFile.Select(x => x.filename + "|" + x.type.ToString());
                        var temp = listcurrentfile.Intersect(list1);
                        if (temp.Count() == listcurrentfile.Count() && listcurrentfile.Count != 0 && list1.Count() == listcurrentfile.Count())
                            return;
                        var list2 = listcurrentfile.Except(list1);
                        if (list2.Count() != 0)
                        {
                            for (int i = 0; i < lvMyFile.Items.Count; i++)
                            {
                                var item = lvMyFile.Items[i];
                                var item2 = list2.SingleOrDefault(x => x == item.Text + "|" + (item.ImageKey == "folder.png" ? FileType.Directory.ToString() : item.ImageKey == "lnk.png" ? FileType.Link.ToString() : FileType.File.ToString()));
                                if (item2 != null)
                                {
                                    lvMyFile.Items.RemoveAt(i);
                                    i--;
                                    listcurrentfile.Remove(item2);
                                }
                            }
                        }
                        var list3 = list1.Except(listcurrentfile);
                        if (list3.Count() != 0)
                        {
                            foreach (var item in list3)
                            {
                                listcurrentfile.Add(item);
                                var lvitem = new ListViewItem();
                                var a = item.Split('|');
                                if (a.Count() != 2)
                                    continue;
                                lvitem.Text = a[0];
                                switch (a[1])
                                {
                                    case "Directory":
                                        lvitem.ImageKey = "folder.png";
                                        break;
                                    case "Link":
                                        lvitem.ImageKey = "lnk.png";
                                        break;
                                    case "File":
                                        var filetype = Path.GetExtension(a[0]).Replace(".", "");
                                        if (ctMyFile.ListType.ContainsKey(filetype))
                                        {
                                            var data = ctMyFile.ListType[filetype];
                                            lvitem.ImageKey = data;
                                        }
                                        else
                                            lvitem.ImageKey = "file.png";
                                        break;
                                }
                                lvitem.Tag = a[1];
                                lvMyFile.Items.Add(lvitem);
                            }
                        }

                    }
                    listcurrentfile.Distinct();
                }
                catch (Exception e)
                {
                    utilEvent.InsertLog(e.Message, UtilLog.LogType.Error);
                    lvMyFile.Items.Clear();
                    listcurrentfile.Clear();
                }
            }));
        }

        private void lvMyFile_DoubleClick(object sender, EventArgs e)
        {
            var path = lvMyFile.Tag;

            if (path == null)
                return;

            if (lvMyFile.SelectedItems.Count > 0)
            {
                var item = lvMyFile.SelectedItems[0];
                var tag = item.Tag.ToString();
                if (tag == FileType.Directory.ToString())
                {
                    txtPath.Text = path.ToString() + item.Text + "/";
                    historyPrev.Push(path.ToString());
                    Reload();
                }
                else
                {
                    if (tag == FileType.FolderParent.ToString())
                    {
                        var tmp = path.ToString().Split('/').ToList();
                        if (tmp.Count > 0)
                            tmp.RemoveAt(tmp.Count - 1);
                        if (tmp.Count > 0)
                            tmp.RemoveAt(tmp.Count - 1);
                        txtPath.Text = string.Join("/", tmp.ToArray());
                        if (!txtPath.Text.StartsWith("/"))
                            txtPath.Text = "/" + txtPath.Text;
                        if (!txtPath.Text.EndsWith("/"))
                            txtPath.Text += "/";
                        historyPrev.Push(path.ToString());
                        Reload();
                    }
                    else
                    {
                        if (tag == FileType.Link.ToString())
                        {
                            txtPath.Text = path.ToString() + item.Text + "/";
                            historyPrev.Push(path.ToString());
                            Reload();
                        }
                        else
                            if (tag == FileType.File.ToString())
                                OpenFile(path.ToString(), item.Text);
                    }
                }
            }
            listofdevice.Select();
        }


        private void OpenFile(string currentfolder, string _filename)
        {

            try
            {
                //SaveFileDialog save = new SaveFileDialog();
                //save.FileName = list[1];

                //if (save.ShowDialog() == DialogResult.OK)
                {
                    //var filename = save.FileName;
                    var saveto = Path.GetTempPath() + _filename;
                    utilEvent.InsertLog("Start pull file", UtilLog.LogType.Text);
                    threadPullFile = new Thread(delegate()
                    {
                        Thread.Sleep(500);
                        utilEvent.UpdateStatusOneItem("Pull File");

                        //var c = ctListOfDevice.SyncServiceInstant;
                        try
                        {
                            //if (c == null)
                            //{
                            //    utilEvent.InsertLog("Stop send file, Sync service null", UtilLog.LogType.Info);
                            //    return;
                            //}
                            //if (!c.IsOpen)
                            //    c.Open();

                            //c.PullFile(currentfolder + _filename, saveto, new SyncImplement());
                            AdbCommand adb = new AdbCommand();
                            adb.OutputTextRunADB += utilEvent.InsertLog;
                            ListOfDevice.CurrentDevice.PullFile(currentfolder + _filename, saveto, adb);

                            utilEvent.InsertLog("Pull file to " + saveto + " success", UtilLog.LogType.Text);
                            Process.Start(saveto);
                        }
                        catch (Exception e1)
                        {
                            utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                            utilEvent.InsertLog("Pull file to " + saveto + " failed", UtilLog.LogType.Error);
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

        private void lvMyFile_Click(object sender, EventArgs e)
        {
            var path = lvMyFile.Tag;

            if (path == null)
                return;

            if (lvMyFile.SelectedItems.Count > 0)
            {
                var item = lvMyFile.SelectedItems[0];
                var tag = item.Tag.ToString();

                if (tag == FileType.FolderParent.ToString())
                {
                    var tmp = path.ToString().Split('/').ToList();
                    if (tmp.Count > 0)
                        tmp.RemoveAt(tmp.Count - 1);
                    if (tmp.Count > 0)
                        tmp.RemoveAt(tmp.Count - 1);
                    txtPath.Text = string.Join("/", tmp.ToArray());
                    if (!txtPath.Text.StartsWith("/"))
                        txtPath.Text = "/" + txtPath.Text;
                    if (!txtPath.Text.EndsWith("/"))
                        txtPath.Text += "/";
                    historyPrev.Push(path.ToString());
                    btnGo_Click(null, null);
                }
            }
        }

        private void txtPath_EventKeyDown(object sender, KeyEventArgs e)
        {
            changepath = true;
            if (e.KeyCode == Keys.Down && !lb1.Visible)
            {
                txtPath_EventTextChange(null, null);
                return;
            }
            if (e.KeyCode == Keys.Down && lb1.Visible)
            {
                int indez = lb1.SelectedIndex;
                indez += 1;
                lb1.SelectedIndex = Math.Min(indez, lb1.Items.Count - 1);
                txtPath.Select(txtPath.Text.Length, 0);
            }
            if (e.KeyCode == Keys.Up && lb1.Visible)
            {
                int indez = lb1.SelectedIndex;
                indez -= 1;
                lb1.SelectedIndex = Math.Max(indez, 0);
                txtPath.Select(txtPath.Text.Length, 0);
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (lb1.Visible && lb1.SelectedIndex > -1)
                {
                    txtPath.Text = lb1.SelectedItem.ToString();
                    lb1.Visible = false;
                    txtPath.Select(txtPath.Text.Length, 0);
                }
                btnGo_Click(null, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changepath = false;
            if (historyNext.Count != 0)
            {
                if (lvMyFile.Tag != null)
                    historyPrev.Push(lvMyFile.Tag.ToString());

                var path = historyNext.Pop();
                txtPath.Text = path;
                Reload();
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            changepath = false;
            if (historyPrev.Count != 0)
            {
                if (lvMyFile.Tag != null)
                    historyNext.Push(lvMyFile.Tag.ToString());

                var path = historyPrev.Pop();
                txtPath.Text = path;
                Reload();
            }
        }

        private void UpdateButtonHistory()
        {
            btnPreview.Enabled = historyPrev.Count != 0;
            btnNext.Enabled = historyNext.Count != 0;
        }


        DateTime timemousedown = DateTime.Now;

        private void btnPushFile_Click(object sender, EventArgs e)
        {
            if (OnPushFileClick != null)
            {
                if (lvMyFile.Tag != null)
                {
                    OnPushFileClick(lvMyFile.Tag.ToString(), null);
                    return;
                }
            }
            utilEvent.InsertLog("Do nothing", UtilLog.LogType.Text);
        }


        private void lvMyFile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
                {
                    btnCreateFolder_Click(null, null);
                    return;
                }
                if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                {
                    if (lvMyFile.SelectedItems.Count != 0 && lvMyFile.Tag != null)
                    {
                        var listfile = lvMyFile.SelectedItems.Cast<ListViewItem>().Select(x => x.Text + ((x.ImageKey == "lnk.png" || x.ImageKey == "folder.png") ? "/" : "")).ToList();
                        MyFile_OnPullFile(listfile.Count(), listfile, lvMyFile.Tag.ToString(), Path.GetTempPath(), true);
                    }
                    return;
                }

                if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
                {
                    pasteToolStripMenuItem_Click(null, null);
                    return;
                }
                if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
                {
                    foreach (ListViewItem item in lvMyFile.Items)
                    {
                        item.Selected = true;
                    }
                    return;
                }

                switch (e.KeyCode)
                {
                    case Keys.Home:
                        btnParent_Click(null, null);
                        break;
                    case Keys.F2:
                        if (lvMyFile.Tag != null && lvMyFile.SelectedItems.Count == 1 && listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
                        {
                            var item = lvMyFile.SelectedItems[0].Text;
                            var frmrename = new frmFormInput(item);
                            if (frmrename.ShowDialog() == DialogResult.OK)
                            {
                                if (item != frmrename.NewName)
                                {
                                    var receiver = new ExecuteShellReceiver();
                                    listofdevice.CurrentDevice.ExecuteShellCommand(String.Format("mv '{0}{1}' '{0}{2}'", lvMyFile.Tag.ToString(), item, frmrename.NewName), receiver);
                                    utilEvent.InsertLog("Rename file/folder from '" + item + "' to '" + frmrename.NewName + "' success ", UtilLog.LogType.Success);
                                    lvMyFile.SelectedItems[0].Text = frmrename.NewName;
                                }
                            }
                        }
                        break;
                    case Keys.Enter:
                        if (lvMyFile.SelectedItems.Count > 1)
                            break;
                        lvMyFile_DoubleClick(null, null);
                        break;
                    case Keys.Back:
                        if (historyPrev.Count != 0)
                            btnPreview_Click(null, null);
                        break;
                    case Keys.F5:
                        if (lvMyFile.Tag != null)
                            btnRefresh_Click(null, null);
                        break;
                    case Keys.Delete:
                        int count = lvMyFile.SelectedItems.Count;
                        if (count != 0 && lvMyFile.Tag != null)
                        {
                            var listfile = lvMyFile.SelectedItems.Cast<ListViewItem>().Select(x => new ADBmanager.Receivers.FileInfo() { filename = x.Text, type = x.ImageKey == "folder.png" ? FileType.Directory : FileType.File }).ToList();
                            OnDeleteFile(lvMyFile.Tag.ToString(), listfile);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e1)
            {
                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
            }

        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            var path = lvMyFile.Tag;

            if (path == null)
                return;
            if (path.ToString() == "/") return;
            var tmp = path.ToString().Split('/').ToList();
            if (tmp.Count > 0)
                tmp.RemoveAt(tmp.Count - 1);
            if (tmp.Count > 0)
                tmp.RemoveAt(tmp.Count - 1);
            txtPath.Text = string.Join("/", tmp.ToArray());
            if (!txtPath.Text.StartsWith("/"))
                txtPath.Text = "/" + txtPath.Text;
            if (!txtPath.Text.EndsWith("/"))
                txtPath.Text += "/";
            historyPrev.Push(path.ToString());
            Reload();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            utilEvent.InsertLog("List file have been reload", UtilLog.LogType.Text);
            Reload();
        }



        private void ShowLisBox()
        {
            try
            {
                if (!IsAddedLB)
                {
                    this.Controls.Add(lb1);
                    lb1.Left = txtPath.Left + 5;
                    lb1.Top = txtPath.Top + txtPath.Height;
                    IsAddedLB = true;
                }
                if (lb1.Items.Count > 0)
                {
                    lb1.Size = new Size(txtPath.Size.Width - 5, Math.Min((lb1.Items.Count + 1) * lb1.ItemHeight, 150));
                    lb1.Visible = true;
                    lb1.SelectedIndex = 0;
                    lb1.BringToFront();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtPath_EventTextChange(object sender, EventArgs e)
        {
            if (!changepath)
                return;
            lb1.Visible = false;
            string StrToSearch = UnUnicodeText(txtPath.Text);
            if (StrToSearch.Length > 0 || sender == null)
            {
                var data = autocomplete.Where(x => UnUnicodeText(x).Contains(StrToSearch)).ToList();
                if (!data.Contains(txtPath.Text))
                    data.Insert(0, txtPath.Text);
                lb1.Items.AddRange(data.ToArray());
                ShowLisBox();
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {

                if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline && lvMyFile.Tag != null)
                {
                    frmFormInput frm = new frmFormInput("Create Folder", "");
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (frm.NewName != "")
                        {
                            var receiver = new ExecuteShellReceiver();
                            listofdevice.CurrentDevice.ExecuteShellCommand("mkdir " + lvMyFile.Tag.ToString() + frm.NewName, receiver);
                            OpenPath(lvMyFile.Tag.ToString() + frm.NewName);
                            utilEvent.InsertLog("Create new folder success", UtilLog.LogType.Success);
                        }
                    }
                }
                else
                {
                    utilEvent.InsertLog("Device null or offile", UtilLog.LogType.Text);
                }
            }
            catch (Exception e2)
            {
                utilEvent.InsertLog(e2.Message, UtilLog.LogType.Error);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listfiles = Clipboard.GetFileDropList().Cast<String>().ToList();
            if (lvMyFile.Tag != null && listfiles.Count > 0)
                if (lvMyFile.SelectedItems.Count == 0 || (lvMyFile.SelectedItems.Count == 1 && lvMyFile.SelectedItems[0].ImageKey == "folder.png"))
                {

                    if (lvMyFile.SelectedItems.Count == 0)
                    {
                        MyFile_OnPasteFile(lvMyFile.Tag.ToString(), listfiles);
                    }
                    else
                    {
                        var text = lvMyFile.SelectedItems[0].Text;
                        MyFile_OnPasteFile(lvMyFile.Tag.ToString() + text + "/", listfiles);
                    }
                }
            return;
        }



        private void OnDeleteFile(string currentFolder, List<Android_Utility.ADBmanager.Receivers.FileInfo> listfile)
        {

            if (DialogResult.OK == MessageBox.Show(String.Format("Do you want to remove {0} {1} selected?", listfile.Count, listfile.Count == 1 ? " file has " : "files have "), "Remove file", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
                {

                    utilEvent.InsertLog("Start delete files", UtilLog.LogType.Text);
                    threadDeleteFile = new Thread(delegate()
                    {
                        var list = listfile;
                        Thread.Sleep(500);
                        var output = new Android_Utility.ADBmanager.Receivers.ExecuteShellReceiver();
                        for (int i = 0; i < list.Count; i++)
                        {
                            try
                            {
                                output.lines.Clear();
                                var filename = list[i].filename;
                                if (filename == null) continue;
                                utilEvent.UpdateStatusManyItem(i, "Delete : " + filename);
                                filename = currentFolder + filename;
                                listofdevice.CurrentDevice.ExecuteShellCommand("rm -R '" + filename + "'", output);
                                utilEvent.InsertLog("Delete success file/folder " + currentFolder + list[i].filename, UtilLog.LogType.Success);
                            }
                            catch (Exception e1)
                            {
                                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                                utilEvent.InsertLog("Delete file/folder: " + currentFolder + list[i].filename + " failed", UtilLog.LogType.Error);
                            }
                        }
                        Reload();
                        utilEvent.CloseProcessManyItem();
                    });
                    threadDeleteFile.Start();
                    utilEvent.ShowProcessManyItem(listfile.Count, 0, (a, b) =>
                    {
                        utilEvent.AbortThread(threadDeleteFile, utilEvent.InsertLog);
                        utilEvent.InsertLog("Cancel delete file", UtilLog.LogType.Text);
                        Reload();
                    });
                }

            }
        }

        private void MyFile_OnPullFile(int totalfile, List<string> listfile, string frompath, string topath, bool addtoclipboard)
        {
            if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
            {

                utilEvent.InsertLog("Start pull files", UtilLog.LogType.Text);
                threadCopyFile = new Thread(delegate()
                {
                    List<string> listpath = new List<string>();
                    try
                    {
                        var list = listfile;
                        Thread.Sleep(500);
                        var output = new Android_Utility.ADBmanager.Receivers.ExecuteShellReceiver();
                        for (int i = 0; i < list.Count; i++)
                        {
                            try
                            {
                                var filename = list[i];
                                if (filename == null) continue;
                                //var service = ctListOfDevice.SyncServiceInstant;
                                //service.PullFile(frompath + filename, topath + filename, new SyncImplement());
                                AdbCommand adb = new AdbCommand();
                                adb.OutputTextRunADB += utilEvent.InsertLog;
                                ListOfDevice.CurrentDevice.PullFile(frompath + filename, topath + filename, adb);

                                listpath.Add(topath + filename);
                                utilEvent.UpdateStatusManyItem(i, "Pull:" + filename);
                                utilEvent.InsertLog(String.Format("Copy file from {0} to {1} success ", filename, topath + filename), UtilLog.LogType.Success);
                            }
                            catch (Exception e1)
                            {
                                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                                utilEvent.InsertLog(String.Format("Copy file from {0} to {1} failed ", list[i], topath + list[i]), UtilLog.LogType.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Reload();
                    if (addtoclipboard && listpath.Count > 0)
                    {
                        StringCollection paths = new StringCollection();
                        foreach (var item in listpath)
                        {
                            paths.Add(item);
                        }
                        this.Invoke(new EventHandler((a, b) =>
                        {
                            Clipboard.SetFileDropList(paths);
                            utilEvent.InsertLog("File and folder have been added to clipboard", UtilLog.LogType.Success);
                        }));
                    }
                    utilEvent.CloseProcessManyItem();
                });
                threadCopyFile.Start();
                utilEvent.ShowProcessManyItem(listfile.Count, 0, (a, b) =>
                {
                    utilEvent.AbortThread(threadCopyFile, utilEvent.InsertLog);
                    utilEvent.InsertLog("Cancel pull file", UtilLog.LogType.Text);
                    Reload();
                });
            }
        }

        private void MyFile_OnPasteFile(string currentFolder, List<string> listfile)
        {
            if (listofdevice.CurrentDevice != null && listofdevice.CurrentDevice.IsOnline)
            {

                utilEvent.InsertLog("Start copy files", UtilLog.LogType.Text);
                threadCopyFile = new Thread(delegate()
                {
                    try
                    {

                        var list = listfile;
                        Thread.Sleep(500);
                        var output = new Android_Utility.ADBmanager.Receivers.ExecuteShellReceiver();
                        for (int i = 0; i < list.Count; i++)
                        {
                            try
                            {
                                var filename = list[i];
                                if (filename == null) continue;
                                var _filename = System.IO.Path.GetFileName(filename);
                                var _fileremote = currentFolder + _filename;
                                var service = listofdevice.SyncServiceInstant;
                                utilEvent.UpdateStatusManyItem(i, "Push: " + _filename);
                                var result = service.PushFile(filename, _fileremote, new SyncImplement());
                                if (result.Code == ErrorCodeHelper.RESULT_OK)
                                {
                                    utilEvent.InsertLog(String.Format("Copy file from {0} to {1} success ", filename, currentFolder), UtilLog.LogType.Success);
                                }
                                else
                                {
                                    utilEvent.InsertLog(String.Format("Copy file from {0} to {1} failed ", filename, currentFolder), UtilLog.LogType.Text);
                                }
                            }
                            catch (Exception e1)
                            {
                                utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                                utilEvent.InsertLog(String.Format("Copy file from {0} to {1} failed ", list[i], currentFolder), UtilLog.LogType.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Reload();
                    utilEvent.CloseProcessManyItem();
                });
                threadCopyFile.Start();
                utilEvent.ShowProcessManyItem(listfile.Count, 0, (a, b) =>
                {
                    utilEvent.AbortThread(threadCopyFile, utilEvent.InsertLog);
                    utilEvent.InsertLog("Cancel copy file", UtilLog.LogType.Text);
                    Reload();
                });
            }
        }
    }
}

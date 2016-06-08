using System.Windows.Forms;

namespace Android_Utility
{
    partial class ctMyFile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctMyFile));
            this.lvMyFile = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPushFile = new MLLib.Controls.ctButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.PictureBox();
            this.btnParent = new System.Windows.Forms.PictureBox();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.ctBreakLine2 = new MLLib.Controls.ctBreakLine();
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.txtPath = new MLLib.Controls.ctTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParent)).BeginInit();
            this.ctPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMyFile
            // 
            this.lvMyFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMyFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMyFile.LargeImageList = this.imageList1;
            this.lvMyFile.Location = new System.Drawing.Point(0, 33);
            this.lvMyFile.Name = "lvMyFile";
            this.lvMyFile.Size = new System.Drawing.Size(588, 249);
            this.lvMyFile.TabIndex = 0;
            this.lvMyFile.UseCompatibleStateImageBehavior = false;
            this.lvMyFile.Click += new System.EventHandler(this.lvMyFile_Click);
            this.lvMyFile.DoubleClick += new System.EventHandler(this.lvMyFile_DoubleClick);
            this.lvMyFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvMyFile_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "7z.png");
            this.imageList1.Images.SetKeyName(1, "apk.png");
            this.imageList1.Images.SetKeyName(2, "asp.png");
            this.imageList1.Images.SetKeyName(3, "avi.png");
            this.imageList1.Images.SetKeyName(4, "bat.png");
            this.imageList1.Images.SetKeyName(5, "bin.png");
            this.imageList1.Images.SetKeyName(6, "bmp.png");
            this.imageList1.Images.SetKeyName(7, "c.png");
            this.imageList1.Images.SetKeyName(8, "cab.png");
            this.imageList1.Images.SetKeyName(9, "cpp.png");
            this.imageList1.Images.SetKeyName(10, "cs.png");
            this.imageList1.Images.SetKeyName(11, "css.png");
            this.imageList1.Images.SetKeyName(12, "csv.png");
            this.imageList1.Images.SetKeyName(13, "db.png");
            this.imageList1.Images.SetKeyName(14, "dbf.png");
            this.imageList1.Images.SetKeyName(15, "dmg.png");
            this.imageList1.Images.SetKeyName(16, "dmp.png");
            this.imageList1.Images.SetKeyName(17, "doc.png");
            this.imageList1.Images.SetKeyName(18, "docx.png");
            this.imageList1.Images.SetKeyName(19, "exe.png");
            this.imageList1.Images.SetKeyName(20, "flv.png");
            this.imageList1.Images.SetKeyName(21, "folder.png");
            this.imageList1.Images.SetKeyName(22, "gif.png");
            this.imageList1.Images.SetKeyName(23, "h.png");
            this.imageList1.Images.SetKeyName(24, "htm.png");
            this.imageList1.Images.SetKeyName(25, "html.png");
            this.imageList1.Images.SetKeyName(26, "ico.png");
            this.imageList1.Images.SetKeyName(27, "ini.png");
            this.imageList1.Images.SetKeyName(28, "iso.png");
            this.imageList1.Images.SetKeyName(29, "jar.png");
            this.imageList1.Images.SetKeyName(30, "java.png");
            this.imageList1.Images.SetKeyName(31, "jpg.png");
            this.imageList1.Images.SetKeyName(32, "js.png");
            this.imageList1.Images.SetKeyName(33, "jsp.png");
            this.imageList1.Images.SetKeyName(34, "lnk.png");
            this.imageList1.Images.SetKeyName(35, "log.png");
            this.imageList1.Images.SetKeyName(36, "mdf.png");
            this.imageList1.Images.SetKeyName(37, "mid.png");
            this.imageList1.Images.SetKeyName(38, "mov.png");
            this.imageList1.Images.SetKeyName(39, "mp3.png");
            this.imageList1.Images.SetKeyName(40, "mp4.png");
            this.imageList1.Images.SetKeyName(41, "obj.png");
            this.imageList1.Images.SetKeyName(42, "pdf.png");
            this.imageList1.Images.SetKeyName(43, "php.png");
            this.imageList1.Images.SetKeyName(44, "png.png");
            this.imageList1.Images.SetKeyName(45, "ppt.png");
            this.imageList1.Images.SetKeyName(46, "pptx.png");
            this.imageList1.Images.SetKeyName(47, "psd.png");
            this.imageList1.Images.SetKeyName(48, "py.png");
            this.imageList1.Images.SetKeyName(49, "rar.png");
            this.imageList1.Images.SetKeyName(50, "rom.png");
            this.imageList1.Images.SetKeyName(51, "rtf.png");
            this.imageList1.Images.SetKeyName(52, "sh.png");
            this.imageList1.Images.SetKeyName(53, "sql.png");
            this.imageList1.Images.SetKeyName(54, "svg.png");
            this.imageList1.Images.SetKeyName(55, "swf.png");
            this.imageList1.Images.SetKeyName(56, "sys.png");
            this.imageList1.Images.SetKeyName(57, "tar.png");
            this.imageList1.Images.SetKeyName(58, "thm.png");
            this.imageList1.Images.SetKeyName(59, "tif.png");
            this.imageList1.Images.SetKeyName(60, "tmp.png");
            this.imageList1.Images.SetKeyName(61, "ttf.png");
            this.imageList1.Images.SetKeyName(62, "txt.png");
            this.imageList1.Images.SetKeyName(63, "vb.png");
            this.imageList1.Images.SetKeyName(64, "wav.png");
            this.imageList1.Images.SetKeyName(65, "xls.png");
            this.imageList1.Images.SetKeyName(66, "xlsx.png");
            this.imageList1.Images.SetKeyName(67, "xml.png");
            this.imageList1.Images.SetKeyName(68, "zip.png");
            this.imageList1.Images.SetKeyName(69, "file.png");
            this.imageList1.Images.SetKeyName(70, "parent.png");
            this.imageList1.Images.SetKeyName(71, "app.png");
            this.imageList1.Images.SetKeyName(72, "bmp.png");
            this.imageList1.Images.SetKeyName(73, "key.png");
            this.imageList1.Images.SetKeyName(74, "rt.png");
            this.imageList1.Images.SetKeyName(75, "so.png");
            this.imageList1.Images.SetKeyName(76, "r.png");
            this.imageList1.Images.SetKeyName(77, "licence.png");
            this.imageList1.Images.SetKeyName(78, "id.png");
            this.imageList1.Images.SetKeyName(79, "conf.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateFolder,
            this.refreshToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 114);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(144, 22);
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPushFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(588, 29);
            this.panel1.TabIndex = 6;
            // 
            // btnPushFile
            // 
            this.btnPushFile.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnPushFile.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnPushFile.ButtonBorderSize = 1;
            this.btnPushFile.ButtonDataText = "Push file";
            this.btnPushFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPushFile.Location = new System.Drawing.Point(495, 3);
            this.btnPushFile.Name = "btnPushFile";
            this.btnPushFile.Padding = new System.Windows.Forms.Padding(1);
            this.btnPushFile.Size = new System.Drawing.Size(93, 26);
            this.btnPushFile.TabIndex = 0;
            this.btnPushFile.Click += new System.EventHandler(this.btnPushFile_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = global::Android_Utility.Properties.Resources.refresh_128__1_;
            this.btnRefresh.Location = new System.Drawing.Point(125, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 22);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Image = global::Android_Utility.Properties.Resources.arrow_forward_128;
            this.btnNext.Location = new System.Drawing.Point(85, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 22);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 4;
            this.btnNext.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreview.Image = global::Android_Utility.Properties.Resources.arrow_back_128;
            this.btnPreview.Location = new System.Drawing.Point(45, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(40, 22);
            this.btnPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPreview.TabIndex = 5;
            this.btnPreview.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPreview, "Back");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo.Image = global::Android_Utility.Properties.Resources.go_next_128;
            this.btnGo.Location = new System.Drawing.Point(544, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGo.Size = new System.Drawing.Size(39, 22);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGo.TabIndex = 6;
            this.btnGo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnGo, "Go");
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnParent
            // 
            this.btnParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnParent.Image = global::Android_Utility.Properties.Resources.home_128;
            this.btnParent.Location = new System.Drawing.Point(5, 5);
            this.btnParent.Name = "btnParent";
            this.btnParent.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnParent.Size = new System.Drawing.Size(40, 22);
            this.btnParent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnParent.TabIndex = 7;
            this.btnParent.TabStop = false;
            this.toolTip1.SetToolTip(this.btnParent, "Go to parent");
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 32);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(588, 1);
            this.ctBreakLine1.TabIndex = 10;
            // 
            // ctBreakLine2
            // 
            this.ctBreakLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine2.BreakLineHeight = 1;
            this.ctBreakLine2.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctBreakLine2.Location = new System.Drawing.Point(0, 282);
            this.ctBreakLine2.Name = "ctBreakLine2";
            this.ctBreakLine2.Size = new System.Drawing.Size(588, 1);
            this.ctBreakLine2.TabIndex = 9;
            // 
            // ctPanel1
            // 
            this.ctPanel1.BackColor = System.Drawing.Color.White;
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.White;
            this.ctPanel1.Controls.Add(this.txtPath);
            this.ctPanel1.Controls.Add(this.btnRefresh);
            this.ctPanel1.Controls.Add(this.btnNext);
            this.ctPanel1.Controls.Add(this.btnPreview);
            this.ctPanel1.Controls.Add(this.btnGo);
            this.ctPanel1.Controls.Add(this.btnParent);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel1.Location = new System.Drawing.Point(0, 0);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(588, 32);
            this.ctPanel1.TabIndex = 1;
            // 
            // txtPath
            // 
            this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.BorderColor = System.Drawing.Color.Teal;
            this.txtPath.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.DataText = "/sdcard/";
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.IsPasswordTextBox = false;
            this.txtPath.Location = new System.Drawing.Point(165, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtPath.Size = new System.Drawing.Size(379, 22);
            this.txtPath.TabIndex = 0;
            this.txtPath.TextHint = "Path:";
            this.txtPath.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtPath.TextHintWidth = 0;
            this.txtPath.EventKeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_EventKeyDown);
            this.txtPath.EventTextChange += new System.EventHandler(this.txtPath_EventTextChange);
            // 
            // ctMyFile
            // 
            this.Controls.Add(this.lvMyFile);
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.ctBreakLine2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctPanel1);
            this.Name = "ctMyFile";
            this.Size = new System.Drawing.Size(588, 312);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParent)).EndInit();
            this.ctPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMyFile;
        private System.Windows.Forms.ImageList imageList1;
        private MLLib.Controls.ctPanel ctPanel1;
        private MLLib.Controls.ctTextBox txtPath;
        private PictureBox btnNext;
        private PictureBox btnPreview;
        private PictureBox btnGo;
        private System.Windows.Forms.Panel panel1;
        private MLLib.Controls.ctButton btnPushFile;
        private MLLib.Controls.ctBreakLine ctBreakLine2;
        private MLLib.Controls.ctBreakLine ctBreakLine1;
        private PictureBox btnParent;
        private PictureBox btnRefresh;
        private ToolTip toolTip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem btnCreateFolder;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}

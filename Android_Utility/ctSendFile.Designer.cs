namespace Android_Utility
{
    partial class ctSendFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRemotePath = new MLLib.Controls.ctTextBox();
            this.ctBreakLine2 = new MLLib.Controls.ctBreakLine();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new MLLib.Controls.ctButton();
            this.btnSendFile = new MLLib.Controls.ctButton();
            this.pnSendFile = new System.Windows.Forms.Panel();
            this.lvReceiverFile = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSendFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvReceiverFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtRemotePath);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 32);
            this.panel5.TabIndex = 8;
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRemotePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRemotePath.BorderColor = System.Drawing.Color.White;
            this.txtRemotePath.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRemotePath.DataText = "/sdcard/";
            this.txtRemotePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemotePath.IsPasswordTextBox = false;
            this.txtRemotePath.Location = new System.Drawing.Point(0, 0);
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(549, 32);
            this.txtRemotePath.TabIndex = 0;
            this.txtRemotePath.TextHint = "Send to: ";
            this.txtRemotePath.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtRemotePath.TextHintWidth = 0;
            // 
            // ctBreakLine2
            // 
            this.ctBreakLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine2.BreakLineHeight = 1;
            this.ctBreakLine2.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctBreakLine2.Location = new System.Drawing.Point(0, 32);
            this.ctBreakLine2.Name = "ctBreakLine2";
            this.ctBreakLine2.Size = new System.Drawing.Size(549, 1);
            this.ctBreakLine2.TabIndex = 9;
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 331);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(549, 1);
            this.ctBreakLine1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSendFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(549, 29);
            this.panel1.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnClear.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnClear.ButtonBorderSize = 1;
            this.btnClear.ButtonDataText = "Clear";
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.Location = new System.Drawing.Point(0, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(1);
            this.btnClear.Size = new System.Drawing.Size(93, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnSendFile.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnSendFile.ButtonBorderSize = 1;
            this.btnSendFile.ButtonDataText = "Send";
            this.btnSendFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendFile.Location = new System.Drawing.Point(456, 3);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Padding = new System.Windows.Forms.Padding(1);
            this.btnSendFile.Size = new System.Drawing.Size(93, 26);
            this.btnSendFile.TabIndex = 0;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_ButtonClick);
            // 
            // pnSendFile
            // 
            this.pnSendFile.AllowDrop = true;
            this.pnSendFile.BackColor = System.Drawing.Color.White;
            this.pnSendFile.BackgroundImage = global::Android_Utility.Properties.Resources._18ixdorz2ibjgjpg;
            this.pnSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnSendFile.Controls.Add(this.lvReceiverFile);
            this.pnSendFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSendFile.Location = new System.Drawing.Point(0, 33);
            this.pnSendFile.Name = "pnSendFile";
            this.pnSendFile.Size = new System.Drawing.Size(549, 298);
            this.pnSendFile.TabIndex = 13;
            this.pnSendFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnSendFile_DragDrop);
            this.pnSendFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnSendFile_DragEnter);
            this.pnSendFile.DragLeave += new System.EventHandler(this.pnSendFile_DragLeave);
            // 
            // lvReceiverFile
            // 
            this.lvReceiverFile.AllowDrop = true;
            this.lvReceiverFile.AllowUserToAddRows = false;
            this.lvReceiverFile.AllowUserToDeleteRows = false;
            this.lvReceiverFile.BackgroundColor = System.Drawing.Color.White;
            this.lvReceiverFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReceiverFile.ColumnHeadersHeight = 30;
            this.lvReceiverFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lvReceiverFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Delete});
            this.lvReceiverFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvReceiverFile.Location = new System.Drawing.Point(0, 0);
            this.lvReceiverFile.MultiSelect = false;
            this.lvReceiverFile.Name = "lvReceiverFile";
            this.lvReceiverFile.ReadOnly = true;
            this.lvReceiverFile.RowHeadersWidth = 20;
            this.lvReceiverFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvReceiverFile.RowTemplate.Height = 30;
            this.lvReceiverFile.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lvReceiverFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvReceiverFile.Size = new System.Drawing.Size(549, 298);
            this.lvReceiverFile.TabIndex = 2;
            this.lvReceiverFile.Visible = false;
            this.lvReceiverFile.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lvReceiverFile_CellMouseClick);
            this.lvReceiverFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvReceiverFile_DragEnter);
            this.lvReceiverFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemsListView_KeyDown);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ctSendFile
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.pnSendFile);
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.ctBreakLine2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "ctSendFile";
            this.Size = new System.Drawing.Size(549, 361);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctSendFile_KeyDown);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnSendFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvReceiverFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        public MLLib.Controls.ctTextBox txtRemotePath;
        private MLLib.Controls.ctBreakLine ctBreakLine2;
        private MLLib.Controls.ctBreakLine ctBreakLine1;
        private System.Windows.Forms.Panel panel1;
        private MLLib.Controls.ctButton btnClear;
        private MLLib.Controls.ctButton btnSendFile;
        private System.Windows.Forms.Panel pnSendFile;
        private System.Windows.Forms.DataGridView lvReceiverFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

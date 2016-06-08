namespace Android_Utility
{
    partial class ctInstallMultipleDevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new MLLib.Controls.ctButton();
            this.btnInstall = new MLLib.Controls.ctButton();
            this.pnInstallFile = new System.Windows.Forms.Panel();
            this.lvReceiverFile = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.pnInstallFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvReceiverFile)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnInstall);
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
            // btnInstall
            // 
            this.btnInstall.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnInstall.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnInstall.ButtonBorderSize = 1;
            this.btnInstall.ButtonDataText = "Install";
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInstall.Location = new System.Drawing.Point(456, 3);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Padding = new System.Windows.Forms.Padding(1);
            this.btnInstall.Size = new System.Drawing.Size(93, 26);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Click += new System.EventHandler(this.btnInstallFile_ButtonClick);
            // 
            // pnSendFile
            // 
            this.pnInstallFile.AllowDrop = true;
            this.pnInstallFile.BackColor = System.Drawing.Color.White;
            this.pnInstallFile.BackgroundImage = global::Android_Utility.Properties.Resources._18ixdorz2ibjgjpg;
            this.pnInstallFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnInstallFile.Controls.Add(this.lvReceiverFile);
            this.pnInstallFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInstallFile.Location = new System.Drawing.Point(0, 0);
            this.pnInstallFile.Name = "pnSendFile";
            this.pnInstallFile.Size = new System.Drawing.Size(549, 331);
            this.pnInstallFile.TabIndex = 13;
            this.pnInstallFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnInstallFile_DragDrop);
            this.pnInstallFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnInstallFile_DragEnter);
            this.pnInstallFile.DragLeave += new System.EventHandler(this.pnInstallFile_DragLeave);
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
            this.lvReceiverFile.Size = new System.Drawing.Size(549, 331);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ctInstallMultipleDevice
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.pnInstallFile);
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.panel1);
            this.Name = "ctInstallMultipleDevice";
            this.Size = new System.Drawing.Size(549, 361);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctInstallFile_KeyDown);
            this.panel1.ResumeLayout(false);
            this.pnInstallFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvReceiverFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctBreakLine ctBreakLine1;
        private System.Windows.Forms.Panel panel1;
        private MLLib.Controls.ctButton btnClear;
        private MLLib.Controls.ctButton btnInstall;
        private System.Windows.Forms.Panel pnInstallFile;
        private System.Windows.Forms.DataGridView lvReceiverFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

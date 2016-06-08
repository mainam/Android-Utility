namespace Android_Utility
{
    partial class ctFillFileMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctFillFileMedia));
            this.btnFillData = new MLLib.Controls.ctButton();
            this.ctPanel2 = new MLLib.Controls.ctPanel();
            this.txtFileDes = new MLLib.Controls.ctOpenFileDialog();
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.txtFolderContainer = new MLLib.Controls.ctTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ctPanel3 = new MLLib.Controls.ctPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nbTotalFile = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctPanel2.SuspendLayout();
            this.ctPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ctPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTotalFile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillData
            // 
            this.btnFillData.BackColor = System.Drawing.Color.White;
            this.btnFillData.ButtonBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFillData.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFillData.ButtonBorderSize = 1;
            this.btnFillData.ButtonDataText = "FILL DATA";
            this.btnFillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFillData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillData.Location = new System.Drawing.Point(0, 2);
            this.btnFillData.Name = "btnFillData";
            this.btnFillData.Size = new System.Drawing.Size(987, 51);
            this.btnFillData.TabIndex = 0;
            this.btnFillData.Click += new System.EventHandler(this.btnFillData_Click);
            // 
            // ctPanel2
            // 
            this.ctPanel2.AutoScroll = true;
            this.ctPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel2.BackgroundImage")));
            this.ctPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel2.Controls.Add(this.txtFileDes);
            this.ctPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel2.Location = new System.Drawing.Point(0, 23);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel2.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel2.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel2.Size = new System.Drawing.Size(988, 33);
            this.ctPanel2.TabIndex = 15;
            // 
            // txtFileDes
            // 
            this.txtFileDes.BrowserButtonBackColor = System.Drawing.Color.Aquamarine;
            this.txtFileDes.BrowserButtonText = "...";
            this.txtFileDes.BrowserButtonWidth = 62;
            this.txtFileDes.DialogTitle = "";
            this.txtFileDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileDes.FileNameBackColor = System.Drawing.Color.White;
            this.txtFileDes.FileNameReadOnly = true;
            this.txtFileDes.FilterText = "";
            this.txtFileDes.LabelText = "Select File To Fill:";
            this.txtFileDes.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.txtFileDes.LabelTextWidth = 0;
            this.txtFileDes.Location = new System.Drawing.Point(3, 3);
            this.txtFileDes.Name = "txtFileDes";
            this.txtFileDes.Size = new System.Drawing.Size(982, 27);
            this.txtFileDes.TabIndex = 14;
            this.txtFileDes.Type = MLLib.Controls.ctOpenFileDialog.TypeControl.SelectFile;
            this.txtFileDes.Value = "";
            // 
            // ctPanel1
            // 
            this.ctPanel1.AutoScroll = true;
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel1.Controls.Add(this.txtFolderContainer);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel1.Location = new System.Drawing.Point(0, 79);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(988, 30);
            this.ctPanel1.TabIndex = 17;
            // 
            // txtFolderContainer
            // 
            this.txtFolderContainer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFolderContainer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFolderContainer.BorderColor = System.Drawing.Color.White;
            this.txtFolderContainer.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderContainer.DataText = "/sdcard/";
            this.txtFolderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFolderContainer.IsPasswordTextBox = false;
            this.txtFolderContainer.Location = new System.Drawing.Point(3, 3);
            this.txtFolderContainer.Name = "txtFolderContainer";
            this.txtFolderContainer.PaddingBottom = 0;
            this.txtFolderContainer.PaddingLeft = 0;
            this.txtFolderContainer.PaddingRight = 0;
            this.txtFolderContainer.PaddingTop = 0;
            this.txtFolderContainer.ReadOnly = false;
            this.txtFolderContainer.Size = new System.Drawing.Size(982, 24);
            this.txtFolderContainer.TabIndex = 0;
            this.txtFolderContainer.TextHint = "Folder Container";
            this.txtFolderContainer.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtFolderContainer.TextHintWidth = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select file to fill";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFillData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 1, 1);
            this.panel1.Size = new System.Drawing.Size(988, 54);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(340, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Folder Container (Ex: /sdcard/image/ or /sdcard/music/)";
            // 
            // ctPanel3
            // 
            this.ctPanel3.AutoScroll = true;
            this.ctPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel3.BackgroundImage")));
            this.ctPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel3.Controls.Add(this.label3);
            this.ctPanel3.Controls.Add(this.nbTotalFile);
            this.ctPanel3.Controls.Add(this.label4);
            this.ctPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel3.Location = new System.Drawing.Point(0, 113);
            this.ctPanel3.Name = "ctPanel3";
            this.ctPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel3.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel3.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel3.Size = new System.Drawing.Size(988, 27);
            this.ctPanel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "(files)";
            // 
            // nbTotalFile
            // 
            this.nbTotalFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbTotalFile.Location = new System.Drawing.Point(58, 3);
            this.nbTotalFile.Name = "nbTotalFile";
            this.nbTotalFile.Size = new System.Drawing.Size(94, 20);
            this.nbTotalFile.TabIndex = 18;
            this.nbTotalFile.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 4);
            this.label5.TabIndex = 21;
            // 
            // ctFillFileMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctPanel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctPanel2);
            this.Controls.Add(this.label1);
            this.Name = "ctFillFileMedia";
            this.Size = new System.Drawing.Size(988, 478);
            this.ctPanel2.ResumeLayout(false);
            this.ctPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ctPanel3.ResumeLayout(false);
            this.ctPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTotalFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MLLib.Controls.ctButton btnFillData;
        private MLLib.Controls.ctPanel ctPanel2;
        private MLLib.Controls.ctOpenFileDialog txtFileDes;
        private MLLib.Controls.ctPanel ctPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private MLLib.Controls.ctPanel ctPanel3;
        private System.Windows.Forms.NumericUpDown nbTotalFile;
        private System.Windows.Forms.Label label4;
        private MLLib.Controls.ctTextBox txtFolderContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

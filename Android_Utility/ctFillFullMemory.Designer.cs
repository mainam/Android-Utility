namespace Android_Utility
{
    partial class ctFillFullMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctFillFullMemory));
            this.btnFillData = new MLLib.Controls.ctButton();
            this.ctPanel2 = new MLLib.Controls.ctPanel();
            this.txtFileDes = new MLLib.Controls.ctOpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nbTotalSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctPanel2.SuspendLayout();
            this.ctPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTotalSize)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnFillData.Size = new System.Drawing.Size(675, 51);
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
            this.ctPanel2.Location = new System.Drawing.Point(1, 24);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel2.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel2.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel2.Size = new System.Drawing.Size(676, 33);
            this.ctPanel2.TabIndex = 10;
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
            this.txtFileDes.Size = new System.Drawing.Size(670, 27);
            this.txtFileDes.TabIndex = 14;
            this.txtFileDes.Type = MLLib.Controls.ctOpenFileDialog.TypeControl.SelectFile;
            this.txtFileDes.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select file to fill";
            // 
            // ctPanel1
            // 
            this.ctPanel1.AutoScroll = true;
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel1.Controls.Add(this.cbType);
            this.ctPanel1.Controls.Add(this.nbTotalSize);
            this.ctPanel1.Controls.Add(this.label3);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel1.Location = new System.Drawing.Point(1, 80);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(676, 27);
            this.ctPanel1.TabIndex = 12;
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Gb",
            "Mb",
            "Kb"});
            this.cbType.Location = new System.Drawing.Point(133, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(53, 21);
            this.cbType.TabIndex = 17;
            // 
            // nbTotalSize
            // 
            this.nbTotalSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbTotalSize.Location = new System.Drawing.Point(39, 3);
            this.nbTotalSize.Name = "nbTotalSize";
            this.nbTotalSize.Size = new System.Drawing.Size(94, 20);
            this.nbTotalSize.TabIndex = 18;
            this.nbTotalSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 57);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Setup size fill";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFillData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 107);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 1, 1);
            this.panel1.Size = new System.Drawing.Size(676, 54);
            this.panel1.TabIndex = 14;
            // 
            // ctFillFullMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctPanel2);
            this.Controls.Add(this.label1);
            this.Name = "ctFillFullMemory";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(678, 398);
            this.ctPanel2.ResumeLayout(false);
            this.ctPanel1.ResumeLayout(false);
            this.ctPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTotalSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MLLib.Controls.ctButton btnFillData;
        private MLLib.Controls.ctPanel ctPanel2;
        private System.Windows.Forms.Label label1;
        private MLLib.Controls.ctOpenFileDialog txtFileDes;
        private MLLib.Controls.ctPanel ctPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nbTotalSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

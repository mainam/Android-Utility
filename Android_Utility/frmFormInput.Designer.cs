namespace Android_Utility
{
    partial class frmFormInput
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormInput));
            this.ctTextBox1 = new MLLib.Controls.ctTextBox();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.btnOK = new MLLib.Controls.ctButton();
            this.btnCancel = new MLLib.Controls.ctButton();
            this.panel.SuspendLayout();
            this.ctPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlFooter
            // 
            this.mlFooter.Location = new System.Drawing.Point(0, 61);
            this.mlFooter.Size = new System.Drawing.Size(405, 55);
            this.mlFooter.Visible = false;
            // 
            // mlHeader
            // 
            this.mlHeader.AllowClose = true;
            this.mlHeader.AllowMaximize = true;
            this.mlHeader.AllowMinimize = true;
            this.mlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.mlHeader.Location = new System.Drawing.Point(0, 1);
            this.mlHeader.Size = new System.Drawing.Size(405, 39);
            this.mlHeader.Title = "Rename";
            this.mlHeader.TitleBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ctPanel1);
            this.panel.Controls.Add(this.ctBreakLine1);
            this.panel.Controls.Add(this.ctTextBox1);
            this.panel.Size = new System.Drawing.Size(405, 116);
            this.panel.Controls.SetChildIndex(this.mlHeader, 0);
            this.panel.Controls.SetChildIndex(this.ctTextBox1, 0);
            this.panel.Controls.SetChildIndex(this.ctBreakLine1, 0);
            this.panel.Controls.SetChildIndex(this.mlFooter, 0);
            this.panel.Controls.SetChildIndex(this.ctPanel1, 0);
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ctTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ctTextBox1.BorderColor = System.Drawing.Color.White;
            this.ctTextBox1.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.DataText = "";
            this.ctTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctTextBox1.IsPasswordTextBox = false;
            this.ctTextBox1.Location = new System.Drawing.Point(0, 40);
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.PaddingBottom = 0;
            this.ctTextBox1.PaddingLeft = 0;
            this.ctTextBox1.PaddingRight = 0;
            this.ctTextBox1.PaddingTop = 0;
            this.ctTextBox1.ReadOnly = false;
            this.ctTextBox1.Size = new System.Drawing.Size(405, 38);
            this.ctTextBox1.TabIndex = 2;
            this.ctTextBox1.TextHint = "Input Name : ";
            this.ctTextBox1.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.ctTextBox1.TextHintWidth = 0;
            this.ctTextBox1.EventKeyDown += new System.Windows.Forms.KeyEventHandler(this.ctTextBox1_EventKeyDown);
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 78);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(405, 1);
            this.ctBreakLine1.TabIndex = 4;
            this.ctBreakLine1.Text = "ctBreakLine1";
            // 
            // ctPanel1
            // 
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.White;
            this.ctPanel1.Controls.Add(this.btnOK);
            this.ctPanel1.Controls.Add(this.btnCancel);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctPanel1.Location = new System.Drawing.Point(0, 79);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(405, 0);
            this.ctPanel1.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnOK.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnOK.ButtonBorderSize = 1;
            this.btnOK.ButtonDataText = "OK";
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(238, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnOK.Size = new System.Drawing.Size(81, 0);
            this.btnOK.TabIndex = 3;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCancel.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnCancel.ButtonBorderSize = 1;
            this.btnCancel.ButtonDataText = "Cancel";
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(319, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(81, 0);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFormInput
            // 
            this.AllowClose = true;
            this.AllowMaximize = true;
            this.AllowMinimize = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 118);
            this.HideFooter = false;
            this.HideHeader = false;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowPinButton = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename";
            this.Load += new System.EventHandler(this.frmFormInput_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRenameRemoteFile_KeyDown);
            this.panel.ResumeLayout(false);
            this.ctPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctTextBox ctTextBox1;
        private MLLib.Controls.ctBreakLine ctBreakLine1;
        private MLLib.Controls.ctPanel ctPanel1;
        private MLLib.Controls.ctButton btnOK;
        private MLLib.Controls.ctButton btnCancel;
    }
}
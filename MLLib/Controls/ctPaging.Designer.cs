namespace MLLib.Controls
{
    partial class ctPaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctPaging));
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.TotalItem = new MLLib.Controls.ctTextBox();
            this.btnPreview = new MLLib.Controls.ctButton();
            this.txtCurrentPage = new MLLib.Controls.ctTextBox();
            this.txtTotalPage = new MLLib.Controls.ctTextBox();
            this.btnNext = new MLLib.Controls.ctButton();
            this.ctTextBox1 = new MLLib.Controls.ctTextBox();
            this.ctPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctPanel1
            // 
            this.ctPanel1.BackColor = System.Drawing.Color.White;
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.Aqua;
            this.ctPanel1.Controls.Add(this.btnPreview);
            this.ctPanel1.Controls.Add(this.txtCurrentPage);
            this.ctPanel1.Controls.Add(this.ctTextBox1);
            this.ctPanel1.Controls.Add(this.TotalItem);
            this.ctPanel1.Controls.Add(this.txtTotalPage);
            this.ctPanel1.Controls.Add(this.btnNext);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctPanel1.Location = new System.Drawing.Point(0, 0);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(697, 32);
            this.ctPanel1.TabIndex = 8;
            // 
            // TotalItem
            // 
            this.TotalItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TotalItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TotalItem.BorderColor = System.Drawing.Color.White;
            this.TotalItem.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItem.DataText = "";
            this.TotalItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.TotalItem.IsPasswordTextBox = false;
            this.TotalItem.Location = new System.Drawing.Point(2, 2);
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.PaddingBottom = 0;
            this.TotalItem.PaddingLeft = 0;
            this.TotalItem.PaddingRight = 0;
            this.TotalItem.PaddingTop = 0;
            this.TotalItem.ReadOnly = true;
            this.TotalItem.Size = new System.Drawing.Size(107, 28);
            this.TotalItem.TabIndex = 11;
            this.TotalItem.TextHint = "Total Item:";
            this.TotalItem.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.TotalItem.TextHintWidth = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.BackgroundImage = global::MLLib.Properties.Resources.LeftHoverKRBBlue;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreview.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnPreview.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnPreview.ButtonBorderSize = 1;
            this.btnPreview.ButtonDataText = "";
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPreview.Location = new System.Drawing.Point(529, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnPreview.Size = new System.Drawing.Size(31, 28);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCurrentPage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCurrentPage.BorderColor = System.Drawing.Color.White;
            this.txtCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPage.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPage.DataText = "";
            this.txtCurrentPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCurrentPage.IsPasswordTextBox = false;
            this.txtCurrentPage.Location = new System.Drawing.Point(560, 2);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.PaddingBottom = 0;
            this.txtCurrentPage.PaddingLeft = 0;
            this.txtCurrentPage.PaddingRight = 0;
            this.txtCurrentPage.PaddingTop = 0;
            this.txtCurrentPage.ReadOnly = false;
            this.txtCurrentPage.Size = new System.Drawing.Size(44, 28);
            this.txtCurrentPage.TabIndex = 9;
            this.txtCurrentPage.TextHint = "";
            this.txtCurrentPage.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtCurrentPage.TextHintWidth = 0;
            this.txtCurrentPage.EventKeyLeave += new System.EventHandler(this.txtCurrentPage_EventKeyLeave);
            this.txtCurrentPage.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_EventKeyPress);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotalPage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotalPage.BorderColor = System.Drawing.Color.White;
            this.txtTotalPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPage.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPage.DataText = "";
            this.txtTotalPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTotalPage.IsPasswordTextBox = false;
            this.txtTotalPage.Location = new System.Drawing.Point(620, 2);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.PaddingBottom = 0;
            this.txtTotalPage.PaddingLeft = 0;
            this.txtTotalPage.PaddingRight = 0;
            this.txtTotalPage.PaddingTop = 0;
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(44, 28);
            this.txtTotalPage.TabIndex = 12;
            this.txtTotalPage.TextHint = "";
            this.txtTotalPage.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalPage.TextHintWidth = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::MLLib.Properties.Resources.RightHoverKRBBlue;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnNext.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnNext.ButtonBorderSize = 1;
            this.btnNext.ButtonDataText = "";
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(664, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnNext.Size = new System.Drawing.Size(31, 28);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ctTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ctTextBox1.BorderColor = System.Drawing.Color.White;
            this.ctTextBox1.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.DataText = "";
            this.ctTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctTextBox1.IsPasswordTextBox = false;
            this.ctTextBox1.Location = new System.Drawing.Point(604, 2);
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.PaddingBottom = 0;
            this.ctTextBox1.PaddingLeft = 0;
            this.ctTextBox1.PaddingRight = 0;
            this.ctTextBox1.PaddingTop = 0;
            this.ctTextBox1.ReadOnly = false;
            this.ctTextBox1.Size = new System.Drawing.Size(16, 28);
            this.ctTextBox1.TabIndex = 13;
            this.ctTextBox1.TextHint = "/";
            this.ctTextBox1.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.ctTextBox1.TextHintWidth = 0;
            // 
            // ctPaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctPanel1);
            this.Name = "ctPaging";
            this.Size = new System.Drawing.Size(697, 32);
            this.ctPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctPanel ctPanel1;
        private ctButton btnPreview;
        private ctButton btnNext;
        public ctTextBox txtCurrentPage;
        public ctTextBox TotalItem;
        public ctTextBox txtTotalPage;
        public ctTextBox ctTextBox1;

    }
}

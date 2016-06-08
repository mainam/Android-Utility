namespace MLLib
{
    partial class ctHeader
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnLabelTitle = new System.Windows.Forms.Panel();
            this.ptBoxIcon = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPinner = new System.Windows.Forms.Panel();
            this.btnPin = new System.Windows.Forms.Button();
            this.pnMinimize = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnMaximize = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pnClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.pnTitle.SuspendLayout();
            this.pnLabelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxIcon)).BeginInit();
            this.pnPinner.SuspendLayout();
            this.pnMinimize.SuspendLayout();
            this.pnMaximize.SuspendLayout();
            this.pnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.pnLabelTitle);
            this.pnTitle.Controls.Add(this.pnPinner);
            this.pnTitle.Controls.Add(this.pnMinimize);
            this.pnTitle.Controls.Add(this.pnMaximize);
            this.pnTitle.Controls.Add(this.pnClose);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTitle.ForeColor = System.Drawing.Color.White;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Padding = new System.Windows.Forms.Padding(3);
            this.pnTitle.Size = new System.Drawing.Size(822, 46);
            this.pnTitle.TabIndex = 0;
            this.pnTitle.SizeChanged += new System.EventHandler(this.pnTitle_SizeChanged);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // pnLabelTitle
            // 
            this.pnLabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnLabelTitle.Controls.Add(this.ptBoxIcon);
            this.pnLabelTitle.Controls.Add(this.lbTitle);
            this.pnLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLabelTitle.Location = new System.Drawing.Point(3, 3);
            this.pnLabelTitle.Name = "pnLabelTitle";
            this.pnLabelTitle.Size = new System.Drawing.Size(660, 40);
            this.pnLabelTitle.TabIndex = 1;
            this.pnLabelTitle.SizeChanged += new System.EventHandler(this.pnLabelTitle_SizeChanged);
            this.pnLabelTitle.DoubleClick += new System.EventHandler(this.pnLabelTitle_DoubleClick);
            this.pnLabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // ptBoxIcon
            // 
            this.ptBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptBoxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.ptBoxIcon.Name = "ptBoxIcon";
            this.ptBoxIcon.Size = new System.Drawing.Size(100, 40);
            this.ptBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBoxIcon.TabIndex = 1;
            this.ptBoxIcon.TabStop = false;
            this.ptBoxIcon.SizeChanged += new System.EventHandler(this.ptBoxIcon_SizeChanged);
            this.ptBoxIcon.Click += new System.EventHandler(this.ptBoxIcon_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(215, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(164, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "LABLE HEADER";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // pnPinner
            // 
            this.pnPinner.Controls.Add(this.btnPin);
            this.pnPinner.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPinner.Location = new System.Drawing.Point(663, 3);
            this.pnPinner.Name = "pnPinner";
            this.pnPinner.Padding = new System.Windows.Forms.Padding(2);
            this.pnPinner.Size = new System.Drawing.Size(39, 40);
            this.pnPinner.TabIndex = 4;
            // 
            // btnPin
            // 
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPin.FlatAppearance.BorderSize = 0;
            this.btnPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPin.Image = global::MLLib.Properties.Resources.btn_pin_o;
            this.btnPin.Location = new System.Drawing.Point(2, 2);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(35, 35);
            this.btnPin.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPin, "Minimize");
            this.btnPin.UseVisualStyleBackColor = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // pnMinimize
            // 
            this.pnMinimize.Controls.Add(this.btnMinimize);
            this.pnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMinimize.Location = new System.Drawing.Point(702, 3);
            this.pnMinimize.Name = "pnMinimize";
            this.pnMinimize.Padding = new System.Windows.Forms.Padding(2);
            this.pnMinimize.Size = new System.Drawing.Size(39, 40);
            this.pnMinimize.TabIndex = 3;
            this.pnMinimize.DoubleClick += new System.EventHandler(this.pnLabelTitle_DoubleClick);
            this.pnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::MLLib.Properties.Resources.minimize_d240;
            this.btnMinimize.Location = new System.Drawing.Point(2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnMaximize
            // 
            this.pnMaximize.Controls.Add(this.btnMaximize);
            this.pnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMaximize.Location = new System.Drawing.Point(741, 3);
            this.pnMaximize.Name = "pnMaximize";
            this.pnMaximize.Padding = new System.Windows.Forms.Padding(2);
            this.pnMaximize.Size = new System.Drawing.Size(39, 40);
            this.pnMaximize.TabIndex = 2;
            this.pnMaximize.DoubleClick += new System.EventHandler(this.pnLabelTitle_DoubleClick);
            this.pnMaximize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::MLLib.Properties.Resources.maximize_d240;
            this.btnMaximize.Location = new System.Drawing.Point(2, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseMove);
            // 
            // pnClose
            // 
            this.pnClose.Controls.Add(this.btnClose);
            this.pnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnClose.Location = new System.Drawing.Point(780, 3);
            this.pnClose.Name = "pnClose";
            this.pnClose.Padding = new System.Windows.Forms.Padding(2);
            this.pnClose.Size = new System.Drawing.Size(39, 40);
            this.pnClose.TabIndex = 0;
            this.pnClose.DoubleClick += new System.EventHandler(this.pnLabelTitle_DoubleClick);
            this.pnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::MLLib.Properties.Resources.close_d240;
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClose, "Close Form");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 45);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(822, 1);
            this.ctBreakLine1.TabIndex = 3;
            this.ctBreakLine1.Text = "ctBreakLine1";
            // 
            // ctHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.pnTitle);
            this.Name = "ctHeader";
            this.Size = new System.Drawing.Size(822, 46);
            this.Load += new System.EventHandler(this.ctTitle_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnLabelTitle.ResumeLayout(false);
            this.pnLabelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxIcon)).EndInit();
            this.pnPinner.ResumeLayout(false);
            this.pnMinimize.ResumeLayout(false);
            this.pnMaximize.ResumeLayout(false);
            this.pnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Panel pnLabelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnMinimize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnMaximize;
        private System.Windows.Forms.Button btnMaximize;
        public System.Windows.Forms.Button btnPin;
        public System.Windows.Forms.Panel pnPinner;
        public System.Windows.Forms.PictureBox ptBoxIcon;
        private Controls.ctBreakLine ctBreakLine1;
    }
}

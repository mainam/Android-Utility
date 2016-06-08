namespace MLLib
{
    partial class mlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel = new MLLib.Controls.ctPanel();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.mlFooter = new MLLib.ctFooter();
            this.mlHeader = new MLLib.ctHeader();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.ctBreakLine1);
            this.panel.Controls.Add(this.mlFooter);
            this.panel.Controls.Add(this.mlHeader);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.PageEndColor = System.Drawing.Color.Empty;
            this.panel.PageStartColor = System.Drawing.Color.Empty;
            this.panel.Size = new System.Drawing.Size(573, 396);
            this.panel.TabIndex = 2;
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.Teal;
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.Teal;
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 46);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(573, 1);
            this.ctBreakLine1.TabIndex = 2;
            this.ctBreakLine1.Text = "ctBreakLine1";
            // 
            // mlFooter
            // 
            this.mlFooter.BackColor = System.Drawing.Color.Black;
            this.mlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mlFooter.ForeColor = System.Drawing.Color.White;
            this.mlFooter.ImageFooter = null;
            this.mlFooter.Location = new System.Drawing.Point(0, 341);
            this.mlFooter.Name = "mlFooter";
            this.mlFooter.Padding = new System.Windows.Forms.Padding(5);
            this.mlFooter.Size = new System.Drawing.Size(573, 55);
            this.mlFooter.TabIndex = 1;
            this.mlFooter.TitleBackground = System.Drawing.Color.Black;
            this.mlFooter.TitleColor = System.Drawing.Color.White;
            this.mlFooter.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlFooter.TitleFooter = "TITLE FOOTER ";
            // 
            // mlHeader
            // 
            this.mlHeader.AllowClose = true;
            this.mlHeader.AllowMaximize = true;
            this.mlHeader.AllowMinimize = true;
            this.mlHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mlHeader.CurrentForm = this;
            this.mlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlHeader.Icon = null;
            this.mlHeader.Location = new System.Drawing.Point(0, 0);
            this.mlHeader.Name = "mlHeader";
            this.mlHeader.Pin = false;
            this.mlHeader.Size = new System.Drawing.Size(573, 46);
            this.mlHeader.TabIndex = 0;
            this.mlHeader.Title = "Title Form";
            this.mlHeader.TitleBackground = System.Drawing.Color.LightSeaGreen;
            this.mlHeader.TitleColor = System.Drawing.Color.White;
            this.mlHeader.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mlHeader.TooltipIcon = "";
            // 
            // mlForm
            // 
            this.ClientSize = new System.Drawing.Size(573, 396);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mlForm_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ctFooter mlFooter;
        public ctHeader mlHeader;
        private System.Windows.Forms.ToolTip toolTip1;
        public Controls.ctPanel panel;
        private Controls.ctBreakLine ctBreakLine1;
    }
}
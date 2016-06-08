using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MLLib.Theme
{
    public partial class ctHeaderBox : UserControl
    {
        public ctHeaderBox()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lbTitleBox.Text;
            }
            set
            {
                lbTitleBox.Text = value;
                lbTitleBox.Left = (this.Width - lbTitleBox.Width) / 2;
                lbTitleBox.Top = (this.Height - lbTitleBox.Height) / 2;
            }
        }
        public Font TitleFont
        {
            get
            {
                return lbTitleBox.Font;
            }
            set
            {
                lbTitleBox.Font = value;
                lbTitleBox.Left = (this.Width - lbTitleBox.Width) / 2;
                lbTitleBox.Top = (this.Height - lbTitleBox.Height) / 2;
            }
        }

        public Color TitleColor
        {
            get
            {
                return lbTitleBox.ForeColor;
            }
            set
            {
                lbTitleBox.ForeColor = value;
            }
        }
        public Color TitleBackground
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        private void ctHeaderBox_SizeChanged(object sender, EventArgs e)
        {
            try
            {

                lbTitleBox.Left = (this.Width - lbTitleBox.Width) / 2;
                lbTitleBox.Top = (this.Height - lbTitleBox.Height) / 2;
            }
            catch (Exception)
            {

            }
        }

        private void ctHeaderBox_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }
    }
}

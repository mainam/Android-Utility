using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MLLib
{
    public partial class ctFooter : UserControl
    {
        public ctFooter()
        {
            InitializeComponent();
        }

        private void ctFooter_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Bottom;
        }

        private void ctFooter_SizeChanged(object sender, EventArgs e)
        {
            ptImage.Width = ptImage.Height;
            lbTitleFooter.Top = (this.Height - lbTitleFooter.Height) / 2;
        }

        public string TitleFooter
        {
            get
            {
                return lbTitleFooter.Text;
            }
            set
            {
                lbTitleFooter.Text = value;
            }
        }
        public Font TitleFont
        {
            get
            {
                return lbTitleFooter.Font;
            }
            set
            {
                lbTitleFooter.Font = value;
                lbTitleFooter.Top = (this.Height - lbTitleFooter.Height) / 2;
            }
        }

        public Color TitleColor
        {
            get
            {
                return lbTitleFooter.ForeColor;
            }
            set
            {
                lbTitleFooter.ForeColor = value;
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

        [DefaultValue(0)]
        public Image ImageFooter
        {
            get
            {
                return this.ptImage.Image;
            }
            set
            {
                this.ptImage.Image  = value;
            }
        }
    }
}

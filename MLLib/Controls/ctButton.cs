using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Controls
{
    public partial class ctButton : Panel
    {
        public ctButton()
        {
            InitializeComponent();
        }

        public String ButtonDataText
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        public Color ButtonBorderColor
        {
            get
            {
                return button1.FlatAppearance.BorderColor;
            }
            set
            {
                button1.FlatAppearance.BorderColor = value;
            }
        }

        public Color ButtonBackgroundColor
        {
            get
            {
                return button1.BackColor;
            }
            set
            {
                button1.BackColor = value;
            }
        }
        protected override void OnBackgroundImageChanged(EventArgs e)
        {
        }

        protected override void OnBackgroundImageLayoutChanged(EventArgs e)
        {
        }

        public ImageLayout BackgroundImageLayout
        {
            get
            {
                return button1.BackgroundImageLayout;
            }
            set
            {
                button1.BackgroundImageLayout = value;
            }

        }


        public Image BackgroundImage
        {
            get
            {
                return button1.BackgroundImage;
            }
            set
            {
                button1.BackgroundImage = value;
            }
        }

        public int ButtonBorderSize
        {
            get
            {
                return button1.FlatAppearance.BorderSize;
            }
            set
            {
                button1.FlatAppearance.BorderSize = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        public void PerformClick()
        {
            OnClick(null);
        }
    }
}

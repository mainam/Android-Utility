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
    public partial class ctPaging : UserControl
    {
        public ctPaging()
        {
            InitializeComponent();
        }

        int currentpage;
        int totalpage;
        public int CurrentPage
        {
            get
            {
                return this.currentpage;
            }
            set
            {
                this.currentpage = value;
                txtCurrentPage.Text = value.ToString();
            }
        }
        public int TotalPage
        {
            get
            {
                return this.totalpage;
            }
            set
            {
                this.totalpage = value;
                txtTotalPage.Text = value.ToString();
            }
        }

        public event EventHandler Next, Preview, KeyLeave;

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (currentpage <= 1)
                return;

            if (Preview != null)
                Preview(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentpage >= totalpage)
                return;
            if (Next != null)
                Next(sender, e);

        }

        private void txtCurrentPage_EventKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;


        }

        private void txtCurrentPage_EventKeyLeave(object sender, EventArgs e)
        {
            var textbox = sender as ctTextBox;
            if (textbox.Text == "")
                textbox.Text = "1";


            int newpage = Convert.ToInt32(txtCurrentPage.Text);
            if (newpage <= 0)
            {
                txtCurrentPage.Text = "1";
            }
            if (newpage > totalpage)
            {
                txtCurrentPage.Text = newpage.ToString();
                return;
            }


            if (KeyLeave != null)
                KeyLeave(sender, e);
        }

    }
}

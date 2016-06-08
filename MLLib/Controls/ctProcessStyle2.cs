using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MLLib.Controls
{
    public partial class ctProcessStyle2 : UserControl
    {
        public ctProcessStyle2()
        {
            InitializeComponent();
        }
        public void Update(string status)
        {
            this.Invoke(new EventHandler(delegate
            {
                lbStatus.Text = status;
            }));
        }


        Form currentform = null;
        bool lockForm;

        public bool LockForm
        {
            get
            {
                return lockForm;
            }
            set
            {
                lockForm = value;
            }
        }

        [DefaultValue(0)]
        public Form CurrentForm
        {
            get
            {
                return currentform;
            }
            set
            {
                currentform = value;
                if (currentform != null)
                {
                    currentform.FormBorderStyle = FormBorderStyle.None;
                    currentform.Opacity = 90;

                }
            }
        }


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentform != null)
                {
                    ReleaseCapture();
                    SendMessage(currentform.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }


        private void ctProcessStyle2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //this.MaximumSize = this.MinimumSize = this.Size = new Size(354, 95);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}

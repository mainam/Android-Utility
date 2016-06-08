using MLLib.Theme;
using MLLib.Windows;
using MLLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MLLib
{
    public partial class mlForm : Form
    {
        private Dropshadow shadow;

        public mlForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new Padding(1, 1, 1, 1);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.mlHeader.FormWindowStateChange += mlHeader_FormWindowStateChange;
        }

        private Color borderShadowColor = Color.LightGreen;
        public Color BorderShadowColor
        {
            set
            {
                borderShadowColor = value;
                if (shadow != null)
                    shadow.ShadowColor = value;
            }
            get
            {
                return borderShadowColor;
            }
        }

        void mlHeader_FormWindowStateChange(object sender, EventArgs e)
        {
            try
            {
                if (sender != null && shadow != null)
                {
                    if (sender == "Maximize")
                    {
                        var screen = Screen.FromControl(this).WorkingArea;
                        screen.X = 0;
                        screen.Y = 0;
                        this.MaximizedBounds = screen;

                        shadow.Hide();
                    }
                    else
                    {
                        shadow.RefreshShadow();
                        shadow.Show();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        // Define the CS_DROPSHADOW constant
        private const int CS_DROPSHADOW = 0x00020000;

        public enum ShadowType
        {
            NoShadow,
            Basic,
            Pro
        }
        public ShadowType shadowtype = ShadowType.NoShadow;
        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                if (shadowtype == ShadowType.Basic)
                {
                    CreateParams cp = base.CreateParams;
                    cp.ClassStyle |= CS_DROPSHADOW;
                    return cp;
                }
                return base.CreateParams;
            }
        }


        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    // TODO: Add custom paint code here

        //    // Calling the base class OnPaint
        //    base.OnPaint(pe);
        //}
        public string TooltipIconHeader
        {
            get
            {
                return this.toolTip1.GetToolTip(mlHeader.ptBoxIcon);
            }
            set
            {
                SetTooltip(mlHeader.ptBoxIcon, value);
            }
        }

        public bool AllowMaximize
        {
            get
            {
                return mlHeader.AllowMaximize;
            }
            set
            {
                mlHeader.AllowMaximize = value;
            }
        }

        public bool AllowMinimize
        {
            get
            {
                return mlHeader.AllowMinimize;
            }
            set
            {
                mlHeader.AllowMinimize = value;
            }
        }

        public bool AllowClose
        {
            get
            {
                return mlHeader.AllowClose;
            }
            set
            {
                mlHeader.AllowClose = value;
            }
        }

        public void SetTooltip(Control control, String tooltip)
        {
            this.toolTip1.SetToolTip(control, tooltip);
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {
        }

        public void AddButtonTitle(ButtonTitle button)
        {
            mlHeader.AddButton(button);
        }

        public bool ShowPinButton
        {
            get
            {
                return this.mlHeader.pnPinner.Visible;
            }
            set
            {
                this.mlHeader.pnPinner.Visible = value;
            }
        }

        public bool HideFooter
        {
            get
            {
                return !mlFooter.Visible;
            }
            set
            {
                mlFooter.Visible = !value;
            }
        }

        public String Text
        {
            get
            {
                return mlHeader.Title;
            }
            set
            {
                mlHeader.Title = base.Text = value;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        public bool HideHeader
        {
            get
            {
                return !mlHeader.Visible;
            }
            set
            {
                mlHeader.Visible = !value;
            }
        }

        bool allowResize = true;
        public bool AllowResize
        {
            get
            {
                return allowResize;
            }
            set
            {
                allowResize = value;
            }
        }

        public void ActiveForm()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            this.Activate();
            // set it back to whatever it was
            TopMost = top;
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ActiveForm();
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                base.WndProc(ref m);
                return;
            }
            if (m.Msg == 0x84 && allowResize)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y <= 3 && pos.X <= 3)
                {
                    m.Result = (IntPtr)13;  // HTTOPLEFT
                    return;
                }

                if (pos.Y <= 3 && pos.X >= this.ClientSize.Width - 3)
                {
                    m.Result = (IntPtr)14;  // HTTOPRIGHT
                    return;
                }

                if (pos.Y <= 3)
                {
                    m.Result = (IntPtr)12;  // HTTOP
                    return;
                }



                if (pos.X <= 3 && pos.Y >= this.ClientSize.Height - 3)
                {
                    m.Result = (IntPtr)16;  // HTBOTTOMLEFT
                    return;
                }

                if (pos.X >= this.ClientSize.Width - 3 && pos.Y >= this.ClientSize.Height - 3)
                {
                    m.Result = (IntPtr)17;  // HTBOTTOMRIGHT
                    return;
                }

                if (pos.X <= 3)
                {
                    m.Result = (IntPtr)10;  // HTLEFT
                    return;
                }

                if (pos.X >= this.ClientSize.Width - 3)
                {
                    m.Result = (IntPtr)11;  // HTRIGHT
                    return;
                }

                if (pos.Y >= this.ClientSize.Height - 3)
                {
                    m.Result = (IntPtr)15;  // HTBOTTOM
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void mlForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            if (!DesignMode && shadowtype == ShadowType.Pro)
            {
                shadow = new Dropshadow(this)
                {
                    ShadowBlur = 17,
                    ShadowSpread = -10,
                    ShadowColor = borderShadowColor

                };
                shadow.RefreshShadow();
            }
        }

    }
}

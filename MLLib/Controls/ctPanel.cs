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
    public partial class ctPanel : System.Windows.Forms.Panel
    {

        // member variables
        System.Drawing.Color mStartColor;
        System.Drawing.Color mEndColor;

        public ctPanel()
        {
            InitializeComponent();
            PaintGradient();
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        //Pen p = Pens.Yellow;
        Color borderColor = Color.White;
        public Color BorderColor
        {
            set
            {
                this.borderColor = value;
                this.Refresh();
            }
            get
            {
                return this.borderColor;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            //using (SolidBrush brush = new SolidBrush(BackColor))
            //    pe.Graphics.FillRectangle(brush, ClientRectangle);
            Pen p = new Pen(borderColor);
            //p.Color = borderColor;
            pe.Graphics.DrawRectangle(p, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            //base.OnPaint(pe);
        }


        public System.Drawing.Color PageStartColor
        {
            get
            {
                return mStartColor;
            }
            set
            {
                mStartColor = value;
                PaintGradient();
            }
        }


        public System.Drawing.Color PageEndColor
        {
            get
            {
                return mEndColor;
            }
            set
            {
                mEndColor = value;
                PaintGradient();
            }
        }


        private void PaintGradient()
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
            gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0),
            new Point(this.Width, this.Height), PageStartColor, PageEndColor);

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}

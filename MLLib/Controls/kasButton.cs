using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Controls
{
    public class kasButton : Label
    {
        private IContainer components;

        private Image _ImageMouseEnter;

        private Image _ImageMouseDown;

        private Image _ImageMouseLeave;

        [Browsable(false)]
        public new Image Image
        {
            get
            {
                return base.Image;
            }
            set
            {
                base.Image = value;
            }
        }

        public Image ImageMouseEnter
        {
            get
            {
                return this._ImageMouseEnter;
            }
            set
            {
                this._ImageMouseEnter = value;
            }
        }

        public Image ImageMouseDown
        {
            get
            {
                return this._ImageMouseDown;
            }
            set
            {
                this._ImageMouseDown = value;
            }
        }

        public Image ImageMouseLeave
        {
            get
            {
                return this._ImageMouseLeave;
            }
            set
            {
                this._ImageMouseLeave = value;
                this.Image = value;
            }
        }

        [DebuggerNonUserCode]
        public kasButton()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Image = this.ImageMouseEnter;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            this.Image = this.ImageMouseDown;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Image = this.ImageMouseLeave;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.Image = this.ImageMouseLeave;
            base.OnMouseUp(mevent);
        }
    }
}

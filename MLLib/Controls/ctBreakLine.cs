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
    public partial class ctBreakLine : Control
    {
        public ctBreakLine()
        {
            InitializeComponent();
        }

        public int BreakLineHeight
        {
            get
            {
                return this.Height;
            }
            set
            {
                this.Height = value;
            }
        }
        public Color BreakLinneColor
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
    }
}

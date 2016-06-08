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
    public partial class ctSwitch : UserControl
    {
        public ctSwitch()
        {
            InitializeComponent();
        }
        bool value = true;
        public bool Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value != this.value && this.ValueChange != null)
                    ValueChange(this, null);
                this.value = value;
                if (value)
                {
                    this.BackgroundImage = global::MLLib.Properties.Resources.btn_toggle_on;
                }
                else
                {
                    this.BackgroundImage = global::MLLib.Properties.Resources.btn_toggle_off;
                }
            }
        }

        //private Image BackgroundImage;

        public event EventHandler ValueChange;


        private void ctSwitch_Click(object sender, EventArgs e)
        {
            Value = !Value;
        }

        private void ctSwitch_Load(object sender, EventArgs e)
        {
            Value = true;
        }
    }
}

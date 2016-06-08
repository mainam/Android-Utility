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
    public partial class ctTextBox : Panel
    {
        public ctTextBox()
        {
            InitializeComponent();
        }

        [Category("Action")]
        public event KeyEventHandler EventKeyDown;
        [Category("Action")]
        public event EventHandler EventKeyLeave;
        [Category("Action")]
        public event KeyPressEventHandler EventKeyPress;
        [Category("Action")]
        public event EventHandler EventTextChange;

        int labelwidth = 0;

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            this.textBox1.Top = this.label1.Top = ((this.Height - this.Padding.Top - this.Padding.Bottom) - textBox1.Height) / 2;
            this.textBox1.Width = (this.Width - this.Padding.Left - this.Padding.Right) - (labelwidth == 0 ? label1.Width : labelwidth) - 20;
            this.textBox1.Left = (labelwidth == 0 ? label1.Width : labelwidth) + 10 + this.Padding.Left;
        }

        private void ucTextBox_Load(object sender, EventArgs e)
        {
            panel1_SizeChanged(null, null);
        }


        public new string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;

            }
        }

        public string DataText
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;

            }
        }

        public int PaddingTop
        {
            get
            {
                return this.Padding.Top;
            }
            set
            {
                if (value >= 0)
                    this.Padding = new Padding(PaddingLeft, value, PaddingRight, PaddingBottom);
            }
        }

        public int PaddingBottom
        {
            get
            {
                return this.Padding.Bottom;
            }
            set
            {
                if (value >= 0)
                    this.Padding = new Padding(PaddingLeft, PaddingTop, PaddingRight, value);
            }
        }

        public int PaddingLeft
        {
            get
            {
                return this.Padding.Left;
            }
            set
            {
                if (value >= 0)
                    this.Padding = new Padding(value, PaddingTop, PaddingRight, PaddingBottom);
            }
        }

        public int PaddingRight
        {
            get
            {
                return this.Padding.Right;
            }
            set
            {
                if (value >= 0)
                    this.Padding = new Padding(PaddingLeft, PaddingTop, value, PaddingBottom);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        public bool IsPasswordTextBox
        {
            get
            {
                return textBox1.PasswordChar == '*';
            }
            set
            {
                if (value)
                    textBox1.PasswordChar = '*';
                else
                    textBox1.PasswordChar = char.MinValue;
            }
        }

        public Font DataFont
        {
            get
            {
                return textBox1.Font;
            }
            set
            {
                textBox1.Font = value;
                panel1_SizeChanged(null, null);
            }
        }
        public Color TextHintColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        public String TextHint
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                panel1_SizeChanged(null, null);
            }
        }

        public int TextHintWidth
        {
            get
            {
                return labelwidth;
            }
            set
            {
                labelwidth = value;
                panel1_SizeChanged(null, null);
            }
        }

        private void ctTextBox_BackColorChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = this.BackColor;
                panel1.BackColor = this.BackColor;
            }
            catch (Exception)
            {
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (EventKeyLeave != null)
            {
                EventKeyLeave(this, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (EventKeyDown != null)
            {
                EventKeyDown(this, e);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EventKeyPress != null)
            {
                EventKeyPress(this, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (EventTextChange != null)
                EventTextChange(this, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        public Color BorderColor
        {
            get
            {
                return panel1.BorderColor;
            }
            set
            {
                panel1.BorderColor = value;
            }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return textBox1.AutoCompleteCustomSource;
            }
            set
            {
                textBox1.AutoCompleteCustomSource = value;
            }
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return textBox1.AutoCompleteMode;
            }
            set
            {
                textBox1.AutoCompleteMode = value;
            }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return textBox1.AutoCompleteSource;
            }
            set
            {
                textBox1.AutoCompleteSource = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return this.textBox1.ReadOnly;
            }
            set
            {
                this.textBox1.ReadOnly = value;
            }
        }
    }
}

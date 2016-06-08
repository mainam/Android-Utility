using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Theme
{
    public class ButtonTitle : Panel
    {
        Button button;
        public ButtonTitle()
        {
            this.Dock = System.Windows.Forms.DockStyle.Right;
            this.Location = new System.Drawing.Point(702, 3);
            this.Name = "panel3";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(39, 40);
            this.TabIndex = 3;

            button = new Button();
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.Dock = System.Windows.Forms.DockStyle.Top;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(2, 2);
            this.button.Size = new System.Drawing.Size(35, 35);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += button_Click;
            this.Controls.Add(button);
        }

        public event EventHandler Click;
        void button_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, e);
        }

        public Image Image
        {
            get
            {
                return this.button.Image;
            }
            set
            {
                this.button.Image = value;
            }
        }
    }
}

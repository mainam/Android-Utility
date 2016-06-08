using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MLLib.Windows.Hotkey.Win32
{

    public class NativeWindowWithEvent : NativeWindow
    {
        public event MessageEventHandler ProcessMessage;

        protected override void WndProc(ref Message m)
        {
            if (this.ProcessMessage != null)
            {
                bool handled = false;
                this.ProcessMessage(this, ref m, ref handled);
                if (!handled)
                {
                    base.WndProc(ref m);
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}


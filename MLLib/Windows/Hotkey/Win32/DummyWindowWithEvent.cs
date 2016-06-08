using System;
using System.Windows.Forms;

namespace MLLib.Windows.Hotkey.Win32
{
    public class DummyWindowWithEvent : NativeWindowWithEvent, IDisposable
    {
        public DummyWindowWithEvent()
        {
            CreateParams cp = new CreateParams();
            this.CreateHandle(cp);
        }

        public void Dispose()
        {
            if (base.Handle != IntPtr.Zero)
            {
                this.DestroyHandle();
            }
        }
    }
}


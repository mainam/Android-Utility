using System;
using System.Runtime.InteropServices;

namespace MLLib.Windows.Hotkey.Win32
{

    public class User32
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}


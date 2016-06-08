using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Windows
{
    public class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);

        public static IntPtr GetIntPtrFromText(string text)
        {
            return Marshal.StringToHGlobalAuto(text);
        }

        public static string GetMessageText(Message msg)
        {
            try
            {
                MessageBox.Show("Test");
                string text = "";
                int length = msg.LParam.ToInt32();
                MessageBox.Show("" + length);
                MessageBox.Show(msg.WParam + "");
                text = Marshal.PtrToStringUni(msg.WParam, length);
                MessageBox.Show(text);
                Marshal.FreeHGlobal(msg.WParam);
                return text;
            }
            catch (Exception)
            {
                return "";
            }
        }

        //private static IntPtr StructToPtr(String obj)
        //{
        //    return Marshal.StringToHGlobalAuto(obj);
        //}

        //public static void PostMessage(int msg, string text)
        //{
        //    //byte[] sarr = System.Text.Encoding.Default.GetBytes(text);
        //    //int len = sarr.Length;
        //    //MLLib.Windows.MessageHelper.COPYDATASTRUCT cds;
        //    //cds.dwData = (IntPtr)100;
        //    //cds.lpData = text;
        //    //cds.cbData = len + 1;
        //    //IntPtr lpData = StructToPtr(cds);
        //    //IntPtr lpLength = new IntPtr(text.Length); 

        //    var temp = StructToPtr(text);
        //    //GCHandle handle1 = GCHandle.Alloc(text);
        //    //MessageBox.Show(((IntPtr)handle1) + "");
        //    //if (!PostMessage((IntPtr)MLLib.Windows.NativeMethods.HWND_BROADCAST,
        //    //                  msg, temp, text.Length))
        //    {
        //        throw new Exception("Could not post message.");
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Android_Utility.Utils
{

    public class UtilLog
    {
        public enum LogType
        {
            Text,
            Info,
            Error,
            Success
        }



        public static void InsertLog(Control control, RichTextBox richTextBox1, UtilLog.LogType type, object Log)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new EventHandler(delegate
                    {
                        InsertLog(control, richTextBox1, type, Log);
                    }));
                    return;
                }

                try
                {
                    if (richTextBox1.Lines.Length > 100)
                    {
                        richTextBox1.Lines = richTextBox1.Lines.Skip(richTextBox1.Lines.Length - 100).Take(100).ToArray();
                    }
                    var text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss:tt | ") + Log + "\n";
                    int index = richTextBox1.Text.Length;
                    richTextBox1.AppendText(text);
                    richTextBox1.Select(index, text.Length);
                    switch (type)
                    {
                        case LogType.Text:
                            richTextBox1.SelectionColor = Color.Violet;
                            break;
                        case LogType.Info:
                            richTextBox1.SelectionColor = Color.Blue;
                            break;
                        case LogType.Error:
                            richTextBox1.SelectionColor = Color.Red;
                            break;
                        case LogType.Success:
                            richTextBox1.SelectionColor = Color.Green;
                            break;
                        default:
                            break;
                    }
                    richTextBox1.Select(richTextBox1.Text.Length - 1, 0);
                    richTextBox1.ScrollToCaret();
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {

            }
        }

    }
}

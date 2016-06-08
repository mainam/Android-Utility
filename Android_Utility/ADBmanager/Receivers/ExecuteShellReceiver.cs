using Managed.Adb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android_Utility.ADBmanager.Receivers
{
    public class ExecuteShellReceiver : MultiLineReceiver
    {
        public List<string> lines = new List<string>();
        protected override void ProcessNewLines(string[] lines)
        {
            this.lines = lines.Where(x => x != null).ToList();
        }
    }
}

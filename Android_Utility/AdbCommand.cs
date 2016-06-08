using Android_Utility.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;

namespace Android_Utility
{
    public class AdbCommand
    {
        Process procAdb;

        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (OutputTextRunADB != null && e.Data != null)
            {
                OutputTextRunADB(e.Data, UtilLog.LogType.Text);
            }
            return;
        }
        public event InsertLogDelegate OutputTextRunADB;

        void process_Exited(object sender, EventArgs e)
        {
            try
            {
                finish = true;
                KillAllProcessesSpawnedBy(Convert.ToUInt32((sender as Process).Id), OutputTextRunADB);

                //System.GC.Collect();

            }
            catch (Exception e1)
            {
                if (OutputTextRunADB != null)
                    OutputTextRunADB(e1.Message, UtilLog.LogType.Error);
            }
        }

        bool finish = false;
        public void ExecuteCommandSync(string command)
        {
            ExecuteCommandSync(command, false);
        }
        object obj = new object();
        public void ExecuteCommandSync(string command, bool wait)
        {
            try
            {
                lock (obj)
                {
                    if (procAdb != null)
                        process_Exited(procAdb, null);
                    procAdb = new Process();

                    ProcessStartInfo procStartInfo = new ProcessStartInfo();
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.RedirectStandardOutput = true;
                    procStartInfo.RedirectStandardError = true;
                    procStartInfo.CreateNoWindow = true;
                    procAdb.EnableRaisingEvents = true;
                    procStartInfo.FileName = "cmd ";
                    procStartInfo.Arguments = " /c " + command;
                    procAdb.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                    procAdb.StartInfo = procStartInfo;
                    procAdb.Exited += new EventHandler(process_Exited);
                    procAdb.Start();
                    procAdb.BeginOutputReadLine();
                    while (!finish && wait)
                    {

                    }
                }
            }
            catch (Exception e)
            {
                if (OutputTextRunADB != null)
                    OutputTextRunADB(e.Message, UtilLog.LogType.Text);
            }
        }


        private static void KillAllProcessesSpawnedBy(UInt32 parentProcessId, InsertLogDelegate output)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    "SELECT * " +
                    "FROM Win32_Process " +
                    "WHERE ParentProcessId=" + parentProcessId);
                ManagementObjectCollection collection = searcher.Get();
                if (collection.Count > 0)
                {
                    foreach (var item in collection)
                    {
                        UInt32 childProcessId = (UInt32)item["ProcessId"];
                        if ((int)childProcessId != Process.GetCurrentProcess().Id)
                        {
                            KillAllProcessesSpawnedBy(childProcessId, output);

                            Process childProcess = Process.GetProcessById((int)childProcessId);
                            //logger.Debug("Killing child process [" + childProcess.ProcessName + "] with Id [" + childProcessId + "]");
                            childProcess.Kill();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (output != null)
                {
                    output(e.Message, UtilLog.LogType.Error);
                }
            }
        }
    }
}

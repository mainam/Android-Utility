using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using System.Windows.Forms;

namespace Android_Utility
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        static string MUTEXNAME = "HELLOMAI_MUTEXT_ANDROID_UTILITY";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //MessageBox.Show("Test");
                bool pass = KiemTraThuVien();
                if (!pass)
                    return;

                App.Config config = new App.Config();
                config.SetConfig();

                KiemTraChay(args);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        static void KiemTraChay(string[] args)
        {
            Process[] runningProcesses = Process.GetProcesses();
            //get current running processes
            bool InstanceRunning = false;
            //this field will show us if an instance is already running
            long runningId = 50000;
            //here we hold the PID of the eventual running instance
            foreach (Process p in runningProcesses)
            {
                try
                {
                    Mutex newinstanceMutex = Mutex.OpenExisting(MUTEXNAME + p.Id.ToString());
                    //we check if a Mutex that respects our format is already created
                    try
                    {
                        newinstanceMutex.ReleaseMutex();
                    }
                    catch
                    {

                    }
                    var vs1 = p.MainModule.FileVersionInfo.ProductVersion;
                    var vs = Application.ProductVersion;
                    if (vs.CompareTo(vs1) == 1)
                    {
                        p.Kill();
                        break;
                    }
                    InstanceRunning = true;
                    //if the upper Mutex.OpenExisting succeeds, a mutex is already created, so
                    //an instance signaling the searched mutex is already running
                    runningId = p.Id;

                    break;
                }
                catch
                {

                }
            }

            if (!InstanceRunning)
            {
                Mutex currentMutex = new Mutex(true,
                  MUTEXNAME +
                  Process.GetCurrentProcess().Id.ToString());
                //if no instance is running we create a new "signaling" Mutex                       
                currentMutex.ReleaseMutex();
                StartForm(args);
            }
            else
            {
                IntPtr winHandle = Process.GetProcessById((int)runningId).MainWindowHandle;
                if (args.Length == 0)
                {
                    MLLib.Windows.NativeMethods.PostMessage(winHandle, MLLib.Windows.NativeMethods.WM_SHOWME, IntPtr.Zero, IntPtr.Zero);
                    return;
                }
                //we now bring the process with PID = runningID to front
                if (winHandle != IntPtr.Zero)
                {
                    MLLib.Windows.MessageHelper msg = new MLLib.Windows.MessageHelper();
                    msg.sendWindowsStringMessage(winHandle.ToInt32(), IntPtr.Zero.ToInt32(), args[0]);
                }
            }
        }

        static void StartForm(string[] args)
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (args.Length == 1)
                {
                    frmFormMain frm = new frmFormMain(args[0], MLLib.mlForm.ShadowType.Pro);
                    Application.Run(frm);
                    return;
                }
                else
                {
                    frmFormMain frm = new frmFormMain("", MLLib.mlForm.ShadowType.Pro);
                    Application.Run(frm);
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        public static bool KiemTraThuVien()
        {
            try
            {
                if (!Directory.Exists("C:\\adb\\"))
                    Directory.CreateDirectory("C:\\adb\\");

                if (!File.Exists("C:/adb/adb.exe"))
                    saveFile("C:/adb/adb.exe", global::Android_Utility.Properties.Resources.adb);
                if (!File.Exists("C:/adb/AdbWinApi.dll"))
                    saveFile("C:/adb/AdbWinApi.dll", global::Android_Utility.Properties.Resources.AdbWinApi);
                if (!File.Exists("C:/adb/AdbWinUsbApi.dll"))
                    saveFile("C:/adb/AdbWinUsbApi.dll", global::Android_Utility.Properties.Resources.AdbWinUsbApi);

                if (!Directory.Exists("C:\\ico\\"))
                    Directory.CreateDirectory("C:\\ico\\");

                if (!File.Exists("C:/ico/Android.ico"))
                {
                    using (var fStream = new FileStream("C:/ico/Android.ico", FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        global::Android_Utility.Properties.Resources.android.Save(fStream);
                        fStream.Close();
                    }
                }

                if (!File.Exists(Application.StartupPath + "\\MLLibv1010.dll"))
                {
                    saveFile(Application.StartupPath + "\\MLLibv1010.dll", global::Android_Utility.Properties.Resources.MLLibv1010);
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur - please contact ngoc.nam@samsung.com");
                return false;
            }
        }


        public static void saveFile(string FileName, byte[] resourcedata)
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
            Assembly Assemb = Assembly.GetExecutingAssembly();
            FileStream fs = new FileStream(FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(resourcedata, 0, resourcedata.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }


    }
}
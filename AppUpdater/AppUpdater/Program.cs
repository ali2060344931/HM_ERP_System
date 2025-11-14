using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace HM_ERP_SystemUpdater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HM_ERP_System Updater";

            if (args.Length == 0)
            {
                Console.WriteLine("مسیر سرور مشخص نشده است.");
                Console.ReadKey();
                return;
            }
            string serverPath = args[0];
            string appName = "HM_ERP_System.exe";
            string processName = "HM_ERP_System";
            string localPath = AppDomain.CurrentDomain.BaseDirectory;
            string srcApp = Path.Combine(serverPath, appName);
            string dstApp = Path.Combine(localPath, appName);
            string serverVersionFile = Path.Combine(serverPath, "HM_ERP_SystemAppUpdater.txt");
            string localVersionFile = Path.Combine(localPath, "HM_ERP_SystemAppUpdater.txt");
            try
            {
                if (!File.Exists(srcApp) || !File.Exists(serverVersionFile))
                {
                    Console.ReadKey();
                    return;
                }

                string serverVersion = File.ReadAllText(serverVersionFile).Trim();
                string localVersion = File.Exists(localVersionFile) ? File.ReadAllText(localVersionFile).Trim() : "0.0.0";
                if (serverVersion == localVersion)
                {
                    Console.ReadKey();
                    return;
                }

                bool appClosed = false;
                for (int i = 0; i < 15; i++)
                {
                    if (Process.GetProcessesByName(processName).Length == 0)
                    {
                        appClosed = true;
                        break;
                    }
                    Thread.Sleep(1000);
                }

                if (!appClosed)
                {
                    Console.ReadKey();
                    return;
                }
                File.Copy(srcApp, dstApp, true);
                File.Copy(sourceFileName: serverVersionFile, destFileName: localVersionFile, overwrite: true);
                Process.Start(dstApp);
            }
            catch (Exception )
            { 
                Console.ReadKey();
            }
        }
    }
}

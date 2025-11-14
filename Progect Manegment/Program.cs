using HM_ERP_System;
using HM_ERP_System.Entity.Basic_information;
using HM_ERP_System.Forms.Accounts.Cheque;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.Accounts.RecevingPayment;
using HM_ERP_System.Forms.Accounts.ReviewAccounts;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Accounts.TotalAccount;
using HM_ERP_System.Forms.Accounts.Transaction;
using HM_ERP_System.Forms.Accounts.TransferBetweenBanks;
using HM_ERP_System.Forms.Accounts.TransferBetweenPersons;
using HM_ERP_System.Forms.AppointmentScheduling;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Car;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Commission;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.CustomerToGroup;
using HM_ERP_System.Forms.DocumentBanck;
using HM_ERP_System.Forms.Draver;
using HM_ERP_System.Forms.FinancialYears;
using HM_ERP_System.Forms.Login;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Peremission;
using HM_ERP_System.Forms.Persons;
using HM_ERP_System.Forms.PurchaseTanker;
using HM_ERP_System.Forms.Role;
using HM_ERP_System.Forms.TankerRental;
using HM_ERP_System.Forms.User;

using Manegmen_Machinery.ContexModels;

using MyClass;

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Progect_Manegment
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                string searchKey = "Data Source=.";
                string appPath = Application.StartupPath; // مسیر اجرای برنامه
                string connectionstring_db = File.ReadAllText(appPath + @"\ConectionString.txt", Encoding.UTF8);

                string localVersionFile = Path.Combine(appPath, "HM_ERP_SystemAppUpdater.txt");
                string cone = Path.Combine(appPath, "HM_ERP_SystemAppUpdater.txt");

                // ایجاد فایل نسخه در صورت عدم وجود
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                File.WriteAllText(localVersionFile, version.ToString());

                // مسیر سرور
                if (!connectionstring_db.Contains(searchKey))
                {
                    string serverPath = @"\\192.168.0.200\Share\Publish";
                    string serverVersionFile = Path.Combine(serverPath, "HM_ERP_SystemAppUpdater.txt");

                    if (File.Exists(serverVersionFile))
                    {
                        string serverVersion = File.ReadAllText(serverVersionFile).Trim();
                        string localVersion = File.ReadAllText(localVersionFile).Trim();

                        if (serverVersion != localVersion)
                        {
                            DialogResult dr = MessageBox.Show(
                                $"نسخه جدیدی از برنامه موجود است ({serverVersion}). آیا می‌خواهید بروزرسانی شود؟",
                                "بروزرسانی برنامه",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );

                            if (dr == DialogResult.Yes)
                            {
                                string updaterPath = Path.Combine(appPath, "AppUpdater.exe");
                                if (File.Exists(updaterPath))
                                {
                                    // اجرای Updater با مسیر سرور به عنوان آرگومان
                                    Process.Start(updaterPath, $"\"{serverPath}\"");
                                    return; // برنامه اصلی بسته شود تا بروزرسانی انجام شود
                                }
                                else
                                {
                                    MessageBox.Show("فایل Updater.exe یافت نشد. لطفاً با مدیر سیستم تماس بگیرید.");
                                }
                            }
                        }
                    }
                }

                #region AppSeting

                AppSeting seting = new AppSeting();
                seting.SaveConnectionString("DBcontextModel", connectionstring_db);
                #endregion

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Basic_information.basic_information();
                HM_ERP_System.Class_General.CreatView.BanckEdid();
                HM_ERP_System.Properties.Settings.Default.ConnectionString = connectionstring_db;
                HM_ERP_System.Properties.Settings.Default.Save();

                AppDomain.CurrentDomain.SetData("SQLServerTypesAssemblyFileName",
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SqlServerTypes\"));
                AppDomain.CurrentDomain.SetData("SqlServerTypesLocation",
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SqlServerTypes"));

                Application.Run(new frmLoginProg());

                //Application.Run(new frmMainForm());

                //Application.Run(new frmComersList());
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }
    }



}

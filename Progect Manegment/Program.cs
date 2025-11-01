using HM_ERP_System.Entity.Basic_information;

using HM_ERP_System;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Persons;
using Manegmen_Machinery.ContexModels;
using System;
using System.Windows.Forms;
using HM_ERP_System.Forms.Draver;
using HM_ERP_System.Forms.Car;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.DocumentBanck;
using HM_ERP_System.Forms.Login;
using HM_ERP_System.Forms.User;
using HM_ERP_System.Forms.Peremission;
using HM_ERP_System.Forms.Role;
using HM_ERP_System.Forms.Accounts.TotalAccount;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.Transaction;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.Accounts.RecevingPayment;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.AppointmentScheduling;
using HM_ERP_System.Forms.CustomerToGroup;
using HM_ERP_System.Forms.TankerRental;
using HM_ERP_System.Forms.Accounts.Cheque;
using HM_ERP_System.Forms.PurchaseTanker;
using HM_ERP_System.Forms.FinancialYears;
using HM_ERP_System.Forms.Accounts.TransferBetweenPersons;
using HM_ERP_System.Forms.Accounts.TransferBetweenBanks;
using HM_ERP_System.Forms.Accounts.ReviewAccounts;

namespace Progect_Manegment
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            #region AppSeting
            string connectionstring_db = @"Initial Catalog=HM_ERP_System1; Data Source=.;Trusted_Connection=True;";
            //string connectionstring_db = @"Initial Catalog=HM_ERP_System1; Data Source=PC1\MSSQLSERVER2016;Trusted_Connection=True;";
            AppSeting seting = new AppSeting();
            seting.SaveConnectionString("DBcontextModel", connectionstring_db);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Basic_information.basic_information();


            //Application.Run(new frmLoginProg());

            Application.Run(new frmMainForm());

            //Application.Run(new frmReviewAccounts());

        }
    }



}

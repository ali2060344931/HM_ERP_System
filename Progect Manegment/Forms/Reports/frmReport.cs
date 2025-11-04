using HM_ERP_System.Forms.Main_Form;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Reports
{
    public partial class frmReport : frmMasterForm
    {
        private DBcontextModel db = new DBcontextModel();
        public string Cod = "";
        public string tblName;
        public string Condition = "";
        public string OnvanReport;
        public string DateReport;
        public string MandehSorathseb;//مانده صورتحساب
        public string MablaghGharardad;
        public string DayGharadad;
        public string DastmozdRozane;
        public string MablaghKarkard;
        public string TitelString="گـــزارش تستی";
        string NameCompani;

        string TarikhRoz = MyClass.PersianDate.NowPersianDate;
        string Time_ = DateTime.Now.ToString("HH:mm:ss tt");

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                //نام(عنوان) شرکت
                NameCompani=db.Settings.Where(c => c.Code==1).First().Subject;

                this.reportViewer1.RefreshReport();
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;



                MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("HM_ERP_System.ReportViewer.Report_KarkarRozaneh.rdlc", reportViewer1, 2, new string[] { "Customers", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport, "TitelString", TitelString });

                //MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One_("Customers", Condition, "DataSet1", "HM_ERP_System.ReportViewer.Report_View_ReportEnterExits.rdlc", reportViewer1, new string[] { "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport });


                switch (Cod)
                {


                    case "0":
                        //کارکردماهانه
                        {

                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("HM_ERP_System.ReportViewerMain.Report_ViwSoratHesab_Karkard.rdlc", reportViewer1, 2, new string[] { "View_Function", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "OnvanReport", OnvanReport, "DateReport", DateReport, "MablaghGharardad", MablaghGharardad, "DayGharadad", DayGharadad, "DastmozdRozane", DastmozdRozane, "MablaghKarkard", MablaghKarkard });



                        }
                        break;

                        /*
                    case "1":
                        //کارکرد روزانه
                        {
                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("Accounting_Warehousing.ReportViewer.Report_KarkarRozaneh.rdlc", reportViewer1, 2, new string[] { "View_Function", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport });

                        }
                        break;

                    case "2":
                        //گزارش اموال
                        {
                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("Accounting_Warehousing.ReportViewer.Report_PropertyDefinitions.rdlc", reportViewer1, 2, new string[] { "PropertyDefinitions", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz });

                        }
                        break;

                    case "3":
                        //گزارش اموال
                        {
                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("Accounting_Warehousing.ReportViewer.Report_View_AnbarGardany.rdlc", reportViewer1, 2, new string[] { "View_AnbarGardany", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz });

                        }
                        break;
                    case "4":
                        //گزارش ورود خروج کالاها
                        {
                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("Accounting_Warehousing.ReportViewer.Report_View_Stores.rdlc", reportViewer1, 2, new string[] { "View_Stores", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport });

                        }
                        break;

                    case "5"://گزارش اسناد حسابداری

                        {
                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("Accounting_Warehousing.ReportViewer.Report_AccountDocuments.rdlc", reportViewer1, 2, new string[] { "AccountDocuments", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport });

                        }
                        break;
                        */
                }
            }
        }
    }
}

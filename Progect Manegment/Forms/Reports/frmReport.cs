using GridExEx;

using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;

using Microsoft.Reporting.WinForms;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string DateReport=" ";
        public string MandehSorathseb;//مانده صورتحساب
        public string MablaghGharardad;
        public string DayGharadad;
        public string DastmozdRozane;
        public string MablaghKarkard;
        public string TitelString = "";
        public GridEX grid;
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
                switch (Cod)
                {
                    case "0":
                        //کارکردماهانه
                        {

                            //MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("HM_ERP_System.ReportViewerMain.Report_ViwSoratHesab_Karkard.rdlc", reportViewer1, 2, new string[] { "View_Function", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "OnvanReport", OnvanReport, "DateReport", DateReport, "MablaghGharardad", MablaghGharardad, "DayGharadad", DayGharadad, "DastmozdRozane", DastmozdRozane, "MablaghKarkard", MablaghKarkard });


                            MyClass.SqlServerBankClass.ShowReportRDLC_More_Than_One("HM_ERP_System.ReportViewer.Report_KarkarRozaneh.rdlc", reportViewer1, 2, new string[] { "V_Customers", Condition, "DataSet1", "ImageCoes", "where id=1", "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport, "TitelString", TitelString });
                        }
                        break;
                    case "1":
                        ReportParameter[] p1 = new ReportParameter[]
    {
        new ReportParameter("NameCompani", NameCompani),
        new ReportParameter("TarikhG", TarikhRoz),
        new ReportParameter("DateReport", DateReport),
        new ReportParameter("TitelString", TitelString)
    };
                        {
                            var companyInfo = db.ImageCos
                                                .Where(c => c.Id == 1)
                                                .Select(c => new
                                                {
                                                    c.Name,
                                                    c.Image
                                                })
                                                .FirstOrDefault();

                            if (companyInfo != null)
                            {
                                DataTable dtCompany = new DataTable();
                                dtCompany.Columns.Add("Name");
                                dtCompany.Columns.Add("image", typeof(byte[]));

                                dtCompany.Rows.Add(companyInfo.Name, companyInfo.Image);

                                // حالا dtCompany آماده است برای ارسال به ReportViewer
                                var extraData = new List<(DataTable, string)>
        {
            (dtCompany, "DataSet2")
        };

                                ReportHelper.ShowReportFromGridEX(
                                    grid,
                                    "HM_ERP_System.ReportViewer.Report_Customer.rdlc",
                                    reportViewer1,
                                    "DataSet1",
                                    extraData,
                                    p1
                                );
                            }
                            break;
                        }//اشخاص
                    case "2"://راننده ها
                        ReportParameter[] p2 = new ReportParameter[]
                        {
                            new ReportParameter("NameCompani", NameCompani),
                            new ReportParameter("TarikhG", TarikhRoz),
                            new ReportParameter("DateReport", DateReport),
                            new ReportParameter("TitelString", TitelString)
                        };
                        {
                            var companyInfo = db.ImageCos
                                                .Where(c => c.Id == 1)
                                                .Select(c => new
                                                {
                                                    c.Name,
                                                    c.Image
                                                })
                                                .FirstOrDefault();

                            if (companyInfo != null)
                            {
                                DataTable dtCompany = new DataTable();
                                dtCompany.Columns.Add("Name");
                                dtCompany.Columns.Add("image", typeof(byte[]));
                                dtCompany.Rows.Add(companyInfo.Name, companyInfo.Image);
                                
                                var extraData = new List<(DataTable, string)>
                                {(dtCompany, "DataSet2")};
                                ReportHelper.ShowReportFromGridEX(
                                    grid,
                                    "HM_ERP_System.ReportViewer.Report_Customer.rdlc",
                                    reportViewer1,
                                    "DataSet1",
                                    extraData,
                                    p2
                                );
                            }
                            break;
                        }


                }
            }
        }
    }
}

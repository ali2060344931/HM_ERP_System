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
        public string DateReport = " ";
        public string MandehSorathseb;//مانده صورتحساب
        public string MablaghGharardad;
        public string DayGharadad;
        public string DastmozdRozane;
        public string MablaghKarkard;
        public string TitelString = "";
        public string ReporFileName = "";
        public string Description = " ";
        public GridExEx.GridExEx grid;
        string NameCompani;

        string TarikhRoz = MyClass.PersianDate.NowPersianDate;
        string Time_ = DateTime.Now.ToString("HH:mm:ss tt");

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    //نام(عنوان) شرکت
                    NameCompani=db.Settings.Where(c => c.Code==1).First().Subject;
                    this.reportViewer1.RefreshReport();
                    //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    SetReport();
                }
            }
                catch (Exception er)
                {
                    PublicClass.ShowErrorMessage(er);
                }
        }


        public void SetReport()
        {
            try
            {
                ReportParameter[] p5 = new ReportParameter[]
                                {
                            new ReportParameter("NameCompani", NameCompani),
                            new ReportParameter("TarikhG", TarikhRoz),
                            new ReportParameter("DateReport", DateReport),
                            new ReportParameter("TitelString", TitelString),
                            new ReportParameter("Description", Description)
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
                            ReporFileName,
                            reportViewer1,
                            "DataSet1",
                            extraData,
                            p5
                        );
                    }
                }
            }
                catch (Exception er)
                {
                    PublicClass.ShowErrorMessage(er);
                }
        }
    }
}

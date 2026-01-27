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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Reports
{
    public partial class frmReport : frmMasterForm
    {
        private DBcontextModel db = new DBcontextModel();
        public string Code = "";
        public string tblName;
        public string Condition1 = "";
        public string Condition2 = "";
        public string OnvanReport;
        public string DateReport = " ";
        public string TitelString = "";
        public string ReporFileName = "";
        public string Description = " ";
        public string View_Table_Name = " ";

        public string DraversH1 = "";
        public string DraversH2 = "";
        public string Resiver1H = "";
        public string Resiver2H = "";
        public string Sender2H = "";
        public string Sender1H = "";
        public string DraversH1Tel = "";
        public string CarPlat = "";
        public string CarPlatSeryal = "";
        public string CodeMeli = "";//سریال گواهینامه
        public string SmartCard = "";//سریال کارت هوشمند
        public string Seryal = "";//سریال هوشمند کامیون
        public string ProductsGroupName = "";//گروه کالاها


        public GridExEx.GridExEx grid;
        string NameCompani="";
        string SubjectCompani = "";
        string Addres="";
        string Tel="";
        int userid = PublicClass.UserId;
        string TarikhRoz = MyClass.PersianDate.NowPersianDate;
        //string Time_ = DateTime.Now.ToString("HH:mm:ss tt");

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
                    int userid = PublicClass.UserId;
                    var cr=db.CustomerRoles.Where(c=>c.Id==userid).First();
                    //نام(عنوان) شرکت
                    var q = db.Settings.Where(c => c.Id == cr.DefultSetingId).First();

                    NameCompani = q.Subject;
                    SubjectCompani = q.StrCode3;
                    Tel = q.StrCode2;
                    Addres=q.StrCode1;
                    
                    //Tel = db.Settings.Where(c => c.Id== cr.DefultSetingId).First().StrCode2;
                    
                    //Addres = db.Settings.Where(c => c.Id == cr.DefultSetingId).First().StrCode1;

                    this.reportViewer1.RefreshReport();
                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

                    if (Code == "")
                        SetReport();
                    else if (Code == "1")
                        SetReportOld();


                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        public void SetReportOld()
        {
            SqlServerBankClass.ShowReportRDLC_More_Than_One(ReporFileName, reportViewer1, 2, new string[] { View_Table_Name, Condition1, "DataSet1", "Settings", Condition2, "DataSet2", "NameCompani", NameCompani, "TarikhG", TarikhRoz, "DateReport", DateReport, "TitelString", TitelString, "Description", " ", "DateReport", DateReport, "DraversH1", DraversH1, "DraversH2", DraversH2, "Resiver1H", Resiver1H, "Resiver2H", Resiver2H, "Sender2H", Sender2H, "Sender1H", Sender1H, "DraversH1Tel" , DraversH1Tel , "CarPlat" , CarPlat, "CarPlatSeryal", CarPlatSeryal, "CodeMeli", CodeMeli, "SmartCard", SmartCard, "Addres", Addres,"Tel", Tel, "SubjectCompani" , SubjectCompani, "Seryal", Seryal, "ProductsGroupName", ProductsGroupName });

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
                    var DefultSetingId = db.CustomerRoles.Where(c => c.Id == userid).First().DefultSetingId;
                    
                    var companyInfo = db.Settings
                                        .Where(c => c.Id == DefultSetingId)
                                        .Select(c => new
                                        {
                                           c.Subject,
                                            c.Image1,
                                        })
                                        .FirstOrDefault();

                    if (companyInfo != null)
                    {
                        DataTable dtCompany = new DataTable();
                        dtCompany.Columns.Add("Subject");
                        dtCompany.Columns.Add("image1", typeof(byte[]));
                        dtCompany.Rows.Add(companyInfo.Subject, companyInfo.Image1);

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

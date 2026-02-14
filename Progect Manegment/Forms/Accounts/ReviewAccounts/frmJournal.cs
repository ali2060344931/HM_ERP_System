using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Reports;

using MyClass;

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

namespace HM_ERP_System.Forms.Accounts.ReviewAccounts
{
    public partial class frmJournal : frmMasterForm, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public string FormName = "ComersH";

        public frmJournal()
        {
            InitializeComponent();
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            try
            {
                txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, PublicClass.SetDayToReportList());
                txtDateEnd.Text = PersianDate.DateEnd();


                string layoutPathComersH = Path.Combine(Application.StartupPath, "DefaultGridLayoutTransaction.xml");

                using (var fs = new FileStream(layoutPathComersH, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvList.LoadLayoutFile(fs);
                }


                UpdateData();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            try
            {
                List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                PublicClass.FilldgvListTransaction_Journal(dgvList, txtDateStart.Text, txtDateEnd.Text, requiredIds);
                dgvList.Dock = DockStyle.Fill;
                this.Text = "دفتـــــر روزنامه";
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            CallUpdateTata();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);

        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            //f.grid = dgvListB;
            //f.DateReport = ResourceCode.T159 + txtDateStart.Text + ResourceCode.T160 + txtDateEnd.Text;
            //f.TitelString = ResourceCode.TRcomerB;
            //f.Description = TxtDescription.Text != "" ? TxtDescription.Text : " ";
            //f.ReporFileName = "HM_ERP_System.ReportViewer.Report_ComersB.rdlc";
            f.ShowDialog();

        }
    }
}

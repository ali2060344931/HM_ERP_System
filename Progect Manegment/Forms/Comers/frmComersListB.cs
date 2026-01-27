using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Commission;
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

namespace HM_ERP_System.Forms.Comers
{
    public partial class frmComersListB : frmMasterForm, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public string FormName = "ComersB";

        public frmComersListB()
        {
            InitializeComponent();
        }
        private void frmComersListB_Load(object sender, EventArgs e)
        {
            try
            {
                txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, PublicClass.SetDayToReportList());
                txtDateEnd.Text = PersianDate.DateEnd();


                string layoutPathComersB = Path.Combine(Application.StartupPath, "DefaultGridLayoutComersB.xml");

                using (var fs = new FileStream(layoutPathComersB, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvListB.LoadLayoutFile(fs);
                }
                dgvListB.Dock = DockStyle.Fill;
                dgvListH.Visible = false;
                dgvListCommission.Visible = false;
                this.Text = "لیست بـــارنامه ها";
                dgvListB.RootTable.Columns["Details"].Visible = false;
                dgvListB.RootTable.Columns["select"].Visible = false;
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
                frmComers.FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, "", false, "ComersB");
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormName == "ComersB")
                {
                    frmComers.FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, "");
                }

                else if (FormName == "ComersH")
                {
                    frmComers.FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                }
                else if (FormName == "Commission")
                {
                    frmCommission.FilldgvList(dgvListCommission, txtDateStart.Text, txtDateEnd.Text);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormName == "ComersB")
                {
                    PublicClass.SaveGridExToExcel(dgvListB);
                }

                else if (FormName == "ComersH")
                {
                    PublicClass.SaveGridExToExcel(dgvListH);
                }
                else if (FormName == "Commission")
                {
                    PublicClass.SaveGridExToExcel(dgvListCommission);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            if (FormName == "ComersB")
            {
                dgvListB.ShowFieldChooser(this, ResourceCode.T158);
            }
            else if (FormName == "ComersH")
            {
                dgvListH.ShowFieldChooser(this, ResourceCode.T158);
            }
            else if (FormName == "Commission")
            {
                dgvListCommission.ShowFieldChooser(this, ResourceCode.T158);
            }

        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormName == "ComersB")
                {
                    frmReport f = new frmReport();
                    f.grid = dgvListB;
                    f.DateReport = ResourceCode.T159 + txtDateStart.Text + ResourceCode.T160 + txtDateEnd.Text;
                    f.TitelString = ResourceCode.TRcomerB;
                    f.Description = TxtDescription.Text != "" ? TxtDescription.Text : " ";
                    f.ReporFileName = "HM_ERP_System.ReportViewer.Report_ComersB.rdlc";
                    f.ShowDialog();

                }

                else if (FormName == "ComersH")
                {
                    frmReport f = new frmReport();
                    f.grid = dgvListH;
                    f.DateReport = ResourceCode.T159 + txtDateStart.Text + ResourceCode.T160 + txtDateEnd.Text;
                    f.TitelString = ResourceCode.TRcomerH;
                    f.Description = TxtDescription.Text != "" ? TxtDescription.Text : " ";
                    f.ReporFileName = "HM_ERP_System.ReportViewer.Report_ComersH.rdlc";
                    f.ShowDialog();

                }

                else if (FormName == "Commission")
                {
                    frmReport f = new frmReport();
                    f.grid = dgvListCommission;
                    f.DateReport = ResourceCode.T159 + txtDateStart.Text + ResourceCode.T160 + txtDateEnd.Text;
                    f.TitelString = ResourceCode.TRCommission;
                    f.Description = TxtDescription.Text != "" ? TxtDescription.Text : " ";
                    f.ReporFileName = "HM_ERP_System.ReportViewer.Report_Commission.rdlc";
                    f.ShowDialog();

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void TxtDescription_ButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtDescription.Text);
            PublicClass.WindowAlart("1", "کپی شد");

        }
    }
}

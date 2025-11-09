using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Commission;
using HM_ERP_System.Forms.Main_Form;

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
using System.Windows.Controls;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Comers
{
    public partial class frmComersList : frmMasterForm, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public string FormName = "";
        public frmComersList()
        {
            InitializeComponent();
        }

        private void frmComersList_Load(object sender, EventArgs e)
        {
            try
            {
                txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
                txtDateEnd.Value = DateTime.Now;


                string layoutPathComersB = Path.Combine(Application.StartupPath, "DefaultGridLayoutComersB.xml");

                using (var fs = new FileStream(layoutPathComersB, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvListB.LoadLayoutFile(fs);
                }
                string layoutPathComersH = Path.Combine(Application.StartupPath, "DefaultGridLayoutComersH.xml");

                using (var fs = new FileStream(layoutPathComersH, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvListH.LoadLayoutFile(fs);
                }

                string layoutPathCommission = Path.Combine(System.Windows.Forms.Application.StartupPath, "DefaultGridLayoutCommission.xml");
                using (var fs = new FileStream(layoutPathCommission, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvListCommission.LoadLayoutFile(fs);
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
                if (FormName=="ComersB")
                {
                    frmComers.FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, "");
                    dgvListB.Dock= DockStyle.Fill;
                    dgvListH.Visible=false;
                    dgvListCommission.Visible=false;
                    this.Text="لیست بـــارنامه ها";
                    dgvListB.RootTable.Columns["Details"].Visible=false;
                    dgvListB.RootTable.Columns["select"].Visible=false;
                    PublicClass.SettingGridEX(dgvListB);

                }

                else if (FormName=="ComersH")
                {
                    frmComers.FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                    dgvListH.Dock= DockStyle.Fill;
                    dgvListB.Visible=false;
                    dgvListCommission.Visible=false;
                    this.Text="لیست حـــواله ها";
                    dgvListH.RootTable.Columns["Details"].Visible=false;
                    PublicClass.SettingGridEX(dgvListH);

                }

                else if (FormName=="Commission")
                {
                    frmCommission.FilldgvList(dgvListCommission, txtDateStart.Text, txtDateEnd.Text);
                    dgvListCommission.Dock= DockStyle.Fill;
                    dgvListB.Visible=false;
                    dgvListH.Visible=false;
                    this.Text="لیست پورسانت ها";
                    dgvListCommission.RootTable.Columns["Details"].Visible=false;
                    PublicClass.SettingGridEX(dgvListCommission);
                }
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
                if (FormName=="ComersB")
                {
                    frmComers.FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, "");//لیست اسناد
                }

                else if (FormName=="ComersH")
                {
                    frmComers.FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);

                }
                else if (FormName=="Commission")
                {
                    frmComers.FilldgvListH(dgvListCommission, txtDateStart.Text, txtDateEnd.Text);

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormName=="ComersB")
                {
                    PublicClass.SaveGridExToExcel(dgvListB);
                }

                else if (FormName=="ComersH")
                {
                    PublicClass.SaveGridExToExcel(dgvListH);
                }
                else if (FormName=="Commission")
                {
                    PublicClass.SaveGridExToExcel(dgvListCommission);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }
    }
}

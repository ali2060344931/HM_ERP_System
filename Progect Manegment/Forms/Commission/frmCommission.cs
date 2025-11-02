using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

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

namespace HM_ERP_System.Forms.Commission
{
    /// <summary>
    /// فرم ثبت پورسانت ها
    /// </summary>
    public partial class frmCommission : frmAddItems, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public frmCommission(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmCommission_Load(object sender, EventArgs e)
        {
            txtDate.Value= DateTime.Now;
            UpdateData();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbComers();
            FillcmbCommissionType();

        }

        DataTable dt_CommissionType;
        private void FillcmbCommissionType()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.PersonGroups.Where(c => c.IsCommission).ToList();
                cmbCommissionType.DataSource=q;
                dt_CommissionType = new System.Data.DataTable();
                dt_CommissionType = PublicClass.AddEntityTableToDataTable(q.ToList());
            }

        }

        DataTable dt_Comers;
        private void FillcmbComers()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cm in db.ComersBs
                            select new
                            {
                                cm.Id,
                                ComersH = cm.SeryalH,
                                ComersB = cm.SeryalB,
                            };
                    cmbComers.DataSource=q.ToList();
                    dt_Comers = new System.Data.DataTable();
                    dt_Comers = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FilldgvList()
        {

        }

        int ComersId = 0;
        private void cmbComers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComersId = Convert.ToInt32(cmbComers.Value);
            }
            catch (Exception)
            {
            }
        }

        private void cmbComers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbComers, dt_Comers);
            }
        }
        int CommissionTypeId = 0;
        private void cmbCommissionType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CommissionTypeId = Convert.ToInt32(cmbCommissionType.Value);
                cmbCustomer.ResetText();
                FillcmbCustomer();
            }
            catch (Exception)
            {
            }
        }

        DataTable dt_Customer ;

        private void FillcmbCustomer()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from ctg in db.CustomerToGroups
                            join cu in db.Customers
                            on ctg.CustomerId equals cu.Id

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id==CommissionTypeId
                            select new
                            {
                                cu.Id,
                                Name = cu.Family +" "+ cu.Name,
                            };
                    cmbCustomer.DataSource = q.ToList();
                    dt_Customer = new System.Data.DataTable();
                    dt_Customer = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
                catch (Exception er)
                {
                    PublicClass.ShowErrorMessage(er);
                }
        }

        private void cmbCommissionType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCommissionType, dt_CommissionType);
            }
        }
        int CustomerId = 0;
        private void cmbCustomer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerId = Convert.ToInt32(cmbCustomer.Value);
            }
            catch (Exception)
            {
            }
        }
    }
}

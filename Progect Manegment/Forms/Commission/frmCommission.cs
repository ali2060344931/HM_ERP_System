using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Entity.TruckUsageType;
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
            //chkSelectList.Checked= true;
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
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.PersonGroups.Where(c => c.IsCommission).ToList();
                    cmbCommissionType.DataSource=q;
                    dt_CommissionType = new System.Data.DataTable();
                    dt_CommissionType = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
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
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from co in db.Commissions
                            join cm in db.ComersBs
                            on co.ComersBId equals cm.Id
                            join pg in db.PersonGroups
                            on co.CommissionTypeId equals pg.Id
                            join cu in db.Customers
                            on co.CustomerId equals cu.Id
                            where string.Compare(co.Date, txtDateStart.Text) >= 0 && string.Compare(co.Date, txtDateEnd.Text) <= 0

                            select new
                            {
                                co.Id,
                                co.Date,
                                co.Amount,
                                co.Des,
                                ComersB = cm.SeryalH,
                                CommissionType = pg.Name,
                                Customer = cu.Family +" "+cu.Name,
                            };
                    dgvList.DataSource=q.ToList();
                    PublicClass.SettingGridEX(dgvList);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int ComersBId = 0;
        private void cmbComers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComersBId = Convert.ToInt32(cmbComers.Value);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
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
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Customer;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtAmount, ResourceCode.T081))
                    return;

                if (!chkSelectList.Checked)
                {
                    if (cmbComers.SelectedIndex==-1)//بارنامه:تکی
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T036);
                        cmbComers.Focus();
                        return;
                    }
                }
                else
                {
                    if (cmbList.Text=="")//بارنامه:لیستی
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T036);
                        cmbList.Focus();
                        return;
                    }
                }


                if (cmbCommissionType.SelectedIndex==-1)//نوع پورسانت
                {
                    PublicClass.ErrorMesseg(ResourceCode.T153);
                    cmbCommissionType.Focus();
                    return;
                }
                if (cmbCustomer.SelectedIndex==-1)//طرف حساب
                {
                    PublicClass.ErrorMesseg(ResourceCode.T042);
                    cmbCustomer.Focus();
                    return;
                }

                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.Commissions.Count(c => c.ComersBId == ComersBId && c.CustomerId == CustomerId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }
                    }
                    else
                    {
                        int cont = db.Commissions.Count(c => c.ComersBId == ComersBId && c.CustomerId == CustomerId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var car = new Repository<Entity.Commission.Commission>(db);
                    if (car.SaveOrUpdate(new Entity.Commission.Commission { Id = ListId, ComersBId=ComersBId, CommissionTypeId=CommissionTypeId, CustomerId=CustomerId, Date=txtDate.Text, Amount=Convert.ToInt64(txtAmount.TextSimple), Des=txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        CelearItems();
                    }
                    else
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T044);
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void CelearItems()
        {
            ListId = 0;
            txtAmount.ResetText();
            txtDes.ResetText();
            cmbCommissionType.ResetText();
            cmbCustomer.ResetText();
            cmbComers.Focus();
            FilldgvList();
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Commissions.Where(c => c.Id == ListId).First();
                        txtDate.Text = q.Date;
                        cmbComers.Value=q.ComersBId;
                        cmbCommissionType.Value=q.CommissionTypeId;
                        cmbCustomer.Value=q.CustomerId;
                        txtAmount.Text=q.Amount.ToString();
                        txtDes.Text=q.Des;
                        cmbComers.Focus();

                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.ComersHs.Where(c => c.CarId == ListId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Commissions.Where(c => c.Id == ListId).First();
                            db.Commissions.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            CelearItems();
                        }
                    }

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void chkSelectList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectList.Checked)
            {
                cmbComers.Enabled=false;
                btnShowComers.Enabled=false;
                cmbList.Enabled=true;
                btnSelectList.Enabled=true;
            }
            else
            {
                cmbComers.Enabled=true;
                btnShowComers.Enabled=true;
                cmbList.Enabled=false;
                btnSelectList.Enabled=false;
            }
        }
    }
}

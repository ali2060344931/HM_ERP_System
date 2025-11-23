using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Role;

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
using System.Xml.Linq;

namespace HM_ERP_System.Forms.User
{
    public partial class frmUser : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public frmUser(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {

            FilldgvList();
            FillcmbUserType();
            FillcmbCustomers();

        }

        private void FillcmbCustomers()
        {
            using (var db = new DBcontextModel())
            {
                var q = (from cu in db.Customers
                         where cu.id_TypeCustomer == 1

                         select new
                         {
                             cu.Id,
                             Name = cu.Family+ " "+cu.Name,
                         }).ToList();
                cmbCustomers.DataSource = q;
            }

        }

        private void FillcmbUserType()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Roles.ToList();
                cmbUserType.DataSource = q;
            }
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from CR in db.CustomerRoles

                            join rl in db.Roles
                             on CR.RoleId equals rl.Id

                            join cu in db.Customers
                            on CR.CustomerId equals cu.Id

                            select new
                            {
                                CR.Id,
                                UserName = cu.Family +" "+ cu.Name,
                                TypeUserName = rl.Name,
                            };
                    DataTable dt = PublicClass.EntityTableToDataTable(q.ToList());dgvList.DataSource = dt;
                    dgvList.AutoSizeColumns();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        int CustomersId_ = 0;
        private void cmbCustomers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomersId_ = Convert.ToInt32(cmbCustomers.Value);
            }
            catch (Exception)
            {
            }

        }
        int RoleId_ = 0;
        private void cmbUserType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                RoleId_ = Convert.ToInt32(cmbUserType.Value);
            }
            catch (Exception)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbCustomers, ResourceCode.T058, cmbUserType, ResourceCode.T059))
                    return;

                string pas = "";
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.CustomerRoles.Count(c => c.CustomerId == CustomersId_ && c.RoleId == RoleId_);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }

                        if (txtPassword.Text!="" && txtPasswordR.Text!="" && txtPassword.Text!=txtPasswordR.Text)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T062); return;
                        }
                        pas=PublicClass.GenerateHash(txtPassword.Text);
                    }
                    else
                    {
                        int cont = db.CustomerRoles.Count(c => c.CustomerId == CustomersId_ && c.RoleId == RoleId_ && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }


                        if (chkEditPass.Checked)
                        {
                            if (txtPasswordR.Text!=""&& txtPassword.Text!="")
                            {
                                if (txtPassword.Text!=txtPasswordR.Text)
                                {
                                    PublicClass.ErrorMesseg(ResourceCode.T062); return;
                                }
                            }

                            if (txtPasswordR.Text==""||txtPassword.Text=="")
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T063); return;

                            }
                        }

                        pas  =db.CustomerRoles.Where(c => c.Id==ListId).First().Password;
                        if (chkEditPass.Checked)
                        {
                            pas=PublicClass.GenerateHash(txtPassword.Text);
                        }
                    }

                    var userRepo = new Repository<Entity.CustomerRole.CustomerRole>(db);
                    if (userRepo.SaveOrUpdate(new Entity.CustomerRole.CustomerRole { Id = ListId, CustomerId=CustomersId_, Password=pas, Status=chkStatus.Checked, RoleId=RoleId_ }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        FilldgvList();
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        CelearItems();
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
            cmbCustomers.SelectedIndex=-1;
            cmbUserType.SelectedIndex=-1;
            txtPassword.ResetText();
            txtPasswordR.ResetText();
            txtPassword.Enabled=true;
            txtPasswordR.Enabled=true;
            chkEditPass.Visible=false;
            chkEditPass.Checked=false;
            ListId = 0;
            cmbCustomers.Focus();
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
                        var q = db.CustomerRoles.Where(c => c.Id == ListId).First();

                        cmbCustomers.Value = q.CustomerId;
                        cmbUserType.Value = q.RoleId;
                        chkStatus.Checked=q.Status;
                        txtPassword.Enabled=false; txtPasswordR.Enabled=false;
                        chkEditPass.Visible=true;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.Ciltys.Where(c => c.ProvincesId == LisId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.CustomerRoles.Where(c => c.Id == ListId).First();
                            db.CustomerRoles.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
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

        private void chkEditPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled=!txtPassword.Enabled;
            txtPasswordR.Enabled=!txtPasswordR.Enabled;

        }

        private void cmbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        //private IUpdatableForms _updatableForms;

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer frmCustomer = new Customer.frmCustomer(this);
            frmCustomer.ShowDialog();
            FillcmbCustomers();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmRole f = new frmRole(this);
            f.ShowDialog();
            FillcmbUserType();
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
             PublicClass.SaveGridExToExcel(dgvList);
        }
    }
}

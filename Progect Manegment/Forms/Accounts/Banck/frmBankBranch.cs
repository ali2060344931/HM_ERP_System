using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
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
using System.Xml.Linq;

namespace HM_ERP_System.Forms.Accounts.Banck
{
    public partial class frmBankBranch : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public frmBankBranch(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmBankBranch_Load(object sender, EventArgs e)
        {

            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FillcmbBanck();
            FilldgvList();
        }

        private void FillcmbBanck()
        {
            using (var db = new DBcontextModel())
            {
                var q=db.Bancks.ToList();
                cmbBanck.DataSource= q;
            }
        }

        public void UpdateData()
        {
            FilldgvList();
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from bb in db.BankBranches
                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id
                        select new
                        {
                            bb.Id,
                            bb.Name,
                            BanckName = ba.Name,
                        };

                System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt; PublicClass.SettingGridEX(dgvList,Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtBranchName, ResourceCode.T147))
                    return;
                if (cmbBanck.SelectedIndex== -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T148); return;
                }
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.BankBranches.Count(c => c.Name == txtBranchName.Text && c.BanckId==BanckId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T148); return;
                        }
                    }
                    else
                    {
                        int cont = db.BankBranches.Count(c => c.Name == txtBranchName.Text && c.BanckId==BanckId&& c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T148); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Accounts.Banck.BankBranch>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Accounts.Banck.BankBranch { Id = ListId, Name = txtBranchName.Text, BanckId=BanckId }, ListId))
                    {
                        PublicClass.WindowAlart("1");
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
            txtBranchName.ResetText();
            cmbBanck.Focus();
            ListId = 0;
            FilldgvList();
        }

        int BanckId = 0;
        private void cmbBanck_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BanckId = Convert.ToInt32(cmbBanck.Value);
            }
            catch (Exception)
            {
            }

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
                        var q = db.BankBranches.Where(c => c.Id == ListId).First();

                        cmbBanck.Value = q.BanckId;
                        txtBranchName.Text = q.Name;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.DetailedAccounts.Where(c => c.ProvincesId == LisId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.BankBranches.Where(c => c.Id == ListId).First();
                            db.BankBranches.Remove(q);
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmBanck frmBanck = new frmBanck(this);
            frmBanck.ShowDialog();
            FillcmbBanck();
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}

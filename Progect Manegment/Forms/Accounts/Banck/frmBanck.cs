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

namespace HM_ERP_System.Forms.Accounts.Banck
{
    public partial class frmBanck : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public frmBanck(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmBanck_Load(object sender, EventArgs e)
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
        }
        public void UpdateData()
        {
            FilldgvList();
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Bancks.ToList();
                dgvList.DataSource = q;

                PublicClass.SettingGridEX(dgvList);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtName, ResourceCode.T139/*, txtBranchName, ResourceCode.T147*/))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Bancks.Count(c => c.Name == txtName.Text /*&& c.BranchName==txtBranchName.Text*/);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T148); return;
                        }
                    }
                    else
                    {
                        int cont = db.Bancks.Count(c => c.Name == txtName.Text /*&& c.BranchName==txtBranchName.Text */&& c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T148); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Accounts.Banck.Banck>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Accounts.Banck.Banck { Id = ListId, Name = txtName.Text/*, BranchName=txtBranchName.Text*/ }, ListId))
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
            txtName.ResetText();
            //txtBranchName.ResetText();
            txtName.Focus();
            ListId=0;
            FilldgvList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
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
                        var q = db.Bancks.Where(c => c.Id == ListId).First();
                        txtName.Text = q.Name;
                        //txtBranchName.Text = q.BranchName;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.Ciltys.Where(c => c.ProvincesId == ListId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.Bancks.Where(c => c.Id == ListId).First();
                            db.Bancks.Remove(q);
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

    }
}

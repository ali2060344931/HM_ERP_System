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

namespace HM_ERP_System.Forms.Role
{
    public partial class frmRole : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int LisId = 0;
        public frmRole(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            CallUpdateTata();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            FilldgvList();
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Roles;
                System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtName, ResourceCode.T066))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (LisId == 0)
                    {
                        int cont = db.Roles.Count(c => c.Name == txtName.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T067); return;
                        }
                    }
                    else
                    {
                        int cont = db.Roles.Count(c => c.Name == txtName.Text & c.Id != LisId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T067); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Role.Role>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Role.Role { Id = LisId, Name = txtName.Text }, LisId))
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
            LisId = 0;
            txtName.ResetText();
            txtName.Focus();

        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                LisId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Roles.Where(c => c.Id == LisId).First();

                        txtName.Text = q.Name;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.RolePermissiones.Where(c => c.RoleId == LisId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Roles.Where(c => c.Id == LisId).First();
                            db.Roles.Remove(q);
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

        private void frmRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
                        if (e.Control && e.KeyCode == Keys.F12) { UpdateData();PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}

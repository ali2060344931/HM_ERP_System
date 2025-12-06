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

namespace HM_ERP_System.Forms.Warehouse
{
    public partial class frmWarehouseType : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmWarehouseType(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;
        }

        private void frmWarehouseType_Load(object sender, EventArgs e)
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
                var q = db.WarehouseTypes;
                System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtName, ResourceCode.T169))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.WarehouseTypes.Count(c => c.Name == txtName.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T170); return;
                        }
                    }
                    else
                    {
                        int cont = db.WarehouseTypes.Count(c => c.Name == txtName.Text & c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T170); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Warehouse.WarehouseType>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Warehouse.WarehouseType { Id = ListId, Name = txtName.Text }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        if (_updatableForms != null)
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
            ListId = 0;
            txtName.ResetText();
            txtName.Focus();
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
                        var q = db.WarehouseTypes.Where(c => c.Id == ListId).First();
                        txtName.Text = q.Name;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.Warehouses.Where(c => c.WarehouseTypeId == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.WarehouseTypes.Where(c => c.Id == ListId).First();
                            db.WarehouseTypes.Remove(q);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}

using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.Warehouse;
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
    public partial class frmWarehouse : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmWarehouse(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;

        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            FillcmbWarehouseType();
            FilldgvList();
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from wh in db.Warehouses

                        join wht in db.WarehouseTypes
                        on wh.WarehouseTypeId equals wht.Id

                        select new
                        { 
                            wh.Id,
                            wh.Name,
                            wh.Capacity,
                            wh.PostalCode,
                            wh.Addres,
                            WarehouseType=wht.Name,
                        };
                System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();
            }
        }

        DataTable dt_WarehouseType;
        private void FillcmbWarehouseType()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.WarehouseTypes.ToList();
                cmbWarehouseType.DataSource = q;
                dt_WarehouseType = new System.Data.DataTable();
                dt_WarehouseType = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmWarehouseType frmWarehouseType_ = new frmWarehouseType(null);
            frmWarehouseType_.ShowDialog();
            FillcmbWarehouseType();
        }

        int WarehouseTypeId = 0;
        private void cmbWarehouseType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbWarehouseType.SelectedIndex != -1)
                {
                    WarehouseTypeId = Convert.ToInt32(cmbWarehouseType.Value);
                }
            }
            catch (Exception)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbWarehouseType.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T169);
                    cmbWarehouseType.Focus();
                    return;
                }
                
                if (PublicClass.FindEmptyControls(txtName, ResourceCode.T171, txtCapacity, ResourceCode.T173, txtPostalCode, ResourceCode.T174))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Warehouses.Count(c => c.Name == txtName.Text && c.WarehouseTypeId == WarehouseTypeId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T172); return;
                        }
                    }
                    else
                    {
                        int cont = db.Warehouses.Count(c => c.Name == txtName.Text && c.WarehouseTypeId == WarehouseTypeId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T172); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Warehouse.Warehouse>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Warehouse.Warehouse { Id = ListId, Name = txtName.Text, WarehouseTypeId = WarehouseTypeId, Capacity = Convert.ToInt32(txtCapacity.Text), PostalCode = txtPostalCode.Text, Addres = txtAddres.Text }, ListId))
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
            txtName.ResetText();
            txtName.Focus();
            txtCapacity.ResetText();
            txtCapacity.Focus();
            txtAddres.ResetText();
            ListId = 0;
            FilldgvList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
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
                        var q = db.Warehouses.Where(c => c.Id == ListId).First();

                        cmbWarehouseType.Value = q.WarehouseTypeId;
                        txtName.Text = q.Name;
                        txtCapacity.Text = q.Capacity.ToString();
                        txtPostalCode.Text = q.PostalCode;
                        txtAddres.Text = q.Addres.ToString();
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        //var q1 = db.Customers.Where(c => c.CityId == ListId).Count();
                        //var q2 = db.ComersHs.Where(c => c.LoadingOrinigId == ListId).Count();
                        //var q3 = db.ComersHs.Where(c => c.UnLoadingOrinigId == ListId).Count();


                        //if (q1 != 0 || q2 != 0 || q3 != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Warehouses.Where(c => c.Id == ListId).First();
                            db.Warehouses.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChangesSafe();
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
    }
}

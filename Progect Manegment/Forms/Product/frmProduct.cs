using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Product;
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

namespace HM_ERP_System.Forms.Product
{
    public partial class frmProduct : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;

        public int LisId = 0;
        int UserId_ = PublicClass.UserId;
        public frmProduct(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            FilldgvList();
            FillcmbProductGroup();

        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                //var q = db.Products.ToList();
                var q = from pr in db.Products
                        join prg in db.ProductGroups
                        on pr.ProductGroupId equals prg.Id
                        select new
                        {
                            pr.Id,
                            pr.Name,
                            ProductGroupName= prg.Name,
                        };
                
                dgvList.DataSource = q.ToList();
                //dgvList.AutoSizeColumns();
                PublicClass.SettingGridEX(dgvList);
            }
        }
        DataTable dt_ProductGroup;
        private void FillcmbProductGroup()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.ProductGroups.ToList();
                cmbProductGroup.DataSource = q;

                dt_ProductGroup = new System.Data.DataTable();
                dt_ProductGroup = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PublicClass.FindEmptyControls(txtName, ResourceCode.
                        T025))
                return;
            using (var db = new DBcontextModel())
            {

                if (LisId == 0)
                {
                    int cont = db.Products.Count(c => c.Name == txtName.Text);
                    if (cont > 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.

                            T026); return;
                    }
                }
                else
                {
                    int cont = db.Products.Count(c => c.Name == txtName.Text & c.Id != LisId);
                    if (cont > 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.
                            T026); return;
                    }
                }

                var userRepo = new Repository<Entity.Product.Product>(db);
                if (userRepo.SaveOrUpdate(new Entity.Product.Product { Id = LisId, Name = txtName.Text,ProductGroupId=ProductGroupId, UserId = UserId_, RecordDateTime = DateTime.Now }, LisId))
                {
                    PublicClass.WindowAlart("1");
                    if (_updatableForms!=null)
                        _updatableForms.UpdateData();
                    CelearItems();
                }
            }
        }
        private void CelearItems()
        {
            LisId = 0;
            txtName.ResetText();
            txtName.Focus();
            FilldgvList();
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            LisId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
            if (e.Column.Key == "Edit")
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.Products.Where(c => c.Id == LisId).First();
                    txtName.Text = q.Name;
                    cmbProductGroup.Value=q.ProductGroupId;
                }

            }

            else if (e.Column.Key == "Delete")
            {
                using (var db = new DBcontextModel())
                {

                    if (db.ComersHs.Where(c => c.ProductsId == LisId).Count() != 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T004);
                        return;
                    }

                    if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var q = db.Products.Where(c => c.Id == LisId).First();
                        db.Products.Remove(q);
                        PublicClass.WindowAlart("2");
                        db.SaveChanges();
                        FilldgvList();
                        CelearItems();
                    }
                }

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

        private void frmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        int ProductGroupId = 0;
        private void cmbProductGroup_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProductGroupId = Convert.ToInt32(cmbProductGroup.Value);
            }
            catch (Exception)
            {
            }

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmProductGroup f=new frmProductGroup(this);
            f.ShowDialog();
            FillcmbProductGroup();
        }

        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbProductGroup, dt_ProductGroup);
            }
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}

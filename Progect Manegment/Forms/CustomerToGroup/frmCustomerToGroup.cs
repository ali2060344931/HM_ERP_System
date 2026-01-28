using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.PersonGroup;

using Janus.Windows.GridEX.EditControls;

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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HM_ERP_System.Forms.CustomerToGroup
{
    public partial class frmCustomerToGroup : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmCustomerToGroup(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;
        }

        private void frmCustomerToGroup_Load(object sender, EventArgs e)
        {
            UpdateData();

        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {

            FilldgvList();
            FillcmbPerson();
            FillcmbGroup();
            FillcmbGroupR();
        }

        DataTable dt_Group;

        private void FillcmbGroup()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.PersonGroups;
                cmbGroup.DropDownDataSource = q.ToList();
                dt_Group = new DataTable();
                dt_Group = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }
        /// <summary>
        /// جدول نقش پایه
        /// </summary>
        private void FillcmbGroupR()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.PersonGroups;
                cmbGroupR.DataSource = q.ToList();
                dt_Group = new DataTable();
                dt_Group = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cg in db.CustomerToGroups

                            join cu in db.Customers
                            on cg.CustomerId equals cu.Id

                            join pg in db.PersonGroups
                            on cg.PersonGroupId equals pg.Id

                            select new
                            {
                                cg.Id,
                                personName = cu.Family + " " + cu.Name,
                                groupName = pg.Name,
                                cu.CodMeli,
                                cg.BasicRole,
                            };
                    System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt; PublicClass.SettingGridEX(dgvList, Name);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Person;
        private void FillcmbPerson()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cu in db.Customers

                            join ct in db.TypeCustomers
                            on cu.id_TypeCustomer equals ct.Id

                            where cu.id_TypeCustomer <= 2
                            select new
                            {
                                cu.Id,
                                name = (cu.Family + " " + cu.Name).Trim(),
                                CustomerType = ct.Name,
                                cu.CodMeli,
                            };
                    cmbPerson.DropDownDataSource = q.ToList();
                    dt_Person = new DataTable();
                    dt_Person = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int PersonId = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PublicClass.SetPeremission("Node1_1_8_1", 1)) return;
                if (cmbPerson.Text == "")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T007); return;
                }
                if (cmbGroup.Text == "")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T097); return;
                }
                if (cmbGroupR.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T187);
                    cmbGroupR.Focus();
                    return;
                }

                if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;


                using (var db = new DBcontextModel())
                {
                    foreach (var CustomerId in cmbPerson.CheckedValues)
                    {
                        int cuId = Convert.ToInt32(CustomerId);

                        var qbr = db.CustomerToGroups.Where(c => c.CustomerId == cuId);

                        if (qbr.Count() != 0)
                        {
                            foreach (var g in qbr.ToList())
                            {
                                g.BasicRole = false;
                            }
                            var br = db.CustomerToGroups.Where(c => c.CustomerId == cuId && c.PersonGroupId == BasicRoleId);
                            if (br.Count() != 0)
                            {
                                br.First().BasicRole = true;
                            }

                        }

                        foreach (var GroupId in cmbGroup.CheckedValues)
                        {
                            int grId = Convert.ToInt32(GroupId);


                            var q = db.CustomerToGroups.Where(c => c.CustomerId == cuId && c.PersonGroupId == grId);
                            if (q.Count() == 0)
                            {
                                var userRepo = new Repository<Entity.CustomerToGroup.CustomerToGroup>(db);
                                userRepo.SaveOrUpdate(new Entity.CustomerToGroup.CustomerToGroup { Id = ListId, CustomerId = cuId, PersonGroupId = grId, BasicRole = grId == BasicRoleId ? true : false }, ListId);
                            }


                        }
                    }
                    db.SaveChanges();


                    PublicClass.WindowAlart("1");
                    FilldgvList();
                    if (_updatableForms != null)
                        _updatableForms.UpdateData();

                    CelearItems();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void CelearItems()
        {
            cmbPerson.ResetText();
            cmbGroup.ResetText();
            cmbGroupR.ResetText();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbPerson();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmPersonGroup f = new frmPersonGroup(this);
            f.ShowDialog();
            FillcmbGroup();
        }

        private void frmCustomerToGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
            if (e.Control && e.KeyCode == Keys.F12) { UpdateData(); PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);


                if (e.Column.Key == "btnBasicRole")
                {
                    if (!PublicClass.SetPeremission("Node1_1_8_4", 1)) return;
                    using (var db = new DBcontextModel())
                    {
                        var q = db.CustomerToGroups.Where(c => c.Id == ListId).First();

                        if (q.BasicRole)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T189);
                            return;
                        }

                        var qs = db.CustomerToGroups.Where(c => c.CustomerId == q.CustomerId && q.BasicRole);
                        string GroupName = "";
                        if (qs.Count() != 0)
                        {
                            GroupName = db.ProductGroups.Where(c => c.Id == qs.FirstOrDefault().PersonGroupId).First().Name;
                        }

                        if (MessageBox.Show(ResourceCode.T188 /*+'\n'+ GroupName!=""?"عنوان نقش قبلی: "+ GroupName:""*/, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var cu = db.CustomerToGroups.Where(x => x.CustomerId == q.CustomerId);
                            foreach (var item in cu.ToList())
                            {
                                item.BasicRole = false;
                            }
                            q.BasicRole = true;


                            int? currentId = null;

                            if (dgvList.CurrentRow != null)
                            {
                                currentId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                            }

                            // عملیات دیتابیس
                            db.SaveChangesSafe();

                            FilldgvList();

                            if (currentId.HasValue)
                            {
                                PublicClass.SetCurrentRowById(dgvList, currentId.Value);
                            }
                        }
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    if (!PublicClass.SetPeremission("Node1_1_8_3", 1)) return;
                    using (var db = new DBcontextModel())
                    {

                        string Item = dgvList.CurrentRow.Cells["personName"].Value.ToString();
                        if (MessageBox.Show(ResourceCode.T003 + '\n' + Item, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)


                        //if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        {
                            var q = db.CustomerToGroups.Where(c => c.Id == ListId).First();
                            db.CustomerToGroups.Remove(q);
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




        private void SetCurrentRowById(int id)
        {
            foreach (Janus.Windows.GridEX.GridEXRow row in dgvList.GetRows())
            {
                if (row.RowType != Janus.Windows.GridEX.RowType.Record)
                    continue;

                if (Convert.ToInt32(row.Cells["Id"].Value) == id)
                {
                    dgvList.Row = row.Position;   // ✅ روش استاندارد انتخاب
                    dgvList.Focus();
                    break;
                }
            }
        }



        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(owner: this, caption: "لیست ستون ها");
        }

        private void cmbPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbPerson, dt_Person, cmbPerson.Text);
            }

        }

        private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbGroup, dt_Group, cmbGroup.Text);
            }

        }

        int BasicRoleId = 0;
        private void cmbGroupR_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BasicRoleId = Convert.ToInt32(cmbGroupR.Value);
            }
            catch (Exception)
            {
            }

        }
    }
}

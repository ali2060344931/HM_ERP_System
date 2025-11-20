using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Gender;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.TypeCustomer;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Reports;

using MyClass;

using Org.BouncyCastle.Asn1.Esf;

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

namespace HM_ERP_System.Forms.Draver
{
    public partial class frmDraver : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;

        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public frmDraver(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmDraver_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            txtBirDate.Value = DateTime.Now;

            FilldgvList();
            FillcmbPerson();
            FillcmbGender();
        }

        private void FillcmbGender()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Genders.ToList();
                cmbGender.DataSource = q;
            }
        }

        DataTable dt_Person;
        private void FillcmbPerson()
        {

            using (var db = new DBcontextModel())
            {
                var q = from c in db.Customers

                        join ctg in db.CustomerToGroups
                        on c.Id equals ctg.CustomerId

                        where ctg.PersonGroupId==1
                        select new
                        {
                            c.Id,
                            Name = c.Family + " " + c.Name,
                            c.CodMeli,
                        };
                cmbPerson.DataSource = q.ToList();
                dt_Person = new System.Data.DataTable();
                dt_Person = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from dr in db.Dravers

                            join cu in db.Customers
                            on dr.CustomerId equals cu.Id

                            join gn in db.Genders
                            on dr.GenderId equals gn.Id

                            join ct in db.Ciltys
                            on cu.CityId equals ct.Id

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id

                            select new
                            {
                                dr.Id,
                                Name = cu.Family + " " + cu.Name,
                                cu.CodMeli,
                                cu.Tel,
                                cu.Adders,
                                dr.Description,
                                dr.BirDate,
                                Gender = gn.Name,
                                Provinces = pr.Name,
                                City = ct.Name,
                                dr.Status,
                                dr.SmartCard,
                                dr.SeryalGovahiname,

                            };
                    dgvList.DataSource = q.ToList();
                    PublicClass.SettingGridEX(dgvList,Name);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int PersonId = 0;
        private void cmbPerson_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                PersonId = Convert.ToInt32(cmbPerson.Value);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(PersonId);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbPerson.SelectedIndex=-1;
                }
            }
            catch (Exception)
            {
            }

        }

        int GenderId = 0;
        private void cmbGender_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GenderId = Convert.ToInt32(cmbGender.Value);
            }
            catch (Exception)
            {
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbPerson, ResourceCode.T012, cmbGender, ResourceCode.T013, txtSeryalGovahiname, ResourceCode.T131, txtSmartCard, ResourceCode.T132))
                    return;

                if (txtBirDate.Text.Length != 10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.
                            T020); return;
                }
                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.Dravers.Count(c => c.CustomerId == PersonId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.

                                T011); return;
                        }
                    }
                    else
                    {
                        int cont = db.Dravers.Count(c => c.CustomerId == PersonId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.
                                T011); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var userRepo = new Repository<Entity.Draver.Draver>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Draver.Draver { Id = ListId, CustomerId = PersonId, BirDate = txtBirDate.Text, GenderId = GenderId, SeryalGovahiname = txtSeryalGovahiname.Text, SmartCard = txtSmartCard.Text, Status = chkStatus.Checked, Description = txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId))
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
            cmbPerson.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbPerson.SelectedIndex = -1;
            txtSeryalGovahiname.ResetText();
            txtSmartCard.ResetText();
            txtBirDate.ResetText();
            txtDes.ResetText();
            chkStatus.Checked = true;
            ListId = 0;
            cmbPerson.Focus();
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
                        var q = db.Dravers.Where(c => c.Id == ListId).First();
                        cmbPerson.Value = q.CustomerId;
                        txtBirDate.Text = q.BirDate;
                        cmbGender.Value = q.GenderId;
                        txtSeryalGovahiname.Text = q.SeryalGovahiname;
                        txtSmartCard.Text = q.SmartCard;
                        txtDes.Text = q.Description;
                        chkStatus.Checked = q.Status;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.ComersHs.Where(c => c.DaraverId1 == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Dravers.Where(c => c.Id == ListId).First();
                            db.Dravers.Remove(q);
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
        //private IUpdatableForms _updatableForms;
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbPerson();
            FilldgvList();
        }


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void cmbPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void cmbPerson_Leave(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                if (ListId == 0 )
                {
                    int cont = db.Dravers.Count(c => c.CustomerId == PersonId);
                    if (cont > 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T011);
                        cmbPerson.SelectedIndex=-1;
                        cmbPerson.Focus();
                    }
                }
            }
        }

        private void cmbPerson_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbPerson, dt_Person);
            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.Cod="2";
            f.grid=dgvList;
            //f.Condition="";
            //f.DateReport="گزارش تاریخ: "+PersianDate.NowPersianDate;
            f.TitelString ="لیست راننده ها";

            f.ShowDialog();
        }
    }
}

using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.CustomerToGroup;
using HM_ERP_System.Forms.Draver;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Reports;

using MyClass;

using Progect_Manegment;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Car
{
    /// <summary>
    /// فرم ثبت خودروها
    /// </summary>
    public partial class frmCar : frmAddItems, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;

        public string Carplate_ = "";

        //public frmCar() : this(null)
        //{
        //}
        public frmCar(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }
        private void frmCar_Load(object sender, EventArgs e)
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
            FillcmbDraverName();
            FillcmbOwnership();
            FillCarName();
            FillcmbGoodsAccount();
            FillTruckUsageType();
            FillcmbCompanys();
            //TruckUsageType
            //FillCmbProvinces();
        }

        private void FillcmbCompanys()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers
                        where cu.id_TypeCustomer==2
                        select new
                        {
                            cu.Id,
                            cu.Name,
                        };

                cmbCompanys.DataSource = q.ToList();
            }
        }

        private void FillTruckUsageType()
        {
            using (var db = new DBcontextModel())
            {
                var q = from tr in db.TruckUsageTypes
                        select new
                        {
                            tr.Id,
                            tr.Name,
                        };
                cmbTruckUsageType.DataSource = q.ToList();
                cmbTruckUsageType.Value=1;

            }

        }
        DataTable dt_GoodsAccount;
        private void FillcmbGoodsAccount()
        {
            using (var db = new DBcontextModel())
            {
                var q = from pr in db.Customers


                        join ctg in db.CustomerToGroups
                        on pr.Id equals ctg.CustomerId

                        where ctg.PersonGroupId==3

                        select new
                        {
                            pr.Id,
                            Name = pr.Family + " " + pr.Name,
                            pr.CodMeli,
                        };
               
                cmbGoodsAccount.DataSource = q.ToList();
                dt_GoodsAccount = new System.Data.DataTable();
                dt_GoodsAccount = PublicClass.AddEntityTableToDataTable(q.ToList());

            }

        }

        private void FillcmbOwnership()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Ownerships.ToList();
                cmbOwnership.DataSource = q;
            }
        }

        private void FillCarName()
        {
            using (var db = new DBcontextModel())
            {
                txtCarName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCarName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                var q = db.Cars.ToList();
                foreach (var c in q)
                {
                    ac.Add(c.CarName);
                }
                txtCarName.AutoCompleteCustomSource = ac;
            }
        }

        DataTable dt_DraverName;
        private void FillcmbDraverName()
        {
            using (var db = new DBcontextModel())
            {
                var q = from dr in db.Dravers

                        join cu in db.Customers
                        on dr.CustomerId equals cu.Id

                        //join ctg in db.CustomerToGroups
                        //on cu.Id equals ctg.CustomerId

                        //where ctg.PersonGroupId==1

                        select new
                        {
                            dr.Id,
                            Name = cu.Family + " " + cu.Name,
                            cu.CodMeli,
                        };
                cmbDraverName.DataSource = q.ToList();
                dt_DraverName = new System.Data.DataTable();
                dt_DraverName = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cr in db.Cars

                        join dr in db.Dravers
                        on cr.DraverId equals dr.Id

                        join cu in db.Customers
                        on dr.CustomerId equals cu.Id

                        join ct in db.Ciltys
                        on cu.CityId equals ct.Id into ctGroup
                        from ct_ in ctGroup.DefaultIfEmpty()

                        join pr in db.Provinces
                        on ct_.ProvincesId equals pr.Id into prGroup
                        from pr_ in prGroup.DefaultIfEmpty()

                        join cu2 in db.Customers
                        on cr.GoodsAccountId equals cu2.Id

                        join tu in db.TruckUsageTypes
                        on cr.TruckUsageTypeId equals tu.Id

                        join ow in db.Ownerships
                        on cr.OwnershipId equals ow.Id

                        join owc in db.Customers
                        on cr.OwnershipCompanyId equals owc.Id into bGroup
                        from OWCompany in bGroup.DefaultIfEmpty()



                        select new
                        {
                            cr.Id,
                            cr.CarName,
                            DraverName = cu.Family + " " + cu.Name,
                            cr.OwnershipId,
                            OwnershipCompanyName = OWCompany !=null ? OWCompany.Name : "-",
                            cr.CarPlat,
                            cr.CarPlatSeryal,
                            cr.Seryal,
                            cr.CreatModel,
                            cr.AxisCount,
                            cr.Description,
                            cr.LoadWeightCapacity,
                            cr.TruckCapacity,
                            OwnershipName = ow.Name,
                            cr.Status,
                            TruckUsageTypeName = tu.Name,
                            GoodsAccountName = cu2.Family + " " + cu2.Name,
                            CodMeli = cu.CodMeli,
                            CityName = ct_ !=null ? ct_.Name : "-",
                            ProvincesName = pr_ !=null ? pr_.Name : "-",

                        };
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList());dgvList.DataSource = dt;
                PublicClass.SettingGridEX(dgvList,Name);
            }
        }

        public void SearchCar_Driver()
        {
            if (txtCarplate.Text.Length == 5 && txtCarplateSeryal.Text.Length == 2 && ListId==0)
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.Cars.Where(c => c.CarPlat == txtCarplate.Text && c.CarPlatSeryal==txtCarplateSeryal.Text);
                    if (q.Count()!=0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T018);
                        txtCarplate.Focus();
                        txtCarplateSeryal.ResetText();
                        return;
                    }
                }

                Carplate_ = txtCarplate.Text + " " + ResourceCode.T016 + " " + txtCarplateSeryal.Text;
            }
            else
            {
                Carplate_ = "";
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            txtCarplate.ResetText();
            txtCarplate.ResetText();
            txtCarplateSeryal.ResetText();
            //  cmbLeter.ResetText();
            txtCarplate.Focus();
        }


        private void txtCarplate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string Carplate_ = this.txtCarplate1.Text + " " + ResourceCode.T016 + " " + this.txtCarplate2.Text;

                if (PublicClass.FindEmptyControls(txtCarName, ResourceCode.T017, cmbDraverName, ResourceCode.T012, cmbOwnership, ResourceCode.T021, cmbGoodsAccount, ResourceCode.T042, cmbTruckUsageType, ResourceCode.T043))
                    return;

                if (cmbDraverName.SelectedIndex==-1|| cmbOwnership.SelectedIndex == -1 || cmbGoodsAccount.SelectedIndex == -1 || cmbTruckUsageType.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T045);
                    return;
                }

                if (txtCarplate.Text.Length != 5 || txtCarplateSeryal.Text.Length != 2)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T019);
                    return;
                }

                if (OwnershipId_==3 && cmbCompanys.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T114);
                    cmbCompanys.Focus();
                    return;
                }

                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.Cars.Count(c => c.CarPlat == txtCarplate.Text && c.CarPlatSeryal == txtCarplateSeryal.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T018); return;
                        }
                    }
                    else
                    {
                        int cont = db.Cars.Count(c => c.CarPlat == txtCarplate.Text && c.CarPlatSeryal == txtCarplateSeryal.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T018); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var car = new Repository<Entity.Car.Car>(db);
                    if (car.SaveOrUpdate(new Entity.Car.Car { Id = ListId, CarName = txtCarName.Text, DraverId = DraverId_, GoodsAccountId=GoodsAccountId_, TruckUsageTypeId=TruckUsageType_, TruckCapacity=Convert.ToInt32(txtTruckCapacity.Text), LoadWeightCapacity=Convert.ToInt32(txtLoadWeightCapacity.Text), CarPlat = txtCarplate.Text, CarPlatSeryal = txtCarplateSeryal.Text, Seryal = txtSeryal.Text, AxisCount = txtAxisCount.Value, CreatModel = txtCreatModel.Value, OwnershipId = OwnershipId_, OwnershipCompanyId=OwnershipCompanyId_, Status = chkStatus.Checked, Description = txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId))
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
            txtCarName.ResetText();
            cmbDraverName.SelectedIndex = -1;
            cmbGoodsAccount.ResetText();
            //cmbTruckUsageType.ResetText();
            txtTruckCapacity.ResetText();
            txtLoadWeightCapacity.ResetText();
            txtCarplate.ResetText();
            txtCarplateSeryal.ResetText();
            txtSeryal.ResetText();
            txtDes.ResetText();
            cmbOwnership.SelectedIndex = -1;
            chkStatus.Checked = true;
            ListId = 0;
            txtCarName.Focus();
            FillCarName();
            FilldgvList();
        }

        int DraverId_ = 0;
        private void cmbDraverName_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DraverId_ = Convert.ToInt32(cmbDraverName.Value);
                using (var db = new DBcontextModel())

                {
                    //var per = db.Customers.Where(x => x.Id==db.Dravers.Where(c => c.Id==DraverId_).FirstOrDefault().Id).First();
                    var per = db.Dravers.Where(x => x.Id==DraverId_).First();

                    //PublicClass.CheckBlacList(per.CustomerId);
                    bool bl1 = false;
                    bool bl2 = false;
                    string name = "";
                    (bl1, bl2, name)=PublicClass.CheckBlacList(per.CustomerId);
                    if (bl1 && bl2)
                    {
                        PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                        cmbDraverName.SelectedIndex=-1;
                    }


                }
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
                        var q = db.Cars.Where(c => c.Id == ListId).First();
                        txtCarName.Text = q.CarName;
                        cmbDraverName.Value = q.DraverId;
                        cmbGoodsAccount.Value=q.GoodsAccountId;
                        cmbTruckUsageType.Value = q.TruckUsageTypeId;
                        txtTruckCapacity.Text=q.TruckCapacity.ToString();
                        txtLoadWeightCapacity.Text = q.LoadWeightCapacity.ToString();
                        txtCarplate.Text = q.CarPlat;
                        txtCarplateSeryal.Text = q.CarPlatSeryal.Substring(0, 2);
                        txtSeryal.Text = q.Seryal;
                        txtCreatModel.Value = q.CreatModel;
                        txtAxisCount.Value = q.AxisCount;
                        cmbOwnership.Value = q.OwnershipId;
                        txtDes.Text = q.Description;
                        chkStatus.Checked = q.Status;
                        if (q.OwnershipCompanyId!=0)
                        {
                            cmbCompanys.Value = q.OwnershipCompanyId;
                        }
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.ComersHs.Where(c => c.CarId == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Cars.Where(c => c.Id == ListId).First();
                            db.Cars.Remove(q);
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

        private void btnAddDravers_Click(object sender, EventArgs e)
        {
            frmCustomerToGroup f = new frmCustomerToGroup(this);
            f.ShowDialog();
            FillcmbDraverName();
        }

        private void txtCarName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        int OwnershipId_ = 0;
        private void cmbOwnership_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOwnership.SelectedIndex!=-1)
                {
                    OwnershipId_ = Convert.ToInt32(cmbOwnership.Value);
                    if (OwnershipId_ == 3)
                    {
                        cmbCompanys.Visible=true;
                        btnAddCompanys.Visible=true;
                    }
                    else
                    {
                        cmbCompanys.Visible=false;
                        btnAddCompanys.Visible=false;
                    }
                }
                else
                {
                    cmbCompanys.Visible=false;
                    btnAddCompanys.Visible=false;
                }

            }
            catch (Exception)
            {
            }

        }

        private void txtCarplate1_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (txtCarplate.Text.Length == 5)
                SendKeys.Send("{TAB}");
        }

        private void txtCarplate2_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (txtCarplateSeryal.Text.Length == 2)
                SendKeys.Send("{TAB}");

        }

        private void txtSeryal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        int GoodsAccountId_ = 0;
        private void cmbGoodsAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GoodsAccountId_ = Convert.ToInt32(cmbGoodsAccount.Value);
                //PublicClass.CheckBlacList(GoodsAccountId_);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(GoodsAccountId_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbGoodsAccount.SelectedIndex=-1;
                }


            }
            catch (Exception)
            {
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            frmCustomerToGroup f = new frmCustomerToGroup(this);
            f.ShowDialog();
            FillcmbGoodsAccount();
        }

        int TruckUsageType_ = 0;
        private void cmbTruckUsageType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TruckUsageType_ = Convert.ToInt32(cmbTruckUsageType.Value);
            }
            catch (Exception)
            {
            }
        }

        private void frmCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) if (PublicClass.CloseForm()) this.Close();
            if (e.Control && e.KeyCode == Keys.F12){UpdateData();}

        }

        private void pnlAddItemBodi_Paint(object sender, PaintEventArgs e)
        {

        }

        int OwnershipCompanyId_ = 0;
        private void cmbCompanys_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCompanys.SelectedIndex!=-1)
                {
                    OwnershipCompanyId_ = Convert.ToInt32(cmbCompanys.Value);
                }
                else
                    OwnershipCompanyId_=0;
            }
            catch (Exception)
            {
            }
        }

        private void btnAddCompanys_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.RequestFromExternalForms="frmCar";
            f.ShowDialog();
            FillcmbCompanys();
        }

        private void cmbDraverName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraverName, dt_DraverName);
            }
        }

        private void cmbGoodsAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbGoodsAccount, dt_GoodsAccount);
            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            //f.Cod="3";
            f.grid=dgvList;
            //f.Condition="";
            //f.DateReport="گزارش تاریخ: "+PersianDate.NowPersianDate;
            f.TitelString =ResourceCode.TRcars;
            f.ReporFileName ="HM_ERP_System.ReportViewer.Report_Cars.rdlc";
            f.ShowDialog();

        }
    }
}

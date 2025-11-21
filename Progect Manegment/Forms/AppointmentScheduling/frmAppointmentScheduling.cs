using HM_ERP_System.Class_General;
using HM_ERP_System.Components;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Forms.Car;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Persons;
using HM_ERP_System.Forms.Reports;

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

namespace HM_ERP_System.Forms.AppointmentScheduling
{
    public partial class frmAppointmentScheduling : frmAddItems, IUpdatableForms
    {
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public string Carplate_ = "";

        public bool isSelectCarPlat = false;
        private IUpdatableForms _updatableForms;
        public frmAppointmentScheduling(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmAppointmentScheduling_Load(object sender, EventArgs e)
        {
            UpdateData();
            if (isSelectCarPlat)
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.AppointmentSchedulings.Where(c => c.IsSelected==true);
                    if (q.Count()!=0)
                    {
                        q.First().IsSelected=false;
                        db.SaveChanges();
                    }
                    dgvList.RootTable.Columns["SelectItem"].Visible=true;
                }
            }
        }

        public void UpdateData()
        {
            txtDate.Value = DateTime.Now;
            FillcmbCarplate();
            FillcmbProvinces();
            FilldgvList();
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from carList in db.AppointmentSchedulings

                            join cr in db.Cars
                            on carList.CarId equals cr.Id

                            join dr in db.Dravers
                            on cr.DraverId equals dr.Id

                            join pr in db.Customers
                            on dr.CustomerId equals pr.Id

                            join GA in db.Customers
                            on cr.GoodsAccountId equals GA.Id

                            where carList.Status== chkSelected.Checked && string.Compare(carList.Date, txtDateStart.Text) >= 0 && string.Compare(carList.Date, txtDateEnd.Text) <= 0

                            select new
                            {
                                carList.Id,
                                CarPlat = cr.CarPlat+cr.CarPlatSeryal,
                                DraverName = pr.Family +" "+pr.Name,
                                CarName = cr.CarName,
                                DateTime = carList.Date+"-"+carList.Time,
                                ProvincesList = carList.ProvincesList,
                                Tel = pr.Tel,
                                carList.Status,
                                GoodsAccount = GA.Family +" "+GA.Name,
                            };

                    dgvList.DataSource = q.ToList();
                    dgvList.AutoSizeColumns();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_LoadingOrinig;
        private void FillcmbProvinces()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Provinces

                            select new
                            {
                                pr.Id,
                                pr.Name,
                            };
                    cmbProvinces.DataSource = q.ToList();
                    cmbProvinces.DropDownList.AutoSizeColumns();
                    dt_LoadingOrinig = new DataTable();
                    dt_LoadingOrinig = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Carplate;
        private void FillcmbCarplate()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = (from cr in db.Cars

                             join dr in db.Dravers
                             on cr.DraverId equals dr.Id

                             join cu in db.Customers
                             on dr.CustomerId equals cu.Id

                             join ct in db.Ciltys
                             on cu.CityId equals ct.Id

                             join pr in db.Provinces
                             on ct.ProvincesId equals pr.Id


                             where dr.Status /*&& (!cr.StatusCarToComers || ListId!=0)*/

                             select new
                             {
                                 cr.Id,
                                 CarPlat = cr.CarPlat + cr.CarPlatSeryal,
                                 cr.CarName,
                                 CarPlat_CarPlatSeryal = cr.CarPlatSeryal + " " + ResourceCode.T016 + " " + cr.CarPlat.ToString().Substring(2, 3) + "ع" + cr.CarPlat.ToString().Substring(0, 2),
                                 DraverName = cu.Family + " " + cu.Name,
                                 cu.CodMeli,
                                 cu.Tel,
                                 cr.Seryal,
                                 CityName = ct.Name,
                                 ProvinceName = pr.Name,
                                 //cmb.StatusDeliveryGoods,

                             }).ToList();
                    cmbCarplate.DataSource = q;
                    dt_Carplate = new DataTable();
                    dt_Carplate = PublicClass.AddEntityTableToDataTable(q);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        int LoadingOrinigId_ = 0;
        private void cmbLoadingOrinig_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadingOrinigId_ = Convert.ToInt32(cmbProvinces.Value);
            }
            catch (Exception)
            {
            }

        }

        private void cmbLoadingOrinig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbProvinces, dt_LoadingOrinig);
            }

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (cmbProvinces.SelectedIndex==-1) return;
            if (txtProvincesList.Text.Contains(cmbProvinces.Text) == true)
            {
                PublicClass.ErrorMesseg(ResourceCode.T090); return;
            }
            txtProvincesList.Text+= cmbProvinces.Text+"، ";
            cmbProvinces.ResetText();
            cmbProvinces.Focus();
        }

        int CarId_ = 0;
        private void cmbCarplate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCarplate.SelectedIndex != -1 && cmbCarplate.Text.Length == 7)
                {
                    CarId_ = Convert.ToInt32(cmbCarplate.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cars.Where(c => c.Id == CarId_).First();

                        var per = db.Dravers.Where(c => c.Id== db.Cars.Where(x => x.Id==CarId_).FirstOrDefault().DraverId).First().CustomerId;

                        Carplate_ = q.CarPlatSeryal + " " + ResourceCode.T016 + " " + q.CarPlat.ToString().Substring(2, 3) + "ع" + q.CarPlat.ToString().Substring(0, 2);

                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbCarplate.SelectedIndex=-1;
                        }



                        lblCarPlatH.Text = Carplate_;
                    }
                    //SearchCar_Driver();
                }
                else
                {
                    CarId_ = 0;
                }

            }
            catch (Exception)
            {
            }
        }

        private void cmbCarplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCarplate, dt_Carplate);

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCarplate.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T052);
                    cmbCarplate.Focus();
                    return;
                }
                if (txtDate.Text.Length!=10 || txtTime.Text.Length!=5)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T091);
                    txtDate.Focus();
                    return;
                }
                if (txtProvincesList.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T092);
                    txtProvincesList.Focus();
                    return;
                }

                //if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.AppointmentSchedulings.Count(c => c.CarId == CarId_ && c.Date.Contains(txtDate.Text)/* && c.CityList.Contains(txtCityList.Text)*/);
                        if (cont > 0)
                        {
                            if (PublicClass.ErrorMessegYesNo(ResourceCode.T093)==DialogResult.No) return;
                        }
                    }
                    //else
                    //{
                    //    int cont = db.AppointmentSchedulings.Count(c => c.CarId == CarId && c.Date.Contains(txtDate.Text) && c.CityList.Contains(txtCityList.Text )&& c.Id != ListId);
                    //    if (cont > 0)
                    //    {
                    //        PublicClass.ErrorMesseg(ResourceCode.T018); return;
                    //    }
                    //}

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var car = new Repository<Entity.AppointmentScheduling.AppointmentScheduling>(db);
                    if (car.SaveOrUpdate(new Entity.AppointmentScheduling.AppointmentScheduling { Id = ListId, CarId=CarId_, ProvincesList=txtProvincesList.Text, Date=txtDate.Text, Time= txtTime.Text, RecordDateTime=DateTime.Now, UserId=UserId_ }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        FilldgvList();

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
            cmbCarplate.ResetText();
            txtTime.ResetText();
            cmbProvinces.ResetText();
            txtProvincesList.ResetText();
            cmbCarplate.Focus();
            ListId=0;
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
                        var q = db.AppointmentSchedulings.Where(c => c.Id == ListId).First();

                        cmbCarplate.Value = q.CarId;
                        txtDate.Text = q.Date;
                        txtTime.Text = q.Time;
                        txtProvincesList.Text=q.ProvincesList;
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

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.AppointmentSchedulings.Where(c => c.Id == ListId).First();
                            db.AppointmentSchedulings.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }
                    }

                }
                else if (e.Column.Key == "SelectItem")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.AppointmentSchedulings.Where(c => c.Id == ListId).First();
                        q.IsSelected= true;
                        db.SaveChanges();

                        frmComers f = Application.OpenForms["frmComers"] as frmComers;
                        f.cmbCarplateH.Text=dgvList.CurrentRow.Cells["CarPlat"].Value.ToString();
                        f.cmbCarplateH.Select();
                        this.Close();

                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnAddNewCity_Click(object sender, EventArgs e)
        {
            frmProvinces f = new frmProvinces(this);
            f.ShowDialog();
            FillcmbProvinces();
        }

        private void btnAddCare_Click(object sender, EventArgs e)
        {
            frmCar f = new frmCar(this);
            f.ShowDialog();
            FillcmbCarplate();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void frmAppointmentScheduling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void chkSelected_CheckedChanged(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.grid=dgvList;
            f.DateReport="گــزارش   از تاریخ: "+txtDateStart.Text+ "   تا تاریخ: "+txtDateEnd.Text;
            f.TitelString ="لیست نوبت دهی کامیون ها";
            f.ReporFileName ="HM_ERP_System.ReportViewer.Report_AppointmentScheduling.rdlc";
            f.ShowDialog();
        }
    }
}

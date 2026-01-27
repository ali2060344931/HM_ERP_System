using HM_ERP_System.Class_General;
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

namespace HM_ERP_System.Forms.Reports
{
    public partial class frmAllReports : frmMasterForm, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        bool LoadForm = false;
        public frmAllReports(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;

        }

        private void frmAllReports_Load(object sender, EventArgs e)
        {
            txtDateStart.Value = DateTime.Now;
            txtDateEnd.Value = DateTime.Now;
            LoadForm = true;

            UpdateData();
        }
        public void UpdateData()
        {
            //FillcmbDraversH1();
            //FillcmbDraversH2();
            //FillcmbResiver1H();
            //FillcmbResiver2H();
            //FillcmbSender2H();
            //FillcmbSender1H();
            FillcmbCompany();
            uiTab1_SelectedTabChanged(null, null);
        }

        void FillcmbCompany()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Settings.ToList();
                cmbCompany.DataSource = q;


                {
                    int id = PublicClass.UserId;
                    var q0 = db.CustomerRoles.Where(c => c.Id == id).First().DefultSetingId;
                    cmbCompany.Value= q0;
                }

            }

        }

        private void FillcmbDraversH1()
        {
            try
            {

                using (var db = new DBcontextModel())
                {
                    var q = from dr in db.Dravers

                            join cu in db.Customers
                            on dr.CustomerId equals cu.Id

                            join ct in db.Ciltys
                            on cu.CityId equals ct.Id

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id

                            join ctg in db.CustomerToGroups
                            on cu.Id equals ctg.CustomerId

                            where dr.Status && ctg.PersonGroupId == 1

                            select new
                            {
                                dr.Id,
                                Name = cu.Family != "" ? (cu.Name + " " + cu.Family).Trim() : cu.Name,

                                cu.Tel,
                                cu.CodMeli,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,

                            };
                    cmbDraversH1.DataSource = q.ToList();

                    dt_Draver1 = new System.Data.DataTable();
                    dt_Draver1 = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        DataTable dt_Resiver1;
        private void FillcmbResiver1H()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers
                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id == 10//فرستنده و گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family != "" ? (pr.Name + " " + pr.Family).Trim() : pr.Name,
                                pr.CodMeli,
                            };
                    cmbResiver1.DataSource = q.ToList();
                    dt_Resiver1 = new System.Data.DataTable();
                    dt_Resiver1 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_Resiver2;

        private void FillcmbResiver2H()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id == 10//فرستنده و گیرنده
                            select new
                            {
                                pr.Id,
                                Name = pr.Family != "" ? (pr.Name + " " + pr.Family).Trim() : pr.Name,

                                pr.CodMeli,
                            };
                    cmbResiver2.DataSource = q.ToList();
                    dt_Resiver2 = new System.Data.DataTable();
                    dt_Resiver2 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        System.Data.DataTable dt_Sender2;

        private void FillcmbSender2H()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id == 10//فرستنده و گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family != "" ? (pr.Name + " " + pr.Family).Trim() : pr.Name,

                                pr.CodMeli,
                            };
                    cmbSender2.DataSource = q.ToList();
                    dt_Sender2 = new System.Data.DataTable();
                    dt_Sender2 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Draver1;
        DataTable dt_Draver2;
        private void FillcmbDraversH2()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from dr in db.Dravers

                            join cu in db.Customers
                            on dr.CustomerId equals cu.Id

                            join ct in db.Ciltys
                            on cu.CityId equals ct.Id

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id

                            join ctg in db.CustomerToGroups
                            on cu.Id equals ctg.CustomerId

                            where dr.Status && ctg.PersonGroupId == 1

                            select new
                            {
                                dr.Id,
                                //Name = cu.Family != "" ? (cu.Family + " " + cu.Name).Trim() : cu.Name,
                                Name = cu.Family != "" ? (cu.Name + " " + cu.Family).Trim() : cu.Name,

                                cu.Tel,
                                cu.CodMeli,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,

                            };
                    cmbDraversH2.DataSource = q.ToList();

                    dt_Draver2 = new System.Data.DataTable();
                    dt_Draver2 = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_bSender1;
        private void FillcmbSender1H()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id == 10//فرستنده و گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family != "" ? (pr.Name + " " + pr.Family).Trim() : pr.Name,
                                pr.CodMeli,
                            };
                    cmbSender1.DataSource = q.ToList();
                    dt_bSender1 = new System.Data.DataTable();
                    dt_bSender1 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void explorerBar1_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {

        }

        private void cmbDraversH1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraversH1, dt_Draver1);
            }

        }

        private void cmbDraversH2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraversH2, dt_Draver2);
            }

        }

        private void cmbSender1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSender1, dt_bSender1);
            }

        }

        private void cmbSender2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSender2, dt_Sender2);
            }

        }

        private void cmbResiver1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbResiver1, dt_Resiver1);
            }

        }

        private void cmbResiver2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbResiver2, dt_Resiver2);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(cmbCompany.SelectedIndex==-1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T203);
                return;
            }

            switch (TabKey)
            {
                case "ComersH":
                    using (var db = new DBcontextModel())
                    {
                        var q = db.ComersHs.Where(c => c.Id == ListId).First();
                        var dr = db.Dravers.Where(c => c.Id == q.DaraverId1).First();
                        var cu = db.Customers.Where(c => c.Id == dr.CustomerId).First();
                        var car = db.Cars.Where(c => c.Id == q.CarId).First();

                        frmReport f = new frmReport();
                        f.Code = "1";
                        f.View_Table_Name = "V_ComersH";
                        f.DateReport = ResourceCode.T159 + txtDateStart.Text + ResourceCode.T160 + txtDateEnd.Text;
                        f.TitelString = ResourceCode.T195;
                        f.Condition1 = " where id=" + ListId;
                        f.Condition2 = " where id=" + CompanyId;
                        f.ReporFileName = "HM_ERP_System.ReportViewer.Report_ComersHSelected.rdlc";
                        f.CodeMeli = cu.CodMeli;
                        f.SmartCard = dr.SmartCard;
                        f.DraversH1 = lblDraversH1.Text;
                        f.DraversH2 = chkDraversH2.Checked && lblDraversH2.Text != "" ? lblDraversH2.Text : " ";
                        f.Resiver1H = chkResiver1.Checked && lblResiver1.Text != "" ? lblResiver1.Text : " ";
                        f.Resiver2H = chkResiver2.Checked && lblResiver2.Text != "" ? lblResiver2.Text : " ";
                        f.Sender1H = chkSender1.Checked && lblSender1.Text != "" ? lblSender1.Text : " ";
                        f.Sender2H = chkSender2.Checked && lblSender2.Text != "" ? lblSender2.Text : " ";
                        f.DraversH1Tel = cu.Tel;
                        f.Seryal = car.Seryal;

                        f.CarPlat = car.CarPlat;
                        f.CarPlatSeryal = car.CarPlatSeryal;
                        //f.CareName = car.CarName;
                        if(chkProductsGroupName.Checked)
                        {
                            var ProductsGroupName = db.ProductGroups.Where(x => x.Id == db.Products.Where(c => c.Id == q.ProductsId).FirstOrDefault().ProductGroupId).First().Name;
                            f.ProductsGroupName = ProductsGroupName;
                        }
                        else
                            f.ProductsGroupName = " ";




                        f.ShowDialog();
                    }
                    break;
                case "ComersB"://بارنامه

                    break;
            }

        }

        string TabKey = "";
        private void uiTab1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            try
            {
                if (LoadForm)
                {
                    TabKey = uiTab1.SelectedTab.Key;
                    switch (TabKey)
                    {
                        case "ComersH":
                            using (var db = new DBcontextModel())
                            {
                                var q = db.ComersHs.Where(c => c.Id == ListId).First();
                                if (q.DaraverId1 != 0)
                                {

                                    var nf = db.Customers.Where(c => c.Id == db.Dravers.Where(x => x.Id == q.DaraverId1).FirstOrDefault().CustomerId).First();
                                    lblDraversH1.Text = nf.Name + " " + nf.Family;
                                }
                                if (q.DaraverId2 != 0)
                                {

                                    var nf = db.Customers.Where(c => c.Id == db.Dravers.Where(x => x.Id == q.DaraverId2).FirstOrDefault().CustomerId).First();
                                    lblDraversH2.Text = nf.Name + " " + nf.Family;
                                }
                                if (q.ResiverId != 0)
                                {
                                    var nf = db.Customers.Where(x => x.Id == q.ResiverId).First();
                                    lblResiver1.Text = nf.Name + " " + nf.Family;

                                }
                                if (q.Resiver2Id != 0)
                                {
                                    var nf = db.Customers.Where(x => x.Id == q.Resiver2Id).First();
                                    lblResiver2.Text = nf.Name + " " + nf.Family;
                                }
                                if (q.SenderId != 0)
                                {
                                    var nf = db.Customers.Where(x => x.Id == q.SenderId).First();
                                    lblSender1.Text = nf.Name + " " + nf.Family;
                                }
                                if (q.Sender2Id != 0)
                                {
                                    var nf = db.Customers.Where(x => x.Id == q.Sender2Id).First();
                                    lblSender2.Text = nf.Name + " " + nf.Family;
                                }
                            }
                            break;
                        case "ComersB"://بارنامه

                            break;
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        int CompanyId = 0;
        private void cmbCompany_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCompany.SelectedIndex != -1)
                {
                    CompanyId = Convert.ToInt32(cmbCompany.Value);

                }

            }
            catch (Exception)
            {
            }

        }

        private void cmbDraversH1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

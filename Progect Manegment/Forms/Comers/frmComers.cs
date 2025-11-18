using GridExEx;
using GridExEx.GridForms;

using HM_ERP_System.Class_General;
using HM_ERP_System.Components;
using HM_ERP_System.Entity.Accounts.DetailedAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.BillLadingWriterPercent;
using HM_ERP_System.Entity.Ciltys;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Entity.PaymentMethod;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.TransactionFee;
using HM_ERP_System.Entity.TypeCalcMethod;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.AppointmentScheduling;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.PlaceTransfer;

using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;

using K4os.Hash.xxHash;

using Microsoft.Office.Interop.Excel;

using MyClass;

using NPOI.OpenXmlFormats.Vml;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

using Progect_Manegment;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;
using System.Windows.Forms;
namespace HM_ERP_System.Forms.Comers
{
    public partial class frmComers : frmMasterForm, IUpdatableForms
    {
        private const int V = 0;
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        int UserId_ = PublicClass.UserId;
        public string Carplate_ = "";
        string ComerTabKey = "";
        //------------
        int TypeDocumentId_ = 0;
        int LoadingOrinigId_ = 0;
        int LoadingLocationId_ = 0;
        int UnLoadingOrinigId_ = 0;
        int UnLoadingLocationId_ = 0;
        //int TypeCalFareId_ = 0;
        //int methodCalFareNameId_ = 0;
        int CostAccountIdH_ = 0;
        int GoodsAccountIdH_ = 0;
        int CostAccountIdB_ = 0;
        int GoodsAccountIdB_ = 0;
        int Sender1Id_ = 0;
        int Resiver1Id_ = 0;
        int Sender2Id_ = 0;
        int Resiver2Id_ = 0;

        int ShiperId_ = V;
        int ProductsId_ = 0;
        int DaraverIdH1_ = 0;
        int DaraverIdH2_ = 0;
        /// <summary>
        /// نحوه محاسبه کرایه:بارنامه/تناژ
        /// </summary>
        int MethodCalFareBId_ = 0;
        bool FormLoded = false;

        //public frmComers(int daraverIdH_)
        //{
        //    DaraverIdH1_ = daraverIdH_;
        //}

        //------------
        int SeryalHId_ = 0;
        //int TypeCalcMethodsBId_ = 0;
        int PaymentMethodId_ = 0;

        int BillLadingCastId_ = 0;
        int BillLadingMethodId_ = 0;

        public frmComers(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmComers_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            txtDateB.Value = DateTime.Now;
            txtDateH.Value = DateTime.Now;


            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateEnd.Value = DateTime.Now;

            chkDocumentBanck.Checked = Properties.Settings.Default.SetDocumentBan;
            cmbListSimilarComerB.Size=new Size(126, 30);
            btnEditCB.Visible=true;
            btnDeleteCB.Visible=true;
            
            
            string layoutPathComersB = Path.Combine(System.Windows.Forms.Application.StartupPath, "DefaultGridLayoutComersB.xml");

            using (var fs = new FileStream(layoutPathComersB, FileMode.Create, FileAccess.Write))
            {
                dgvListB.SaveLayoutFile(fs);
            }
            string layoutPathComersH = Path.Combine(System.Windows.Forms.Application.StartupPath, "DefaultGridLayoutComersH.xml");

            using (var fs = new FileStream(layoutPathComersH, FileMode.Create, FileAccess.Write))
            {
                dgvListH.SaveLayoutFile(fs);
            }
            FormLoded=true;

            CallUpdateTataH();
        }

        public void UpdateData()
        {
            CallUpdateTataH();
            CallUpdateTataB();
        }

        private void uiTab1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            //if (FormLoded)
            {
                ComerTabKey = uiTab1.SelectedTab.Key;
                switch (ComerTabKey)
                {
                    case "ComersH":
                        CallUpdateTataH();//حواله
                        break;
                    case "ComersB"://بارنامه
                        CallUpdateTataB();
                        break;
                }
            }
        }

        /// <summary>
        /// آپدیت فیلدهای حواله
        /// </summary>
        private void CallUpdateTataH()
        {
            dgvListH.SaveSettings=true;
            dgvListH.SettingsKey=this.Name;
            //uiPanel0.Height=325;

            uiPanel0.Text = "بخش ثبت اطلاعات حواله";
            uiPanel1.Text = "بخش لیست نمایش اطلاعات حواله";
            dgvListH.BringToFront();
            dgvListH.Dock = DockStyle.Fill;
            btnChangStatusGoods.Visible = false;
            txtWeightDeliveredGoods.Visible = false;
            panelDeleteEdit.Visible=false;
            txtSearch.Visible=false;
            CreatRemiaanceSeryal();
            FillcmbTypeDocument();
            FillcmbCity1();
            FillcmbCity2();
            FillcmbCarplate();
            FillcmbCostAccountH();
            FillcmbGoodsAccountH();
            FillcmbCostAccountB();
            FillcmbGoodsAccountB();


            FillcmbSender1H();
            FillcmbResiver1H();
            FillcmbSender2H();
            FillcmbResiver2H();

            FillcmbShiper();
            FillcmbDraversH1();
            FillcmbDraversH2();

            FillcmbProducts();
            FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
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

                            where pg.Code==6//گیرنده
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
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

                            where pg.Code==5//گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
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

        /// <summary>
        /// طرف حساب کامیون
        /// </summary>

        System.Data.DataTable dt_CostAccountB;
        private void FillcmbCostAccountB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            //where pr.id_TypeCustomer<=2
                            where ctg.PersonGroupId==3
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbCostAccountB.DataSource = q.ToList();

                    dt_CostAccountB = new System.Data.DataTable();
                    dt_CostAccountB = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// طرف حساب کالا
        /// </summary>
        System.Data.DataTable dt_GoodsAccountB;
        private void FillcmbGoodsAccountB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            //where pr.id_TypeCustomer<=2
                            where ctg.PersonGroupId==4
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbGoodsAccountB.DataSource = q.ToList();
                    dt_GoodsAccountB = new System.Data.DataTable();
                    dt_GoodsAccountB = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// آپدیت فیلدهای بارنامه
        /// </summary>
        private void CallUpdateTataB()
        {
            dgvListB.SaveSettings=true;
            dgvListB.SettingsKey=this.Name;
            //uiPanel0.Height=405;

            dgvListB.BringToFront();
            dgvListB.Dock = DockStyle.Fill;
            uiPanel0.Text = "بخش ثبت اطلاعات بارنامه";
            uiPanel1.Text = "بخش لیست نمایش اطلاعات بارنامه";
            btnChangStatusGoods.Visible = true;
            txtWeightDeliveredGoods.Visible = true;
            txtWeightDeliveredGoods.BringToFront();
            panelDeleteEdit.Visible=true;
            txtSearch.Visible=true;

            FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);//لیست اسناد
            FillcmbCarPlatB();
            FillcmbPaymentMethod();
            FillcmbBillLadingCast();
            FillcmbBillLadingMethod();
            FillcmbFareCalcMethodsB();
            FillcmbMethodCalFareB();
            FillcmbDraversB1();
            FillcmbDraversB2();
            FillcmbResiverB1();
            FillcmbSenderB1();
            FillcmbResiverB2();
            FillcmbSenderB2();
            //FillcmbPaymentToOthers();
        }
        System.Data.DataTable dt_PaymentToOthers;

        /// <summary>
        /// حساب/اشخاص پرداختی توسط رانند
        /// </summary>
        private void FillcmbPaymentToOthers()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cu in db.Customers

                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id

                            select new
                            {
                                cu.Id,
                                Name = (cu.Family +" "+cu.Name).Trim(),
                                Type = tc.Name,
                            };
                    cmbPaymentToOthers.DataSource = q.ToList();
                    cmbPaymentToOthers.SelectedIndex=-1;

                    dt_PaymentToOthers = new System.Data.DataTable();
                    dt_PaymentToOthers = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbFareCalcMethodsB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.FareCalcMethods;
                    cmbFareCalcMethods.DataSource = q.ToList();
                    cmbFareCalcMethods.Value=2;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbDraversB1()
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
                            where dr.Status
                            select new
                            {
                                dr.Id,
                                Name = cu.Family + " " + cu.Name,
                                cu.Tel,
                                cu.CodMeli,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,

                            };
                    cmbDraversB1.DataSource = q.ToList();

                    dt_DraverB1 = new System.Data.DataTable();
                    dt_DraverB1 = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbDraversB2()
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
                            where dr.Status
                            select new
                            {
                                dr.Id,
                                Name = cu.Family + " " + cu.Name,
                                cu.Tel,
                                cu.CodMeli,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,

                            };
                    cmbDraversB2.DataSource = q.ToList();

                    dt_DraverB2 = new System.Data.DataTable();
                    dt_DraverB2 = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbPaymentMethod()
        {
            //try
            //{
            //    using (var db = new DBcontextModel())
            //    {
            //        var q = db.PaymentMethods;
            //        cmbPaymentMethod.DataSource = q.ToList();
            //        cmbPaymentMethod.SelectedIndex=0;
            //    }

            //}
            //catch (Exception er)
            //{
            //    PublicClass.ShowErrorMessage(er);
            //}
        }

        private void FillcmbBillLadingCast()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.PaymentMethods;
                    cmbBillLadingCast.DataSource = q.ToList();
                    cmbBillLadingCast.Value=1;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbBillLadingMethod()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.TypeCalcMethods.Where(c => c.Id>1 && c.Id<4);
                    cmbBillLadingMethod.DataSource = q.ToList();
                    cmbBillLadingMethod.SelectedIndex=0;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbTypeCalcMethodsB()
        {
            //try
            //{
            //    using (var db = new DBcontextModel())
            //    {
            //        var q = db.TypeCalcMethods;
            //        cmbTypeCalcMethodsB.DataSource = q.ToList();
            //    }

            //}
            //catch (Exception er)
            //{
            //    PublicClass.ShowErrorMessage(er);
            //}
        }

        /// <summary>
        /// لیست نحوه محاسبه کرایه صاحب کالا
        /// </summary>
        private void FillcmbMethodCalFareB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.TypeCalcMethods.Where(c => c.Id<=2);
                    cmbMethodCalFare.DataSource = q.ToList();
                    cmbMethodCalFare.Value=1;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void FillcmbCarPlatB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cmh in db.ComersHs

                            join dr in db.Dravers
                            on cmh.DaraverId1 equals dr.Id

                            join cu in db.Customers
                            on dr.CustomerId equals cu.Id

                            join cr in db.Cars
                            on cmh.CarId equals cr.Id

                            join ct1 in db.Ciltys
                            on cmh.LoadingOrinigId equals ct1.Id

                            join ct2 in db.Ciltys
                            on cmh.UnLoadingOrinigId equals ct2.Id

                            join pr in db.Products
                            on cmh.ProductsId equals pr.Id

                            join pt1 in db.PlaceTransfers
                            on cmh.LoadingLocationId equals pt1.Id

                            join pt2 in db.PlaceTransfers
                            on cmh.UnLoadingLocationId equals pt2.Id

                            where !db.ComersBs.Any(c => c.SeryalH == cmh.RemiaanceSeryal && ListId==0)

                            select new
                            {
                                cmh.Id,
                                Name = cmh.RemiaanceSeryal,
                                CarPlat = cr.CarPlat + cr.CarPlatSeryal,
                                DraverName = cu.Family + " " + cu.Name,
                                LoadingOrinig = ct1.Name,
                                UnLoadingOrinig = ct2.Name,
                                ProductName = pr.Name,
                                LoadingLocation = pt1.Name,
                                UnLoadingLocation = pt2.Name,
                            };


                    cmbCarplateB.DataSource = q.ToList();

                    dt_SeryalH = new System.Data.DataTable();
                    dt_SeryalH = PublicClass.AddEntityTableToDataTable(q.ToList());


                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


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
                    cmbCarplateH.DataSource = q;
                    dt_Carplate = new System.Data.DataTable();
                    dt_Carplate = PublicClass.AddEntityTableToDataTable(q);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        /// <summary>
        /// ایجاد سریال حواله
        /// </summary>
        private void CreatRemiaanceSeryal()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.ComersHs;
                    string yare = PersianDate.NowPersianDate.Substring(0, 4);

                    if (q.Count() == 0)
                    {
                        txtNumberTranferForm.Text = yare + "0001";
                    }
                    else
                    {

                        var maxRemiaanceSeryal = q.Max(c => c.RemiaanceSeryal);
                        if (maxRemiaanceSeryal.ToString().Substring(0, 4) == yare)
                        {
                            txtNumberTranferForm.Text = (maxRemiaanceSeryal + 1).ToString();
                        }
                        else
                        {
                            txtNumberTranferForm.Text = yare + "0001";
                        }
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_Products;
        private void FillcmbProducts()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    //var q = db.Products;
                    var q = from pr in db.Products

                            join pg in db.ProductGroups
                            on pr.ProductGroupId equals pg.Id
                            select new
                            {
                                pr.Id,
                                pr.Name,
                                Group = pg.Name,

                            };
                    cmbProducts.DataSource = q.ToList();
                    dt_Products = new System.Data.DataTable();
                    dt_Products = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        public System.Data.DataTable dt_SeryalH { get; private set; }
        public System.Data.DataTable dt_LoadingOrinig { get; private set; }
        public System.Data.DataTable dt_LoadingLocation { get; private set; }
        public System.Data.DataTable dt_UnLoadingOrinig { get; private set; }
        public System.Data.DataTable dt_UnLoadingLocation { get; private set; }
        public System.Data.DataTable dt_Carplate { get; private set; }
        public System.Data.DataTable dt_ListSimilarComerB { get; private set; }
        public System.Data.DataTable dt_DraverB2 { get; private set; }
        public System.Data.DataTable dt_DraverB1 { get; private set; }
        public System.Data.DataTable dt_CostAccountH { get; private set; }

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

                            where dr.Status && ctg.PersonGroupId==1

                            select new
                            {
                                dr.Id,
                                Name = cu.Family + " " + cu.Name,
                                cu.Tel,
                                cu.CodMeli,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,

                            };
                    cmbDraversH1.DataSource = q.ToList();

                    dt_Draver1 = new System.Data.DataTable();
                    dt_Draver1 = PublicClass.AddEntityTableToDataTable(q.ToList());
                }


                //using (var db = new DBcontextModel())
                //{
                //    var q = from pr in db.Customers

                //            join ctg in db.CustomerToGroups
                //             on pr.Id equals ctg.CustomerId

                //            where ctg.PersonGroupId==2//بارنامه نویس
                //            select new
                //            {
                //                dr.Id,
                //                Name = cu.Family + " " + cu.Name,
                //                cu.Tel,
                //                cu.CodMeli,
                //                CityName = ct.Name,
                //                ProvincesName = pr.Name,
                //            };
                //    cmbShiper.DataSource = q.ToList();

                //}
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


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

                            where dr.Status && ctg.PersonGroupId==1

                            select new
                            {
                                dr.Id,
                                Name = cu.Family + " " + cu.Name,
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

        private void FillcmbShiper()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                             on pr.Id equals ctg.CustomerId

                            where ctg.PersonGroupId==2//بارنامه نویس
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbShiper.DataSource = q.ToList();
                    dt_Shiper = new System.Data.DataTable();
                    dt_Shiper = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        System.Data.DataTable dt_cmbSenderB1;
        System.Data.DataTable dt_cmbSenderB2;
        System.Data.DataTable dt_ResiverB1;
        System.Data.DataTable dt_ResiverB2;
        System.Data.DataTable dt_Resiver1;
        System.Data.DataTable dt_Draver1;
        System.Data.DataTable dt_Draver2;
        System.Data.DataTable dt_Shiper;

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

                            where pg.Code==6//گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
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
        private void FillcmbResiverB1()
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

                            where pg.Code==6//گیرنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbResiverB1.DataSource = q.ToList();
                    dt_ResiverB1 = new System.Data.DataTable();
                    dt_ResiverB1 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void FillcmbResiverB2()
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

                            where pg.Code==6//گیرنده
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbResiverB2.DataSource = q.ToList();
                    dt_ResiverB2 = new System.Data.DataTable();
                    dt_ResiverB2 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_bSender1;
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

                            where pg.Code==5//فرستنده


                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
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
        private void FillcmbSenderB1()
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

                            where pg.Code==5//فرستنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbSenderB1.DataSource = q.ToList();

                    dt_cmbSenderB1 = new System.Data.DataTable();
                    dt_cmbSenderB1 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void FillcmbSenderB2()
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

                            where pg.Code==5//فرستنده

                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbSenderB2.DataSource = q.ToList();
                    dt_cmbSenderB2 = new System.Data.DataTable();
                    dt_cmbSenderB2 = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_GoodsAccountH;
        /// <summary>
        /// طرف حساب کالا در حواله
        /// </summary>
        private void FillcmbGoodsAccountH()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.Customers

                            join ctg in db.CustomerToGroups
                            on pr.Id equals ctg.CustomerId

                            //where pr.id_TypeCustomer<=2
                            where ctg.PersonGroupId==4
                            select new
                            {
                                pr.Id,
                                Name = pr.Family + " " + pr.Name,
                                pr.CodMeli,
                            };
                    cmbGoodsAccountH.DataSource = q.ToList();
                    dt_GoodsAccountH = new System.Data.DataTable();
                    dt_GoodsAccountH = PublicClass.AddEntityTableToDataTable(q.ToList());

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// طرف حساب کامیون
        /// </summary>

        //System.Data.DataTable dt_CostAccountH;
        private void FillcmbCostAccountH()
        {
            try
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
                    cmbCostAccountH.DataSource = q.ToList();
                    dt_CostAccountH = new System.Data.DataTable();
                    dt_CostAccountH = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbPlaceTransfersT(int cityId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.PlaceTransfers

                            //join ed in db.EvacuationDeployments
                            //on pr.EvacuationDeploymentId equals ed.Id

                            where pr.CiltyId == cityId || pr.publicStatus

                            select new
                            {
                                pr.Id,
                                pr.Name,
                                //EvacuationDeploymentsName = ed.Name,
                            };
                    cmbUnLoadingLocation.DataSource = q.ToList();
                    dt_UnLoadingLocation = new System.Data.DataTable();
                    dt_UnLoadingLocation = PublicClass.AddEntityTableToDataTable(q.ToList());


                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// مکان های بارگیری
        /// </summary>


        private void FillcmbPlaceTransfersB(int CitiId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pr in db.PlaceTransfers

                            //join ed in db.EvacuationDeployments
                            //on pr.EvacuationDeploymentId equals ed.Id

                            where pr.CiltyId == CitiId || pr.publicStatus

                            select new
                            {
                                pr.Id,
                                pr.Name,
                                //EvacuationDeploymentsName = ed.Name,
                            };
                    cmbLoadingLocation.DataSource = q.ToList();
                    dt_LoadingLocation = new System.Data.DataTable();
                    dt_LoadingLocation = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbTypeDocument()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.TypeDocuments.ToList();
                    cmbTypeDocument.DataSource = q.ToList();
                    cmbTypeDocument.Value=1;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbCity1()

        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from ct in db.Ciltys

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id
                            select new
                            {
                                ct.Id,
                                CiltyName = ct.Name,
                                ProvinceName = pr.Name,
                            };
                    cmbLoadingOrinig.DataSource = q.ToList();
                    cmbLoadingOrinig.DropDownList.AutoSizeColumns();
                    dt_LoadingOrinig = new System.Data.DataTable();
                    dt_LoadingOrinig = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void FillcmbCity2()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from ct in db.Ciltys

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id
                            select new
                            {
                                ct.Id,
                                CiltyName = ct.Name,
                                ProvinceName = pr.Name,
                            };
                    cmbUnLoadingOrinig.DataSource = q.ToList();
                    cmbUnLoadingOrinig.DropDownList.AutoSizeColumns();

                    dt_UnLoadingOrinig = new System.Data.DataTable();
                    dt_UnLoadingOrinig = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        int CarIdH_ = 0;
        bool StatusDeliveryGoods = false;

        /// <summary>
        /// 
        /// </summary>
        public void SearchCar_DriverH()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.Cars.Where(c => c.Id == CarIdH_);
                    var cuId = db.Customers.Where(c => c.Id ==q.FirstOrDefault().DraverId).First().Id;
                    var q1 = db.Customers.Where(c => c.Id ==q.FirstOrDefault().DraverId);
                    if (q.Count() != 0)
                    {
                        CarIdH_ = q.First().Id;
                        var drv = db.Customers.Where(c => c.Id == cuId).First();
                        
                        
                        cmbDraversH1.Value = drv.Id;
                        var per = db.Customers.Where(c => c.Id == cuId).First();
                        lblTelDraver1.Text = per.Tel;

                        lblCarName.Text = q.First().CarName;
                        lblCarSeryal.Text = q.First().Seryal;
                        lblDraverCarName.Text = per.Name + " " + per.Family;
                        lblOwnershipName.Text = db.Ownerships.Where(c => c.Id == q.FirstOrDefault().OwnershipId).First().Name;
                        cmbCostAccountH.Value = q.First().GoodsAccountId;
                        lblTruckUsageType.Text = db.TruckUsageTypes.Where(c => c.Id == q.FirstOrDefault().TruckUsageTypeId).First().Name;
                        lblTruckCapacity.Text = q.First().TruckCapacity.ToString();
                        lblLoadWeightCapacity.Text = q.First().LoadWeightCapacity.ToString();
                        lblCountComerH.Text = db.ComersHs.Where(c => c.CarId == CarIdH_).Count().ToString();
                        lblEndDateComerH.Text = db.ComersHs.Where(c => c.CarId == CarIdH_).Max(c => c.date);

                        lblProvinces.Text = db.Provinces.Where(c => c.Id == db.Ciltys.Where(x => x.Id == drv.CityId).FirstOrDefault().ProvincesId).First().Name;
                        lblCity.Text = db.Ciltys.Where(c => c.Id == drv.CityId).First().Name;
                        txtTruckCapacity.Value= q.First().LoadWeightCapacity;

                        if (StatusCar(CarIdH_) && ListId==0)
                        {
                            string ertext = ResourceCode.T039+'\n'+ResourceCode.T084;
                            if (PublicClass.ErrorMessegYesNo(ertext)==DialogResult.No)
                            {
                                StatusDeliveryGoods = true;
                                cmbCarplateH.ResetText();
                                cmbCarplateH.Focus();
                            }
                            else
                                StatusDeliveryGoods = false;
                        }
                        else
                            StatusDeliveryGoods = false;
                    }
                }
                Carplate_ = lblCarPlatH.Text;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        public void SearchCar_DriverB()
        {
            try
            {
                if (ComersHId_ == 0) return;
                using (var db = new DBcontextModel())
                {
                    var q = db.ComersHs.Where(c => c.Id == ComersHId_).First();

                    var qD = db.Dravers.Where(c => c.Id == q.DaraverId1).First();

                    var pn = db.Products.Where(c => c.Id == q.ProductsId).First();
                    var pnG = db.ProductGroups.Where(c => c.Id == pn.ProductGroupId).First();

                    var qlo = db.Ciltys.Where(c => c.Id == q.LoadingOrinigId).First();
                    var qll = db.PlaceTransfers.Where(c => c.Id == q.LoadingLocationId).First();
                    var qulo = db.Ciltys.Where(c => c.Id == q.UnLoadingOrinigId).First();
                    var qull = db.PlaceTransfers.Where(c => c.Id == q.UnLoadingLocationId).First();

                    StatusLading(q.StatusLading);
                    lblDateB.Text = q.date;
                    lblSeryalH.Text = q.RemiaanceSeryal.ToString();

                    if (q.ShiperId== 0)
                        lblShiperName.Text="";
                    else
                    {
                        var sn = db.Customers.Where(c => c.Id==q.ShiperId).First();
                        lblShiperName.Text=sn.Name +" "+ sn.Family;
                    }

                    lblProdectName.Text = pn.Name+" - "+ pnG.Name;
                    lblLoadingOrinig.Text = qlo.Name+" - "+qll.Name;
                    lblUnLoadingOrinig.Text = qulo.Name + " - " + qull.Name;
                    if (ListId==0)
                    {
                        cmbDraversB1.Value = q.DaraverId1;
                        cmbDraversB2.Value = q.DaraverId2;

                        cmbSenderB1.Value = q.SenderId;
                        cmbResiverB1.Value = q.ResiverId;

                        cmbSenderB2.Value = q.Sender2Id;
                        cmbResiverB2.Value = q.Resiver2Id;

                        cmbCostAccountB.Value= q.CostAccountId;
                        cmbGoodsAccountB.Value=q.GoodsAccountId;
                        SelectEndBillLading(ComersHId_);

                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// لیست آیتم های آخرین بارنامه با پلاک انتخاب شده
        /// </summary>

        private void SelectEndBillLading(int ComersHId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var ch = db.ComersHs.Where(c => c.Id == ComersHId).First();

                    var q = (from cmb in db.ComersBs

                             join cmh in db.ComersHs
                             on cmb.ComersHId equals cmh.Id

                             where cmh.CarId == ch.CarId && cmh.LoadingOrinigId == ch.LoadingOrinigId && cmh.LoadingLocationId == ch.LoadingLocationId && cmh.UnLoadingOrinigId == ch.UnLoadingOrinigId && cmh.UnLoadingLocationId == ch.UnLoadingLocationId
                             orderby cmb.DateB descending

                             select cmb);

                    if (q.Count() != 0)
                    {
                        AddDataToItems(q);
                    }
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// ثبت مقادیر از دیتابیس به فیلدهای فرم
        /// </summary>
        /// <param name="q"></param>
        public void AddDataToItems(IEnumerable<ComersB> q)
        {
            try
            {
                txtLoadWeight.Value=(int)q.First().LoadWeight;
                txtWeightDeliveredGoodsMain.Value=(int)q.First().WeightDeliveredGoods;
                cmbFareCalcMethods.Value=q.First().TypeCalFareId;
                cmbMethodCalFare.Value=q.First().MethodCalFareId;
                txtFreightRate.Value = q.First().FreightRate;
                txtCargoInsurance.Value = q.First().CargoInsurance;
                txtLoadinCast.Value = q.First().LoadinCast;
                txtLoadWeightCapacity.Value = q.First().LoadWeightCapacityB;
                txtIncentive.Value = q.First().Incentive;
                txtStopCharge.Value = q.First().StopCharge;
                txtDeduction.Value = q.First().Deduction;
                txtBalanceAccount.Value = q.First().BalanceAccount;
                //cmbTypeCalcMethodsB.Value = q.First().TypeCalcMethodsBId;
                txtPaidFreightRate.Value = q.First().PaidFreightRate;
                txtInsurancCost.Value = q.First().InsurancCost;
                //cmbPaymentMethod.Value = q.First().PaymentMethodId;
                txtPaidIncentive.Value = q.First().PaidIncentive;
                txtPaidStopCharge.Value = q.First().PaidStopCharge;
                txtDriverDeduction.Value = q.First().DriverDeduction;
                cmbBillLadingCast.Value = q.First().BillLadingCastId;
                cmbBillLadingMethod.Value = q.First().BillLadingMethodId;
                txtBaseFreight.Value = q.First().BaseFreight;
                txtBillLadingAmount.Value = q.First().BillLadingAmount;
                txtInsuranceAmount.Value = q.First().InsuranceAmount;
                txtBillLadingWriterPercent.Value = q.First().BillLadingWriterPercent;
                txtAmountPaidTruckDriver.Value = q.First().AmountPaidTruckDriver;
                txtBalanceAccountِDraver.Value = q.First().BalanceAccountDraver;
                txtDescriptionB.Text = q.First().Description;
                cmbDraversB1.Value = q.First().DaraverId1_;
                cmbDraversB2.Value = q.First().DaraverId2_;
                cmbSenderB1.Value = q.First().SenderId;
                cmbSenderB2.Value = q.First().SenderId2;
                cmbResiverB1.Value = q.First().ResiverId;
                cmbResiverB2.Value = q.First().ResiverId2;
                cmbGoodsAccountB.Value=q.First().GoodsAccountId;
                cmbCostAccountB.Value=q.First().CostAccountId;
                if (q.First().PaymentToOthers1!=0)
                {
                    chkPaymentToOthers.Checked=true;
                    txtPaymentToOthers1.Value=q.First().PaymentToOthers1;
                    PaymentToOthersId_=q.First().PaymentToOthersId;
                    using (var db = new DBcontextModel())
                    {
                        var q0 = db.DetailedAccounts.Where(c => c.Id==PaymentToOthersId_).First();
                        lblPaymentToOthers.Text=db.Customers.Where(c => c.Id==q0.CustomerId).First().Name+ " "+db.Customers.Where(c => c.Id==q0.CustomerId).First().Family;
                        lblPaymentToOthers.Tag=PaymentToOthersId_;
                    }
                }
                if (q.First().PaymentToOthers2!=0)
                {
                    txtPaymentToOthers2.Value=q.First().PaymentToOthers2;
                    txtDesToOthers.Text=q.First().DesToOthers;

                }

                //ثبت درصد بارنامه نویس
                {
                    using (var db = new DBcontextModel())
                    {
                        var shid = db.ComersHs.Where(c => c.Id==q.First().ComersHId).First().ShiperId;
                        if (shid!=0)
                        {
                            var bwp = db.BillLadingWriterPercents.Where(c => c.CustomerId==shid).First().Percent;
                            txtBillLadingWriterPercent.Value=bwp;
                        }
                    }
                }

                txtBalanceAccount_Enter(null, null);
                txtBalanceBillLadingAmount_Enter(null, null);
                txtBalanceAccountِDraver_Enter(null, null);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// بررسی وضعیت خالی بودن کامیون
        /// </summary>
        /// <param name="carid"></param>
        private bool StatusCar(int carid)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q1 = (from cmb in db.ComersBs
                              join cmh in db.ComersHs
                              on cmb.ComersHId equals cmh.Id
                              where (cmh.CarId == carid && cmb.StatusDeliveryGoods == false)
                              select cmb);
                    if (q1.Count() > 0)
                    {
                        return true;
                    }
                    var q2 = from ch in db.ComersHs
                             where !db.ComersBs.Any(c => c.SeryalH == ch.RemiaanceSeryal) && ch.CarId == carid
                             select ch;

                    if (q2.Count() > 0)
                    {
                        return true;
                    }


                    return false;
                }
            }
            catch (Exception er)
            {

                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        public static GridEX FilldgvListH(GridExEx.GridExEx dx, string dateS, string dateE, int? Id = null)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cmh in db.ComersHs

                            join td in db.TypeDocuments
                            on cmh.TypeDocumentId equals td.Id

                            join lo in db.Ciltys
                            on cmh.LoadingOrinigId equals lo.Id

                            join ll in db.PlaceTransfers
                            on cmh.LoadingLocationId equals ll.Id

                            join ulo in db.Ciltys
                            on cmh.UnLoadingOrinigId equals ulo.Id

                            join ull in db.PlaceTransfers
                            on cmh.UnLoadingLocationId equals ull.Id

                            join ca in db.Customers
                            on cmh.CostAccountId equals ca.Id

                            join ga in db.Customers
                            on cmh.GoodsAccountId equals ga.Id

                            join sr1 in db.Customers
                            on cmh.SenderId equals sr1.Id

                            join rs1 in db.Customers
                            on cmh.ResiverId equals rs1.Id

                            join sr2 in db.Customers
                            on cmh.Sender2Id equals sr2.Id into sr2Group
                            from sender2 in sr2Group.DefaultIfEmpty()

                            join rs2 in db.Customers
                            on cmh.Resiver2Id equals rs2.Id into rs2Group
                            from reciver2 in rs2Group.DefaultIfEmpty()

                            join dr1 in db.Dravers
                            on cmh.DaraverId1 equals dr1.Id

                            join cu1 in db.Customers
                            on dr1.CustomerId equals cu1.Id

                            join dr2 in db.Dravers
                            on cmh.DaraverId2 equals dr2.Id into dr2Group
                            from dr2_ in dr2Group.DefaultIfEmpty()

                            join cu2 in db.Customers
                            on dr2_.CustomerId equals cu2.Id into cu2Group
                            from cu2_ in cu2Group.DefaultIfEmpty()

                            join pr in db.Products
                            on cmh.ProductsId equals pr.Id

                            join cr in db.Cars
                            on cmh.CarId equals cr.Id

                            join doc in db.DocumentBancks
                            on cmh.Id equals doc.ListInFoemId into docGroup

                            //ToDo باشد جهت نمایش در دیتاگرید Null یک جدول صفر0 یا  Id وقتی مقدار
                            join sh in db.Customers
                            on cmh.ShiperId equals sh.Id into shGroup
                            from shLeft in shGroup.DefaultIfEmpty()

                            where string.Compare(cmh.date, dateS) >= 0 && string.Compare(cmh.date, dateE) <= 0 && (Id == null || cmh.Id == Id.Value)

                            orderby cmh.Id descending

                            select new
                            {
                                //نام بارنامه نویس
                                ShiperName = shLeft!=null ? (shLeft.Family + " " + shLeft.Name).Trim() : "-",
                                //آمار تعداد مدارک پیوست
                                CountDoc = docGroup.Where(c => c.FormName=="frmComersH").Count(),
                                cmh.Id,
                                cmh.date,
                                TypeDocumentName = td.Name,
                                LoadingOrinigName = lo.Name,
                                LoadingLocationName = ll.Name,
                                UnLoadingOrinigName = ulo.Name,
                                UnLoadingLocationName = ull.Name,
                                CostAccountName = (ca.Family + " " + ca.Name).Trim(),
                                GoodsAccountName = (ga.Family + " " + ga.Name).Trim(),

                                SenderName = (sr1.Family + " " + sr1.Name).Trim(),
                                ResiverName = (rs1.Family + " " + rs1.Name).Trim(),

                                SenderName2 = sender2 !=null ? (sender2.Family + " " + sender2.Name).Trim() : "-",
                                ResiverName2 = reciver2 !=null ? (reciver2.Family + " " + reciver2.Name).Trim() : "-",

                                DaraverName1 = (cu1.Family + " " + cu1.Name).Trim(),
                                DaraverName2 = cu2_!=null ? (cu2_.Family + " " + cu2_.Name).Trim() : "-",

                                ProductsName = pr.Name,
                                CarPlat = cr.CarPlat + "-" + cr.CarPlatSeryal,
                                cmh.RemiaanceSeryal,
                                cmh.LoadWeightCapacity,
                                cmh.Description,
                                cmh.CotajNumber,
                            };
                    dx.DataSource = q.ToList();
                    //dx.AutoSizeColumns();
                    PublicClass.SettingGridEX(dx);
                    return dx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        public static GridEX FilldgvListB(
            GridExEx.GridExEx Gx,
            string dateS,
            string dateE,
            int? Id = null,
            string serch = null,
            bool hideIfInCommission = false // 🔸 شرط پویا برای حذف بارنامه‌های دارای پورسانت
        )
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q =
                        from cmb in db.ComersBs

                        join cmh in db.ComersHs on cmb.ComersHId equals cmh.Id
                        join ct1 in db.Ciltys on cmh.LoadingOrinigId equals ct1.Id
                        join pt1 in db.PlaceTransfers on cmh.LoadingLocationId equals pt1.Id
                        join ct2 in db.Ciltys on cmh.UnLoadingOrinigId equals ct2.Id
                        join pt2 in db.PlaceTransfers on cmh.UnLoadingLocationId equals pt2.Id
                        join pr in db.Products on cmh.ProductsId equals pr.Id
                        join dr1 in db.Dravers on cmb.DaraverId1_ equals dr1.Id
                        join cu1 in db.Customers on dr1.CustomerId equals cu1.Id
                        join dr2 in db.Dravers on cmb.DaraverId2_ equals dr2.Id
                        join cu2 in db.Customers on dr2.CustomerId equals cu2.Id
                        join ca in db.Customers on cmb.CostAccountId equals ca.Id
                        join ga in db.Customers on cmb.GoodsAccountId equals ga.Id
                        join sd1 in db.Customers on cmb.SenderId equals sd1.Id
                        join rs1 in db.Customers on cmb.ResiverId equals rs1.Id

                        join rs2 in db.Customers on cmb.ResiverId2 equals rs2.Id into rs2Group
                        from rs2Left in rs2Group.DefaultIfEmpty()

                        join sd2 in db.Customers on cmb.SenderId2 equals sd2.Id into sd2Group
                        from sd2Left in sd2Group.DefaultIfEmpty()

                        join tcf in db.FareCalcMethods on cmb.TypeCalFareId equals tcf.Id
                        join mcf in db.TypeCalcMethods on cmb.MethodCalFareId equals mcf.Id
                        join pm2 in db.PaymentMethods on cmb.BillLadingCastId equals pm2.Id
                        join tcm2 in db.TypeCalcMethods on cmb.BillLadingMethodId equals tcm2.Id

                        join sh in db.Customers on cmh.ShiperId equals sh.Id into shGroup
                        from shLeft in shGroup.DefaultIfEmpty()

                            // 🔸 اصلاح کامل بخش PaymentToOthers
                        join ptonDA in db.DetailedAccounts
                        on cmb.PaymentToOthersId equals ptonDA.Id into ptonDAGroup
                        from ptonDA_Left in ptonDAGroup.DefaultIfEmpty()

                        join ptonC in db.Customers
                        on ptonDA_Left.CustomerId equals ptonC.Id into ptonCGroup
                        from ptonC_Left in ptonCGroup.DefaultIfEmpty()

                        join cr in db.Cars on cmh.CarId equals cr.Id
                        join tf in db.TransactionFees on cmb.BT equals tf.Id

                        join doc in db.DocumentBancks on cmb.Id equals doc.ListInFoemId into docGroup
                        join tr in db.Transactions on cmb.Id equals tr.ComerBId into TrGroup

                        where string.Compare(cmb.DateB, dateS) >= 0
                           && string.Compare(cmb.DateB, dateE) <= 0
                           && (string.IsNullOrEmpty(serch)
                               || ((sd1.Family + " " + sd1.Name).Contains(serch)
                                   || (sd2Left.Family + " " + sd2Left.Name).Contains(serch)
                                   || (rs1.Family + " " + rs1.Name).Contains(serch)
                                   || (rs2Left.Family + " " + rs2Left.Name).Contains(serch)
                                   || (shLeft.Family + " " + shLeft.Name).Contains(serch)
                                   || (ct1.Name).Contains(serch)
                                   || (pt1.Name).Contains(serch)
                                   || (ct2.Name).Contains(serch)
                                   || (pt2.Name).Contains(serch)
                                   || (ca.Family + " " + ca.Name).Contains(serch)
                                   || (ga.Family + " " + ga.Name).Contains(serch)))

 && (hideIfInCommission ? (Id == null || !db.Commissions.Any(c => c.ComersBId == cmb.Id && c.CommissionTypeId == Id.Value)): (Id == null || cmh.Id == Id.Value)
)

                        orderby cmb.Id descending

                        select new
                        {
                            cmb.Id,
                            cmb.DateB,
                            cmb.SeryalB,
                            cmb.SeryalH,
                            Transaction = TrGroup.Any(),
                            LoadingOrinigName = ct1.Name,
                            LoadingLocationName = pt1.Name,
                            UnLoadingOrinigName = ct2.Name,
                            UnLoadingLocationName = pt2.Name,
                            CostAccountName = (ca.Family + " " + ca.Name).Trim(),
                            GoodsAccountName = (ga.Family + " " + ga.Name).Trim(),
                            ShiperName = shLeft != null ? (shLeft.Family + " " + shLeft.Name).Trim() : "-",
                            CarPlat = cr.CarPlatSeryal + " " + cr.CarPlat,
                            DaraverName = cu1.Family + " " + cu1.Name,
                            DaraverTel = cu1.Tel,
                            DaraverName2 = cu2.Family + " " + cu2.Name,
                            DaraverTel2 = cu2.Tel,
                            SenderName = sd1.Family + " " + sd1.Name,
                            ResiverName = rs1.Family + " " + rs1.Name,
                            SenderName2 = sd2Left != null ? (sd2Left.Family + " " + sd2Left.Name).Trim() : "-",
                            ResiverName2 = rs2Left != null ? (rs2Left.Family + " " + rs2Left.Name).Trim() : "-",
                            ProductsName = pr.Name,
                            FareCalcMethodName = tcf.Name,
                            MethodCalFareName = mcf.Name,
                            CountDoc = docGroup.Count(c => c.FormName == "frmComersB"),
                            cmb.LoadWeight,
                            cmb.WeightDeliveredGoods,
                            cmb.FreightRate,
                            cmb.CargoInsurance,
                            cmb.LoadinCast,
                            cmb.Incentive,
                            cmb.StopCharge,
                            cmb.Deduction,
                            cmb.BalanceAccount,
                            cmb.PaidFreightRate,
                            cmb.InsurancCost,
                            cmb.PaidIncentive,
                            cmb.PaidStopCharge,
                            cmb.DriverDeduction,
                            cmb.BaseFreight,
                            cmb.BillLadingAmount,
                            cmb.InsuranceAmount,
                            cmb.BillLadingWriterPercent,
                            cmb.OtherBillLadingCosts,
                            cmb.AmountPaidTruckDriver,
                            cmb.BalanceAccountDraver,
                            cmb.StatusDeliveryGoods,
                            cmb.Description,
                            cmb.PaymentToOthers1,
                            cmb.PaymentToOthers2,
                            PaymentToOthersName = ptonC_Left != null ? (ptonC_Left.Family + " " + ptonC_Left.Name).Trim() : "-",
                            DesToOthers = cmb.DesToOthers,
                            BillLadingCast = pm2.Name,
                            BillLadingMethod = tcm2.Name,
                            cmb.BO,
                            cmb.AE,
                            cmb.AV,
                            cmb.AX,
                            cmb.AZ,
                            cmb.BP,
                            cmb.BK,
                            cmb.BS,
                            BT = tf.Name,
                            cmb.AY,
                            cmb.BV,
                            cmb.Ac,
                            cmb.Bn,
                        };

                    Gx.DataSource = q.ToList();
                    //gx.AutoSizeColumns();
                    PublicClass.SettingGridEX(Gx);
                    
                    return Gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }





        private void txtSeryal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void txtCarplateSeryal_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_DriverH();
        }

        private void btnAddNewCity1_Click(object sender, EventArgs e)
        {
            AddNewCity();
            FillcmbCity1();
            FillcmbCity2();
        }

        void AddNewCity()
        {
            frmCiltys frmCiltys = new frmCiltys(this);
            frmCiltys.ShowDialog();
        }

        private void btnAddNewCity2_Click(object sender, EventArgs e)
        {
            AddNewCity();
            FillcmbCity1();
            FillcmbCity2();

        }

        private void btnAddPlaceTransfersB_Click(object sender, EventArgs e)
        {
            AddNewPlaceTransfer();
            FillcmbPlaceTransfersB(LoadingOrinigId_);
        }

        void AddNewPlaceTransfer()
        {
            frmPlaceTransfer frmPlaceTransfer = new frmPlaceTransfer(this);
            frmPlaceTransfer.ShowDialog();
        }

        private void btnAddPlaceTransfersT_Click(object sender, EventArgs e)
        {
            AddNewPlaceTransfer();
            FillcmbPlaceTransfersT(UnLoadingOrinigId_);
        }

        private void btnAddPerson1_Click(object sender, EventArgs e)
        {
            AddPerson();
            //FillcmbCostAccount();
            //FillcmbGoodsAccount();
            //FillcmbSenderH();
            //FillcmbResiverH();
            //FillcmbShiper();

        }

        void AddPerson()
        {
            Customer.frmCustomer frmCustomer = new Customer.frmCustomer(this);
            frmCustomer.ShowDialog();

        }

        private void btnAddPerson2_Click(object sender, EventArgs e)
        {
            AddPerson();
            //FillcmbCostAccount();
            //FillcmbGoodsAccount();
            //FillcmbSenderH();
            //FillcmbResiverH();
            //FillcmbShiper();
        }

        private void btnAddPerson3_Click(object sender, EventArgs e)
        {
            AddPerson();
            //FillcmbCostAccount();
            //FillcmbGoodsAccount();
            //FillcmbSenderH();
            //FillcmbResiverH();
            //FillcmbShiper();
        }

        private void btnAddPerson4_Click(object sender, EventArgs e)
        {
            AddPerson();
            //FillcmbCostAccount();
            //FillcmbGoodsAccount();
            //FillcmbSenderH();
            //FillcmbResiverH();
            //FillcmbShiper();

        }

        private void btnAddPerson5_Click(object sender, EventArgs e)
        {
            AddPerson();
            //FillcmbCostAccount();
            //FillcmbGoodsAccount();
            //FillcmbSenderH();
            //FillcmbResiverH();
            //FillcmbShiper();
        }

        private void btnAddDraver_Click(object sender, EventArgs e)
        {
            Draver.frmDraver frmDraver = new Draver.frmDraver(this);
            frmDraver.ShowDialog();
            FillcmbDraversH1();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            Product.frmProduct frmProduct = new Product.frmProduct(this);
            frmProduct.ShowDialog();
            FillcmbProducts();
        }

        private void btnAddCare_Click(object sender, EventArgs e)
        {
            Car.frmCar frmCar = new Car.frmCar(this);
            frmCar.ShowDialog();
            FillcmbCarplate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ComerTabKey == "ComersH")
                SaveFildsH();// متد ثبت اطلاعات حـــواله
            else if (ComerTabKey == "ComersB")
                SaveFildsB();// متد ثبت اطلاعات بارنامه
        }

        double BO = 0;
        double AE = 0;
        double AV = 0;
        double AX = 0;
        double AZ = 0;
        double BK = 0;
        double BS = 0;
        double BT = 0;
        double AY = 0;
        double BV = 0;
        double AC = 0;
        double BN = 0;
        double BP = 0;
        bool StatusDeliveryGoods_ = false;
        /// <summary>
        /// متد ثبت اطلاعات بارنامه
        /// </summary>
        private void SaveFildsB()
        {
            try
            {
                if (ControlEmptyFildsB())
                    return;
                using (var db = new DBcontextModel())
                {
                    if (txtSeryalB.Text=="")
                        txtSeryalB.Text="0";
                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                    int PaymentToOthersId_ = 0;
                    if (lblPaymentToOthers.Tag!=null && chkPaymentToOthers.Checked)
                        PaymentToOthersId_=Convert.ToInt32(lblPaymentToOthers.Tag);


                    int BillLadingMethodId = BillLadingMethodId_;
                    if (cmbBillLadingMethod.SelectedIndex==-1)
                        BillLadingMethodId=4;


                    var SeryalH = db.ComersHs.Where(c => c.Id == ComersHId_).First();
                    CalcComerFilds_();

                    var com = new Repository<ComersB>(db);
                    int newId = com.SaveOrUpdateRefId(new ComersB { Id = ListId, ComersHId = ComersHId_, DateB = txtDateB.Text, SeryalB = Convert.ToInt32(txtSeryalB.Text), SeryalH = SeryalH.RemiaanceSeryal, FreightRate = txtFreightRate.Value, CargoInsurance = txtCargoInsurance.Value, LoadinCast = txtLoadinCast.Value, Incentive = txtIncentive.Value, StopCharge = txtStopCharge.Value, Deduction = txtDeduction.Value, BalanceAccount = txtBalanceAccount.Value, PaidFreightRate = txtPaidFreightRate.Value, InsurancCost = txtInsurancCost.Value, /*PaymentMethodId = PaymentMethodId_,*/ PaidIncentive = txtPaidIncentive.Value, PaidStopCharge = txtPaidStopCharge.Value, PaymentToOthers1=txtPaymentToOthers1.Value, PaymentToOthersId=PaymentToOthersId_, PaymentToOthers2=txtPaymentToOthers2.Value, DriverDeduction = txtDriverDeduction.Value, BillLadingMethodId = BillLadingMethodId, BillLadingCastId = BillLadingCastId_, BaseFreight = txtBaseFreight.Value, BillLadingAmount = txtBillLadingAmount.Value, InsuranceAmount = txtInsuranceAmount.Value, BillLadingWriterPercent = txtBillLadingWriterPercent.Value, AmountPaidTruckDriver = txtAmountPaidTruckDriver.Value, BalanceAccountDraver = txtBalanceAccountِDraver.Value, StatusDeliveryGoods = StatusDeliveryGoods_, Description = txtDescriptionB.Text, DaraverId1_ = DaraverIdB1_, DaraverId2_ = DaraverIdB2_, SenderId = SenderB1Id_, ResiverId = ResiverBId_, SenderId2=SenderB2Id_, ResiverId2 = ResiverB2Id_, CostAccountId = CostAccountIdB_, GoodsAccountId = GoodsAccountIdB_, LoadWeight = txtLoadWeight.Value, LoadWeightCapacityB=txtLoadWeightCapacity.Value, WeightDeliveredGoods = txtWeightDeliveredGoodsMain.Value, MethodCalFareId=MethodCalFareBId_, TypeCalFareId= FareCalcMethod_, DesToOthers=txtDesToOthers.Text, OtherBillLadingCosts=0, Ac=AC, AE=AE, BK=BK, AV=AV, AX=AX, AY=AY, AZ=AZ, Bn= BN, BO=BO, BS=BS, BT=BT, BV=BV, BP=BP }, ListId);
                    PublicClass.WindowAlart("1");
                    //TypeCalcMethodsBId_

                    var q = db.ComersHs.Where(c => c.Id==ComersHId_).First();
                    q.LoadWeightCapacity=txtLoadWeightCapacity.Value;
                    db.SaveChanges();

                    //ثبت مدارک پیوست
                    if (newId != ListId && chkDocumentBanck.Checked)
                    {
                        string lblCaption = "ش بارنامه: " + txtSeryalB.Text + " س حواله: " + lblSeryalH.Text;

                        PublicClass.AddDocumentToBanck(this.Name + "B", newId, lblCaption);
                    }
                    if (_updatableForms!=null)
                        _updatableForms.UpdateData();
                    FillcmbCarPlatB();

                    AddBillLadingWriterPercents();//ثبت درصد بارنامه نویس در دیتابیس
                    AccountingDocumentRegistration(newId);//ثبت سند حسابداری
                    FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
                    CelearItemsB();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// ثبت درصد بارنامه نویس در دیتابیس
        /// </summary>
        private void AddBillLadingWriterPercents()
        {
            if (panelLanding.Enabled && cmbBillLadingMethod.Text == "درصدی")
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.ComersHs.Where(c => c.Id==ComersHId_).First();
                    var bwp = db.BillLadingWriterPercents.Where(c => c.CustomerId==q.ShiperId);
                    int ListId = 0;
                    if (bwp.Count()!=0)
                    {
                        ListId=bwp.First().Id;
                    }
                    var ADR = new Repository<BillLadingWriterPercent>(db);
                    ADR.SaveOrUpdate(new BillLadingWriterPercent { Id = ListId, CustomerId=q.ShiperId, Percent=txtBillLadingWriterPercent.Value }, ListId);
                }
            }
        }

        /// <summary>
        /// ثبت اسناد حسابداری
        /// </summary>
        private void AccountingDocumentRegistration(int ComerB_Id)
        {
            if (MessageBox.Show(ResourceCode.T111, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            PublicClass.ComerB_AccountingDocumentRegistration(ComerB_Id);
        }

        /// <summary>
        /// محاسبات مقادیر محاسباتی بارنامه
        /// </summary>
        void CalcComerFilds_()
        {
            try
            {
                BO = 0;
                AE = 0;
                AV = 0;
                AX = 0;
                AZ = 0;
                BK = 0;
                BS = 0;
                BT = 0;
                AY = 0;
                BV = 0;
                AC = 0;
                BN = 0;
                BP = 0;
                using (var db = new DBcontextModel())
                {
                    var SeryalH = db.ComersHs.Where(c => c.Id == ComersHId_);
                    if (SeryalH.Count()!=0)

                    {
                        //var TruckCapacity = db.Cars.Where(c => c.Id==SeryalH.FirstOrDefault().CarId).First().TruckCapacity;
                        //ظــرفیت مجاز بارگیری
                        int LoadWeightCapacity = txtLoadWeightCapacity.Value;

                        if (ListId!=0)
                            StatusDeliveryGoods_=db.ComersBs.Where(c => c.Id==ListId).First().StatusDeliveryGoods;
                        //txtLoadWeightCapacity
                        CalculatComerB ccb = new CalculatComerB();
                        (AV, AC, AZ, BO, AE, AX, BK, BS, BT, AY, BV, BN, BP)= ccb.CalcComerFilds(ComersHId_, TypeCalFareId_: FareCalcMethod_, MethodCalFareId_: MethodCalFareBId_, LoadWeight_: txtLoadWeight.Value, WeightDeliveredGoods_: 0, TruckCapacity_: LoadWeightCapacity, FreightRate_: txtFreightRate.Value, CargoInsurance_: txtCargoInsurance.Value, LoadinCast_: txtLoadinCast.Value, Incentive_: txtIncentive.Value, StopCharge_: txtStopCharge.Value, Deduction_: txtDeduction.Value, BalanceAccount_: txtBalanceAccount.Value, TypeCalcMethodsBId_: MethodCalFareBId_, PaidFreightRate_: txtPaidFreightRate.Value, InsurancCost_: txtInsurancCost.Value, PaidIncentive_: txtPaidIncentive.Value, PaidStopCharge_: txtPaidStopCharge.Value, DriverDeduction_: txtDriverDeduction.Value, BillLadingMethodId_: BillLadingMethodId_, BillLadingCastId_: BillLadingCastId_, BaseFreight_: txtBaseFreight.Value, BillLadingAmount_: txtBillLadingAmount.Value, InsuranceAmount_: txtInsuranceAmount.Value, BillLadingWriterPercent_: txtBillLadingWriterPercent.Value, AmountPaidTruckDriver_: txtAmountPaidTruckDriver.Value, BalanceAccountDraver_: txtBalanceAccountِDraver.Value, OtherBillLadingCosts_: 0, BalanceBillLadingAmount_: _=txtBalanceBillLadingAmount.Value);
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// متد ثبت اطلاعات حواله
        /// </summary>
        private void SaveFildsH()
        {
            try
            {
                if (ControlEmptyFildsH())// کنترل فیلدهای خالی در زمان ثبت اطلاعات بخش حواله
                    return;
                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.ComersHs.Count(c => c.CarId == CarIdH_ && c.date == txtDateH.Text);

                        if (cont > 0)
                        {
                            string txteror = ResourceCode.T039+'\n'+ResourceCode.T084;
                            if (PublicClass.ErrorMessegYesNo(txteror)==DialogResult.No) return;
                        }
                    }
                    else
                    {
                        int cont = db.ComersHs.Count(c => c.CarId == CarIdH_ && c.date == txtDateH.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T033); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    if (chkStatusLading.Checked)
                        ShiperId_=0;

                    var com = new Repository<ComersH>(db);

                    int newId = com.SaveOrUpdateRefId(new ComersH { Id = ListId, date = txtDateH.Text, TypeDocumentId = TypeDocumentId_, LoadingOrinigId = LoadingOrinigId_, LoadingLocationId = LoadingLocationId_, UnLoadingOrinigId = UnLoadingOrinigId_, UnLoadingLocationId = UnLoadingLocationId_, CostAccountId = CostAccountIdH_, GoodsAccountId = GoodsAccountIdH_, SenderId = Sender1Id_, Sender2Id = Sender2Id_, ResiverId = Resiver1Id_, Resiver2Id = Resiver2Id_, ShiperId = ShiperId_, CarId = CarIdH_, DaraverId1 = DaraverIdH1_, DaraverId2 = DaraverIdH2_, RemiaanceSeryal = Convert.ToInt32(txtNumberTranferForm.Text), ProductsId = ProductsId_, LoadWeightCapacity = txtTruckCapacity.Value, Description = txtDescriptionH.Text, CotajNumber = txtCotajNumber.Text, StatusLading=chkStatusLading.Checked }, ListId);

                    PublicClass.WindowAlart("1");

                    if (newId != ListId && chkDocumentBanck.Checked)
                    {//ثبت اسناد و مدارک
                        string lblCaption = "تاریخ حواله: " + txtDateH.Text + " شماره حواله: " + txtNumberTranferForm.Text + " شماره پلاک: " + lblCarPlatH.Text;

                        PublicClass.AddDocumentToBanck(this.Name + "H", ListId, lblCaption);
                    }

                    PublicClass.CheangStatusCarToComers(CarIdH_, true);
                    DeleteAppointmentSchedulingsToList();// حذف کامیون از لیست نوبت

                    if (_updatableForms!=null)
                        _updatableForms.UpdateData();
                    CelearItemsH();
                    FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                    FillcmbCarplate();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// حذف کامیون از لیست نوبت
        /// </summary>
        void DeleteAppointmentSchedulingsToList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.AppointmentSchedulings.Where(c => c.CarId==CarIdH_ && c.IsSelected);
                    if (q.Count()!=0)
                    {
                        //db.AppointmentSchedulings.Remove(q.First());
                        q.First().Status=true;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// کنترل فیلدهای خالی در زمان ثبت اطلاعات بخش حواله
        /// </summary>
        /// <returns></returns>
        private bool ControlEmptyFildsH()
        {
            try
            {
                if (TypeDocumentId_ == 0 || LoadingOrinigId_ == 0 || LoadingLocationId_ == 0 || UnLoadingOrinigId_ == 0 || UnLoadingLocationId_ == 0 || CostAccountIdH_ == 0 || GoodsAccountIdH_ == 0 /*|| SenderId_ == 0*/ || Resiver1Id_ == 0  || ProductsId_ == 0 || DaraverIdH1_ == 0 || CarIdH_ == 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T029);
                    return true;
                }
                if (txtDateH.Text.Length != 10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    return true;
                }

                if (txtNumberTranferForm.Text == "")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T030);
                    return true;
                }

                //if (txtCotajNumber.Text == "")
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T046);
                //    return true;
                //}

                if (txtTruckCapacity.Text == "")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T032);
                    return true;
                }
                if (cmbLoadingLocation.Value== cmbUnLoadingLocation.Value)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T098);
                    return true;
                }
                if (!chkStatusLading.Checked && ShiperId_ == 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T089);
                    return true;
                }

                return false;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        /// <summary>
        /// کنترل فیلدهای خالی در زمان ثبت اطلاعات بخش بارنامه
        /// </summary>
        /// <returns></returns>
        private bool ControlEmptyFildsB()
        {
            try
            {
                if (cmbCarplateB.SelectedIndex == -1 /*|| cmbTypeCalcMethodsB.SelectedIndex == -1 || cmbPaymentMethod.SelectedIndex == -1 */|| cmbBillLadingCast.SelectedIndex == -1 || cmbDraversB1.SelectedIndex == -1 || cmbDraversB2.SelectedIndex == -1 || cmbSenderB1.SelectedIndex == -1|| cmbCostAccountB.SelectedIndex == -1 || cmbResiverB1.SelectedIndex == -1|| cmbGoodsAccountB.SelectedIndex == -1||cmbMethodCalFare.SelectedIndex == -1||cmbFareCalcMethods.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T029);
                    return true;
                }

                if (txtDateB.Text.Length != 10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    txtDateB.Focus();
                    return true;
                }
                if (txtSeryalB.Text == "" && !chkStatusLading.Enabled)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T036);
                    txtSeryalB.Focus();
                    return true;
                }

                if (txtLoadWeight.Text == "0" || txtLoadWeight.Value == 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T031);
                    txtLoadWeight.Focus();
                    return true;
                }
                if (StatusDeliveryGoods == true)
                    return true;

                if (string.Compare(lblDateB.Text, txtDateB.Text) > 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T083);
                    return true;
                }
                if (chkPaymentToOthers.Checked && (txtPaymentToOthers1.Text=="" || lblPaymentToOthers.Text==""))
                {
                    PublicClass.ErrorMesseg(ResourceCode.T102);
                    txtPaymentToOthers1.Focus();
                    return true;
                }



                return false;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        private void CelearItemsH()
        {
            FillcmbCarplate();
            cmbDraversH1.ResetText();
            cmbCarplateH.ResetText();
            txtNumberTranferForm.ResetText();
            txtLoadWeight.ResetText();
            txtLoadWeightCapacity.ResetText();
            txtTruckCapacity.ResetText();
            txtDescriptionH.ResetText();
            txtCotajNumber.ResetText();
            ListId = 0;
            txtDateH.Focus();
            CreatRemiaanceSeryal();
            CelearLableItemslH();
        }

        private void CelearItemsB()
        {
            ListId = 0;
            FillcmbCarPlatB();

            CelearLableItemslB();

            SeryalHId_ = 0;
            txtSeryalB.ResetText();
            StatusDeliveryGoods = false;
            cmbCarplateB.ResetText();
            cmbCarplateB.Enabled=true;
            btnListSimilarComerB.Enabled=true;
        }

        private void CelearLableItemslH()
        {
            lblCarName.ResetText();
            lblCarSeryal.ResetText();
            lblDraverCarName.ResetText();
            lblOwnershipName.ResetText();
            lblTelDraver1.ResetText();
            lblTelDraver2.ResetText();
            lblCarPlatH.ResetText();
            lblTruckUsageType.ResetText();
            lblTruckCapacity.ResetText();
            lblLoadWeightCapacity.ResetText();
            lblCountComerH.ResetText();
            lblEndDateComerH.ResetText();
            lblProvinces.ResetText();
            lblCity.ResetText();
            cmbDraversH1.SelectedIndex = -1;
            cmbCostAccountH.SelectedIndex = -1;
        }

        private void CelearLableItemslB()
        {
            lblDateB.ResetText();
            lblSeryalH.ResetText();

            lblProdectName.ResetText();
            lblLoadingOrinig.ResetText();
            lblUnLoadingOrinig.ResetText();
            lblDraver1Tel.ResetText();
            lblCarPlatB.ResetText();
            lblCarOwnerShip.ResetText();

            cmbDraversB1.SelectedIndex = -1;
            cmbDraversB2.SelectedIndex = -1;
            cmbSenderB1.SelectedIndex = -1;
            cmbResiverB1.SelectedIndex = -1;
            cmbSenderB2.SelectedIndex = -1;
            cmbResiverB2.SelectedIndex = -1;

            cmbListSimilarComerB.Visible = false;
            btnListSimilarComerB.Visible = false;
            cmbListSimilarComerB.ResetText();
        }

        private void CelearItemsAllH()
        {
            CelearItemsH();
            cmbDraversH2.SelectedIndex = -1;
            //cmbTypeDocument.SelectedIndex = -1;
            cmbLoadingOrinig.SelectedIndex = -1;
            cmbLoadingLocation.SelectedIndex = -1;
            cmbUnLoadingOrinig.SelectedIndex = -1;
            cmbUnLoadingLocation.SelectedIndex = -1;
            cmbCostAccountH.SelectedIndex = -1;
            cmbGoodsAccountH.SelectedIndex = -1;
            cmbSender1.SelectedIndex = -1;
            cmbResiver1.SelectedIndex = -1;
            cmbSender2.SelectedIndex = -1;
            cmbResiver2.SelectedIndex = -1;


            cmbShiper.SelectedIndex = -1;
            cmbProducts.SelectedIndex = -1;
            cmbTypeDocument.Focus();
            ShiperId_=0;
            chkStatusLading.Checked=false;
        }

        private void CelearItemsAllB()
        {
            CelearItemsB();
            txtFreightRate.ResetText();
            txtCargoInsurance.ResetText();
            txtLoadinCast.ResetText();
            txtIncentive.ResetText();
            txtStopCharge.ResetText();
            txtDeduction.ResetText();
            txtBalanceAccount.ResetText();
            txtPaidFreightRate.ResetText();
            txtInsurancCost.ResetText();
            txtPaidIncentive.ResetText();
            txtPaidStopCharge.ResetText();
            txtDriverDeduction.ResetText();
            cmbBillLadingMethod.Value=3;
            txtBaseFreight.ResetText();
            txtBillLadingAmount.ResetText();
            txtInsuranceAmount.ResetText();
            cmbMethodCalFare.Value=1;
            cmbFareCalcMethods.Value=2;
            txtBillLadingWriterPercent.ResetText();
            txtAmountPaidTruckDriver.ResetText();
            txtBalanceAccountِDraver.ResetText();
            txtDescriptionB.ResetText();
            cmbListSimilarComerB.Visible = false;
            txtWeightDeliveredGoodsMain.ResetText();
            txtLoadWeight.ResetText();
            txtLoadWeightCapacity.ResetText();
            txtPaymentToOthers2.ResetText();
            txtDesToOthers.ResetText();
            chkPaymentToOthers.Checked=false;
            txtPaymentToOthers1.ResetText();
            cmbPaymentToOthers.SelectedIndex = -1;
            cmbCostAccountB.SelectedIndex = -1;
            cmbGoodsAccountB.SelectedIndex = -1;
            txtAC.ResetText();
            txtAV.ResetText();
            txtAY.ResetText();
            lblShiperName.ResetText();
            SenderB2Id_=0;
            ResiverB2Id_=0;
            PaymentToOthersId_=0;
            panelLanding.Enabled=true;
            txtSeryalB.Enabled=true;
            cmbBillLadingCast.Enabled=true;
            cmbBillLadingCast.SelectedIndex=1;
        }

        private void cmbTypeDocument_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TypeDocumentId_ = Convert.ToInt32(cmbTypeDocument.Value);
            }
            catch (Exception)
            {
            }
        }

        private void cmbCity1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadingOrinigId_ = Convert.ToInt32(cmbLoadingOrinig.Value);
                FillcmbPlaceTransfersB(LoadingOrinigId_);
            }
            catch (Exception)
            {
            }
        }

        private void cmbPlaceTransfersB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadingLocationId_ = Convert.ToInt32(cmbLoadingLocation.Value);
            }
            catch (Exception)
            {
            }
        }

        private void cmbUnLoadingOrinig_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                UnLoadingOrinigId_ = Convert.ToInt32(cmbUnLoadingOrinig.Value);
                FillcmbPlaceTransfersT(UnLoadingOrinigId_);
            }
            catch (Exception)
            {
            }
        }

        private void cmbUnLoadingLocation_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                UnLoadingLocationId_ = Convert.ToInt32(cmbUnLoadingLocation.Value);
            }
            catch (Exception)
            {
            }
        }

        private void cmbCostAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CostAccountIdH_ = Convert.ToInt32(cmbCostAccountH.Value);

                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(CostAccountIdH_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbCostAccountH.SelectedIndex=-1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbGoodsAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GoodsAccountIdH_ = Convert.ToInt32(cmbGoodsAccountH.Value);
                //PublicClass.CheckBlacList(GoodsAccountId_);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(GoodsAccountIdH_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbGoodsAccountH.SelectedIndex=-1;
                }


            }
            catch (Exception)
            {
            }

        }

        private void cmbSender_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Sender1Id_ = Convert.ToInt32(cmbSender1.Value);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(Sender1Id_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbSender1.SelectedIndex=-1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbResiver_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Resiver1Id_ = Convert.ToInt32(cmbResiver1.Value);
                //PublicClass.CheckBlacList(ResiverId_);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(Resiver1Id_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbResiver1.SelectedIndex=-1;
                }


            }
            catch (Exception)
            {
            }
        }

        private void cmbShiper_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ShiperId_ = Convert.ToInt32(cmbShiper.Value);
                //PublicClass.CheckBlacList(ShiperId_);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(ShiperId_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbShiper.SelectedIndex=-1;
                }


            }
            catch (Exception)
            {
            }
        }

        private void cmbDravers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDraversH1.SelectedIndex != -1)
                {
                    DaraverIdH1_ = Convert.ToInt32(cmbDraversH1.Value);
                    using (var db = new DBcontextModel())
                    {
                        var drv = db.Dravers.Where(c => c.Id == DaraverIdH1_).First();
                        cmbDraversH1.Value = drv.Id;
                        var per = db.Customers.Where(c => c.Id == drv.CustomerId).First();
                        lblTelDraver1.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbDraversH1.SelectedIndex=-1;
                        }


                    }
                }
                else
                {
                    DaraverIdH1_ = 0;
                    lblTelDraver1.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbProducts_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProductsId_ = Convert.ToInt32(cmbProducts.Value);
            }
            catch (Exception)
            {
            }

        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId_ = Convert.ToInt32(dgvListH.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Details")
                {
                    cms_cmsDgvH.Show(Cursor.Position);
                }


                /*
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.ComersHs.Where(c => c.Id == ListId).First();
                        var search = db.ComersBs.Where(c => c.ComersHId == ListId);
                        if (search.Count() != 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T037); return;
                        }
                        FillcmbCarplate();
                        txtDateH.Text = q.date;
                        cmbTypeDocument.Value = q.TypeDocumentId;
                        cmbLoadingOrinig.Value = q.LoadingOrinigId;
                        cmbLoadingLocation.Value = q.LoadingLocationId;
                        cmbUnLoadingOrinig.Value = q.UnLoadingOrinigId;
                        cmbUnLoadingLocation.Value = q.UnLoadingLocationId;
                        cmbCostAccountH.Value = q.CostAccountId;
                        cmbGoodsAccountH.Value = q.GoodsAccountId;
                        cmbSender.Value = q.SenderId;
                        cmbResiver.Value = q.ResiverId;
                        cmbShiper.Value = q.ShiperId;


                        {//محاسبه پلاک
                            var cmh = db.ComersHs.Where(c => c.Id == q.Id).First();
                            var cr = db.Cars.Where(c => c.Id == cmh.CarId).First();
                            cmbCarplateH.Value = cr.Id;
                        }

                        cmbDraversH1.Value = q.DaraverId1;
                        DaraverIdH1_=q.DaraverId1;
                        cmbDraversH2.Value=q.DaraverId2;
                        DaraverIdH2_=q.DaraverId2;

                        txtNumberTranferForm.Text = q.RemiaanceSeryal.ToString();

                        cmbProducts.Value = q.ProductsId;
                        txtTruckCapacity.Value = q.LoadWeightCapacity;
                        txtDescriptionH.Text = q.Description;
                        txtCotajNumber.Text = q.CotajNumber.ToString();
                    }
                }
                else if (e.Column.Key == "Delete")
                {
                    if (!PublicClass.SetPeremission("d1", 1)) return;

                    using (var db = new DBcontextModel())
                    {
                        //this.dgwList.ClearSelection();
                        //this.dgwList.Rows[e.RowIndex].Selected = true;
                        //int r = e.RowIndex;//.ToString();
                        //idsabt = dgwList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //this.Text = idsabt;
                        //this.dgvList.CurrentCell = this.dgvList.Rows[e.RowIndex].Cells[1];
                        //this.contextMenuStrip_dgvListH.Show(this.dgwList, e.Location);


                        var search = db.ComersBs.Where(c => c.ComersHId == ListId);
                        if (search.Count() != 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T038); return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            var q = db.ComersHs.Where(c => c.Id == ListId).First();
                            var dc = db.DocumentBancks.Where(c => c.FormName == "frmComersH" && c.ListInFoemId == ListId).ToList();
                            db.DocumentBancks.RemoveRange(dc);
                            db.ComersHs.Remove(q);
                            PublicClass.CheangStatusCarToComers(q.CarId, false);

                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvListH();
                            CelearItemsH();

                        }

                    }

                }
                else if (e.Column.Key == "AddDocumentToBanck")//ثبت مدارک
                {
                    string lblCaption = "تاریخ حواله: " + dgvListH.GetRow().Cells["date"].Value.ToString() + " شماره حواله: " + dgvListH.GetRow().Cells["RemiaanceSeryal"].Value.ToString() + " شماره پلاک: " + dgvListH.GetRow().Cells["CarPlat"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name + "H", ListId, lblCaption);
                    FilldgvListH();
                }
                else if (e.Column.Key == "BillLadingRequests")//ثبت درخواست بارنامه
                {
                    frmBillLadingRequest f = new frmBillLadingRequest();
                    f.ComersHId=ListId;
                    f.ShowDialog();
                }
                else if (e.Column.Key == "CeatComerB")//ثبت بارنامه
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cars.Where(c => c.Id==db.ComersHs.Where(x => x.Id==ListId).FirstOrDefault().CarId).First();
                        ListId=0;
                        uiTab1.TabPages["ComersB"].Selected=true;
                        cmbCarplateB.Text=q.CarPlat+q.CarPlatSeryal;
                        cmbSeryalH_Leave(null, null);
                        txtSeryalB.Focus();
                    }
                }
                */

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            if (ComerTabKey == "ComersH")
                FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
            else if (ComerTabKey == "ComersB")
                FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (ComerTabKey == "ComersH")
                CelearItemsH();
            else if (ComerTabKey == "ComersB")
            {
                CelearItemsB();
                //CelearLableItemslB();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (ComerTabKey == "ComersH")
            {
                CelearItemsAllH();
                CelearItemsH();
            }


            else if (ComerTabKey == "ComersB")
            {
                cmbCarplateB.ResetText();
                CelearItemsAllB();
                //CelearItemsB();
                CelearLableItemslB();

            }
        }

        private void cmbTypeDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSenderB1, dt_cmbSenderB1);
            }
        }

        private void cmbSeryalH_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCarplateB.SelectedIndex != -1)
                {
                    if (ListId == 0)
                        SeryalHId_ = Convert.ToInt32(cmbCarplateB.Value);

                    using (var db = new DBcontextModel())
                    {
                        int SeryalH_ = Convert.ToInt32(cmbCarplateB.Text);
                        var q = db.ComersHs.Where(c => c.RemiaanceSeryal == SeryalH_).First();
                        var qD = db.Dravers.Where(c => c.Id == q.DaraverId1).First();
                        var qdn = db.Customers.Where(c => c.Id == qD.Id).First();
                        var pn = db.Products.Where(c => c.Id == q.ProductsId).First();
                        var qct1 = db.Ciltys.Where(c => c.Id == q.LoadingOrinigId).First();
                        var qct2 = db.Ciltys.Where(c => c.Id == q.UnLoadingOrinigId).First();
                        lblDateB.Text = q.date;
                        var cr1 = db.ComersHs.Where(c => c.Id == q.CarId).First().CarId;
                        var cr2 = db.Cars.Where(c => c.Id == cr1).First();
                        lblSeryalH.Text = cr2.CarPlatSeryal + " " + cr2.CarPlat;
                        lblDraverCarName.Text = qdn.Name + " " + qdn.Family;
                        lblDraver1Tel.Text = qdn.Tel;
                        //lblLoadWeight.Text = q.LoadWeight.ToString();
                        lblProdectName.Text = pn.Name;
                        lblLoadingOrinig.Text = qct1.Name;
                        lblUnLoadingOrinig.Text = qct2.Name;
                    }
                }
                else
                {
                    CelearLableItemslB();
                }

            }
            catch (Exception)
            {
            }
        }


        private void txtSeryalB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void cmbTypeCalcMethodsB_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    TypeCalcMethodsBId_ = Convert.ToInt32(cmbTypeCalcMethodsB.Value);
            //}
            //catch (Exception)
            //{
            //}

        }
        private void cmbPaymentMethod_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //PaymentMethodId_ = Convert.ToInt32(cmbPaymentMethod.Value);
            }
            catch (Exception)
            {
            }
        }

        private void cmbBillLadingCast_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BillLadingCastId_ = Convert.ToInt32(cmbBillLadingCast.Value);
            }
            catch (Exception)
            {
            }

        }
        private void cmbBillLadingMethod_ValueChanged(object sender, EventArgs e)
        {
            try

            {
                if (cmbBillLadingMethod.SelectedIndex==-1) return;
                BillLadingMethodId_ = Convert.ToInt32(cmbBillLadingMethod.Value);

                if (BillLadingMethodId_==2)
                {
                    txtBillLadingWriterPercent.Enabled=false;
                    txtBillLadingWriterPercent.ResetText();
                    txtBillLadingAmount.Enabled=true;

                    txtBaseFreight.Enabled=true;
                    txtInsuranceAmount.Enabled=true;
                    txtAmountPaidTruckDriver.Enabled=true;
                    //txtOtherBillLadingCosts.Enabled=true;
                    txtBalanceBillLadingAmount.Enabled=true;
                }
                else if (BillLadingMethodId_==3)
                {
                    txtBillLadingWriterPercent.Enabled=true;
                    txtBillLadingAmount.Enabled=false;
                    txtBillLadingAmount.ResetText();

                    txtBaseFreight.Enabled=true;
                    txtInsuranceAmount.Enabled=true;
                    txtAmountPaidTruckDriver.Enabled=true;
                    //txtOtherBillLadingCosts.Enabled=true;
                    txtBalanceBillLadingAmount.Enabled=true;
                }
                else if (BillLadingMethodId_==4)
                {
                    txtBillLadingWriterPercent.Enabled=false;
                    txtBillLadingAmount.Enabled=false;
                    txtBaseFreight.Enabled=false;
                    txtInsuranceAmount.Enabled=false;
                    txtAmountPaidTruckDriver.Enabled=false;
                    //txtOtherBillLadingCosts.Enabled=false;
                    txtBalanceBillLadingAmount.Enabled=false;
                    txtBillLadingWriterPercent.ResetText();
                    txtBillLadingAmount.ResetText();
                    txtBaseFreight.ResetText();
                    txtInsuranceAmount.ResetText();
                    txtAmountPaidTruckDriver.ResetText();
                    //txtOtherBillLadingCosts.ResetText();
                    txtBalanceBillLadingAmount.ResetText();

                }


            }
            catch (Exception)
            {
            }

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (ComerTabKey == "ComersH")
                PublicClass.SaveGridExToExcel(dgvListH);

            else if (ComerTabKey == "ComersB")
                PublicClass.SaveGridExToExcel(dgvListB);
        }

        /// <summary>
        /// ویرایش آیتم های لیست بارنامه
        /// </summary>
        /// <param name="listid"></param>
        void EditdgvListB(int listid)
        {
            using (var db = new DBcontextModel())
            {
                var q = db.ComersBs.Where(c => c.Id == listid);
                var q2 = db.ComersHs.Where(c => c.Id==q.FirstOrDefault().ComersHId);

                cmbCarplateB.Enabled=false;
                btnListSimilarComerB.Enabled=false;

                FillcmbCarPlatB();
                SeryalHId_ = q.First().ComersHId;
                txtDateB.Text = q.First().DateB;
                txtSeryalB.Text = q.First().SeryalB.ToString();
                cmbCarplateB.Value=q2.First().Id;
                AddDataToItems(q);
                SearchCar_DriverB();
            }
        }
        /// <summary>
        /// حذف آیتم های لیست بارنامه
        /// </summary>
        /// <param name="listid"></param>
        void DeletegvListB(int listid)
        {
            using (var db = new DBcontextModel())
            {
                if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var q = db.ComersBs.Where(c => c.Id == listid).First();
                    var dc = db.DocumentBancks.Where(c => c.FormName == "frmComersB" && c.ListInFoemId == listid).ToList();
                    db.DocumentBancks.RemoveRange(dc);
                    db.ComersBs.Remove(q);
                    PublicClass.WindowAlart("2");
                    db.SaveChanges();
                    FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                }
            }
        }

        private void dgvListB_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId_ = Convert.ToInt32(dgvListB.CurrentRow.Cells["Id"].Value);

                if (e.Column.Key == "Details")
                {
                    cms_cmsDgvB.Show(Cursor.Position);
                }
                /*
                else if (e.Column.Key == "Delete")
                {

                    DeletegvListB(ListId);
                }
                else if (e.Column.Key == "AddDocumentToBanck")
                {
                    string lblCaption = "ش بارنامه: " + dgvListB.GetRow().Cells["SeryalB"].Value.ToString() + " س حواله: " + dgvListB.GetRow().Cells["SeryalH"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name + "B", ListId, lblCaption);
                    FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
                }
                */
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbSeryalH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmbDravers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraversH1, dt_Draver1);
            }
        }

        private void cmbSeryalH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCarplateB, dt_SeryalH);
            }

        }

        private void cmbLoadingOrinig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbLoadingOrinig, dt_LoadingOrinig);
            }


        }

        private void cmbLoadingLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbLoadingLocation, dt_LoadingLocation);
            }
        }

        private void cmbUnLoadingOrinig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbUnLoadingOrinig, dt_UnLoadingOrinig);
            }
        }

        private void cmbUnLoadingLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbUnLoadingLocation, dt_UnLoadingLocation);

            }
        }

        private void cmbCarplate_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCarplateH, dt_Carplate);

            }


        }

        private void cmbCarplate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCarplateH.SelectedIndex != -1 && cmbCarplateH.Text.Length == 7)
                {
                    CarIdH_ = Convert.ToInt32(cmbCarplateH.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cars.Where(c => c.Id == CarIdH_).First();
                        Carplate_ = q.CarPlatSeryal + " " + ResourceCode.T016 + " " + q.CarPlat.ToString().Substring(2, 3) + "ع" + q.CarPlat.ToString().Substring(0, 2);


                        lblCarPlatH.Text = Carplate_;
                    }
                    //SearchCar_Driver();
                }
                else
                {
                    CarIdH_ = 0;
                    CelearLableItemslH();
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnChangStatusGoods_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (dgvListB.GetCheckedRows().Count() == 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T041); return;
                    }

                    if (dgvListB.GetCheckedRows().Count() != 0 && (txtWeightDeliveredGoods.Value == 0 || txtWeightDeliveredGoods.Text == ""))
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T047);
                        txtWeightDeliveredGoods.Focus();
                        return;
                    }

                    if (MessageBox.Show(ResourceCode.T040, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    int n = 0;


                    foreach (GridEXRow item in dgvListB.GetCheckedRows())
                    {
                        int id = Convert.ToInt32(item.Cells["Id"].Value);
                        if (!Convert.ToBoolean(item.Cells["StatusDeliveryGoods"].Value))
                        {
                            var q = db.ComersBs.Where(c => c.Id == id).First();
                            var cmh = db.ComersHs.Where(c => c.Id==q.ComersHId).First();

                            PublicClass.CheangStatusCarToComers(cmh.CarId, false);

                            q.StatusDeliveryGoods = true;
                            if (dgvListB.GetCheckedRows().Count() == 1)
                                q.WeightDeliveredGoods = txtWeightDeliveredGoods.Value;

                            n++;
                        }
                    }
                    PublicClass.WindowAlart("1", "تعداد آیتم های ثبت شده: " + n.ToString());

                    db.SaveChanges();
                    FillcmbCarplate();
                    FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnUnChangStatusGoods_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (dgvListB.GetCheckedRows().Count() == 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T041); return;
                    }
                    if (MessageBox.Show(ResourceCode.T040, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    int n = 0;
                    foreach (GridEXRow item in dgvListB.GetCheckedRows())
                    {
                        int id = Convert.ToInt32(item.Cells["Id"].Value);
                        if (Convert.ToBoolean(item.Cells["StatusDeliveryGoods"].Value))
                        {
                            var q = db.ComersBs.Where(c => c.Id == id).First();

                            var cmh = db.ComersHs.Where(c => c.Id==q.ComersHId).First();

                            PublicClass.CheangStatusCarToComers(cmh.CarId, true);

                            q.StatusDeliveryGoods = false;
                            n++;
                        }
                    }
                    PublicClass.WindowAlart("1", "تعداد آیتم های ثبت شده: " + n.ToString());
                    db.SaveChanges();
                    FillcmbCarplate();
                    FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void cmbCarplate_Leave(object sender, EventArgs e)
        {
            SearchCar_DriverH();
        }

        private void btnListSimilarComerB_Click(object sender, EventArgs e)
        {
            if (cmbCarplateB.SelectedIndex == -1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T052);
                return;
            }
            if (!cmbListSimilarComerB.Visible)
            {
                ListSimilarComerB();// لیست بارنامه های مشابه
                cmbListSimilarComerB.Visible = true;
            }
            else
            {
                cmbListSimilarComerB.Visible = false;
            }

        }
        /// <summary>
        /// لیست بارنامه های مشابه
        /// </summary>
        void ListSimilarComerB()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var Q = db.ComersHs.Where(c => c.Id == ComersHId_).First();

                    var q = (from cmb in db.ComersBs

                             join cmh in db.ComersHs
                             on cmb.ComersHId equals cmh.Id

                             join cr in db.Cars
                             on cmh.CarId equals cr.Id

                             join dr in db.Dravers
                             on cr.DraverId equals dr.Id

                             join cu in db.Customers
                             on dr.CustomerId equals cu.Id

                             join lo in db.Ciltys
                             on cmh.LoadingOrinigId equals lo.Id

                             join ll in db.PlaceTransfers
                             on cmh.LoadingLocationId equals ll.Id

                             join ulo in db.Ciltys
                             on cmh.UnLoadingOrinigId equals ulo.Id

                             join ull in db.PlaceTransfers
                             on cmh.UnLoadingLocationId equals ull.Id

                             where cmh.LoadingOrinigId == Q.LoadingOrinigId && cmh.LoadingLocationId == Q.LoadingLocationId && cmh.UnLoadingOrinigId == Q.UnLoadingOrinigId && cmh.UnLoadingLocationId == Q.UnLoadingLocationId

                             select new
                             {
                                 Id = cmb.ComersHId,
                                 cmh.date,
                                 CarPlat = cr.CarPlat + cr.CarPlatSeryal,
                                 DraverName = cu.Family + " " + cu.Name,
                                 LoadingOrinigName = lo.Name,
                                 LoadingLocationName = ll.Name,
                                 UnLoadingOrinigName = ulo.Name,
                                 UnLoadingLocationName = ull.Name,
                             }).ToList();
                    cmbListSimilarComerB.DataSource = q;
                    dt_ListSimilarComerB = new System.Data.DataTable();
                    dt_ListSimilarComerB = PublicClass.AddEntityTableToDataTable(q);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void cmbSeryalH_Leave(object sender, EventArgs e)
        {
            btnListSimilarComerB.Visible = true;
            SearchCar_DriverB();
        }

        int CarIdB_ = 0;
        int ComersHId_ = 0;
        private void cmbCarPlatB_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbCarplateB.SelectedIndex != -1 && cmbCarplateB.Text.Length == 7)
                {
                    ComersHId_ = Convert.ToInt32(cmbCarplateB.Value);

                    using (var db = new DBcontextModel())
                    {
                        var CarId = db.ComersHs.Where(x => x.Id == ComersHId_).First().CarId;
                        var Car = db.Cars.Where(c => c.Id == CarId).First();

                        var Ownerships = db.Ownerships.Where(c => c.Id==Car.OwnershipId).First();

                        CarIdB_ = Car.Id;
                        Carplate_ = Car.CarPlatSeryal + " " + ResourceCode.T016 + " " + Car.CarPlat.ToString().Substring(2, 3) + "ع" + Car.CarPlat.ToString().Substring(0, 2);
                        lblCarPlatB.Text = Carplate_;

                        string OwnershipCompany = "";
                        if (Car.OwnershipId==3)
                        {
                            OwnershipCompany=" - "+ db.Customers.Where(c => c.Id==Car.OwnershipCompanyId).First().Name;
                        }


                        lblCarOwnerShip.Text=("نوع مالکیت: "+Ownerships.Name+OwnershipCompany).Trim();
                    }
                }
                else
                {
                    CarIdB_ = 0;
                    ComersHId_ = 0;
                    CelearLableItemslB();
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbDraversB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraversB1, dt_DraverB1);
            }

        }
        int DaraverIdB1_ = 0;
        private void cmbDraversB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDraversB1.SelectedIndex != -1)
                {
                    DaraverIdB1_ = Convert.ToInt32(cmbDraversB1.Value);
                    using (var db = new DBcontextModel())
                    {
                        var drv = db.Dravers.Where(c => c.Id == DaraverIdB1_).First();
                        var per = db.Customers.Where(c => c.Id == drv.CustomerId).First();
                        lblDraver1Tel.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbDraversB1.SelectedIndex=-1;
                        }


                    }
                }
                else
                {
                    DaraverIdB1_ = 0;
                    lblDraver1Tel.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void cmbDraversB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDraversB2, dt_DraverB2);
            }
        }
        int DaraverIdB2_ = 0;
        private void cmbDraversB2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDraversB2.SelectedIndex != -1)
                {
                    DaraverIdB2_ = Convert.ToInt32(cmbDraversB2.Value);
                    using (var db = new DBcontextModel())
                    {
                        var drv = db.Dravers.Where(c => c.Id == DaraverIdB2_).First();

                        var per = db.Customers.Where(c => c.Id == drv.CustomerId).First();
                        lblDraver2Tel.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbDraversB2.SelectedIndex=-1;
                        }


                    }
                }
                else
                {
                    DaraverIdB2_ = 0;
                    lblDraver2Tel.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        int SenderB1Id_ = 0;
        private void cmbSenderB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSenderB1.SelectedIndex != -1)
                {
                    SenderB1Id_ = Convert.ToInt32(cmbSenderB1.Value);
                    using (var db = new DBcontextModel())
                    {
                        var per = db.Customers.Where(c => c.Id == SenderB1Id_).First();
                        lblSenderTel1.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbSenderB1.SelectedIndex=-1;
                        }


                    }

                }
                else
                {
                    SenderB1Id_ = 0;
                    lblSenderTel1.ResetText();
                }
            }
            catch (Exception)
            {
            }

        }
        int ResiverBId_ = 0;
        private void cmbResiverB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbResiverB1.SelectedIndex != -1)
                {
                    ResiverBId_ = Convert.ToInt32(cmbResiverB1.Value);
                    using (var db = new DBcontextModel())
                    {
                        var per = db.Customers.Where(c => c.Id == ResiverBId_).First();
                        lblReciverTel1.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbResiverB1.SelectedIndex=-1;
                        }
                    }
                }
                else
                {
                    ResiverBId_ = 0;
                    lblReciverTel1.ResetText();
                }
            }
            catch (Exception)
            {
            }

        }

        private void btnAddDraverB1_Click(object sender, EventArgs e)
        {
            Draver.frmDraver frmDraver = new Draver.frmDraver(this);
            frmDraver.ShowDialog();
            FillcmbDraversB1();

        }

        private void btnAddDraverB2_Click(object sender, EventArgs e)
        {
            Draver.frmDraver frmDraver = new Draver.frmDraver(this);
            frmDraver.ShowDialog();
            FillcmbDraversB2();

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer cu = new Customer.frmCustomer(this);
            cu.ShowDialog();
            FillcmbResiverB1();
            FillcmbResiverB1();
        }

        private void chkDocumentBanck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SetDocumentBan = chkDocumentBanck.Checked;
            Properties.Settings.Default.Save();
        }

        private void cmbListSimilarComerB_ValueChanged(object sender, EventArgs e)
        {
            int ComersHId = 0;
            if (cmbListSimilarComerB.SelectedIndex != -1)
            {
                ComersHId = Convert.ToInt32(cmbListSimilarComerB.Value);
                SelectEndBillLading(ComersHId);
                cmbListSimilarComerB.Visible = false;
                txtLoadWeight.Focus();
            }
        }

        private void cmbListSimilarComerB_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbListSimilarComerB, dt_ListSimilarComerB);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicClass.CelereTables();
        }

        private void txtWeightDeliveredGoods_Enter(object sender, EventArgs e)
        {
            var q = dgvListB.GetCheckedRows();
            if (q.Count()==1)
            {
                foreach (GridEXRow item in q)
                {
                    int LoadWeight = Convert.ToInt32(item.Cells["LoadWeight"].Value.ToString());
                    txtWeightDeliveredGoods.Value=LoadWeight;
                }
            }
            else
            {
                txtWeightDeliveredGoods.Value=0;
            }
        }

        private void cmbMethodCalFare_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MethodCalFareBId_ = Convert.ToInt32(cmbMethodCalFare.Value);
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// نوع محاسبه کرایه حمل/کمیسیون
        /// </summary>
        int FareCalcMethod_ = 0;
        private void cmbFareCalcMethods_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FareCalcMethod_ = Convert.ToInt32(cmbFareCalcMethods.Value);
            }
            catch (Exception)
            {
            }

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }
        int SenderB2Id_ = 0;
        private void cmbSenderB2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSenderB2.SelectedIndex != -1)
                {
                    SenderB2Id_ = Convert.ToInt32(cmbSenderB2.Value);
                    using (var db = new DBcontextModel())
                    {
                        var per = db.Customers.Where(c => c.Id == SenderB2Id_).First();
                        lblSenderTel2.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbSenderB2.SelectedIndex=-1;
                        }



                    }

                }
                else
                {
                    SenderB2Id_ = 0;
                    lblSenderTel2.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        int ResiverB2Id_ = 0;
        private void cmbResiverB2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbResiverB2.SelectedIndex != -1)
                {
                    ResiverB2Id_ = Convert.ToInt32(cmbResiverB2.Value);
                    using (var db = new DBcontextModel())
                    {
                        var per = db.Customers.Where(c => c.Id == ResiverB2Id_).First();
                        lblReciverTel2.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbResiverB2.SelectedIndex=-1;
                        }


                    }

                }
                else
                {
                    ResiverB2Id_ = 0;
                    lblReciverTel2.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            CalcComerFilds_();
            txtAY.Value=AV;
            txtBalanceAccountِDraver.Value=AV;
        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvListB.GetCheckedRows().Count() != 1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T076); return;
            }
            ListId=Convert.ToInt32(dgvListB.GetCheckedRows().First().Cells["Id"].Value);

            int SeryalB = Convert.ToInt32(dgvListB.GetCheckedRows().First().Cells["SeryalH"].Value);
            if (txtSeryalH_DE.Value==0 || SeryalB!=txtSeryalH_DE.Value)
            {
                PublicClass.ErrorMesseg(ResourceCode.T077); return;
            }
            DeletegvListB(ListId);
            FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvListB.GetCheckedRows().Count() != 1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T076); return;
            }
            ListId=Convert.ToInt32(dgvListB.GetCheckedRows().First().Cells["Id"].Value);

            using (var db = new DBcontextModel())
            {
                var q = db.Transactions.Where(c => c.ComerBId==ListId);
                if (q.Count() != 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T115);
                    return;
                }
            }

            int SeryalB = Convert.ToInt32(dgvListB.GetCheckedRows().First().Cells["SeryalH"].Value);
            if (txtSeryalH_DE.Value==0 || SeryalB!=txtSeryalH_DE.Value)
            {
                PublicClass.ErrorMesseg(ResourceCode.T077); return;
            }
            EditdgvListB(ListId);
            FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
        }

        private void txtBalanceAccount_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtBalanceAccount.Text==null || txtBalanceAccount.Value==0)
                {
                    CalcComerFilds_();
                    txtAC.Value=AC;
                    txtBalanceAccount.Value=0;
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtBalanceAccountِDraver_Enter(object sender, EventArgs e)
        {
            if (txtBalanceAccountِDraver.Text==null || txtBalanceAccountِDraver.Value==0)
            {
                CalcComerFilds_();
                if (AV!=0)
                    txtAV.Value=AV;
                else
                    txtAV.Value=AX;

                txtBalanceAccountِDraver.Value=0;
            }
        }

        private void txtBalanceAccount_Leave(object sender, EventArgs e)
        {
            CalcComerFilds_();
            txtAC.Value=AC;
            //txtBalanceAccount.Value=AC;
        }

        private void txtBalanceAccountِDraver_Leave(object sender, EventArgs e)
        {
            CalcComerFilds_();
            txtAV.Value=AV;
            //txtBalanceAccountِDraver.Value=AV;
        }

        private void txtBalanceBillLadingAmount_Enter(object sender, EventArgs e)
        {
            if (txtBalanceBillLadingAmount.Text==null || txtBalanceBillLadingAmount.Value==0)
            {
                CalcComerFilds_();
                txtAY.Value=AY;
                txtBalanceBillLadingAmount.Value=0;
            }
        }

        private void txtBalanceBillLadingAmount_Leave(object sender, EventArgs e)
        {
            CalcComerFilds_();
            txtAY.Value=AY;
        }

        private void frmComers_Activated(object sender, EventArgs e)
        {
            //if (FormLoded)
            //{
            //    CallUpdateTataH();
            //    CallUpdateTataB();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDraverH2_Click(object sender, EventArgs e)
        {
            Draver.frmDraver frmDraver = new Draver.frmDraver(this);
            frmDraver.ShowDialog();
            FillcmbDraversH2();

        }

        private void cmbDraversH2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDraversH2.SelectedIndex != -1)
                {
                    DaraverIdH2_ = Convert.ToInt32(cmbDraversH2.Value);
                    using (var db = new DBcontextModel())
                    {
                        var drv = db.Dravers.Where(c => c.Id == DaraverIdH2_).First();
                        cmbDraversH2.Value = drv.Id;
                        var per = db.Customers.Where(c => c.Id == drv.CustomerId).First();
                        lblTelDraver2.Text = per.Tel;
                        //PublicClass.CheckBlacList(per.Id);
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(per.Id);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbDraversH2.SelectedIndex=-1;
                        }



                    }
                    if (DaraverIdH1_==DaraverIdH2_)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T094);
                        cmbDraversH2.SelectedIndex=-1;
                        return;
                    }
                }
                else
                {
                    DaraverIdH2_ = 0;
                    lblTelDraver2.ResetText();
                }
            }
            catch (Exception)
            {
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

        private void btnSelectAppointmentScheduling_Click(object sender, EventArgs e)
        {
            frmAppointmentScheduling f = new frmAppointmentScheduling(this);
            f.isSelectCarPlat=true;
            f.ShowDialog();
        }

        private void frmComers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void uiGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmsDgvH_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            ListId=ListId_;
            switch (e.Command.Key)
            {


                case "Edit":
                    using (var db = new DBcontextModel())
                    {

                        var q = db.ComersHs.Where(c => c.Id == ListId).First();
                        var search = db.ComersBs.Where(c => c.ComersHId == ListId);
                        if (search.Count() != 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T037); return;
                        }
                        FillcmbCarplate();
                        txtDateH.Text = q.date;
                        cmbTypeDocument.Value = q.TypeDocumentId;
                        cmbLoadingOrinig.Value = q.LoadingOrinigId;
                        cmbLoadingLocation.Value = q.LoadingLocationId;
                        cmbUnLoadingOrinig.Value = q.UnLoadingOrinigId;
                        cmbUnLoadingLocation.Value = q.UnLoadingLocationId;
                        cmbCostAccountH.Value = q.CostAccountId;
                        cmbGoodsAccountH.Value = q.GoodsAccountId;
                        cmbSender1.Value = q.SenderId;
                        cmbResiver1.Value = q.ResiverId;
                        cmbSender2.Value = q.Sender2Id;
                        cmbResiver2.Value = q.Resiver2Id;
                        if (q.ShiperId==0)
                            chkStatusLading.Checked = true;
                        cmbShiper.Value = q.ShiperId;


                        {//محاسبه پلاک
                            var cmh = db.ComersHs.Where(c => c.Id == q.Id).First();
                            var cr = db.Cars.Where(c => c.Id == cmh.CarId).First();
                            cmbCarplateH.Value = cr.Id;
                        }

                        cmbDraversH1.Value = q.DaraverId1;
                        DaraverIdH1_=q.DaraverId1;
                        cmbDraversH2.Value=q.DaraverId2;
                        DaraverIdH2_=q.DaraverId2;

                        txtNumberTranferForm.Text = q.RemiaanceSeryal.ToString();

                        cmbProducts.Value = q.ProductsId;
                        txtTruckCapacity.Value = q.LoadWeightCapacity;
                        txtDescriptionH.Text = q.Description;
                        txtCotajNumber.Text = q.CotajNumber.ToString();
                    }
                    break;
                case "Delete":
                    if (!PublicClass.SetPeremission("d1", 1)) return;

                    using (var db = new DBcontextModel())
                    {
                        //this.dgwList.ClearSelection();
                        //this.dgwList.Rows[e.RowIndex].Selected = true;
                        //int r = e.RowIndex;//.ToString();
                        //idsabt = dgwList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //this.Text = idsabt;
                        //this.dgvList.CurrentCell = this.dgvList.Rows[e.RowIndex].Cells[1];
                        //this.contextMenuStrip_dgvListH.Show(this.dgwList, e.Location);


                        var search = db.ComersBs.Where(c => c.ComersHId == ListId);
                        if (search.Count() != 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T038); return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            var q = db.ComersHs.Where(c => c.Id == ListId).First();
                            var dc = db.DocumentBancks.Where(c => c.FormName == "frmComersH" && c.ListInFoemId == ListId).ToList();
                            db.DocumentBancks.RemoveRange(dc);
                            db.ComersHs.Remove(q);
                            PublicClass.CheangStatusCarToComers(q.CarId, false);

                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                            CelearItemsH();

                        }

                    }


                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    string lblCaption = "تاریخ حواله: " + dgvListH.GetRow().Cells["date"].Value.ToString() + " شماره حواله: " + dgvListH.GetRow().Cells["RemiaanceSeryal"].Value.ToString() + " شماره پلاک: " + dgvListH.GetRow().Cells["CarPlat"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name + "H", ListId, lblCaption);
                    FilldgvListH(dgvListH, txtDateStart.Text, txtDateEnd.Text);
                    ListId=0;


                    break;
                case "BillLadingRequests"://ثبت درخواست بارنامه
                    frmBillLadingRequest f = new frmBillLadingRequest(this);
                    f.ComersHId=ListId;
                    f.ShowDialog();
                    ListId=0;


                    break;
                case "CeatComerB"://ثبت بارنامه
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cars.Where(c => c.Id==db.ComersHs.Where(x => x.Id==ListId).FirstOrDefault().CarId).First();
                        ListId=0;
                        uiTab1.TabPages["ComersB"].Selected=true;
                        cmbCarplateB.Text=q.CarPlat+q.CarPlatSeryal;
                        cmbSeryalH_Leave(null, null);
                        txtSeryalB.Focus();
                    }
                    break;
            }
            //ListId=0;
        }

        private void cms_cmsDgvB_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            ListId=ListId_;
            switch (e.Command.Key)
            {
                case "AccountingDocumentRegistration"://سند حسابداری
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Transactions.Where(c => c.ComerBId==ListId);
                        if (q.Count()==0)
                        {
                            AccountingDocumentRegistration(ListId);
                            
                            FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
                        }
                        else
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T110);
                        }
                    }

                    break;
                case "Delete"://حذف
                    //DeletegvListB(ListId);
                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    string lblCaption = "ش بارنامه: " + dgvListB.GetRow().Cells["SeryalB"].Value.ToString() + " س حواله: " + dgvListB.GetRow().Cells["SeryalH"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name + "B", ListId, lblCaption);
                    FilldgvListB(dgvListB, txtDateStart.Text, txtDateEnd.Text, null, txtSearch.Text);
                    break;
            }
            ListId=0;
        }

        /// <summary>
        /// بررسی وضعیت بارنامه: دارد/ندارد
        /// </summary>
        /// <param name="statuslading"></param>
        void StatusLading(bool statuslading)
        {
            if (statuslading)
            {

                panelLanding.Enabled=false;
                txtSeryalB.Enabled=false;
                txtSeryalB.ResetText();
                cmbBillLadingCast.Enabled=false;
                cmbBillLadingCast.Value=3;
                //cmbBillLadingMethod.Value=4;
                cmbBillLadingMethod.SelectedIndex=-1;
                txtBaseFreight.ResetText();
                txtBillLadingAmount.ResetText();
                txtInsuranceAmount.ResetText();
                txtBillLadingWriterPercent.ResetText();
                txtAmountPaidTruckDriver.ResetText();
                //txtOtherBillLadingCosts.ResetText();
                txtBalanceAccountِDraver.ResetText();
                txtAY.ResetText();
            }
            else

            {
                panelLanding.Enabled=true;
                txtSeryalB.Enabled=true;
                cmbBillLadingCast.Enabled=true;
                cmbBillLadingCast.Value=1;
                cmbBillLadingMethod.Value=3;
                //cmbBillLadingCast.ResetText();
                //cmbBillLadingMethod.ResetText();
            }

        }

        private void chkStatusLading_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatusLading.Checked)
            {
                cmbShiper.SelectedIndex=-1;
                cmbShiper.Enabled=false;
            }
            else
            {
                cmbShiper.Enabled=true;
            }
        }

        private void chkPaymentToOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaymentToOthers.Checked)
            {
                txtPaymentToOthers1.Enabled=true;
                //cmbPaymentToOthers.Enabled=true;
                btnPaymentToOthers.Enabled=true;
            }
            else
            {
                txtPaymentToOthers1.Enabled=false;
                btnPaymentToOthers.Enabled=false;
                //cmbPaymentToOthers.Enabled=false;
                txtPaymentToOthers1.ResetText();
            }
            lblPaymentToOthers.ResetText();
            cmbPaymentToOthers.SelectedIndex=-1;
        }

        int PaymentToOthersId_ = 0;
        private void cmbPaymentToOthers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaymentToOthers.SelectedIndex != -1)
                {
                    PaymentToOthersId_ = Convert.ToInt32(cmbPaymentToOthers.Value);
                    bool bl1 = false;
                    bool bl2 = false;
                    string name = "";
                    (bl1, bl2, name)=PublicClass.CheckBlacList(PaymentToOthersId_);
                    if (bl1 && bl2)
                    {
                        PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                        cmbPaymentToOthers.SelectedIndex=-1;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbCostAccountB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCostAccountB.SelectedIndex != -1)
                {
                    CostAccountIdB_ = Convert.ToInt32(cmbCostAccountB.Value);
                    using (var db = new DBcontextModel())
                    {
                        var per = db.Customers.Where(c => c.Id == CostAccountIdB_).First();
                        //lblCostAccountB.Text = per.Tel;
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(CostAccountIdB_);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbCostAccountB.SelectedIndex=-1;
                        }
                    }
                }
                else
                {
                    CostAccountIdB_=0;
                    //lblCostAccountB.ResetText();
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbGoodsAccountB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGoodsAccountB.SelectedIndex != -1)
                {
                    using (var db = new DBcontextModel())
                    {
                        GoodsAccountIdB_ = Convert.ToInt32(cmbGoodsAccountB.Value);
                        var per = db.Customers.Where(c => c.Id == GoodsAccountIdB_).First();
                        //lblGoodsAccountB.Text = per.Tel;
                        bool bl1 = false;
                        bool bl2 = false;
                        string name = "";
                        (bl1, bl2, name)=PublicClass.CheckBlacList(GoodsAccountIdB_);
                        if (bl1 && bl2)
                        {
                            PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                            cmbGoodsAccountB.SelectedIndex=-1;
                        }
                    }
                }
                else
                {
                    GoodsAccountIdB_=0;
                    //lblGoodsAccountB.ResetText();

                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbPaymentToOthers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbPaymentToOthers, dt_PaymentToOthers);
            }

        }
        private void cmbSender2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Sender2Id_ = Convert.ToInt32(cmbSender2.Value);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(Sender2Id_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbSender2.SelectedIndex=-1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbResiver2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Resiver2Id_ = Convert.ToInt32(cmbResiver2.Value);
                bool bl1 = false;
                bool bl2 = false;
                string name = "";
                (bl1, bl2, name)=PublicClass.CheckBlacList(Resiver2Id_);
                if (bl1 && bl2)
                {
                    PublicClass.StopMesseg(ResourceCode.T101+'\n'+name);
                    cmbResiver2.SelectedIndex=-1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPaymentToOthers_Click(object sender, EventArgs e)
        {
            frmDetailedAccount f = new frmDetailedAccount(this);
            f.IsRequest=true;
            f.ShowDialog();
        }

        private void txtBalanceAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.Insert)
            {
                CalcComerFilds_();
                //txtAC.Value=AC;
                txtBalanceAccount.Value=AC;
            }
        }

        private void txtBalanceBillLadingAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.Insert)
            {
                CalcComerFilds_();
                //txtAY.Value=AY;
                txtBalanceBillLadingAmount.Value=AY;
            }
        }

        private void txtBalanceAccountِDraver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.Insert)
            {
                CalcComerFilds_();
                //txtAV.Value=AV;
                txtBalanceAccountِDraver.Value=AV;
            }
        }

        private void cmbBillLadingCast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //SendKeys.Send("{TAB}");
                txtDescriptionB.Focus();

        }

        private void txtDescriptionB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //SendKeys.Send("{TAB}");
                txtFreightRate.Focus();

        }

        private void txtPaymentToOthers2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void cmbSenderB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSenderB2, dt_cmbSenderB2);
            }
        }

        private void cmbResiverB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbResiverB1, dt_ResiverB1);
            }
        }

        private void cmbResiverB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbResiverB2, dt_ResiverB2);
            }

        }

        private void cmbGoodsAccountB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbGoodsAccountB, dt_GoodsAccountB);
            }
        }

        private void cmbCostAccountB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCostAccountB, dt_CostAccountB);
            }
        }

        private void txtDateB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //SendKeys.Send("{TAB}");
                txtSeryalB.Focus();
        }

        private void txtCargoInsurance_ValueChanged(object sender, EventArgs e)
        {
            txtInsuranceAmount.Value=txtCargoInsurance.Value;
        }

        private void cmbProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbProducts, dt_Products);

            }

        }

        //private void cmbCostAccountH_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        SendKeys.Send("{TAB}");

        //    if (e.KeyCode == Keys.F2)
        //    {
        //        PublicClass.SearchCmbId(cmbCostAccountH, dt_CostAccountH);

        //    }

        //}

        private void cmbGoodsAccountH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbGoodsAccountH, dt_GoodsAccountH);

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

        private void cmbShiper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbShiper, dt_Shiper);

            }

        }

        private void cmbCostAccountH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCostAccountH, dt_CostAccountH);
            }

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void lblCarOwnerShip_Click(object sender, EventArgs e)
        {

        }

        private void chkIncomeDocument_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkIncomeDocument.Checked)
            {
                rdbCostAccount.Enabled=chkIncomeDocument.Checked;
                rdbShiper.Enabled=chkIncomeDocument.Checked;
            }
        }
    }
}

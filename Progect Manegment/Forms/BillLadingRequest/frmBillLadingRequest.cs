using FontAwesome.Sharp;

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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HM_ERP_System.Forms.BillLadingRequest
{
    /// <summary>
    /// فـــرم درخواست بارنامه به بارنامه نویس
    /// </summary>
    public partial class frmBillLadingRequest : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        int UserId_ = PublicClass.UserId;

        public int ComersHId = 1;
        public frmBillLadingRequest(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmBillLadingRequest_Load(object sender, EventArgs e)
        {

            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            pnlAddItems.Visible=false;

            UpdateData();
        }

        public void UpdateData()
        {
            FillcmbShiper();
            //FillItemsInfo();
            FilldgvListH();
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
                            };
                    cmbShiper.DataSource = q.ToList();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillItemsInfo()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = (from cm in db.ComersHs

                             join lo in db.Ciltys
                             on cm.LoadingOrinigId equals lo.Id

                             join ll in db.PlaceTransfers
                             on cm.LoadingLocationId equals ll.Id

                             join ct_ll in db.Ciltys
                             on ll.CiltyId equals ct_ll.Id

                             join ulo in db.Ciltys
                             on cm.UnLoadingOrinigId equals ulo.Id

                             join ull in db.PlaceTransfers
                             on cm.UnLoadingLocationId equals ull.Id

                             join ct_ull in db.Ciltys
                             on ull.CiltyId equals ct_ull.Id

                             join cr1 in db.Dravers
                             on cm.DaraverId1 equals cr1.Id

                             join cr2 in db.Dravers
                            on cm.DaraverId2 equals cr2.Id

                             join dr1 in db.Customers
                             on cr1.CustomerId equals dr1.Id

                             join dr2 in db.Customers
                             on cr2.CustomerId equals dr2.Id

                             join pr in db.Products
                             on cm.ProductsId equals pr.Id

                             join sn in db.Customers
                             on cm.SenderId equals sn.Id

                             join rs in db.Customers
                             on cm.ResiverId equals rs.Id

                             //join sh in db.Customers
                             //on cm.ShiperId equals sh.Id

                             where cm.Id==ComersHId


                             select new
                             {
                                 dr1,
                                 dr2,
                                 cm,
                                 lo,
                                 ulo,
                                 //cr1,
                                 //cr2,
                                 pr,
                                 //ct_ll,
                                 //ct_ull,
                                 ull,
                                 ll,
                                 sn,
                                 rs,
                                 //sh,

                             }).First();

                    //lblLoadingOrinig.Text=q.lo.Name+" - "+q.ll.Name;
                    //lblUnLoadingOrinig.Text=q.ulo.Name+" - "+q.ull.Name;
                    //lblSender.Text=(q.sn.Name+" "+q.sn.Family).Trim()+" - "+q.sn.Tel;
                    //lblReciver.Text=(q.rs.Name+" "+q.rs.Family).Trim()+" - "+q.rs.Tel;
                    //lblDraver1.Text=(q.dr1.Name+" "+q.dr1.Family).Trim()+" - "+q.dr1.Tel;
                    //lblDraver2.Text=(q.dr2.Name+" "+q.dr2.Family).Trim()+" - "+q.dr2.Tel;
                    //lblProdectName.Text=q.pr.Name;
                    //cmbComersH.Value=q.cm.Id;
                    cmbShiper.Value=q.cm.ShiperId;
                }

            }
            catch (Exception er)
            {
                //PublicClass.ShowErrorMessage(er);
            }
        }

        private void FilldgvListH()
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

                            join sr in db.Customers
                            on cmh.SenderId equals sr.Id

                            join rs in db.Customers
                            on cmh.ResiverId equals rs.Id

                            join dr1 in db.Dravers
                            on cmh.DaraverId1 equals dr1.Id

                            join cu1 in db.Customers
                            on dr1.CustomerId equals cu1.Id

                            join dr2 in db.Dravers
                            on cmh.DaraverId2 equals dr2.Id

                            join cu2 in db.Customers
                            on dr2.CustomerId equals cu2.Id

                            join pr in db.Products
                            on cmh.ProductsId equals pr.Id

                            join cr in db.Cars
                            on cmh.CarId equals cr.Id

                            join doc in db.DocumentBancks
                            on cmh.Id equals doc.ListInFoemId into docGroup

                            join sh in db.Customers
                            on cmh.ShiperId equals sh.Id into shGroup
                            from shLeft in shGroup.DefaultIfEmpty()

                            where !cmh.StatusLading  &&  string.Compare(cmh.date, txtDateStart.Text) >= 0 && string.Compare(cmh.date, txtDateEnd.Text) <= 0 && cmh.DH_StatusRejistered==chkSended.Checked

                            //orderby cmh.Id descending

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
                                SenderName = (sr.Family + " " + sr.Name).Trim(),
                                ResiverName = (rs.Family + " " + rs.Name).Trim(),
                                DaraverName1 = (cu1.Family + " " + cu1.Name).Trim(),
                                DaraverName2 = (cu2.Family + " " + cu2.Name).Trim(),
                                ProductsName = pr.Name,
                                CarPlat = cr.CarPlat + "-" + cr.CarPlatSeryal,
                                cmh.RemiaanceSeryal,
                                cmh.LoadWeightCapacity,
                                cmh.Description,
                                cmh.CotajNumber,
                                cmh.DH_FreightCharge,
                                cmh.DH_LoadWeight,
                                cmh.DH_PriceGoods,
                                cmh.DH_SealNumber,
                                cmh.DH_StatusRejistered
                            };
                    dgvListH.DataSource = q.ToList();
                    dgvListH.AutoSizeColumns();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


        int ShiperId_ = 0;
        private void cmbShiper_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ShiperId_ = Convert.ToInt32(cmbShiper.Value);

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

        private void dgvListH_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvListH.CurrentRow.Cells["Id"].Value);


                if (e.Column.Key == "SendMessageToShiper")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.ComersHs.Where(c => c.Id == ListId).First();
                        
                        var search = db.ComersBs.Where(c => c.ComersHId == ListId);
                        if (search.Count() != 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T037); return;
                        }
                        cmbShiper.Value = q.ShiperId;
                        lblTelDraver1.Text=q.RemiaanceSeryal.ToString();
                        txtDH_LoadWeight.Text=q.DH_LoadWeight.ToString();
                        txtDH_SealNumber.Text=q.DH_SealNumber.ToString();
                        txtDH_FreightCharge.Text=q.DH_FreightCharge.ToString();
                        txtDH_PriceGoods.Text=q.DH_PriceGoods.ToString();
                        chkDH_StatusRejistered.Checked=q.DH_StatusRejistered;

                        txtMessage.ResetText();
                        txtDH_LoadWeight.Focus();
                        pnlAddItems.Visible=true;
                        //pnlAddItemFoter.Visible=true;
                        //PanelH.Visible=true;
                        //PanelM.Visible=false;
                    }

                }

                else if (e.Column.Key == "AddDocumentToBanck")//ثبت مدارک
                {
                    string lblCaption = "تاریخ حواله: " + dgvListH.GetRow().Cells["date"].Value.ToString() + " شماره حواله: " + dgvListH.GetRow().Cells["RemiaanceSeryal"].Value.ToString() + " شماره پلاک: " + dgvListH.GetRow().Cells["CarPlat"].Value.ToString();

                    PublicClass.AddDocumentToBanck("frmComersH", ListId, lblCaption);
                    FilldgvListH();
                }
                else if (e.Column.Key == "SendMessageToShiper")//ارسال اطلاعات حواله به بارنامه نویس
                {
                    PanelM.Visible=true;
                    pnlAddItemFoter.Visible=false;
                    PanelH.Visible=false;

                    creatMessagText(ListId);

                    //
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// ایجاد پیام برای بارنامه نویس
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void creatMessagText(int listId)
        {
            string txt = "";
            using (var db = new DBcontextModel())
            {
                
                var q = db.ComersHs.Where(c => c.Id==ListId).First();

                var ctS = db.Ciltys.Where(c => c.Id==q.LoadingOrinigId).First().Name;
                var llS = db.PlaceTransfers.Where(c => c.Id==q.LoadingLocationId).First();
                var ctE = db.Ciltys.Where(c => c.Id==q.UnLoadingOrinigId).First().Name;
                var llE = db.PlaceTransfers.Where(c => c.Id==q.UnLoadingLocationId).First();
                var sender1=db.Customers.Where(c=>c.Id==q.SenderId).First();
                var sender2=db.Customers.Where(c=>c.Id==q.Sender2Id);
                var Reciver1=db.Customers.Where(c=>c.Id==q.ResiverId).First();
                var Reciver2 = db.Customers.Where(c=>c.Id==q.Resiver2Id);
                var Draver1 = db.Customers.Where(c=>c.Id==db.Dravers.Where(x=>x.Id==q.DaraverId1).FirstOrDefault().CustomerId).First();
                var Draver2 = db.Customers.Where(c=>c.Id==db.Dravers.Where(x => x.Id==q.DaraverId2).FirstOrDefault().CustomerId).First();

                lblCaption.Text="اطلاعات مربوط به حواله: "+q.RemiaanceSeryal;


                txt+="▪ مـبداء: شهر " +ctS+" - محل بارگیری: "  +llS.Name + " - آدرس: "+llS.Addres+" - کد پستی: "+llS.PostalCode+'\n';
                
                txt+="▪ مـقصد: شهر " +ctE+" - محل تخلیه: "  +llE.Name + " - آدرس: "+llE.Addres+" - کد پستی: "+llE.PostalCode+'\n';

                txt+="▪ فـرستنده: "+ sender1.Name+" "+sender1.Family+" با " +" کد/شناسه ملی: "+sender1.CodMeli +  (sender2.Count()!=0 ? " و "+ sender2.First().Name+" " +sender2.First().Family + " با " +" کد/شناسه ملی: "+sender2.First().CodMeli : "")+'\n';
                
                txt+="▪ گیرنده: "+ Reciver1.Name+" "+Reciver1.Family +" با " +" کد/شناسه ملی: "+Reciver1.CodMeli+  (Reciver2.Count()!=0 ? " و " + Reciver2.First().Name+" " +Reciver2.First().Family+" با " +" کد/شناسه ملی: "+Reciver2.First().CodMeli : "")+'\n';
                
                txt+="▪ کالا: "+db.Products.Where(c=>c.Id==q.ProductsId).First().Name+'\n';
                
                txt+="▪ کرایه حمل: "+q.DH_FreightCharge.ToString("#,##")+" ریال"+'\n';
                
                txt+="▪ ارزش(بهاء) کالا: "+q.DH_PriceGoods.ToString("#,##")+" ریال"+'\n';
                
                txt+="▪ راننـده اول: "+Draver1.Name+" "+Draver1.Family+" با کد ملی: "+Draver1.CodMeli +" ، تلفن: "+Draver1.Tel+'\n';
                
                txt+="▪ راننـده دوم: "+Draver2.Name+" "+Draver2.Family+" با کد ملی: "+Draver2.CodMeli +" ، تلفن: "+Draver2.Tel+'\n';
               
                txt+="▪ وزن بـار: "+q.DH_LoadWeight.ToString()+" کیلوگرم"+'\n';
                
                txt+="▪ پلمپ ها: "+q.DH_SealNumber+'\n';
                
                txt+="▪ توضیحــات: "+q.Description.ToString()+'\n';


            }
            txtMessage.Text=txt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PublicClass.FindEmptyControls(txtDH_LoadWeight, ResourceCode.T085, txtDH_SealNumber, ResourceCode.T086, txtDH_FreightCharge, ResourceCode.T087, txtDH_PriceGoods, ResourceCode.T088)) return;
            
            if (cmbShiper.SelectedIndex==-1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T089); return;
            }


            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            using (var db = new DBcontextModel())
            {
                var q = db.ComersHs.Where(c => c.Id==ListId).First();
                q.DH_LoadWeight=Convert.ToInt32(txtDH_LoadWeight.Text);
                q.DH_SealNumber=txtDH_SealNumber.Text;
                q.DH_FreightCharge= Convert.ToDouble(txtDH_FreightCharge.TextSimple);
                q.DH_PriceGoods= Convert.ToDouble(txtDH_PriceGoods.TextSimple);
                q.ShiperId=ShiperId_;
                q.DH_StatusRejistered=chkDH_StatusRejistered.Checked;
                db.SaveChanges();
                PublicClass.WindowAlart("1");
                FilldgvListH();
                
                creatMessagText(ListId);
                //CelearItems();
            }
        }

        private void CelearItems()
        {
            txtDH_LoadWeight.ResetText();
            txtDH_SealNumber.ResetText();
            txtDH_FreightCharge.ResetText();
            txtDH_PriceGoods.ResetText();
            chkDH_StatusRejistered.Checked=false;
            cmbShiper.SelectedIndex=-1;
            pnlAddItemFoter.Visible=false;
            PanelH.Visible=false;

        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvListH();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T109, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using(var db=new DBcontextModel())
            {
                var q = db.ComersHs.Where(c => c.Id==ListId).First();
                q.DH_StatusRejistered=true;
                db.SaveChanges();
                FilldgvListH();
                PublicClass.WindowAlart("1");
            }
            PanelM.Visible=false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtMessage.SelectedText);
            }
            catch (Exception)
            {
                PublicClass.ErrorMesseg("هیچ متنی جهت کپی انتخاب نشد");
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtMessage.Text=Clipboard.GetText();
        }

        private void lblTelDraver1_Click(object sender, EventArgs e)
        {

        }

        private void frmBillLadingRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void chkSended_CheckedChanged(object sender, EventArgs e)
        {
            FilldgvListH();
        }

        private void btnCratMessage_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);  
            
            //creatMessagText(ListId);
        }

        private void txtDH_LoadWeight_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void btnAddPerson5_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer frmCustomer = new Customer.frmCustomer(this);
            frmCustomer.ShowDialog();
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvListH.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}

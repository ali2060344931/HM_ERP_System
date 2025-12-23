using BotProgram;

using DevComponents.DotNetBar;

using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Banck;
using HM_ERP_System.Forms.Accounts.Banck;
using HM_ERP_System.Forms.Accounts.Cheque;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.Accounts.RecevingPayment;
using HM_ERP_System.Forms.Accounts.ReviewAccounts;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Accounts.TotalAccount;
using HM_ERP_System.Forms.Accounts.Transaction;
using HM_ERP_System.Forms.Accounts.TransferBetweenBanks;
using HM_ERP_System.Forms.Accounts.TransferBetweenPersons;
using HM_ERP_System.Forms.AppointmentScheduling;
using HM_ERP_System.Forms.BlacList;
using HM_ERP_System.Forms.Calendar;
using HM_ERP_System.Forms.Car;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Commission;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.CustomerToGroup;
using HM_ERP_System.Forms.Draver;
using HM_ERP_System.Forms.FinancialYears;
using HM_ERP_System.Forms.Peremission;
using HM_ERP_System.Forms.PersonGroup;
using HM_ERP_System.Forms.PlaceTransfer;
using HM_ERP_System.Forms.Product;
using HM_ERP_System.Forms.PurchaseTanker;
using HM_ERP_System.Forms.Reports;
using HM_ERP_System.Forms.Settings;
using HM_ERP_System.Forms.TankerRental;
using HM_ERP_System.Forms.User;
using HM_ERP_System.Forms.Warehouse;

using MyClass;

using Progect_Manegment;

using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Main_Form
{
    public partial class frmMainForm : frmMasterForm, IUpdatableForms
    {

        public int UsersId = 0;
        [Obsolete]
        public frmMainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            BaleBotClass.RunTelegram();

        }
        public void UpdateData()
        {
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = ResourceCode.ProgName;
                WindowState = FormWindowState.Maximized;
                IsMdiContainer = true;
                {
                    tabStrip1.AutoSelectAttachedControl = true;
                    tabStrip1.CanReorderTabs = true;
                    tabStrip1.CloseButtonOnTabsVisible = true;
                    tabStrip1.CloseButtonVisible = false;
                    tabStrip1.Dock = DockStyle.Top;
                    tabStrip1.Location = new Point(0, 50);
                    tabStrip1.MdiTabbedDocuments = true;
                    tabStrip1.Name = "tabStrip1";
                    tabStrip1.SelectedTab = null;
                    tabStrip1.SelectedTabFont = new Font("Tahoma", 10F, 0, GraphicsUnit.Point, 0);//Microsoft Sans Tahoma
                    tabStrip1.Size = new Size(512, 26);
                    tabStrip1.Style = eTabStripStyle.OneNote;
                    tabStrip1.TabAlignment = eTabStripAlignment.Top;
                    tabStrip1.TabIndex = 6;
                    tabStrip1.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
                    tabStrip1.Text = "tabStrip1";
                }
                tabStrip1.MdiForm = this;
                setPeremissions();//تنظیمات سطوح دسترسی
                SetRibbonStatusBar();

               MetohdsClass.SendMessageForAdminAsync("✅برنامه اجرا شد", lblUserName.Text);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void SetRibbonStatusBar()
        {
            using (var db = new DBcontextModel())
            {
                int UserId = PublicClass.UserId;
                var q = db.CustomerRoles.Where(c => c.Id == UserId).First();
                var UserName = db.Customers.Where(c => c.Id == q.CustomerId).First();
                var RoleName = db.Roles.Where(c => c.Id == q.RoleId).First();
                lblUserName.Text = "نام کاربر: " + UserName.Name + "" + UserName.Family;
                lblUserRole.Text = "نوع کاربری: " + RoleName.Name;
                lblDate.Text = "تاریخ: " + PersianDate.NowPersianDate;
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                lblVersion_.Text = "نسخه برنامه: " + version.ToString();
            }
        }

        /// <summary>
        /// تنظیمات سطوح دسترسی های کاربران
        /// </summary>
        public void setPeremissions()
        {
            try
            {
                {
                    using (var db = new DBcontextModel())
                    {
                        if (db.Peremissions.Count() == 0) return;
                    }

                    //حمل و نقل
                    ribbon1.Tabs["Transportation"].Visible = PublicClass.SetPeremission("Node1");
                    {
                        ribbon1.Tabs["Transportation"].Groups["Definitions"].Visible = PublicClass.SetPeremission("Node1_1");
                        //تعاریف
                        {
                            //گروه اشخاص
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["PersonGroup"].Visible = PublicClass.SetPeremission("Node1_1_7");
                            //گروه بندی اشخاص
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["CustomToGroup"].Visible = PublicClass.SetPeremission("Node1_1_8");
                            //اشخاص
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["Customers"].Visible = PublicClass.SetPeremission("Node1_1_1");
                            //راننده ها
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["Dravers"].Visible = PublicClass.SetPeremission("Node1_1_2");
                            //ناوگان ها
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["Cars"].Visible = PublicClass.SetPeremission("Node1_1_3");
                            //محل های بارگیری، تخلیه
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["PlaceTransfers"].Visible = PublicClass.SetPeremission("Node1_1_4");
                            //کـــالاهـــا
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["Products"].Visible = PublicClass.SetPeremission("Node1_1_5");
                            //شهرها
                            ribbon1.Tabs["Transportation"].Groups["Definitions"].Commands["Ciltys"].Visible = PublicClass.SetPeremission("Node1_1_6");
                        }

                        //ثبت اسناد
                        ribbon1.Tabs["Transportation"].Groups["OperationRegistration"].Visible = PublicClass.SetPeremission("Node1_2");
                        {
                            //ثبت حواله و بارنامه
                            ribbon1.Tabs["Transportation"].Groups["OperationRegistration"].Commands["Comers"].Visible = PublicClass.SetPeremission("Node1_2_1");
                            //پورســـانت
                            ribbon1.Tabs["Transportation"].Groups["OperationRegistration"].Commands["Commission"].Visible = PublicClass.SetPeremission("Node1_2_2");
                            //نوبت دهی کامیون ها
                            ribbon1.Tabs["Transportation"].Groups["OperationRegistration"].Commands["AppointmentScheduling"].Visible = PublicClass.SetPeremission("Node1_2_3");
                            //لیست سیاه
                            ribbon1.Tabs["Transportation"].Groups["OperationRegistration"].Commands["BlacList"].Visible = PublicClass.SetPeremission("Node1_2_4");
                        }

                        ////گزارشات
                        ribbon1.Tabs["Transportation"].Groups["Reports"].Visible = PublicClass.SetPeremission("Node1_3");
                        {
                            //لیست حـــواله ها
                            ribbon1.Tabs["Transportation"].Groups["Reports"].Commands["ShowListComersH"].Visible = PublicClass.SetPeremission("Node1_3_1");
                            //لیست بــارنامه ها
                            ribbon1.Tabs["Transportation"].Groups["Reports"].Commands["ShowListComersB"].Visible = PublicClass.SetPeremission("Node1_3_2");
                            //لیست پورسانت ها
                            ribbon1.Tabs["Transportation"].Groups["Reports"].Commands["ShowListCommission"].Visible = PublicClass.SetPeremission("Node1_3_3");
                        }
                    }

                    //حسابداری
                    ribbon1.Tabs["Accounting"].Visible = PublicClass.SetPeremission("Node2");
                    {
                        //تعاریف
                        ribbon1.Tabs["Accounting"].Groups["Definitions"].Visible = PublicClass.SetPeremission("Node2_1");
                        {
                            //گروه اشخاص
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["AddCustomAc"].Visible = PublicClass.SetPeremission("Node2_1_1");
                            //حساب های بانکی
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["AddBancksAc"].Visible = PublicClass.SetPeremission("Node2_1_2");
                            //صنــــــــــــــــدوق ها
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["AddCofersAc"].Visible = PublicClass.SetPeremission("Node2_1_3");
                            //حساب های کـــــــــــــــــــل
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["TotalAccounts"].Visible = PublicClass.SetPeremission("Node2_1_4");
                            //حساب های معیـــــــــــن
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["SpecficAccounts"].Visible = PublicClass.SetPeremission("Node2_1_5");
                            //حساب های تفصیلی
                            ribbon1.Tabs["Accounting"].Groups["Definitions"].Commands["DetailedAccount"].Visible = PublicClass.SetPeremission("Node2_1_6");
                        }

                        //ثبت عملیات
                        ribbon1.Tabs["Accounting"].Groups["OperationRegistration"].Visible = PublicClass.SetPeremission("Node2_2");
                        {
                            //درآمـــد(فروش) هــــزینه(خرید)
                            ribbon1.Tabs["Accounting"].Groups["OperationRegistration"].Commands["TransactionIE"].Visible = PublicClass.SetPeremission("Node2_2_1");
                        }

                        //گزارشــــــات
                        ribbon1.Tabs["Accounting"].Groups["Reports"].Visible = PublicClass.SetPeremission("Node2_3");
                        {
                            //مـــــرور حسابها
                            ribbon1.Tabs["Accounting"].Groups["Reports"].Commands["ReviewAccounts"].Visible = PublicClass.SetPeremission("Node2_3_1");
                        }

                    }

                    ////خزانه
                    ribbon1.Tabs["Treasury"].Visible = PublicClass.SetPeremission("Node3");
                    {
                        //تعاریف
                        ribbon1.Tabs["Treasury"].Groups["Definitions"].Visible = PublicClass.SetPeremission("Node3_1");
                        {
                            //اشخاص
                            ribbon1.Tabs["Treasury"].Groups["Definitions"].Commands["Customers"].Visible = PublicClass.SetPeremission("Node3_1_1");
                            //بانک ها
                            ribbon1.Tabs["Treasury"].Groups["Definitions"].Commands["Bancks"].Visible = PublicClass.SetPeremission("Node3_1_2");
                            //حساب های بانکی
                            ribbon1.Tabs["Treasury"].Groups["Definitions"].Commands["AccountBancks"].Visible = PublicClass.SetPeremission("Node3_1_3");
                            //صندوق ها
                            ribbon1.Tabs["Treasury"].Groups["Definitions"].Commands["Cofers"].Visible = PublicClass.SetPeremission("Node3_1_4");
                        }

                        //ثبت اسناد
                        ribbon1.Tabs["Treasury"].Groups["OperationRegistration"].Visible = PublicClass.SetPeremission("Node3_2");
                        {
                            //دریافت  پرداخت
                            ribbon1.Tabs["Treasury"].Groups["OperationRegistration"].Commands["Receving_Payment"].Visible = PublicClass.SetPeremission("Node3_2_1");
                            //جابجایی بین اشخــــــــاص
                            ribbon1.Tabs["Treasury"].Groups["OperationRegistration"].Commands["TransferBetweenPersons"].Visible = PublicClass.SetPeremission("Node3_2_2");
                            //جابجایی بین بانــــــــــــک ها
                            ribbon1.Tabs["Treasury"].Groups["OperationRegistration"].Commands["TransferBetweenBanks"].Visible = PublicClass.SetPeremission("Node3_2_3");
                        }

                        //امکانات
                        ribbon1.Tabs["Treasury"].Groups["Facilities"].Visible = PublicClass.SetPeremission("Node3_3");
                        {
                            //مـــرور حســـاب ها
                            ribbon1.Tabs["Treasury"].Groups["Facilities"].Commands["ReviewAccounts2"].Visible = PublicClass.SetPeremission("Node3_3_1");
                            //مدیریت چک ها
                            ribbon1.Tabs["Treasury"].Groups["Facilities"].Commands["RegCheques"].Visible = PublicClass.SetPeremission("Node3_3_2");
                        }
                    }

                    ////یدک
                    ribbon1.Tabs["Spare"].Visible = PublicClass.SetPeremission("Node4");
                    {
                        //تعاریف
                        ribbon1.Tabs["Spare"].Groups["Definitions"].Visible = PublicClass.SetPeremission("Node4_1");
                        {
                            //اجاره تانکرها
                            ribbon1.Tabs["Spare"].Groups["Definitions"].Commands["TankerRental"].Visible = PublicClass.SetPeremission("Node4_1_1");
                            //خرید تانکرها
                            ribbon1.Tabs["Spare"].Groups["Definitions"].Commands["TenkerPurchase"].Visible = PublicClass.SetPeremission("Node4_1_2");
                        }
                    }

                    //تنظیمات
                    ribbon1.Tabs["Setings"].Visible = PublicClass.SetPeremission("Node5");
                    {
                        //بخش امنیتی نـــرم افـــزار
                        ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Visible = PublicClass.SetPeremission("Node5_1");
                        {
                            //ثبت کاربران سیستم
                            //ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Commands["RegisteringSystemUsers"].Visible = PublicClass.SetPeremission("Node5_1_1");
                            //مدیریت سطوح دسترسی
                            //ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Commands["AccessLevelManagement"].Visible = PublicClass.SetPeremission("Node5_1_2");
                        }
                        //تنظیمات نرم افزار
                        ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Visible = PublicClass.SetPeremission("Node5_2");
                        {
                            //تنظیمات نرم افزار
                            ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Commands["SoftwareSettings"].Visible = PublicClass.SetPeremission("Node5_2_1");
                            //تعریف سال مالی
                            ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Commands["DefinitionFiscalYear"].Visible = PublicClass.SetPeremission("Node5_2_2");
                        }
                    }

                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void buttonCommand1_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCustomer>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void buttonCommand2_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmDraver>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void buttonCommand3_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCar>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void buttonCommand5_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCiltys>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void buttonCommand6_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmPlaceTransfer>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void buttonCommand4_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmProduct>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void btnComers_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmComers>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnDeledeTables_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            PublicClass.CelereTables();
        }

        private void buttonCommand7_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmUser>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnPeremission_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmPeremission>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void btnTotalAccount_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmTotalAccount>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnSpecficAccount_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmSpecificAccount>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnCalculater_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            //ToDo اجرای برنامه های بیرون از نرم افزار
            Process.Start("calc.exe");

        }

        /// <summary>
        /// جهت ثبت حساب های بانک و صندوق
        /// </summary>
        private void buttonCommand8_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmContraAccounts>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnCustomers_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCustomer>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnTransactionIE_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmTransaction>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void btnRecevingPayment_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmRecevingPaymentNew>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void btnSettingProg_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmSettings>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        /// <summary>
        /// نمایش فرم حساب های تفصیلی
        /// </summary>
        private void btnDetailedAccount_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmDetailedAccount>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnAppointmentScheduling_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmAppointmentScheduling>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnPersonGroup_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmPersonGroup>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnCustomToGroup_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCustomerToGroup>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnBlacList_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmBlacList>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void frmMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                buttonCommand16_Click(null, null);
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F12)
            {
                ribbon1.Tabs["Setings"].Visible = true;
                {
                    //بخش امنیتی نـــرم افـــزار
                    ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Visible = true;
                    {
                        //ثبت کاربران سیستم
                        ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Commands["RegisteringSystemUsers"].Visible = true;
                        //مدیریت سطوح دسترسی
                        ribbon1.Tabs["Setings"].Groups["SoftwareSecuritySection"].Commands["AccessLevelManagement"].Visible = true;
                    }
                    //تنظیمات نرم افزار
                    ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Visible = true;
                    {
                        //تنظیمات نرم افزار
                        ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Commands["SoftwareSettings"].Visible = true;
                        //تعریف سال مالی
                        ribbon1.Tabs["Setings"].Groups["SoftwareSettings"].Commands["DefinitionFiscalYear"].Visible = true;
                    }
                }

            }


        }
        private void btnTankerRental_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmTankerRental>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnReceving_Payment_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmRecevingPaymentNew>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        /// <summary>
        /// ثبت چک ها
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegCheques_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
        }
        frmPurchase_Tanker frmPurchase_Tanker;
        private void btnTenkerPurchase_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmPurchase_Tanker>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnFinancialYears_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmFinancialYears>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnTransferBetweenPersons_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmTransferBetweenPersons>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }
        private void btnTransferBetweenBanks_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmTransferBetweenBanks>(this, this.ActiveMdiChild);
        }

        private void btnAddCustomAc_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            buttonCommand1_Click(null, null);
        }

        private void btnAddBancksAc_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id = 3;
            f.SpecificAccountCode = 10102;//بانک
            f.ShowList(3);
            f.ShowDialog();
        }

        private void btnAddCofersAc_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id = 4;
            f.SpecificAccountCode = 10101;//صندوق
            f.ShowList(4);
            f.ShowDialog();
        }
        private void btnBancks_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmBankBranch>(this, this.ActiveMdiChild);
        }
        frmReviewAccounts frmReviewAccounts;
        private void btnReviewAccounts_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmReviewAccounts>(this, this.ActiveMdiChild);
        }

        private void btnReviewAccounts2_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            btnReviewAccounts_Click(null, null);
        }

        private void buttonCommand16_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T151, MyClass.PublicClass.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();

        }

        private void buttonCommand14_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            btnAddBancksAc_Click(null, null);
        }

        private void buttonCommand15_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            btnAddCofersAc_Click(null, null);
        }

        private void buttonCommand10_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            MessageBox.Show("این آیتم در دست طراحی می باشد");
        }

        private void buttonCommand9_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            buttonCommand1_Click(null, null);
        }

        private void buttonCommand17_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCommission>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void btnRepCustomer1_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmReport f = new frmReport();
            f.Cod = "0";
            //f.Condition="";
            f.DateReport = "گزارش از تاریخ: " + "1404/01/01" + "  تا تاریخ: " + "1404/05/25";
            f.ShowDialog();
        }

        private void btnShowListComersH_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmComersList frmComersList = new frmComersList();
            frmComersList.FormName = "ComersH";
            frmComersList.ShowDialog();
        }

        private void btnShowListComersB_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmComersList frmComersList = new frmComersList();
            frmComersList.FormName = "ComersB";
            frmComersList.ShowDialog();

        }

        private void btnShowListCommission_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmComersList frmComersList = new frmComersList();
            frmComersList.FormName = "Commission";
            frmComersList.ShowDialog();

        }
       
        private void btnExitProgram_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T151, MyClass.PublicClass.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
               MetohdsClass.SendMessageForAdminAsync("❌برنامه بسته شد", lblUserName.Text);
                Application.Exit();
            }
        }

        private void btnRegCheques__Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmCheque>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void buttonCommand19_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmProduct>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void buttonCommand10_Click_1(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FormManager.ShowMdiChildForm<frmWarehouse>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
        }

        private void lblDate_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmCalendar f = new frmCalendar();

            //// گرفتن موقعیت فعلی موس
            //var mousePos = Cursor.Position;

            //// تعیین مختصات: چپ + پایین موس
            //int x = mousePos.X - f.Width - 10;
            //int y = mousePos.Y + 10;

            //// اگر سمت چپ صفحه بیرون زد → اصلاح
            //if (x < 0) x = 10;

            //f.Location = new Point(x, y);

            f.ShowDialog();
        }
    }
}

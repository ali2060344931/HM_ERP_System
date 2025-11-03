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

using MyClass;

using Progect_Manegment;

using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Main_Form
{
    public partial class frmMainForm : frmMasterForm, IUpdatableForms
    {

        public int UsersId = 0;

        public frmMainForm()
        {
            InitializeComponent();
            this.KeyPreview=true;
        }
        public void UpdateData()
        {
        }
        /*
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
       */
        private void frmMainForm_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text=ResourceCode.ProgName;
                WindowState= FormWindowState.Maximized;
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
                var q = db.CustomerRoles.Where(c => c.Id==UserId).First();
                var UserName = db.Customers.Where(c => c.Id==q.CustomerId).First();
                var RoleName = db.Roles.Where(c => c.Id==q.RoleId).First();
                lblUserName.Text="نام کاربر: "+UserName.Name+ ""+UserName.Family;
                lblUserRole.Text="نوع کاربری: "+RoleName.Name;
                lblDate.Text="تاریخ: "+ PersianDate.NowPersianDate;
            }
        }

        /// <summary>
        /// تنظیمات سطوح دسترسی ها
        /// </summary>
        public void setPeremissions()
        {
            {
                using (var db = new DBcontextModel())
                {
                    if (db.Peremissions.Count()==0) return;
                }
                //حمل و نقل
                ribbon1.Tabs["Transportation"].Visible =PublicClass.SetPeremission("Node1");
                {
                    //حمل و نقل-تعاریف
                    ribbon1.Tabs["Transportation"].Groups["Definitions"].Visible=PublicClass.SetPeremission("Node1_1");
                }


                //حسابداری
                ribbon1.Tabs["Accounting"].Visible =PublicClass.SetPeremission("Node2");
                {

                }
                ////خزانه
                //ribbon1.Tabs["Treasury"].Visible =PublicClass.SetPeremission("Node5");
                //{
                //}
                ////یدک
                //ribbon1.Tabs["Spare"].Visible =PublicClass.SetPeremission("Node6");
                //{
                //}

                //تنظیمات
                ribbon1.Tabs["Setings"].Visible =PublicClass.SetPeremission("Node4");
                {
                }

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
            if (e.Modifiers==Keys.Control && e.KeyCode==Keys.E)
            {
                buttonCommand16_Click(null, null);
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
            FormManager.ShowMdiChildForm<frmCheque>(mdiParent: this, activeMdiChild: this.ActiveMdiChild);
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
            f.TypeAccounts_Id=3;
            f.SpecificAccountCode=10102;//بانک
            f.ShowList(3);
            f.ShowDialog();
        }

        private void btnAddCofersAc_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id=4;
            f.SpecificAccountCode=10101;//صندوق
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
            //f.Cod="4";
            f.Condition="";
            f.DateReport="گزارش از تاریخ: "+"1404/01/01"+"  تا تاریخ: "+"1404/05/25";
            f.ShowDialog();
        }
    }
}

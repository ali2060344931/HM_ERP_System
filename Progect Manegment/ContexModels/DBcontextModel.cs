
using HM_ERP_System.Entity.Accessibility;
using HM_ERP_System.Entity.Accounts.Banck;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Accounts.DetailedAccount;
using HM_ERP_System.Entity.Accounts.GroupAccount;
using HM_ERP_System.Entity.Accounts.NatureAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Accounts.TotalAccount;
using HM_ERP_System.Entity.Accounts.Transaction;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.Accounts.TypeAccount;
using HM_ERP_System.Entity.Alphabet;
using HM_ERP_System.Entity.AppointmentScheduling;
using HM_ERP_System.Entity.BillLadingWriterPercent;
using HM_ERP_System.Entity.BlacList;
using HM_ERP_System.Entity.Car;
using HM_ERP_System.Entity.Ciltys;
using HM_ERP_System.Entity.Color;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Entity.Commission;
using HM_ERP_System.Entity.Customer;
using HM_ERP_System.Entity.CustomerRole;
using HM_ERP_System.Entity.CustomerToGroup;
using HM_ERP_System.Entity.DocumentBanck;
using HM_ERP_System.Entity.Draver;
using HM_ERP_System.Entity.EvacuationDeployment;
using HM_ERP_System.Entity.FareCalcMethod;
using HM_ERP_System.Entity.FinancialYear;
using HM_ERP_System.Entity.Gender;
using HM_ERP_System.Entity.ImageCo;
using HM_ERP_System.Entity.Ownership;
using HM_ERP_System.Entity.PaymentMethod;
using HM_ERP_System.Entity.Peremission;
using HM_ERP_System.Entity.PersonGroup;
using HM_ERP_System.Entity.PlaceTransfer;
using HM_ERP_System.Entity.Product;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.PurchaseTanker;
using HM_ERP_System.Entity.RolePermissione;
using HM_ERP_System.Entity.SetingProg;
using HM_ERP_System.Entity.Settings;
using HM_ERP_System.Entity.Ship;
using HM_ERP_System.Entity.Spare;
using HM_ERP_System.Entity.TransactionFee;
using HM_ERP_System.Entity.TruckManufacturer;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Entity.TypeCalcMethod;
using HM_ERP_System.Entity.TypeCustomer;
using HM_ERP_System.Entity.TypeDocument;
using HM_ERP_System.Entity.Unit;
using HM_ERP_System.Entity.WarantyType;

using System.Data.Entity;
using System.Transactions;

namespace Progect_Manegment
{
    public class DBcontextModel : DbContext
    {
        public DBcontextModel()
            : base("name=DBcontextModel")
        {
            //دستور اجرای اتوماتیم مایگریشن
            Database.SetInitializer<DBcontextModel>
    (new MigrateDatabaseToLatestVersion<DBcontextModel, MigrationConfig>("DBcontextModel"));


        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // اعمال ایندکس بر روی فیلد نام
            // اعمال عدم تکراری بودن نام
            //modelBuilder.Entity<Role>().HasIndex(u => u.Name).IsUnique();
            #region //--------Fluent API---------
            modelBuilder.Configurations.Add(new CiltysConfig());
            modelBuilder.Configurations.Add(new ProvincesConfig());
            modelBuilder.Configurations.Add(new UnittConfig());
            modelBuilder.Configurations.Add(new TypeCustomertConfig());
            modelBuilder.Configurations.Add(new ProducttConfig());
            modelBuilder.Configurations.Add(new GenderConfig());
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new AlphabetConfig());
            modelBuilder.Configurations.Add(new ShipConfig());
            modelBuilder.Configurations.Add(new DraverConfig());
            modelBuilder.Configurations.Add(new CarConfig());
            modelBuilder.Configurations.Add(new OwnershipConfig());
            modelBuilder.Configurations.Add(new TypeDocumentConfig());
            modelBuilder.Configurations.Add(new PlaceTransferConfig());
            modelBuilder.Configurations.Add(new EvacuationDeploymentConfig());
            modelBuilder.Configurations.Add(new FareCalcMethodConfig());
            modelBuilder.Configurations.Add(new TypeCalcMethodConfig());
            modelBuilder.Configurations.Add(new ComersHConfig());
            modelBuilder.Configurations.Add(new ComersBConfig());
            modelBuilder.Configurations.Add(new PaymentMethodConfig());
            modelBuilder.Configurations.Add(new TruckUsageTypeConfig());
            modelBuilder.Configurations.Add(new DocumentBanckConfig());
            modelBuilder.Configurations.Add(new SetingProgConfig());
            modelBuilder.Configurations.Add(new TransactionFeeConfig());
            modelBuilder.Configurations.Add(new HM_ERP_System.Entity.Role.RoleTypeConfig());
            modelBuilder.Configurations.Add(new AccessibilityConfig());
            modelBuilder.Configurations.Add(new PeremissionConfig());
            modelBuilder.Configurations.Add(new CustomerRoleConfig());
            modelBuilder.Configurations.Add(new RolePermissioneConfig());
            modelBuilder.Configurations.Add(new GroupAccountConfig());
            modelBuilder.Configurations.Add(new TotalAccountConfig());
            modelBuilder.Configurations.Add(new SpecificAccountConfig());
            modelBuilder.Configurations.Add(new NatureAccountConfig());
            modelBuilder.Configurations.Add(new TransactionTypeConfig());
            modelBuilder.Configurations.Add(new TransactionConfig());
            modelBuilder.Configurations.Add(new DetailedAccountConfig());
            modelBuilder.Configurations.Add(new AppointmentSchedulingConfig());
            modelBuilder.Configurations.Add(new PersonGroupConfig());
            modelBuilder.Configurations.Add(new CustomerToGroupConfig());
            modelBuilder.Configurations.Add(new BlacListConfig());
            modelBuilder.Configurations.Add(new SpareConfig());
            modelBuilder.Configurations.Add(new WarantyTypeConfig());
            modelBuilder.Configurations.Add(new ProductGroupConfig());
            modelBuilder.Configurations.Add(new BillLadingWriterPercentConfig());
            modelBuilder.Configurations.Add(new FinancialYearConfig());
            modelBuilder.Configurations.Add(new SpecificAccountsGroupConfig());
            modelBuilder.Configurations.Add(new ChequeConfig());
            modelBuilder.Configurations.Add(new ChequeStatusConfig());
            modelBuilder.Configurations.Add(new ChequeTypeConfig());
            modelBuilder.Configurations.Add(new PurchaseTankerConfig());
            modelBuilder.Configurations.Add(new BanckConfig());
            modelBuilder.Configurations.Add(new BankBranchConfig());
            modelBuilder.Configurations.Add(new CommissionConfig());
            modelBuilder.Configurations.Add(new ImageCoConfig());
            modelBuilder.Configurations.Add(new SettingConfig());
            modelBuilder.Configurations.Add(new TypeAccountConfig());
            modelBuilder.Configurations.Add(new RentalTypeConfig());
            modelBuilder.Configurations.Add(new TruckManufacturerConfig());
            modelBuilder.Configurations.Add(new ColorConfig());

            base.OnModelCreating(modelBuilder);
            #endregion

        }



        #region //--------Tables---------
        /// <summary>
        /// جدول شهر ها
        /// </summary>
        public virtual DbSet<Ciltys> Ciltys { get; set; }
        /// <summary>
        /// استانها
        /// </summary>
        public virtual DbSet<Provinces> Provinces { get; set; }
        /// <summary>
        /// جدول واحد اندازه گیری
        /// </summary>
        public virtual DbSet<Unit> Units { get; set; }
        /// <summary>
        /// جدول نوع مشتری حقیقی/حقوقی
        /// </summary>
        public virtual DbSet<TypeCustomer> TypeCustomers { get; set; }
        /// <summary>
        /// جدول محصولات/کالاها
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public virtual DbSet<Gender> Genders { get; set; }
        /// <summary>
        /// جدول مشتری ها
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// جدول حروف الفبا
        /// </summary>
        public virtual DbSet<Alphabet> Alphabets { get; set; }
        /// <summary>
        /// جدول کشتی ها
        /// </summary>
        public virtual DbSet<Ship> Ships { get; set; }
        /// <summary>
        /// جدول راننده ها
        /// </summary>
        public virtual DbSet<Draver> Dravers { get; set; }
        /// <summary>
        /// جدول خودروها
        /// </summary>
        public virtual DbSet<Car> Cars { get; set; }
        /// <summary>
        /// وضعیت مالکیت
        /// </summary>
        public virtual DbSet<Ownership> Ownerships { get; set; }
        /// <summary>
        /// نوع سند
        /// </summary>
        public virtual DbSet<TypeDocument> TypeDocuments { get; set; }
        /// <summary>
        /// محل بارگیریو تخلیه
        /// </summary>
        public virtual DbSet<PlaceTransfer> PlaceTransfers { get; set; }
        /// <summary>
        /// بارگیری، تخلیه
        /// </summary>
        public virtual DbSet<EvacuationDeployment> EvacuationDeployments { get; set; }
        /// <summary>
        /// نحوه محاسبه کرایه
        /// </summary>
        public virtual DbSet<FareCalcMethod> FareCalcMethods { get; set; }
        /// <summary>
        /// نوع محاسبه کرایه کالاها: تناژ، بارنامه، درصدی
        /// </summary>
        public virtual DbSet<TypeCalcMethod> TypeCalcMethods { get; set; }
        /// <summary>
        /// جدول اسناد حواله
        /// </summary>
        public virtual DbSet<ComersH> ComersHs { get; set; }
        /// <summary>
        /// جدول اسناد بارنامه
        /// </summary>
        public virtual DbSet<ComersB> ComersBs { get; set; }
        /// <summary>
        /// جدول پرداخت هزینه بارگیری توسط
        /// </summary>

        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        /// <summary>
        /// جدول نوع کاربری کامیون
        /// </summary>
        public virtual DbSet<TruckUsageType> TruckUsageTypes { get; set; }
        /// <summary>
        /// جدول ثبت اسناد و مدارک
        /// </summary>
        public virtual DbSet<DocumentBanck> DocumentBancks { get; set; }
        /// <summary>
        /// جدول تنظیمات برنامه
        /// </summary>
        public virtual DbSet<SetingProg> SetingProgs { get; set; }
        /// <summary>
        /// جدول نوع تراکنش: نقدی، غیر نقدی
        /// </summary>
        public virtual DbSet<TransactionFee> TransactionFees { get; set; }

        /// <summary>
        /// جدول سطح دسترسی
        /// </summary>
        public virtual DbSet<Accessibility> Accessibilities { get; set; }


        /// <summary>
        /// جدول نوع دسترسی
        /// </summary>
        //public virtual DbSet<User> Users { get; set; }
        
        public virtual DbSet<HM_ERP_System.Entity.Role.Role> Roles { get; set; }
        
        /// <summary>
        /// مجوزهای قابلیت دسترسی(مثلا: دیدنفرم، ویرایش، حذف و غیره
        /// </summary>
        public virtual DbSet<Peremission> Peremissions { get; set; }

        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }

        public virtual DbSet<RolePermissione> RolePermissiones { get; set; }
        
        /// <summary>
        /// گروه حساب ها
        /// </summary>
        public virtual DbSet<GroupAccount> GroupAccounts { get; set; }
        
        /// <summary>
        /// حساب های کل
        /// </summary>
        public virtual DbSet<TotalAccount> TotalAccounts { get; set; }
        
        /// <summary>
        /// حساب معین
        /// </summary>
        public virtual DbSet<SpecificAccount> SpecificAccounts { get; set; }
        
        /// <summary>
        /// ماهیت حساب ها
        /// </summary>
        public virtual DbSet<NatureAccount> NatureAccounts { get; set; }
        
        /// <summary>
        /// نوع سند حسابداری:درآمد، هزینه یا جابجایی
        /// </summary>
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        
        /// <summary>
        /// جدول اسناد حسابداری
        /// </summary>
        public virtual DbSet<HM_ERP_System.Entity.Accounts.Transaction.Transaction> Transactions { get; set; }
        
        /// <summary>
        /// جدول حساب های تفصیلی
        /// </summary>
        public virtual DbSet<DetailedAccount> DetailedAccounts { get; set; }
        
        /// <summary>
        /// جدول نوبت دهی
        /// </summary>
        public virtual DbSet<AppointmentScheduling> AppointmentSchedulings { get; set; }
        /// <summary>
        /// گروه اشخاص
        /// </summary>
        public virtual DbSet<PersonGroup> PersonGroups { get; set; }
        /// <summary>
        /// اختصاص اشخاص به گروهها
        /// </summary>
        public virtual DbSet<CustomerToGroup> CustomerToGroups { get; set; }
        public virtual DbSet<BlacList> BlacLists { get; set; }
        /// <summary>
        /// جدول یدک
        /// </summary>
        public virtual DbSet<Spare> Spares { get; set; }
        /// <summary>
        /// نوع ضمانت
        /// </summary>
        public virtual DbSet<WarantyType> WarantyTypes { get; set; }
        /// <summary>
        /// جدول گروه کالاها
        /// </summary>
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        /// <summary>
        /// جدول درصد بارنامه نویس
        /// </summary>
        public virtual DbSet<BillLadingWriterPercent> BillLadingWriterPercents { get; set; }
        /// <summary>
        /// جدول سال مالی
        /// </summary>
        public virtual DbSet<FinancialYear> FinancialYears { get; set; }
        /// <summary>
        /// جدول گروه بندی حساب های معین
        /// </summary>
        public virtual DbSet<SpecificAccountsGroup> SpecificAccountsGroups { get; set; }
        /// <summary>
        /// جدول ثبت چک ها
        /// </summary>
        public virtual DbSet<Cheque> Cheques { get; set; }
        /// <summary>
        /// تاریخچه و وضعیت‌های چک
        /// </summary>
        public virtual DbSet<ChequeStatus> ChequeStatuses { get; set; }
        /// <summary>
        /// نوع چک 1.دریافتنی 2.پرداختنی
        /// </summary>
        public virtual DbSet<ChequeType> ChequeTypes { get; set; }
        /// <summary>
        /// (کد وصعیت چد: ( 1: در جریان وصول، 2: به صندوق/بانک خوابانده شد، 3: پاس شد، 4: برگشت خورد، 5: خرج شد 6:ثبت شده
        /// </summary>
        public virtual DbSet<ChequeStatusType> ChequeStatusTypes { get; set; }
        /// <summary>
        /// خرید تانکرها
        /// </summary>
        public virtual DbSet<PurchaseTanker> PurchaseTankers { get; set; }
        /// <summary>
        /// جدول بانک ها
        /// </summary>
        public virtual DbSet<Banck> Bancks { get; set; }
        /// <summary>
        /// جدول شعب بانک ها
        /// </summary>
        public virtual DbSet<BankBranch> BankBranches { get; set; }
        /// <summary>
        /// جدول پورسانت ها
        /// </summary>
        public virtual DbSet<Commission> Commissions { get; set; }
        
        /// <summary>
        /// جدول لوگوی شرکت
        /// </summary>
        public virtual DbSet<ImageCo> ImageCos { get; set; }
        /// <summary>
        /// جدول تنظیمات
        /// </summary>
        public virtual DbSet<Setting> Settings { get; set; }
        /// <summary>
        /// نوع حساب های بانکی
        /// </summary>
        public virtual DbSet<TypeAccount> TypeAccounts { get; set; }
        /// <summary>
        /// نوع اجاره ها
        /// </summary>
        public virtual DbSet<RentalType> RentalTypes { get; set; }
        /// <summary>
        /// کارخانه سازنده کامیون ها
        /// </summary>
        public virtual DbSet<TruckManufacturer> TruckManufacturers { get; set; }
        public virtual DbSet<Color_> Color_s { get; set; }

        #endregion



    }

}
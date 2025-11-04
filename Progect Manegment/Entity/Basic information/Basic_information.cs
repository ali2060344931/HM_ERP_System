using HM_ERP_System.Entity.Ciltys;
using HM_ERP_System.Entity.EvacuationDeployment;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Entity.TransactionFee;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Entity.Role;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_ERP_System.Entity.Accounts.TotalAccount;
using System.Windows.Forms;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Accounts.GroupAccount;
using MyClass;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.Accounts.DetailedAccount;

namespace HM_ERP_System.Entity.Basic_information
{
    public static class Basic_information
    {
        static DBcontextModel db = new DBcontextModel();

        public static void basic_information()
        {
            try
            {

                //ثبت اطلاعات استان و شهرها از فایل
                var q0 = db.Provinces.Count();
                if (q0==0)
                {
                    AddProvincesCityToDataBase();
                }

                //جنسیت
                var q1 = db.Genders.Count();
                if (q1 == 0)
                {
                    db.Genders.Add(new Gender.Gender { Name = "مرد" });
                    db.Genders.Add(new Gender.Gender { Name = "زن" });
                    db.SaveChanges();
                }

                ////نوع مشتری
                var q2 = db.TypeCustomers.Count();
                if (q2 == 0)
                {
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "حقیقی" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "حقوقی" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "بانک" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "صندوق" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "سایر حساب های تفصیلی" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "تنخواه گردان" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "مراکز درآمد" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "مراکز هزینه" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "اموال" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "موجودی کالا" });
                    db.TypeCustomers.Add(new TypeCustomer.TypeCustomer { Name = "جاری شرکا" });
                    db.SaveChanges();
                }

                var q3 = db.Ownerships.Count();
                if (q3 == 0)
                {
                    db.Ownerships.Add(new Ownership.Ownership { Name = "شخصی" });
                    db.Ownerships.Add(new Ownership.Ownership { Name = "استیجاری" });
                    db.Ownerships.Add(new Ownership.Ownership { Name = "شرکتی" });
                    db.Ownerships.Add(new Ownership.Ownership { Name = "خودمالک" });
                    db.SaveChanges();
                }

                //نوع سند
                var q4 = db.TypeDocuments.Count();
                if (q4 == 0)
                {
                    db.TypeDocuments.Add(new TypeDocument.TypeDocument { Name = "حمل" });
                    db.TypeDocuments.Add(new TypeDocument.TypeDocument { Name = "تخلیه کشتی" });
                    db.SaveChanges();
                }
                //بارگیری، تخلیه
                var q5 = db.EvacuationDeployments.Count();
                if (q5 == 0)
                {
                    db.EvacuationDeployments.Add(new EvacuationDeployment.EvacuationDeployment { Name = "بارگیری" });
                    db.EvacuationDeployments.Add(new EvacuationDeployment.EvacuationDeployment { Name = "تخلیه" });
                    db.SaveChanges();
                }
                var q6 = db.FareCalcMethods.Count();
                if (q6 == 0)
                {
                    db.FareCalcMethods.Add(new FareCalcMethod.FareCalcMethod { Name = "لیست" });//کرایه حمل
                    db.FareCalcMethods.Add(new FareCalcMethod.FareCalcMethod { Name = "مقصد" });//کمیسیون
                    db.SaveChanges();
                }
                var q7 = db.PaymentMethods.Count();
                if (q7 == 0)
                {
                    db.PaymentMethods.Add(new PaymentMethod.PaymentMethod { Name = "پیمانکار" });
                    db.PaymentMethods.Add(new PaymentMethod.PaymentMethod { Name = "راننده" });
                    db.PaymentMethods.Add(new PaymentMethod.PaymentMethod { Name = "ندارد" });
                    db.SaveChanges();
                }

                var q8 = db.TypeCalcMethods.Count();
                if (q8 == 0)
                {
                    db.TypeCalcMethods.Add(new TypeCalcMethod.TypeCalcMethod { Name = "کیلوگرمی" });
                    db.TypeCalcMethods.Add(new TypeCalcMethod.TypeCalcMethod { Name = "سرویسی" });
                    db.TypeCalcMethods.Add(new TypeCalcMethod.TypeCalcMethod { Name = "درصدی" });
                    db.TypeCalcMethods.Add(new TypeCalcMethod.TypeCalcMethod { Name = "ندارد" });
                    db.SaveChanges();
                }

                var q9 = db.TruckUsageTypes.Count();
                if (q9 == 0)
                {
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "تانکر" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "کمپرسی" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "لبه دار" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "یخچال دار" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "کفی" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "ترانزیت" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "کمرشکن" });
                    db.TruckUsageTypes.Add(new TruckUsageType.TruckUsageType { Name = "بوژی" });

                    db.SaveChanges();
                }
                var q10 = db.TransactionFees.Count();
                if (q10 == 0)
                {
                    db.TransactionFees.Add(new TransactionFee.TransactionFee { Name = "نقدی" });
                    db.TransactionFees.Add(new TransactionFee.TransactionFee { Name = "غیر نقدی" });

                    db.SaveChanges();
                }

                var q11 = db.Roles.Count();
                if (q11 == 0)
                {
                    db.Roles.Add(new Role.Role { Name = "مدیر سیستم" });
                    db.Roles.Add(new Role.Role { Name = "کاربر سطح 1" });
                    db.Roles.Add(new Role.Role { Name = "کاربر سطح 2" });
                    db.SaveChanges();
                }
                var q12_0 = db.Customers.Count();
                if (q12_0 == 0)
                {
                    db.Customers.Add(new Customer.Customer { Name="علی اصغر", Family="غلامزاده", CodMeli="admin", id_TypeCustomer=1, Tel="09111161996", Tel2="09021161996" });
                    
                    db.Customers.Add(new Customer.Customer { Name="اداره دارایی-مالیات بر ارزش افزوده خرید", CodMeli="1000000001", id_TypeCustomer=2, Tel="0",SecretCode=1});
                    
                    db.Customers.Add(new Customer.Customer { Name="اداره دارایی-مالیات بر ارزش افزوده فروش", CodMeli="1000000002", id_TypeCustomer=2, Tel="0", SecretCode=2 });
                    
                    db.Customers.Add(new Customer.Customer { Name="درآمد حمل کالا", CodMeli="1000000003", id_TypeCustomer=7, Tel="0", SecretCode=3 });
                    
                    db.Customers.Add(new Customer.Customer { Name="هزینه حمل کالا", CodMeli="1000000004", id_TypeCustomer=8, Tel="0", SecretCode=4 });
                    
                    db.Customers.Add(new Customer.Customer { Name="سایر هزینه ها", CodMeli="1000000005", id_TypeCustomer=8, Tel="0", SecretCode=5 });
                    
                    db.Customers.Add(new Customer.Customer { Name="حساب تجمیع هزینه های متفرقه", CodMeli="1000000006", id_TypeCustomer=8, Tel="0", SecretCode=6 });
                    db.Customers.Add(new Customer.Customer { Name="هزینه های کارمزد خدمات بانکی", CodMeli="1000000007", id_TypeCustomer=8, Tel="0", SecretCode=7 });

                    db.Customers.Add(new Customer.Customer { Name="مرکز درآمد اجاره تانکرها", CodMeli="1000000008", id_TypeCustomer=7, Tel="0", SecretCode=8 });
                    
                    db.Customers.Add(new Customer.Customer { Name="هزینه صدور بارنامه", CodMeli="1000000009", id_TypeCustomer=8, Tel="0", SecretCode=9 });

                    db.SaveChanges();

                }

                var q12_1 = db.Customers.Where(c=>c.SecretCode==10).Count();
                if (q12_1 == 0)
                {
                    db.Customers.Add(new Customer.Customer { Name="سند رزور افتتاحیه", CodMeli="1000000010", id_TypeCustomer=5, Tel="0", SecretCode=10 });
                    db.SaveChanges();
                }


                var q13 = db.CustomerRoles.Count();
                if (q13 == 0)
                {
                    db.CustomerRoles.Add(new CustomerRole.CustomerRole { CustomerId=1, RoleId=1,Password=PublicClass.GenerateHash("1") });
                    db.SaveChanges();
                }

                var q14 = db.NatureAccounts.Count();
                if (q14 == 0)
                {
                    db.NatureAccounts.Add(new Entity.Accounts.NatureAccount.NatureAccount { Name = "بدهکار" });
                    db.NatureAccounts.Add(new Entity.Accounts.NatureAccount.NatureAccount { Name = "بستانکار" });
                    db.NatureAccounts.Add(new Entity.Accounts.NatureAccount.NatureAccount { Name = "خنثی" });
                    db.SaveChanges();
                }
                //گروه حساب ها
                var q15 = db.GroupAccounts.Count();
                if (q15 == 0)
                {
                    db.GroupAccounts.Add(new GroupAccount { Name = "دارایی ها", IdMahiyat = 1 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "دارایی های غیرجاری", IdMahiyat = 1 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "بدهی ها", IdMahiyat = 2 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "بدهی های غیرجاری", IdMahiyat = 2 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "حقوق صاحبان سهام", IdMahiyat = 2 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "درآمد", IdMahiyat = 2 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "بهای تمام شده کالای فروش رفته", IdMahiyat = 1 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "هزینه ها", IdMahiyat = 1 });
                    db.GroupAccounts.Add(new GroupAccount { Name = "سایر حسابها", IdMahiyat = 3 });
                    db.SaveChanges();
                }

                //حساب کل
                var q16 = db.TotalAccounts.Count();
                if (q16 == 0)
                {
                    //انتخاب فایل مورد نظر در مسیر فایل اجرایی
                    string sp = Application.StartupPath + @"\HKol.txt";
                    foreach (string line in File.ReadLines(sp, Encoding.UTF8))
                    {
                        string[] txt = line.Split(',');
                        db.TotalAccounts.Add(new TotalAccount { Cod = int.Parse(txt[0]), Name = txt[1], Id_GroupAccount = int.Parse(txt[0].Substring(0, 1)) });
                    }

                    db.SaveChanges();
                }

                var q17 = db.SpecificAccounts.Count();
                if (q17 == 0)
                {
                    //انتخاب فایل مورد نظر در مسیر فایل اجرایی
                    string sp = Application.StartupPath + @"\HMoin.txt";
                    foreach (string line in File.ReadLines(sp, Encoding.UTF8))
                    {
                        string[] txt = line.Split(',');
                        int cod = int.Parse(txt[0].Substring(0, 3));
                        //تعیین ای دی حساب کل
                        var IdHKol = db.TotalAccounts.Where(C => C.Cod == cod).First().Id;
                        //افزودن مقادیر در جدول معین
                        db.SpecificAccounts.Add(new SpecificAccount { Cod = int.Parse(txt[0]), Name = txt[1]/*, Id_MahiyatHesab = int.Parse(txt[2])*/, Id_TotalAccount = IdHKol });
                    }
                    db.SaveChanges();
                }

                var q18 = db.TransactionTypes.Count();
                if (q18 == 0)
                {
                    db.TransactionTypes.Add(new Entity.Accounts.TransactionType.TransactionType { Name="درآمد" });
                    db.TransactionTypes.Add(new Entity.Accounts.TransactionType.TransactionType { Name="هزینه" });
                    db.TransactionTypes.Add(new Entity.Accounts.TransactionType.TransactionType { Name="جابجایی" });
                    db.TransactionTypes.Add(new Entity.Accounts.TransactionType.TransactionType { Name="دریافت" });
                    db.TransactionTypes.Add(new Entity.Accounts.TransactionType.TransactionType { Name="پرداخت" });
                    db.SaveChanges();
                }

                var q19=db.DetailedAccounts.Count();
                if (q19 == 0)
                {
                    db=new DBcontextModel();
                    int SpecificAccountTaxId = db.SpecificAccounts.Where(c => c.Cod==10406).First().Id;
                    int CodeAccount_ = PublicClass.CeratDetailedAccountCode(SpecificAccountTaxId);

                    var insert1 = new Repository<DetailedAccount>(db);
                    insert1.SaveOrUpdate(new DetailedAccount { Id = 0, SpecificAccountId=SpecificAccountTaxId, CustomerId=2, CodeAccount=CodeAccount_}, 0);

                    db=new DBcontextModel();
                    SpecificAccountTaxId = db.SpecificAccounts.Where(c => c.Cod==30602).First().Id;
                    CodeAccount_ = PublicClass.CeratDetailedAccountCode(SpecificAccountTaxId);

                    var insert2 = new Repository<DetailedAccount>(db);
                    insert2.SaveOrUpdate(new DetailedAccount { Id = 0, SpecificAccountId=SpecificAccountTaxId, CustomerId=3, CodeAccount=CodeAccount_}, 0);
                }

                var q20 = db.PersonGroups.Count();
                if (q20 == 0)
                {
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="راننده" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="بارنامه نویس" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب کامیون" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب کالا" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="فرستنده" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="گیرنده" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="کارکنان" });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="سایر" });
                   
                    db.SaveChanges();
                }
                

                var q21 = db.WarantyTypes.Count();
                if (q21 == 0)
                {
                    db.WarantyTypes.Add(new Entity.WarantyType.WarantyType { Name="چک" });
                    db.WarantyTypes.Add(new Entity.WarantyType.WarantyType { Name="سفته" });
                    db.WarantyTypes.Add(new Entity.WarantyType.WarantyType { Name="ندارد" });
                    db.SaveChanges();
                }

                var q22 = db.ChequeTypes.Count();
                if (q22 == 0)
                {
                    db.ChequeTypes.Add(new Entity.Accounts.Cheque.ChequeType { Name="دریافتنی" });
                    db.ChequeTypes.Add(new Entity.Accounts.Cheque.ChequeType { Name="پرداختنی" });
                    db.SaveChanges();
                }
                
                var q23 = db.ChequeStatusTypes.Count();
                if (q23 == 0)
                {
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="در جریان وصول" });
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="به صندوق/بانک خوابانده شد" });
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="پاس شد" });
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="برگشت خورد" });
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="خرج شد" });
                    db.ChequeStatusTypes.Add(new Entity.Accounts.Cheque.ChequeStatusType { Name="ثبت شده" });
                    db.SaveChanges();
                }

                var q24 = db.PersonGroups.Where(c => c.IsCommission).Count();
                if (q24 == 0)
                {
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب جذب کامیون", IsCommission=true });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب اعلام بار", IsCommission=true });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب پورسانت بارنامه نویسی", IsCommission = true });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب پورسانت مخازن", IsCommission = true });
                    db.PersonGroups.Add(new Entity.PersonGroup.PersonGroup { Name="طرف حساب پورسانت ترخیصکار", IsCommission = true });
                    db.SaveChanges();
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
            }
        }

        /// <summary>
        /// متد افزودن استان و شهر دیتابیس
        /// </summary>
        static void AddProvincesCityToDataBase()
        {
            var q = db.Ciltys.Count();
            if (q==0)
            {
                try
                {
                    var linesP = File.ReadAllLines(@"Provinces.txt");
                    var linesC = File.ReadAllLines(@"City.txt");

                    var filteredLinesP = linesP.Where(line => !string.IsNullOrWhiteSpace(line));

                    var filteredLinesC = linesC.Where(line => !string.IsNullOrWhiteSpace(line));


                    Entity.Provinces.Provinces p = new Entity.Provinces.Provinces();

                    foreach (var line in filteredLinesP)
                    {
                        p.Name = line;
                        db.Provinces.Add(p);
                        db.SaveChanges();
                    }

                    Entity.Ciltys.Ciltys c = new Ciltys.Ciltys();
                    foreach (var line in filteredLinesC)
                    {
                        string[] city = line.Split(',');
                        string cityname = city[0];
                        var qp = db.Provinces.Where(x => x.Name==cityname).First().Id;

                        c.ProvincesId = qp;
                        c.Name = city[1];

                        db.Ciltys.Add(c);
                        db.SaveChanges();
                    }

                }
                catch (Exception er)
                {
                    PublicClass.ShowErrorMessage(er);
                }
            }
        }


    }
}

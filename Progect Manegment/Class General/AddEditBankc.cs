using DevComponents.DotNetBar;
using Progect_Manegment;

using System.Data;
using System.Linq;

namespace MyClass
{
    /// <summary>ظ
    /// کلاس برای ثبت اطلاعات در بانک داده ها
    /// </summary>
    public static class Add_Edit_Bancks
    {
        public const string Verson = "2.5.03";
        //todo #region
        #region
        private static DBcontextModel db = new DBcontextModel();

        public static bool BanckEdid()
        {
           



            //try
            //{
            //    var productsToDelete = db.DocumentRevExps.Where(p => p.CodDocument>253).ToList();
            //    db.DocumentRevExps.RemoveRange(productsToDelete);
            //    db.SaveChanges();
            //}
            //catch (System.Exception)
            //{

            //}
            /*
            var q = db.SpecificAccounts.Where(c => c.Cod==80211).First().Id;
            var StensilAccounts_ = db.StensilAccounts.Where(c => c.Id_Specifice==172).ToList();
            foreach (var item in StensilAccounts_)
            {
                item.Id_Specifice=q;
            }
            db.SaveChanges();


            Accounts_Fund_Bank_Currency co;
            if (db.Accounts_Fund_Banks.Count()==0)
            {
                var cofer = db.Coffers;
                foreach (var item in cofer.ToList())
                {
                    co=new Accounts_Fund_Bank_Currency();
                    co.Id_Company=item.Id_Company;
                    co.Id_TypeAccount=1;
                    co.Id_Account=(int)item.Id;
                    co.IsCurrency=item.IsCurrency;
                    db.Accounts_Fund_Banks.Add(co);
                }

                var bank = db.Bancks.Where(c=>c.NodeLevel==2).ToList();
                foreach (var item in bank)
                {
                    co=new Accounts_Fund_Bank_Currency();
                    co.Id_Company=(int)item.Id_Company;
                    co.Id_TypeAccount=2;
                    co.Id_Account=(int)item.Id;
                    co.IsCurrency=item.Is_Currency_Account;
                    db.Accounts_Fund_Banks.Add(co);
                }

                var currency = db.CryptoToWallets.ToList();
                foreach (var item in currency)
                {
                    co=new Accounts_Fund_Bank_Currency();
                    co.Id_Company=(int)item.Id_Company;
                    co.Id_TypeAccount=3;
                    co.Id_Account=(int)item.Id;
                    co.IsCurrency=true;
                    db.Accounts_Fund_Banks.Add(co);
                }

                db.SaveChanges();
            }
            */


            /*
            #region حساب های کل
           
            var HK = db.TotalAccounts.Where(c => c.NameEn!=null).Count();
            if (HK==0)
            {
                //انتخاب فایل مورد نظر در مسیر فایل اجرایی
                string sp = Application.StartupPath+@"\HKol.txt";
                foreach (string line in File.ReadLines(sp, Encoding.UTF8))
                {
                    string[] txt = line.Split(',');
                    int id_ = Convert.ToInt32(txt[0]);
                    var q = db.TotalAccounts.Where(c => c.Cod==id_).First();
                    q.NameEn=txt[2];
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "e1");
                }
            }



            #endregion

            #region حساب های معین


            var HM = db.SpecificAccounts.Where(c => c.NameEn==null).Count();
            if (HM!=0)
            {
                //انتخاب فایل مورد نظر در مسیر فایل اجرایی
                string sp = Application.StartupPath+@"\HMoin.txt";
                foreach (string line in File.ReadLines(sp, Encoding.UTF8))
                {
                    try
                    {
                        string[] txt = line.Split(',');
                        int id_ = Convert.ToInt32(txt[0]);
                        var q = db.SpecificAccounts.Where(c => c.Cod==id_).First();
                        q.NameEn=txt[3];
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {

                    }   
                }
            }

            #endregion


            #region گروه حسابها

            var GA = db.GroupAccounts.Where(c => c.NameEn!=null).Count();
            if (GA==0)


            {
                string sp = "Current assets,Non-current assets,Current liabilities,Non-current liabilities,Shareholders' equity,Sales,Cost of goods sold,Expenses,Other accounts";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.GroupAccounts.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();

            }



            #endregion
            #region نوع سند
            var TD = db.TypeDocuments.Where(c => c.NameEn!=null).Count();
            if (TD==0)
            {
                string sp = "Income,Expense,Relocation,Accounts receivable transfer,Accounts payable transfer,Receivables transfer,Payables transfer,Loan,Loan installment,Asset-purchase,Asset-sale,Asset expenses,Capital,Opening document,Tax,Reserve document";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.TypeDocuments.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();

            }
            #endregion
            #region نوع روش پرداخت
            var TA = db.TypeAccounts.Where(c => c.NameEn!=null).Count();
            if (TA==0)
            {
                string sp = "Cash,Bank,Currency,Check,Individuals,Asset,Expenses,Loan,Tax";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.TypeAccounts.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();

            }
            #endregion
            #region حقیقی/حقوقی
            var PC = db.Person_Companies.Where(c => c.NameEn!=null).Count();
            if (PC==0)
            {
                string sp = "person,entity,User";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.Person_Companies.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();
            }
            #endregion
            #region حقیقی/حقوقی
            var RP = db.ReceivingPayments.Where(c => c.NameEn!=null).Count();
            if (RP==0)
            {
                string sp = "Receive,Pay";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.ReceivingPayments.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                //try
                //{
                db.SaveChanges();

            }
            #endregion
            #region بدهکار/بستانکار
            var MH = db.MahiyatHesabs.Where(c => c.NameEn!=null).Count();
            if (MH==0)
            {
                string sp = "Debtor,Creditor,Neutral";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.MahiyatHesabs.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();

            }
            #endregion
            #region بدهکار/بستانکار
            var TC = db.TypeCustomers.Where(c => c.NameEn!=null).Count();
            if (TC==0)
            {
                string sp = "Regular customer,Supplier,Marketer";
                string[] txt = sp.Split(',');
                for (int i = 1; i <= txt.Length; i++)
                {
                    var q = db.TypeCustomers.Where(c => c.Id==i).First();
                    q.NameEn=txt[i-1];
                }
                db.SaveChanges();
            }

            #endregion
          */





            //var CA = db.Cards.Where(c => c.Name=="Other").Count();
            //if (CA==0)
            //{
            //    var qq = new Accounting_Warehousing.Entity.Definitions.Bank_Wallet.Bank.Card();
            //    qq.Name="Other";
            //    db.Cards.Add(qq);
            //    db.SaveChanges();
            //}
            //var ST = db.Settings.Where(c => c.Id_Company==IdCompany && c.Cod==11).Count();
            //if (ST==0)
            //{
            //    db.Settings.Add(new Setting { Id_Company=1, Cod=11, Name = "کد حساب بانک جهت ثبت در تلگرام" }); db.SaveChanges();
            //}

            //var ST0 = db.Settings.Where(c => c.Id_Company==IdCompany && c.Cod==12).Count();
            //if (ST0==0)
            //{
            //    db.Settings.Add(new Setting { Id_Company=1, Cod=12, Name = "توکن تلگرام", Txt="5760606334:AAEr43EeeAglaZtN9a3U8ywWDMiRRZ8SqSs" }); db.SaveChanges();
            //}


            ////جهت افزودن حساب معین مالیات فدرال و ایالتی
            //if(db.SpecificAccounts.Where(c=>c.Cod==10410).Count()==0)
            //{
            //    db.SpecificAccounts.Add(new SpecificAccount { Cod=10410, Name = "مالیات فدرال", Id_MahiyatHesab=1 ,Id_TotalAccount=4});
            //    db.SpecificAccounts.Add(new SpecificAccount { Cod=10411, Name = "مالیات ایالتی", Id_MahiyatHesab=1, Id_TotalAccount=4 });
            //    db.SaveChanges();

            //}


            //string VerInBank =  SqlBankClass.SerchOnCellString("select txt from tbl_Tanzimat where id=1");
            //int IdVer = string.Compare(Verson, VerInBank);

            //if (IdVer == 0)//عدم نیاز به بروز رسانی
            //    return true;

            //if (IdVer < 0)//اعلام بروز رسانی
            //{
            //     PublicClass.ErrorMesseg("نسخه برنامه شما بروزرسانی نشده. لطفا برنامه را بروز رسانی نمائید" + '\n' + "نسخه برنامه شما:" + Verson + '\n' + "آخرین نسخه منتشر شده: " + VerInBank + '\n' + "لطفا فایل اجرایی را در مسیر نصب برنامه جایگزین نمائید");
            //    return false;
            //}

            //if (IdVer > 0)//اانجام عملیات بروز رسانی
            {
                // SqlBankClass.Update("tbl_Tanzimat", "id=1", "txt", Verson);
                //School_management.Properties.Settings.Default.Version = Verson;
                //School_management.Properties.Settings.Default.Save();

                #region
                //string txt = "SELECT  dbo.tbl_Sabt_Export_KalaAsAnbar.id, dbo.tbl_Sabt_Export_KalaAsAnbar.idp, dbo.tbl_Sabt_Export_KalaAsAnbar.idBakhsh, dbo.tbl_Kala.id_groh_kala, dbo.tbl_Sabt_Export_KalaAsAnbar.id_kala,  dbo.tbl_Sabt_Export_KalaAsAnbar.tarikh, dbo.tbl_Zirgroh.name AS nameBakhsh, dbo.tbl_name_Kala.name, dbo.tbl_Vaheds.name AS vahed, dbo.tbl_Sabt_Export_KalaAsAnbar.meghdar,  dbo.tbl_Sabt_Export_KalaAsAnbar.Tozihat, dbo.tbl_Sabt_Export_KalaAsAnbar.SabtNahaii, dbo.tbl_Karbaran.name AS PerSabt, tbl_Karbaran_1.name AS PerEdit, dbo.tbl_Sabt_Export_KalaAsAnbar.TarikhEdit FROM  dbo.tbl_Zirgroh INNER JOIN dbo.tbl_Sabt_Export_KalaAsAnbar ON dbo.tbl_Zirgroh.id = dbo.tbl_Sabt_Export_KalaAsAnbar.idBakhsh INNER JOIN dbo.tbl_Vaheds INNER JOIN dbo.tbl_Kala ON dbo.tbl_Vaheds.id = dbo.tbl_Kala.id_Vahed INNER JOIN dbo.tbl_name_Kala ON dbo.tbl_Kala.id_name_Kala = dbo.tbl_name_Kala.id ON dbo.tbl_Sabt_Export_KalaAsAnbar.id_kala = dbo.tbl_Kala.id_name_Kala INNER JOIN dbo.tbl_Karbaran ON dbo.tbl_Sabt_Export_KalaAsAnbar.Per_Sabt = dbo.tbl_Karbaran.id INNER JOIN dbo.tbl_Karbaran AS tbl_Karbaran_1 ON dbo.tbl_Sabt_Export_KalaAsAnbar.Per_Edit = tbl_Karbaran_1.id";

                //string txt1 = "SELECT dbo.tbl_Sabt_Porsion.id, dbo.tbl_Sabt_Porsion.idp, dbo.tbl_Sabt_Porsion.idBakhsh, dbo.tbl_Sabt_Porsion.tarikh, dbo.tbl_Sabt_Porsion.roz AS [روز هفته], dbo.tbl_Sabt_Porsion.tarikh AS تاریخ, dbo.tbl_Zirgroh.name AS [واحد | بخش],  dbo.tbl_TmenuMahiyane.name AS [نام منو], dbo.tbl_VadeGhazaii.name AS [نام وعده], dbo.tbl_menuGhaza.name AS [نام غذا], dbo.tbl_Sabt_Porsion.tedad AS [تعداد اعلامی پروژه],  dbo.tbl_Sabt_Porsion.tedadServShode AS [تعداد سروی پروژه], dbo.tbl_Sabt_Porsion.tedadMande AS [اختلاف مانده پرسیون پروژه], dbo.tbl_Sabt_Porsion.TedadEP AS [تعداد اعلامی پرسنل],  dbo.tbl_Sabt_Porsion.TedadSP AS [تعداد سروی پرسنل], dbo.tbl_Sabt_Porsion.TedadMandeP AS [اختلاف مانده پرسیون پرسنل], dbo.tbl_Sabt_Porsion.tozihat AS ملاحظات, dbo.tbl_Sabt_Porsion.SabtNahaii AS [ثبت نهایی],  dbo.tbl_Karbaran.name AS [ثبت کننده], tbl_Karbaran_1.name AS [ویرایش کننده], dbo.tbl_Sabt_Porsion.TarikhEdit AS [تاریخ ویرایش] FROM dbo.tbl_Sabt_Porsion INNER JOIN dbo.tbl_TmenuMahiyane ON dbo.tbl_Sabt_Porsion.id_TmenuMahiyane = dbo.tbl_TmenuMahiyane.id INNER JOIN dbo.tbl_VadeGhazaii ON dbo.tbl_Sabt_Porsion.id_VadeGhazaii = dbo.tbl_VadeGhazaii.id INNER JOIN dbo.tbl_menuGhaza ON dbo.tbl_Sabt_Porsion.id_Ghaza = dbo.tbl_menuGhaza.id INNER JOIN dbo.tbl_Zirgroh ON dbo.tbl_Sabt_Porsion.idBakhsh = dbo.tbl_Zirgroh.id INNER JOIN dbo.tbl_Karbaran ON dbo.tbl_Sabt_Porsion.Per_Sabt = dbo.tbl_Karbaran.id INNER JOIN dbo.tbl_Karbaran AS tbl_Karbaran_1 ON dbo.tbl_Sabt_Porsion.Per_Edit = tbl_Karbaran_1.id";

                //string txt2 = "SELECT dbo.tbl_SabtDaramadha.id, dbo.tbl_SabtDaramadha.idp, dbo.tbl_SabtDaramadha.idDaramad, dbo.tbl_Daramad_Ja.name AS [نام درآمد], dbo.tbl_SabtDaramadha.sal AS سال, dbo.tbl_SabtDaramadha.mah AS ماه,  dbo.tbl_SabtDaramadha.Tarihk AS [تاریخ ثبت], dbo.tbl_SabtDaramadha.maglagh AS مبلغ, dbo.tbl_NoeSoratVaziyat.name AS [نوع صورت وضعیت], dbo.tbl_SabtDaramadha.Tozihat AS توضیحات FROM dbo.tbl_SabtDaramadha INNER JOIN dbo.tbl_Daramad_Ja ON dbo.tbl_SabtDaramadha.idDaramad = dbo.tbl_Daramad_Ja.id INNER JOIN dbo.tbl_NoeSoratVaziyat ON dbo.tbl_SabtDaramadha.idNoeSoratVaziyat = dbo.tbl_NoeSoratVaziyat.id";

                //-------------------------------------------------------
                //حذف کامل جدول
                // SqlBankClass.CeratTable("Drop Table tbt_Set_Dasresi");

                //-------------------------------------------------------
                //ساخت جدول جدید
                // SqlBankClass.CeratTable("Create Table tbl_AddTedadKalaha (idKala int , idp int,idBakhsh int ,T1 char(10),megh1 float,T2 char(10),megh2 float,T3 char(10),megh3 float,T4 char(10),megh4 float,T5 char(10),megh5 float,T6 char(10),megh6 float,T7 char(10),megh7 float)");

                // SqlBankClass.CeratTable("Create Table tbt_Set_Dasresi (id int IDENTITY(1,1),id_Dastresi  int,CL_1 bit,TA_1_1 bit,TA_1_1_1 bit,TA_1_1_1_1 bit,TA_1_1_1_2 bit,TA_1_1_2 bit,TA_1_1_3 bit,TA_1_1_4 bit,TA_1_1_5 bit,TA_1_1_6 bit,TA_1_1_7 bit,TA_1_1_8 bit,TA_1_1_9 bit,TA_1_1_10 bit,TA_1_1_11 bit,TA_1_1_12 bit,TA_1_1_13 bit,TA_1_1_14 bit,TA_1_1_15 bit,Ap_1_2 bit,Ap_1_2_1 bit,Ap_1_2_2 bit,Ap_1_2_3 bit,Ap_1_2_4 bit,Ap_1_2_5 bit,SB_1_3 bit,SB_1_3_1 bit,SB_1_3_2 bit,SB_1_3_3 bit,SB_1_3_4 bit,GZ_1_4 bit,GZ_1_4_1 bit,GZ_1_4_2 bit,GZ_1_4_3 bit,GZ_1_4_4 bit,GZ_1_4_5 bit,GZ_1_4_6 bit,EM_1_5 bit,EM_1_5_1 bit,EM_1_5_2 bit,EM_1_5_3 bit,EM_1_5_4 bit,TZ_1_6 bit,TZ_1_6_1 bit,TZ_1_6_2 bit,TZ_1_6_3 bit,TZ_1_6_4 bit,GZ_1_4_2_1 bit,GZ_1_4_2_2 bit,GZ_1_4_2_3 bit,GZ_1_4_2_3_1 bit,GZ_1_4_2_3_2 bit,GZ_1_4_2_3_3 bit,GZ_1_4_2_3_4 bit,GZ_1_4_2_3_4_1 bit,GZ_1_4_2_3_4_2 bit,GZ_1_4_2_3_4_3 bit,GZ_1_4_2_4 bit,GZ_1_4_2_5 bit,GZ_1_4_2_5_1 bit,GZ_1_4_2_5_2 bit,GZ_1_4_2_6 bit,GZ_1_4_2_7 bit,GZ_1_4_3_1 bit,GZ_1_4_3_2 bit,GZ_1_4_5_1 bit,GZ_1_4_5_2 bit,GZ_1_4_5_3 bit,GZ_1_4_5_1_1 bit,GZ_1_4_5_1_2 bit,GZ_1_4_5_2_1 bit,GZ_1_4_5_2_2 bit,    ML_2 bit,ML_2_1 bit,ML_2_2 bit,ML_2_3 bit,ML_2_4 bit,ML_2_5 bit,ML_2_1_1 bit,ML_2_2_1 bit,ML_2_3_1 bit,ML_2_3_2 bit,ML_2_3_3 bit,ML_2_4_1 bit,ML_2_4_2 bit,ML_2_5_1 bit,  FR_3 bit,FR_3_1 bit,FR_3_2 bit,FR_3_3 bit,PRIMARY KEY (id))");

                // SqlBankClass.CeratTable("Create Table tbl_AmarTahlil_Rozane (Tarihk char(10),maglaghAnbar bigint,maglaghPoe_E bigint,maglaghPoe_S bigint)");

                // SqlBankClass.CeratTable("Create Table tbl_MahSal (id int IDENTITY(1,1),name nvarchar(50),PRIMARY KEY (id))");

                // SqlBankClass.CeratTable("Create Table tbl_SabtDaryaftiha (id int IDENTITY(1,1),idp int,idDaryafti int,sal nchar(4),mah nvarchar(20),Tarihk nchar(10),maglagh bigint,Tozihat nvarchar(100),PRIMARY KEY (id))");


                // SqlBankClass.CeratTable("Create Table tbl_Set_Ha_DA_inProje (id int IDENTITY(1,1),idp int,idHazine int,idDaramad int,PRIMARY KEY (id))");

                // SqlBankClass.CeratTable("Create Table tbl_EtelatCheck_Babat (Babat nvarchar(100))");
                // SqlBankClass.CeratTable("Create Table tbl_EtelatCheck_Tozihat (Tozihat nvarchar(100))");

                // SqlBankClass.CeratTable("Create Table tbl_SabtMoshtariha (id int IDENTITY(1,1), nameMoshtary nvarchar(150),nameTarafHasab nvarchar(150),nameBank nvarchar(50),ShHasab nvarchar(30),PRIMARY KEY (id)) ");

                // SqlBankClass.CeratTable("Create Table WitedrawalDepositAmmount_Cofrer (id int , Id_Account bigint,Amount float,Id_Person bigint)");

                // SqlBankClass.CeratTable("Create Table tbl_Amar_Porsion_TajmiByRiyal (Tarihk nchar(10),maglagh float) ");
                //-------------------------------------------------------
                //افزودن فیلد جدید در یک جدول


                //{// فقط برای سطح دسترسی
                //    string txtsql = "AP_1_2_6 bit,GZ_1_4_3_3 bit,GZ_1_4_3_4 bit,GZ_1_4_3_5 bit,GZ_1_4_5_1_3 bit";
                //     SqlBankClass.AddColumnInTable("ALTER TABLE tbt_Set_Dasresi ADD " + txtsql);

                //    DataTable dtlist =  SqlBankClass.ReadTableFromBank_InsertToDataTable("SELECT COLUMN_NAME FROM  	INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbt_Set_Dasresi'");


                //    for (int i = 2; i < dtlist.Rows.Count; i++)
                //    {
                //         SqlBankClass.Update("tbt_Set_Dasresi", dtlist.Rows[i][0].ToString() + " IS NULL", dtlist.Rows[i][0].ToString(), "True");
                //    }

                //}



                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_Sabt_Export_KalaAsAnbar ADD TarikhEdit char(10)");
                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_Sabt_Porsion ADD TarikhEdit char(10)");

                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_SabtSoratvazyat_Mahane ADD Tozihat nvarchar(200)");

                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_Daramad_Ja ADD isByZarib bit");
                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_SabtDaramadha ADD idNoeSoratVaziyat int");


                //-------------------------------------------------------
                //تغییر نوع داده در ستون

                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_SabtSoratvazyat_Mahane ALTER COLUMN Onvan int");
                //-------------------------------------------------------
                //حذف یک ستون

                // SqlBankClass.AddColumnInTable("ALTER TABLE tbl_SabtMoshtariha DROP COLUMN nameTarafHasab");
                //-------------------------------------------------------
                //ساخت Views

                // SqlBankClass.AddColumnInTable("Drop view  View_tbl_Sabt_Export_KalaAsAnbar");
                // SqlBankClass.AddColumnInTable("CREATE VIEW [View_tbl_Sabt_Export_KalaAsAnbar] AS " + txt);

                // SqlBankClass.AddColumnInTable("Drop view  View_tbl_Sabt_Porsion");
                // SqlBankClass.AddColumnInTable("CREATE VIEW [View_tbl_Sabt_Porsion] AS " + txt1);

                // SqlBankClass.AddColumnInTable("Drop view View_tbl_SabtSoratvazyat_Mahane");
                // SqlBankClass.AddColumnInTable("CREATE VIEW [View_tbl_SabtSoratvazyat_Mahane] AS " + txt1);

                // SqlBankClass.AddColumnInTable("Drop view  View_tbl_SabtDaramadha");
                // SqlBankClass.AddColumnInTable("CREATE VIEW [View_tbl_SabtDaramadha] AS " + txt2);

                //------------------------------------------------------            //افزودن مقدار در تنظیمات
                //if ( SqlBankClass.CountValueIn1Field_Repeat("select count(id) from tbl_Tanzimat where id=20") == 0)
                //{
                //     SqlBankClass.Insert("insert into tbl_Tanzimat(id,name,txt) values(20,'Version','" + Verson + "')");
                //}

                //if ( SqlBankClass.CountValueIn1Field_Repeat("select count(id) from tbl_Tanzimat where id=18") == 0)
                //{
                //     SqlBankClass.Insert("insert into tbl_Tanzimat(id,TF) values(18,'False')");
                //}

                //------------------------------------------------------            //محاسبات




                //tbl_NoeSoratVaziyat
                //if ( SqlBankClass.CountValueIn1Field_Repeat("select count(*) from tbl_NoeSoratVaziyat") == 0)
                //{
                //     SqlBankClass.Insert("tbl_NoeSoratVaziyat", "موقت");
                //     SqlBankClass.Insert("tbl_NoeSoratVaziyat", "قطعی");

                //}

                //if ( SqlBankClass.CountValueIn1Field_Repeat("select count(*) from tbl_MahSal") == 0)
                //{
                //     SqlBankClass.Insert("tbl_MahSal", "فروردین");
                //     SqlBankClass.Insert("tbl_MahSal", "اردیبهشت");
                //     SqlBankClass.Insert("tbl_MahSal", "خرداد");
                //     SqlBankClass.Insert("tbl_MahSal", "تیر");
                //     SqlBankClass.Insert("tbl_MahSal", "مرداد");
                //     SqlBankClass.Insert("tbl_MahSal", "شهریور");
                //     SqlBankClass.Insert("tbl_MahSal", "مهر");
                //     SqlBankClass.Insert("tbl_MahSal", "آبان");
                //     SqlBankClass.Insert("tbl_MahSal", "آذر");
                //     SqlBankClass.Insert("tbl_MahSal", "دی");
                //     SqlBankClass.Insert("tbl_MahSal", "بهمن");
                //     SqlBankClass.Insert("tbl_MahSal", "اسفند");

                //}


                // SqlBankClass.Update("tbl_SabtSoratvazyat_Mahane", "id=2", "Onvan", "1");
                // SqlBankClass.Update("tbl_Sabt_Export_KalaAsAnbar", "SabtNahaii='0'", "SabtNahaii", "N");
                // SqlBankClass.Update("tbl_Sabt_Export_KalaAsAnbar", "SabtNahaii='1'", "SabtNahaii", "Y");

                // SqlBankClass.Update("tbl_Sabt_Porsion", "SabtNahaii='0'", "SabtNahaii", "N");
                // SqlBankClass.Update("tbl_Sabt_Porsion", "SabtNahaii='1'", "SabtNahaii", "Y");


                // SqlBankClass.Update("tbl_Sabt_Export_KalaAsAnbar", "Per_Sabt is null", "Per_Sabt", "1");
                // SqlBankClass.Update("tbl_Sabt_Export_KalaAsAnbar", "Per_Edit is null", "Per_Edit", "1");
                // SqlBankClass.Update("tbl_Sabt_Porsion", "Per_Sabt is null", "Per_Sabt", "1");
                // SqlBankClass.Update("tbl_Sabt_Porsion", "Per_Edit is null", "Per_Edit", "1");

                // SqlBankClass.Update("tbl_Sabt_Porsion", "SabtNahaii='0'", "SabtNahaii", "N");
                // SqlBankClass.Update("tbl_Sabt_Porsion", "SabtNahaii='1'", "SabtNahaii", "Y");



                // SqlBankClass.Update("tbl_KalaToGhza", "id_menuGhaza=498", "idp", "4");
                // SqlBankClass.Delete("tbl_KalaToGhza", "id_menuGhaza=532 and idp=3");
                // SqlBankClass.Delete("tbl_KalaToGhza", "id_menuGhaza=531 and idp=3");

                //DataTable dt =  SqlBankClass.ReadTableFromBank_InsertToDataTable("select * from tbl_SabtSoratvazyat_Mahane");

                //double Dif = 0;
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    Dif = double.Parse(dt.Rows[i]["maglagh2"].ToString()) - double.Parse(dt.Rows[i]["maglagh1"].ToString());

                //     SqlBankClass.Update("tbl_SabtSoratvazyat_Mahane", "id=" + dt.Rows[i][0].ToString(), "Dif_mablagh", Dif);
                //}


                //string[] txt = new string[] { "تاریخ به عدد", "تاریخ به حروف", "مبلغ به عدد", "مبلغ به حروف", "در وجه", "توضیحات" };
                //{
                //    string lable = "";
                //    int dis = 0;
                //    for (int i = 0; i <= 5; i++)
                //    {
                //        for (int j = 0; j < 3; j++)
                //        {
                //            switch (j)
                //            {
                //                case 0:
                //                    lable = "L";
                //                    dis = 20;
                //                    break;
                //                case 1:

                //                    lable = "T";
                //                    dis = 50;

                //                    break;
                //                case 2:
                //                    lable = "S";
                //                    dis = 9;

                //                    break;
                //            }

                //             SqlBankClass.Insert("tbl_Setings_Check_New", i + 1, j + 1, txt[i], lable, dis);
                //        }
                //    }
                //}

                #endregion

                // PublicClass.SaveMesseg("اطلاعات بروزرسانی شد" + '\n' + "Verson: " + Verson);

                return true;
            }
            //return false;
        }
        #endregion
    }
}


using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Customer
{
    /// <summary>
    /// جدول مشتری ها
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        
        /// <summary>
        /// نام مشتری
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// فامیلی
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// کد ملی /اقتصادی
        /// </summary>
        public string CodMeli { get; set; }
        
        /// <summary>
        /// کد نوع مشتری حقیقی/حقوقی
        /// </summary>
        public int id_TypeCustomer { get; set; }
        /// <summary>
        /// شهر
        /// </summary>
        public int CityId { get; set; }
          /// <summary>
        /// تلفن
        /// </summary>
        ///
     
        public string Tel { get; set; }
        
        /// <summary>
        /// تلفن
        /// </summary>

        public string Tel2 { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        public string Adders { get; set; }
        
        /// <summary>
        /// آدرس
        /// </summary>
        public string Adders2 { get; set; }
        
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// نام بانک
        /// </summary>
        public string BanckName {  get; set; }
        public int? BanckId { get; set; } = 0;
        
        /// <summary>
        /// شماره شبا
        /// </summary>
        public string SeryalShaba { get; set; }
        
        /// <summary>
        /// شماره کارت عابربانک
        /// </summary>
        public string  DabitCardNumber {  get; set; }
        ///// <summary>
        ///// مانده ابتدای دوره
        ///// </summary>
        //public double BeginningBanace   { get; set; }
        ///// <summary>
        ///// ماهیت حساب
        ///// </summary>
        //public int? NatureAccountsId { get; set; }
        ///// <summary>
        ///// کد حساب معین
        ///// </summary>
        //public int SpecificAccountsId { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// کد برای توسعه برنامه
        /// </summary>
        public int SecretCode {  get; set; }

        public virtual TypeCustomer.TypeCustomer TypeCustomer { get; set; }
        public virtual ICollection<Draver.Draver> Dravers { get; set; }
        public virtual ICollection <Car.Car > Car { get; set; }
    }
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(100);
            Property(c => c.Family).HasMaxLength(100);
            Property(c => c.CodMeli).HasMaxLength(12);
            Property(c => c.Tel).HasMaxLength(12);
            Property(c => c.Adders).HasMaxLength(150);
            Property(c => c.Tel2).HasMaxLength(12);
            Property(c => c.Adders2).HasMaxLength(150);
            Property(c => c.PostalCode).HasMaxLength(12);
            Property(c => c.BanckName).HasMaxLength(50);

            Property(c => c.Description).HasMaxLength(int.MaxValue);
        }
    }

}

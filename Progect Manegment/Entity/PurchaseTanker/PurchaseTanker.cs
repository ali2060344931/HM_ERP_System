using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.PurchaseTanker
{
    /// <summary>
    /// خرید تانکرها
    /// </summary>
    public class PurchaseTanker
    {
        public int Id { get; set; }

        public String Date { get; set; }
        /// <summary>
        /// شماره تانکر
        /// </summary>
        public int TankerNo { get; set; }
        /// <summary>
        /// فروشنده
        /// </summary>
        public int SellerId { get; set; }
        /// <summary>
        /// خریدار
        /// </summary>
        public int BuyerId { get; set; }
        /// <summary>
        /// تعداد محور
        /// </summary>
        public int NumberAxles { get; set; }
        /// <summary>
        /// نوع یدک
        /// </summary>
        public int TypeTrailerId { get; set; }
        /// <summary>
        /// نوع شاسی و کپسول
        /// </summary>
        public string TypeChassisCapsule { get; set; }
        /// <summary>
        /// کارخانه سازنده
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// وضعیت سند
        /// </summary>
        public string DocumentStatus { get; set; }
        /// <summary>
        /// شماره پلاک قبلی
        /// </summary>
        public int PreviousPlateNumber { get; set; }
        /// <summary>
        /// شماره پلاک جدید
        /// </summary>
        public int NewPlateNumber { get; set; }
        /// <summary>
        ///  مبلغ خرید 
        /// </summary>
        public long PurchaseAmount { get; set; }
        /// <summary>
        ///  مسدودی بابت سند 
        /// </summary>
        public long BlockedAmountDocument { get; set; }
        /// <summary>
        ///  کمیسیون بنگاه 
        /// </summary>
        public long AgencyCommission { get; set; }
        /// <summary>
        /// وضعیت ثبت سند حسابداری
        /// </summary>
        public bool TransactionsStatuse { get; set; }
    }
    public class PurchaseTankerConfig : EntityTypeConfiguration<PurchaseTanker>
    {
        public PurchaseTankerConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Date).IsRequired().HasMaxLength(10);
            //Property(d => d.TypeTrailer).IsRequired().HasMaxLength(50);
            Property(d => d.TypeChassisCapsule).IsRequired().HasMaxLength(50);
            Property(d => d.Manufacturer).IsRequired().HasMaxLength(50);
            Property(d => d.DocumentStatus).IsRequired().HasMaxLength(50);
        }
    }

}

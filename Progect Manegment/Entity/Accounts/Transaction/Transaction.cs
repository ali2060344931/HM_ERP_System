using System;
using System.Data.Entity.ModelConfiguration;

namespace HM_ERP_System.Entity.Accounts.Transaction
{
    /// <summary>
    /// جدول اسناد حسابداری
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }
        /// <summary>
        /// سال مالی
        /// </summary>
        public string FinancialYear { get; set; }
        /// <summary>
        /// شماره سند
        /// </summary>
        public int TransactionCode { get; set; }
        /// <summary>
        /// ردیف سند
        /// </summary>
        public int Series { get; set; }
        /// <summary>
        /// تاریخ سند
        /// </summary>
        public string TransactionDate { get; set; }
        /// <summary>
        /// نوع سند:درآمد، هزینه و جایجایی
        /// </summary>
        public int TransactionTypeId { get; set; }
        /// <summary>
        /// کد حساب معین
        /// </summary>
        public int SpecificAccountId { get; set; }
        /// <summary>
        /// کد حساب تفصیلی
        /// </summary>
        public int DetailedAccountId { get; set; }
        /// <summary>
        /// کل مبلغ سند
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// مبلغ بدهکار
        /// </summary>
        public double PaymentBed { get; set; }
        /// <summary>
        /// مبلغ بستانکار
        /// </summary>
        public double PaymentBes { get; set; }
        /// <summary>
        /// کد بارنامه
        /// </summary>
        public int? ComerBId { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// شماره سریال اسناد رسید/حواله
        /// </summary>
        public string SeryalNumber { get; set; }
        /// <summary>
        /// وضعیت ابطال سند
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// وضعیت ثبت نهایی
        /// </summary>
        public bool FinalRegistry { get; set; }
        
        /// <summary>
        /// آیا سند اتوماتیک می باشد
        /// </summary>
        public bool IsAutoRejDoc { get; set; }
        /// <summary>
        /// آیا سند مانده ابتدای دوره است؟
        /// </summary>
        public bool IsBeginningBalance {  get; set; }
        /// <summary>
        /// شخص ثبت کننده حساب
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// زمان ثبت
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;
    }

    public class TransactionConfig : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.FinancialYear).IsRequired().HasMaxLength(15);

            Property(d => d.TransactionDate).IsRequired().HasMaxLength(11);
            Property(d => d.Description).HasMaxLength(int.MaxValue);
            Property(d => d.SeryalNumber).HasMaxLength(15);
        }
    }

}

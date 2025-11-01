using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Cheque
{
    /// <summary>
    /// جدول ثبت چک ها
    /// </summary>
    public class Cheque
    {
        public int Id { get; set; }
        /// <summary>
        /// نوع چک: دریافتی یا پرداختی
        /// </summary>
        public int ChequeTypeId { get; set; }
        /// <summary>
        /// شماره سریال چک
        /// </summary>
        public string ChequeNumber { get; set; }
        /// <summary>
        /// مبلغ
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// تاریخ سررسید
        /// </summary>
        public string DueDate { get; set; }
        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public string IssueDate { get; set; }
        /// <summary>
        /// نام بانک
        /// </summary>
        //public string BankName { get; set; }
        public int BankId { get; set; }

        /// <summary>
        /// کد تفصیلی طرف حساب (مشتری یا تأمین کننده) که چک را به او داده‌ایم یا از او گرفته‌ایم
        /// </summary>
        public int Payer_Payee_AccId { get; set; }
        /// <summary>
        ///نام صاحب حساب چک
        /// </summary>
        public string ChequeOwner { get; set; }
        /// <summary>
        /// (وضعیت فعلی چک (لینک به آخرین رکورد در جدول Tbl_ChequeStatus
        /// </summary>
        public int CurrentStatusID { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// شخص ثبت کننده حساب
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// زمان ثبت
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
    public class ChequeConfig : EntityTypeConfiguration<Cheque>
    {
        public ChequeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.ChequeNumber).IsRequired().HasMaxLength(20);
            //Property(d => d.BankName).IsRequired().HasMaxLength(50);
            Property(d => d.ChequeOwner).IsRequired().HasMaxLength(50);
            Property(d => d.DueDate).IsRequired().HasMaxLength(10);
            Property(d => d.IssueDate).IsRequired().HasMaxLength(10);
            Property(d => d.Description).HasMaxLength(int.MaxValue);
        }
    }

}

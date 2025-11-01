using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Cheque
{

    /// <summary>
    /// تاریخچه و وضعیت‌های چک
    /// </summary>
    public class ChequeStatus
    {
        public int Id { get; set; }

        public int ChequeId { get; set; }
        /// <summary>
        /// (کد وصعیت چد: ( 1: در جریان وصول، 2: به صندوق/بانک خوابانده شد، 3: پاس شد، 4: برگشت خورد، 5: خرج شد 6:ثبت شده
        /// </summary>
        public int StatusCodeId { get; set; }
        /// <summary>
        /// تاریخ وقوع این وضعیت
        /// </summary>
        public string StatusDate { get; set; }
        /// <summary>
        /// (لینک به سند حسابداری که در نتیجه این تغییر وضعیت صادر شده است. (اگر سندی صادر شده باشد
        /// </summary>
        public int TransactionId { get; set; }
        /// <summary>
        /// (اگر چک جابجا شده، کد حساب معین جدیدی که چک به آن منتقل شده است (مثلاً از اسناد در جریان وصول به حساب بانک
        /// </summary>
        public int NewLocationAccId { get; set; }
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
        public class ChequeStatusConfig : EntityTypeConfiguration<ChequeStatus>
    {
        public ChequeStatusConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.StatusDate).IsRequired().HasMaxLength(10);
            Property(d => d.Description).HasMaxLength(int.MaxValue);
        }
    }

}

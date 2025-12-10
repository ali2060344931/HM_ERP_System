using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.DetailedAccount
{
    /// <summary>
    /// جدول حساب های تفصیلی
    /// </summary>
    public class DetailedAccount
    {
        public int Id { get; set; }
        /// <summary>
        /// کد حساب تفصیلی
        /// </summary>
        public int CodeAccount { get; set; }

        /// <summary>
        /// کد حساب معین
        /// </summary>
        public int SpecificAccountId { get; set; }
        /// <summary>
        /// کد مشتری/اشخاص
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// کد شعبه بانک ها
        /// </summary>
        public int? BankBrancheId { get; set; } = 0;

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

    }
    public class DetailedAccountConfig : EntityTypeConfiguration<DetailedAccount>
    {
        public DetailedAccountConfig()
        {
            HasKey(x => x.Id);
        }
    }

}

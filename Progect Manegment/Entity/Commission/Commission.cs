using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Commission
{
    /// <summary>
    /// جدول پورسانت ها
    /// </summary>
    public class Commission
    {
        public int Id { get; set; }
        /// <summary>
        /// کد بارنامه
        /// </summary>
        public int ComersBId { get; set; }
        /// <summary>
        /// نوع پورسانت
        /// </summary>
        public int CommissionTypeId { get; set; }
        /// <summary>
        /// کد مشتری
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// مبلغ
        /// </summary>
        public long Amount { get; set; }
        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; set; }
    }
    public class CommissionConfig : EntityTypeConfiguration<Commission>
    {
        public CommissionConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Date).IsRequired().HasMaxLength(10);
        }
    }

}

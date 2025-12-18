using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.FieldActivity
{
    /// <summary>
    /// جدول رشته های فعالیت در انبارها
    /// </summary>
    public class FieldActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

        public virtual ICollection<PlaceTransfer.PlaceTransfer> PlaceTransfers { get; set; }
    }
    public class FieldActivityConfig : EntityTypeConfiguration<FieldActivity>
    {
        public FieldActivityConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }
}

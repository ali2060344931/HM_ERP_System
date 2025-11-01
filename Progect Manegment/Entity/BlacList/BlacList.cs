using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.BlacList
{
    /// <summary>
    /// لیست سیاه
    /// </summary>
    public class BlacList
    {
        public int Id { get; set; }
        /// <summary>
        /// کد اشخاص
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// وضعیت
        /// </summary>
        public bool status { get; set; }
        /// <summary>
        /// عدم ثبت اطلاعات
        /// </summary>
        public bool NoSaveData { get; set; }


    }
        public class BlacListConfig : EntityTypeConfiguration<BlacList>
    {
        public BlacListConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Description).IsRequired().HasMaxLength(int.MaxValue);
        }
    }

}

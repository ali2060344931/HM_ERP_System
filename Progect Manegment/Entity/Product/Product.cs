using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Product
{
    /// <summary>
    /// جدول محصولات
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// گروه کالاها
        /// </summary>
        public int ProductGroupId { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }
    }
    public class ProducttConfig : EntityTypeConfiguration<Product>
    {
        public ProducttConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(100);
        }
    }

}

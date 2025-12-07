using HM_ERP_System.Entity.Accounts.GroupAccount;
using HM_ERP_System.Entity.GoodsTransfer;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Warehouse
{
    /// <summary>
    /// جدول انبارها
    /// </summary>
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// نوع انبار
        /// </summary>
        public int WarehouseTypeId { get; set; }
        /// <summary>
        ///  ظرفیت
        /// </summary>
        public int? Capacity { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Addres { get; set; }
        public WarehouseType WarehouseType { get; set; }
        public virtual ICollection<GoodsIn> GoodsIns { get; set; }
    }

    public class WarehouseConfig : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
            Property(d => d.PostalCode).IsRequired().HasMaxLength(10);
            Property(d => d.Addres).HasMaxLength(500);

            HasRequired(w => w.WarehouseType)
    .WithMany(t => t.Warehouses)
    .HasForeignKey(w => w.WarehouseTypeId)
    .WillCascadeOnDelete(false);

        }
    }

}

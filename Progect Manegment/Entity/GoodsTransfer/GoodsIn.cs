using NPOI.POIFS.Properties;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.GoodsTransfer
{
    /// <summary>
    /// جدول رسید انبارها
    /// </summary>
    public class GoodsIn
    {
        public int Id { get; set; }
        /// <summary>
        /// کد نام انبار
        /// </summary>
        public int WarehouseId { get; set; }
        public virtual Warehouse.Warehouse Warehouse { get; set; }
        /// <summary>
        /// سریال رسید/کوتاژ
        /// </summary>
        public string Seryal { get; set; }
        /// <summary>
        /// کد کالا
        /// </summary>
        public int GoodId { get; set; }
        public virtual Product.Product Product { get; set; }
        /// <summary>
        /// طرف حساب کالا
        /// </summary>
        public int OwnerGoodsId { get; set; }
        public virtual Customer.Customer CustomerO { get; set; }
        /// <summary>
        /// فرستنده کالا
        /// </summary>
        public int SenderId { get; set; }
        public virtual Customer.Customer CustomerS { get; set; }

        /// <summary>
        /// مقدار
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// نقطه سفارش
        /// </summary>
        public double OrderPoint { get; set; }
    }
    public class GoodsInConfig : EntityTypeConfiguration<GoodsIn>
    {
        public GoodsInConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Seryal).IsRequired().HasMaxLength(20);

            //HasRequired(c => c.Warehouse)
            //    .WithMany(p => p.GoodsIns)
            //    .HasForeignKey(c => c.WarehouseId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Product)
            //    .WithMany(p => p.GoodsIns)
            //    .HasForeignKey(child => child.GoodId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.CustomerO)
            //    .WithMany(p => p.GoodsIns)
            //    .HasForeignKey(c => c.OwnerGoodsId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.CustomerS)
            //    .WithMany(p => p.GoodsIns)
            //    .HasForeignKey(c => c.SenderId)
            //    .WillCascadeOnDelete(false);
        }
    }
}

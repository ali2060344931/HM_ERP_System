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
        public int WarehouseTypeId { get; set; }
        public int? Capacity { get; set; }
        public string Addres { get; set; }

    }
    public class WarehouseConfig : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
            Property(d => d.Addres).HasMaxLength(500);


        }
    }

}

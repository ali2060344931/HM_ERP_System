using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Warehouse
{
    /// <summary>
    /// نوع انبار
    /// </summary>
    public class WarehouseType
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
            public class WarehouseTypeConfig : EntityTypeConfiguration<WarehouseType>
    {
        public WarehouseTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Product
{
    /// <summary>
    /// جدول گروه کالاها
    /// </summary>
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class ProductGroupConfig : EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.WarantyType
{
    /// <summary>
    /// جدول نوع ضوانت
    /// </summary>
    public class WarantyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class WarantyTypeConfig : EntityTypeConfiguration<WarantyType>
    {
        public WarantyTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

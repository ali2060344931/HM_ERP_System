using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Unit
{
    /// <summary>
    /// جدول واحد اندازه گیری
    /// </summary>
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class UnittConfig : EntityTypeConfiguration<Unit>
    {
        public UnittConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }

}

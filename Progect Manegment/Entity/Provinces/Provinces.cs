using HM_ERP_System.Entity.Ciltys;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Provinces
{
    /// <summary>
    /// جدول استان ها
    /// </summary>
    public class Provinces
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ciltys.Ciltys> Ciltys { get; set; }
    }
    public class ProvincesConfig : EntityTypeConfiguration<Provinces>
    {
        public ProvincesConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }
}

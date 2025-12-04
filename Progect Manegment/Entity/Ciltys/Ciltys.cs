using HM_ERP_System.Entity.Accounts.TotalAccount;
using HM_ERP_System.Entity.Unit;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Ciltys
{
    /// <summary>
    /// جدول شهرها
    /// </summary>
    public class Ciltys
    {
        public int Id { get; set; }
        public int ProvincesId { get; set; }
        public string Name { get; set; }
        public virtual Provinces.Provinces Provinces { get; set; }
    }
    public class CiltysConfig : EntityTypeConfiguration<Ciltys>
    {
        public CiltysConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);

            HasRequired(c => c.Provinces)
            .WithMany(p => p.Ciltys)
            .HasForeignKey(c => c.ProvincesId)
            .WillCascadeOnDelete(false);
        }
    }


}

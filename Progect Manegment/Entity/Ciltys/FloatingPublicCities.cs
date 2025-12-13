using DocumentFormat.OpenXml.Bibliography;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Ciltys
{
    /// <summary>
    /// جدول شهرهای عمومی شناور
    /// </summary>
    public  class FloatingPublicCities
    {
        public int Id { get; set; }
        
        public int PlaceTransferId { get; set; }
        public virtual PlaceTransfer.PlaceTransfer PlaceTransfer { get; set; }
        
        public int CiltysId { get; set; }
        public virtual Ciltys Ciltys { get; set; }

    }
        public class FloatingPublicCitiesxConfig : EntityTypeConfiguration<FloatingPublicCities>
    {
        public FloatingPublicCitiesxConfig()
        {
            HasKey(x => x.Id);

            HasRequired(c => c.Ciltys)
            .WithMany(p => p.FloatingPublicCities)
            .HasForeignKey(c => c.CiltysId)
            .WillCascadeOnDelete(false);

            HasRequired(c => c.PlaceTransfer)
            .WithMany(p => p.FloatingPublicCities)
            .HasForeignKey(c => c.PlaceTransferId)
            .WillCascadeOnDelete(false);
        }
    }

}

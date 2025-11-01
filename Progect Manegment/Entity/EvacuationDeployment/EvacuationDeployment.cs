using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.EvacuationDeployment
{
    /// <summary>
    /// بارگیری، تخلیه
    /// </summary>
    public class EvacuationDeployment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PlaceTransfer.PlaceTransfer> PlaceTransfers { get; set; }

    }
    public class EvacuationDeploymentConfig : EntityTypeConfiguration<EvacuationDeployment>
    {
        public EvacuationDeploymentConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(10);
        }
    }

}

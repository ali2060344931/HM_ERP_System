using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Ownership
{
    /// <summary>
    /// وضعیت مالکیت
    /// </summary>
    public class Ownership
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car.Car> Cars { get; set; }
    }
    public class OwnershipConfig : EntityTypeConfiguration<Ownership>
    {
        public OwnershipConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(10);
        }
    }

}

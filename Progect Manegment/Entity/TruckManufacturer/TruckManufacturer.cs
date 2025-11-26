using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TruckManufacturer
{
    /// <summary>
    /// جدول کارخانه سازنده کامیون ها
    /// </summary>
    public class TruckManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car.Car> Cars { get; set; }
    }
    public class TruckManufacturerConfig : EntityTypeConfiguration<TruckManufacturer>
    {
        public TruckManufacturerConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

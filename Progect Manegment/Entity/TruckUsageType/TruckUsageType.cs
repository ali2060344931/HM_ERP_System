using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TruckUsageType
{
    /// <summary>
    /// جدول نوع کاربری کامیون
    /// </summary>
    public class TruckUsageType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car.Car> Cars { get; set; }
    }
        public class TruckUsageTypeConfig : EntityTypeConfiguration<TruckUsageType>
    {
        public TruckUsageTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(25);
        }
    }

}

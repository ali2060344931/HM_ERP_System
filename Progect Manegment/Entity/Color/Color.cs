using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Color
{
    public class Color_
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car.Car> Cars { get; set; }
    }
    public class ColorConfig : EntityTypeConfiguration<Color_>
    {
        public ColorConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Ship
{
    /// <summary>
    /// جدول کشتی هل
    /// </summary>
    public  class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ShipConfig : EntityTypeConfiguration<Ship>
    {
        public ShipConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }


}

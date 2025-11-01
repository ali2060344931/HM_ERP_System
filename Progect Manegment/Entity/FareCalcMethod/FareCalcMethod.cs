using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.FareCalcMethod
{
    /// <summary>
    /// نحوه محاسبه کرایه
    /// </summary>
    public class FareCalcMethod
    {

        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class FareCalcMethodConfig : EntityTypeConfiguration<FareCalcMethod>
    {
        public FareCalcMethodConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(20);
        }
    }
}

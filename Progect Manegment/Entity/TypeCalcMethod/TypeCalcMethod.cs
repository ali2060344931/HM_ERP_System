using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TypeCalcMethod
{
    /// <summary>
    /// نوع محاسبه کرایه کالاها: تناژ، بارنامه، درصدی
    /// </summary>
    public class TypeCalcMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Comers.ComersB> ComersB { get; set; }

    }
    public class TypeCalcMethodConfig : EntityTypeConfiguration<TypeCalcMethod>
    {
        public TypeCalcMethodConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(20);
        }
    }
}
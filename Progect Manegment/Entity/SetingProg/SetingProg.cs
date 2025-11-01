using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.SetingProg
{
    /// <summary>
    /// جدول تنظیمات
    /// </summary>
    public class SetingProg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int IntValue { get; set; }
        public bool BoolValue { get; set; }
        public string stringValue { get; set; }
        public double doubleValue { get; set; }
    }
        public class SetingProgConfig : EntityTypeConfiguration<SetingProg>
    {
        public SetingProgConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).HasMaxLength(100);
            Property(d => d.stringValue).HasMaxLength(100);
        }
    }

}

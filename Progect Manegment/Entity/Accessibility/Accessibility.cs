using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accessibility
{
    /// <summary>
    /// جدول سطح دسترسی
    /// </summary>
    public class Accessibility
    {
        public int Id { get; set; }
        public string Des { get; set; }
        public string FildName { get; set; }
        public bool Lavel0 { get; set; }
        public bool Lavel1 { get; set; }
        public bool Lavel2 { get; set; }
        public bool Lavel3 { get; set; }
        public bool Lavel4 { get; set; }
        public bool Lavel5 { get; set; }
        public bool Lavel6 { get; set; }
        public bool Lavel7 { get; set; }
        public bool Lavel8 { get; set; }
        public bool Lavel9 { get; set; }
        public bool Lavel10 { get; set; }
    }
        public class AccessibilityConfig : EntityTypeConfiguration<Accessibility>
    {
        public AccessibilityConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Des).IsRequired().HasMaxLength(50);
            HasKey(x => x.Id);
            Property(d => d.FildName).IsRequired().HasMaxLength(30);
        }
    }

}

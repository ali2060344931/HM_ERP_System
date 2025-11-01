using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Peremission
{
    /// <summary>
    /// مجوزهای قابلیت دسترسی(مثلا: دیدنفرم، ویرایش، حذف و غیره
    /// </summary>
    public class Peremission
    {
        public int Id { get; set; }
        public string Des { get; set; }
        public string NodeName { get; set; }
        public string Rot { get; set; }
        //public bool Status { get; set; }
    }
    public class PeremissionConfig : EntityTypeConfiguration<Peremission>
    {
        public PeremissionConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Des).IsRequired().HasMaxLength(100);
            Property(d => d.NodeName).IsRequired().HasMaxLength(50);
            Property(d => d.Rot).HasMaxLength(int.MaxValue);

        }
    }

}

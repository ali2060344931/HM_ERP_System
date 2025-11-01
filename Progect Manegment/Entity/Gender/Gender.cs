using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Gender
{
    /// <summary>
    /// جدول جنسیت
    /// </summary>
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

        public class GenderConfig : EntityTypeConfiguration<Gender>
    {
        public GenderConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(10);
        }
    }

}

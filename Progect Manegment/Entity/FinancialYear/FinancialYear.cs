using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.FinancialYear
{
    /// <summary>
    /// جدول سال مالی
    /// </summary>
    public  class FinancialYear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }

    }
        public class FinancialYearConfig : EntityTypeConfiguration<FinancialYear>
    {
        public FinancialYearConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
            Property(d => d.DateStart).IsRequired().HasMaxLength(10);
            Property(d => d.DateEnd).IsRequired().HasMaxLength(10);
        }
    }

}

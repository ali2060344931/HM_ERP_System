using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.FinancialDocumentRegistrationUnit
{
    /// <summary>
    /// FinancialDocumentRegistrationUnit واحد ثبت سند مالی
    /// 
    /// </summary>
    public class FDRU
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class FDRUConfig : EntityTypeConfiguration<FDRU>
    {
        public FDRUConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }
}

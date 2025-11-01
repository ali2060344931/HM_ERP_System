using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Cheque
{
    /// <summary>
    /// نوع چک 1.دریافتنی 2.پرداختنی
    /// </summary>
    public class ChequeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ChequeTypeConfig : EntityTypeConfiguration<ChequeType>
    {
        public ChequeTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

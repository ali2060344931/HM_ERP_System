using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TransactionFee
{
    /// <summary>
    /// جدول نوع تراکنش: نقدی، غیر نقدی
    /// </summary>
    public class TransactionFee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class TransactionFeeConfig : EntityTypeConfiguration<TransactionFee>
    {
        public TransactionFeeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(10);
        }
    }


}

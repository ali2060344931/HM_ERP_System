using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.TransactionType
{
    /// <summary>
    /// نوع سند حسابداری:درآمد، هزینه یا جابجایی
    /// </summary>
    public  class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class TransactionTypeConfig : EntityTypeConfiguration<TransactionType>
    {
        public TransactionTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

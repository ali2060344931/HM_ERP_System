using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.BillLadingWriterPercent
{
    /// <summary>
    /// جدول درصد بارنامه نویس
    /// </summary>
    public class BillLadingWriterPercent
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Percent { get; set; }
    }
        public class BillLadingWriterPercentConfig : EntityTypeConfiguration<BillLadingWriterPercent>
    {
        public BillLadingWriterPercentConfig()
        {
            HasKey(x => x.Id);
            //Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

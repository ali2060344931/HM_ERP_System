using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Spare
{
    /// <summary>
    /// جدول نوع اجاره
    /// </summary>
    public  class RentalType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class RentalTypeConfig : EntityTypeConfiguration<RentalType>
    {
        public RentalTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

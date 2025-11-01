using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.PaymentMethod
{
    /// <summary>
    /// جدول پرداخت هزینه بارگیری توسط
    /// </summary>
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class PaymentMethodConfig : EntityTypeConfiguration<PaymentMethod>
    {
        public PaymentMethodConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }

}

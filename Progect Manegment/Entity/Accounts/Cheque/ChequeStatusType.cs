using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Cheque
{
    /// <summary>
    /// (کد وصعیت چد: ( 1: در جریان وصول، 2: به صندوق/بانک خوابانده شد، 3: پاس شد، 4: برگشت خورد، 5: خرج شد 6:ثبت شده
    /// </summary>
    public class ChequeStatusType
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class ChequeStatusTypeConfig : EntityTypeConfiguration<ChequeStatusType>
    {
        public ChequeStatusTypeConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}

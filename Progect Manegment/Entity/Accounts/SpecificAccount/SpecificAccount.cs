using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.SpecificAccount
{
    /// <summary>
    /// حساب های معین
    /// </summary>
    public class SpecificAccount
    {
        public int Id { get; set; }
        public int Cod { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// ماهیت حساب
        /// </summary>
        //public int Id_MahiyatHesab { get; set; }
        /// <summary>
        /// کد حساب کل
        /// </summary>
        public int Id_TotalAccount { get; set; }
        /// <summary>
        /// کد نوع سند
        /// </summary>
        public int? Id_TypeDocuments { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public bool Status { get; set; } = true;

        /// <summary>
        /// حساب پیش فرض
        /// </summary>
        public bool DefaultAccounts { get; set; }

        //public ICollection<MahiyatHesab> mahiyatHesabs { get; set; }//ماهیت حساب ها

    }
    public class SpecificAccountConfig : EntityTypeConfiguration<SpecificAccount>
    {
        public SpecificAccountConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(200);

        }

    }
}

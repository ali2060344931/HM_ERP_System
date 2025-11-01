using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TypeDocument
{
    /// <summary>
    /// نوع سند
    /// </summary>
    public  class TypeDocument
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
        public class TypeDocumentConfig : EntityTypeConfiguration<TypeDocument>
    {
        public TypeDocumentConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(20);
        }
    }

}

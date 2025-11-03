using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.ImageCo
{
    /// <summary>
    /// جدول لگوی شرکت
    /// </summary>
    public class ImageCo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

    }
    public class ImageCoConfig : EntityTypeConfiguration<ImageCo>
    {
        public ImageCoConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}

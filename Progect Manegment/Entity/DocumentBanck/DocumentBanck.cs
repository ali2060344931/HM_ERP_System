using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.DocumentBanck
{
    /// <summary>
    /// جدول ثبت اسناد و مدارک
    /// </summary>
    public class DocumentBanck
    {
        public int Id { get; set; }
        /// <summary>
        /// موضوع/نام فایل
        /// </summary>
        public string MoZoFile { get; set; }
        /// <summary>
        /// نام فرم
        /// </summary>
        public string FormName { get; set; }
        /// <summary>
        /// کد لیست منتخب
        /// </summary>
        public int ListInFoemId { get; set; }
        /// <summary>
        /// نام فایل با پسوند
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// پسوند فایل
        /// </summary>
        public string File_Title { get; set; }
        /// <summary>
        /// اندازه فایل
        /// </summary>
        public long LengthFile { get; set; }
        /// <summary>
        /// فایل
        /// </summary>
        public byte[] Data { get; set; }
    }
    public class DocumentBanckConfig : EntityTypeConfiguration<DocumentBanck>
    {
        public DocumentBanckConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.MoZoFile).IsRequired().HasMaxLength(100);
            Property(c => c.FormName).IsRequired().HasMaxLength(100);
            Property(c => c.File_Title).IsRequired().HasMaxLength(20);
        }
    }
}

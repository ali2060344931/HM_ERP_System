using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class.EntityGpt
{
    public class CustomerQueryEntity
    {
        public string NameOrFamily { get; set; }
        public string City { get; set; }
        public string Field { get; set; }
        public bool? IsLegal { get; set; } // حقوقی / حقیقی
        public string NationalCode { get; set; }
    }
}

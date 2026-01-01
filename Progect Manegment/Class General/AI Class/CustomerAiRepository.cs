using HM_ERP_System.Class_General.AI_Class.EntityGpt;

using Microsoft.EntityFrameworkCore;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public class CustomerAiRepository : ICustomerAiRepository
    {

        public object Query(CustomerQueryEntity e, AiIntent intent)
        {
            var db = new DBcontextModel();

            var q = db.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(e.NameOrFamily))
                q = q.Where(c =>
                    (c.Name + " " + c.Family).Contains(e.NameOrFamily));

            if (e.IsLegal.HasValue)
                q = q.Where(c => c.id_TypeCustomer == (e.IsLegal.Value ? 2 : 1));

            if (!string.IsNullOrEmpty(e.NationalCode))
                q = q.Where(c => c.CodMeli == e.NationalCode);

            if (intent == AiIntent.Customer_FieldValue && !string.IsNullOrEmpty(e.Field))
            {
                return q.Select(c => new
                {
                    Name = c.Name + " " + c.Family,
                    Value = EF.Property<string>(c, e.Field)
                }).ToList();
            }

            return q.Select(c => new
            {
                c.Name,
                c.Family,
                c.Tel,
                c.Adders,
                c.CodMeli
            }).ToList();
        }
    }
}

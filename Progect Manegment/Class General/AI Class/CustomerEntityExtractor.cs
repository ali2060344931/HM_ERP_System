using HM_ERP_System.Class_General.AI_Class.EntityGpt;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public static class CustomerEntityExtractor
    {
        public static CustomerQueryEntity Extract(string question)
        {
            question = Normalize(question);

            var entity = new CustomerQueryEntity();

            if (question.Contains("حقوقی"))
                entity.IsLegal = true;

            if (question.Contains("حقیقی"))
                entity.IsLegal = false;

            if (question.Contains("تلفن"))
                entity.Field = "Tel";

            if (question.Contains("آدرس"))
                entity.Field = "Adders";

            if (question.Contains("کد ملی"))
                entity.Field = "CodMeli";

            // اسم (نسخه ساده – قابل ارتقا)
            var nameMatch = Regex.Match(question, @"(?:نام\s*(?:مشتری)?\s*)([آ-ی\s]+?)(?:\s+است|\s+می‌باشد|$)");
            if (nameMatch.Success)
                entity.NameOrFamily = nameMatch.Groups[1].Value.Trim();

            return entity;
        }

        private static string Normalize(string s)
        {
            return s.Replace("ی", "ي").Replace("ک", "ك").ToLower();
        }
    }
}

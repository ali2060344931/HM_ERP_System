using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System
{
    public class MockAiService : IAiService
    {
        public Task<string> AnalyzeResult(string question, string data)
        {
            // پاسخ‌های شبیه‌سازی‌شده حسابداری
            if (question.Contains("بدهکار"))
            {
                return Task.FromResult(
    @"[MOCK MODE]
بدهکارترین مشتری «شرکت آلفا» است
مبلغ بدهی: 1,250,000,000 ریال

پیشنهاد:
بررسی وضعیت تسویه و اعمال محدودیت اعتباری");
            }

            if (question.Contains("فروش"))
            {
                return Task.FromResult(
    @"[MOCK MODE]
مجموع فروش این دوره: 8,450,000,000 ریال
روند فروش نسبت به دوره قبل افزایشی است");
            }

            // حالت پیش‌فرض
            return Task.FromResult(
    $@"[MOCK MODE]
سؤال دریافت شد:
{question}

داده:
{data}

(این پاسخ شبیه‌سازی شده است)");
        }
    }
}

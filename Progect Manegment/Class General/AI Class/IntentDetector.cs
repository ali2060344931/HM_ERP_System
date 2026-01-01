using System.Linq;
public enum AiIntent
{
    Unknown = 0,
    TopDebtor = 1,
    MonthlySales = 2,
    GetBillOfLadings = 3,   //حواله ها
    Customer_List,          // لیست اشخاص
    Customer_Find,          // پیدا کردن شخص
    Customer_FieldValue,    // گرفتن مقدار یک فیلد (تلفن، آدرس...)
}
public static class IntentDetector
{
    public static AiIntent Detect(string question)
    {
        question = Normalize(question);

        // -------------------------------
        // 1️⃣ Customer – Field Value
        // -------------------------------
        if (ContainsAny(question,
            "تلفن", "شماره", "آدرس", "کد ملی", "شبا", "حساب", "کارت"))
        {
            if (ContainsAny(question,
                "مشتری", "شخص", "اشخاص", "طرف حساب", "شرکت"))
                return AiIntent.Customer_FieldValue;
        }

        // -------------------------------
        // 2️⃣ Customer – List
        // -------------------------------
        if (ContainsAny(question,
            "لیست اشخاص", "لیست مشتری", "لیست طرف حساب",
            "اشخاص", "مشتریان"))
        {
            return AiIntent.Customer_List;
        }

        // -------------------------------
        // 3️⃣ Customer – Find
        // -------------------------------
        if (ContainsAny(question,
            "مشخصات", "اطلاعات", "پیدا کن", "نمایش"))
        {
            if (ContainsAny(question,
                "مشتری", "شخص", "اشخاص", "طرف حساب"))
                return AiIntent.Customer_Find;
        }

        // -------------------------------
        // 4️⃣ Business Intents قبلی
        // -------------------------------
        if (ContainsAny(question, "فروش", "درآمد", "جمع فروش"))
            return AiIntent.MonthlySales;

        if (question.Contains("بدهکار"))
            return AiIntent.TopDebtor;

        if (ContainsAny(question,
            "حواله", "بارنامه", "پورسانت",
            "کامیون", "راننده", "پلاک"))
            return AiIntent.GetBillOfLadings;

        return AiIntent.Unknown;
    }

    // -------------------------------
    // Helpers
    // -------------------------------
    private static bool ContainsAny(string text, params string[] words)
    {
        return words.Any(w => text.Contains(w));
    }

    private static string Normalize(string input)
    {
        return input
            .Replace("ي", "ی")
            .Replace("ك", "ک")
            .Trim()
            .ToLower();
    }
}

/*
public static class IntentDetector
{
    public static AiIntent Detect(string question)
    {
        question = Normalize(question);

        if (question.Contains("فروش") ||
            question.Contains("درآمد") ||
            question.Contains("جمع فروش"))
            return AiIntent.MonthlySales;

        if (question.Contains("بدهکار"))
            return AiIntent.TopDebtor;
        if (question.Contains("حواله") || question.Contains("بارنامه") || question.Contains("پورسانت") || question.Contains("کامیون") || question.Contains("راننده") || question.Contains("پلاک"))
            return AiIntent.GetBillOfLadings;
        
        return AiIntent.Unknown;
    }

    private static string Normalize(string input)
    {
        return input
            .Replace("ي", "ی")
            .Replace("ك", "ک")
            .Trim()
            .ToLower();
    }
}
*/

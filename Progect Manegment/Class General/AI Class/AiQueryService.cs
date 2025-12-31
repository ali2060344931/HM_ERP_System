using HM_ERP_System.Class_General.AI_Class;
using HM_ERP_System.Entity.AiQuestionLog;

using Microsoft.ML;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using static MyClass.PersianDate;

public class AiQueryService
{
    private readonly IAccountingAiRepository _repo;
    private readonly MLContext _mlContext;
    private PredictionEngine<AiTrainingData, AiPrediction> _predictor;
    private string _modelPath;

    public AiQueryService(IAccountingAiRepository repo, string modelFileName = "IntentModel.zip")
    {
        _repo = repo;
        _mlContext = new MLContext();
        _modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, modelFileName);

        // بارگذاری مدل یا آموزش اولیه
        if (!File.Exists(_modelPath))
            AiModelTrainer.TrainAndSaveModel(modelFileName);

        LoadModel();
    }

    private void LoadModel()
    {
        var trainedModel = _mlContext.Model.Load(_modelPath, out var schema);
        _predictor = _mlContext.Model.CreatePredictionEngine<AiTrainingData, AiPrediction>(trainedModel);
    }

    public AiResponse Execute(string question)
    {
        // 1️⃣ ثبت سؤال
        using (var db = new DBcontextModel())
        {
            db.AiQuestionLogs.Add(new AiQuestionLog
            {
                Question = question,
                Intent = "Unknown",
                CreateDate = DateTime.Now
            });
            db.SaveChanges();
        }

        // 2️⃣ تشخیص Intent با Rule-Based
        var intent = IntentDetector.Detect(question);

        // 3️⃣ اگر Rule-Based جواب نداد → ML
        if (intent == AiIntent.Unknown)
        {
            var prediction = _predictor.Predict(new AiTrainingData { Text = question });
            if (!Enum.TryParse(prediction.PredictedLabel, out intent))
                intent = AiIntent.Unknown;
        }

        // 4️⃣ پاسخ‌دهی
        switch (intent)
        {
            case AiIntent.TopDebtor:
                var debtor = _repo.GetTopDebtorWithName();
                if (debtor.Amount <= 0)
                    return AiResponse.Fail("بدهکاری یافت نشد.");

                return AiResponse.Ok(
                    intent,
                    debtor,
                    $"بدهکارترین شخص ({debtor.Name}) مبلغ {debtor.Amount:N0} ریال بدهکار است"
                );

            case AiIntent.MonthlySales:
                var (from, to) = PersianDateRules.DetectRange(question);
                var sales = _repo.GetMonthlySales(from, to);

                return AiResponse.Ok(
                    intent,
                    sales,
                    $"میزان فروش از {from} تا {to} برابر است با {sales:N0} ریال"
                );

            case AiIntent.GetBillOfLadings:
                // ۱- استخراج پارامترها
                var (fromStr, toStr) = PersianDateRules.DetectRange(question);
                var hideIfInCommission = question.Contains("بدون پورسانت");
                string driverName = ExtractDriverName(question); // یک متد ساده برای استخراج نام

                // ۲- اجرای کوئری
              //FilldgvListB(grid, fromStr, toStr, null, driverName, hideIfInCommission);

                return AiResponse.Ok(intent, null, "لیست بارنامه‌ها بارگذاری شد");



            default:
                return AiResponse.Fail("سؤال قابل تحلیل نیست.");
        }
    }

    private string ExtractDriverName(string question)
    {
        if (question.Contains("راننده"))
        {
            int idx = question.IndexOf("راننده") + 6;
            var name = question.Substring(idx).Trim();
            if (!string.IsNullOrEmpty(name))
                return name;
        }
        return null;
    }
    /*
    public AiResponse Execute(string question)
    {
        // ثبت سوال
        var newEntry = new AiQuestionLog
        {
            Question = question,
            Intent = "Unknown",
            CreateDate = DateTime.Now
        };

        using (var db = new DBcontextModel())
        {
            db.AiQuestionLogs.Add(newEntry);
            db.SaveChanges();
        }

        // Retrain خودکار در Background (اختیاری: فقط اگر تعداد سوالات جدید به حد مشخص رسید)
        Task.Run(() => AiModelTrainer.TrainAndSaveModel());

        // پیش‌بینی Intent با مدل فعلی
        var prediction = _predictor.Predict(new AiTrainingData { Text = question });
        if (!Enum.TryParse<AiIntent>(prediction.PredictedLabel, out var intent))
            intent = AiIntent.Unknown;

        // پاسخ‌دهی Rule-Based
        switch (intent)
        {
            case AiIntent.TopDebtor:
                var debtor = _repo.GetTopDebtorWithName();
                if (debtor.Amount <= 0)
                    return AiResponse.Fail("بدهکاری یافت نشد.");

                return AiResponse.Ok(
                    intent,
                    debtor,
                    $"بدهکارترین شخص ({debtor.Name}) مبلغ {debtor.Amount:N0} ریال بدهکار است"
                );

            case AiIntent.MonthlySales:
                var (from, to) = PersianDateRules.DetectRange(question);
                var sales = _repo.GetMonthlySales(from, to);

                return AiResponse.Ok(
                    intent,
                    sales,
                    $"میزان فروش از {from:yyyy/MM/dd} تا {to:yyyy/MM/dd} برابر است با {sales:N0} ریال"
                );
            default:
                return AiResponse.Fail("سؤال قابل تحلیل نیست.");
        }
    }
    */
}


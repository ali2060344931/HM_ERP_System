using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using Microsoft.ML;
    using Microsoft.ML.Data;

    using Progect_Manegment;

namespace HM_ERP_System.Class_General.AI_Class
{

    public static class AiModelTrainer
    {
        public static void TrainAndSaveModel(string modelFileName = "IntentModel.zip")
        {
            var mlContext = new MLContext();

            // 👇👇👇 اینجا جایی است که جمله‌ها نوشته می‌شوند
            var trainingData = new List<AiTrainingData>
        {
            // ===== Intent: GetBillOfLadings =====
            new AiTrainingData { Text = "بارنامه", Label = "GetBillOfLadings" },
            new AiTrainingData { Text = "لیست بارنامه", Label = "GetBillOfLadings" },
            new AiTrainingData { Text = "بارنامه این هفته", Label = "GetBillOfLadings" },
            new AiTrainingData { Text = "بارنامه بدون پورسانت", Label = "GetBillOfLadings" },
            new AiTrainingData { Text = "بارنامه راننده علی", Label = "GetBillOfLadings" },

            // ===== Intentهای دیگر =====
            new AiTrainingData { Text = "فروش این ماه", Label = "MonthlySales" },
            new AiTrainingData { Text = "بدهکارترین مشتری", Label = "TopDebtor" },
        };
            // 👆👆👆 فقط همین‌جا

            var trainData = mlContext.Data.LoadFromEnumerable(trainingData);

            var pipeline = mlContext.Transforms.Text
                .FeaturizeText("Features", nameof(AiTrainingData.Text))
                .Append(mlContext.Transforms.Conversion.MapValueToKey("Label"))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy())
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(trainData);

            var modelPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                modelFileName
            );

            mlContext.Model.Save(model, trainData.Schema, modelPath);
        }
    }

    /*
    public static class AiModelTrainer
    {
        private static readonly object _lock = new object();

        public static void TrainAndSaveModel(string modelFileName = "IntentModel.zip")
        {
            lock (_lock) // جلوگیری از اجرای همزمان Retrain
            {
                var mlContext = new MLContext();

                var db = new DBcontextModel();
                var trainingData = db.AiQuestionLogs
                    .Select(x => new AiTrainingData
                    {
                        Text = x.Question,
                        Label = x.Intent
                    })
                    .ToList();

                if (!trainingData.Any())
                    return;

                IDataView dataView = mlContext.Data.LoadFromEnumerable(trainingData);

                var pipeline = mlContext.Transforms.Conversion
                    .MapValueToKey("Label", nameof(AiTrainingData.Label))
                    .Append(mlContext.Transforms.Text.FeaturizeText("Features", nameof(AiTrainingData.Text)))
                    .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy())
                    .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                var model = pipeline.Fit(dataView);

                var outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, modelFileName);
                mlContext.Model.Save(model, dataView.Schema, outputPath);
            }
        }
    }
    */
}

using Microsoft.ML.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public class AiPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel { get; set; }
    }
}

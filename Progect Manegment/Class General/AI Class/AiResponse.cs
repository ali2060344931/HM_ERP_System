using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AiResponse
{
    public bool IsSuccess { get; set; }   // 👈 تغییر نام (خیلی مهم)
    public string Message { get; set; }
    public object Data { get; set; }
    public AiIntent Intent { get; set; }

    public static AiResponse Ok(AiIntent intent, object data, string message)
    {
        return new AiResponse
        {
            IsSuccess = true,
            Intent = intent,
            Data = data,
            Message = message
        };
    }

    public static AiResponse Fail(string message)
    {
        return new AiResponse
        {
            IsSuccess = false,
            Message = message
        };
    }
}

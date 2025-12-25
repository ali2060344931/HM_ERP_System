using Newtonsoft.Json;

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AiService
{
    private readonly string _apiKey =
        System.Configuration.ConfigurationManager.AppSettings["OpenAI_ApiKey"];

    public async Task<string> AnalyzeResult(string question, string data)
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add(
                "Authorization", $"Bearer {_apiKey}");

            var body = new
            {
                model = "gpt-4.1-mini",
                input = $"سؤال: {question}\nداده: {data}"
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(body),
                Encoding.UTF8,
                "application/json");

            var response = await client.PostAsync(
                "https://api.openai.com/v1/responses", content);

            string json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return "خطا در دریافت پاسخ از هوش مصنوعی";

            dynamic obj = JsonConvert.DeserializeObject(json);

            // ⭐️ راه امن
            if (obj.output_text != null)
                return obj.output_text.ToString();

            return "پاسخی از هوش مصنوعی دریافت نشد.";
        }
    }


}

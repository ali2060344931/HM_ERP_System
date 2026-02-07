
using HM_ERP_System.Entity.Commission;
using HM_ERP_System.Entity.Customer;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.util;

using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


namespace BotProgram
{
    public class BaleBotClass
    {

        public static string BeleToken = "590185072:uMzKkHykZFW-_scPMNFQDt37MMGVZG3HZT0";

        private static readonly string url = $"https://api.telegram.org/bot{BeleToken}/getUpdates";
        public static readonly string BeleApiUrl = "https://tapi.bale.ai/";
        private static TelegramBotClient Bot = new TelegramBotClient(token: BeleToken, baseUrl: BeleApiUrl);
        private static readonly DateTime BotStartTime = DateTime.UtcNow;
        private static int offset = 0; // برای کار با پیام‌های جدید  
        public static long MyChatId = 359880214;
        static List<InlineKeyboardButton[]> Buttons = new List<InlineKeyboardButton[]>();
        static InlineKeyboardButton[][] keyboard = Buttons.ToArray();
        static InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keyboard);
        static string txtError = "شماره همراه شما در داخل سیستم شرکت ثبت نمی باشد." + '\n' + "برای ثبت تلفن همراه لطفا به واحد منابع انسانی شرکت مراجعه نمائید";
        public static string txtSendReqoestBeforSatrtPrpg = "لطفا از منوی برنامه *خالی کردن گفتگو* و مجدداً روی دکمه *شروع* کلیک نمائید";

        //private static KeyboardButton[] keybordAll;
        //private static KeyboardButton[][] keybordAl0;
        //private static ReplyKeyboardMarkup markup = new ReplyKeyboardMarkup();

        [Obsolete]
        public static void RunTelegram()
        {
            //while (true)
            //{
            //    await GetUpdates();
            //    // زمان انتظار قبل از درخواست بعدی (به ثانیه)  
            //    await Task.Delay(15000); // 15 ثانیه  
            //}


            //BeleToken = BeleToken_;
            {//برای تلگرام
                Bot.StartReceiving();
                Bot.OnMessage += Bot_OnMessage;
                Bot.OnCallbackQuery += Bot_OnCallbackQuery;
                Bot.OnUpdate += Bot_OnUpdate;
            }
        }

        [Obsolete]
        private static void Bot_OnUpdate(object sender, UpdateEventArgs e)
        {

            //if (e.Update.PreCheckoutQuery != null)
            //{
            //    var checkoutId = e.Update.PreCheckoutQuery.Id;


            //    // تابع پاسخ به پرداخت را اینجا صدا می‌زنید:
            //    Bot.AnswerPreCheckoutQueryAsync(checkoutId);


            //    if (e.Update.Message != null && e.Update.Message.SuccessfulPayment != null)
            //    {
            //        var paymentInfo = e.Update.Message.SuccessfulPayment;
            //        // حالا می‌تونید از اطلاعات پرداخت استفاده کنید

            //        //Console.WriteLine($"پرداخت موفق! مبلغ: {paymentInfo.TotalAmount / 100.0} {paymentInfo.Currency}");

            //        Bot.SendTextMessageAsync(e.Update.Message.From.Id, "خرید شما با موفقیت انجام شد"+'\n'+"سریال خرید: "+e.Update.Message.SuccessfulPayment.InvoicePayload);

            //    }
            //}
        }

        [Obsolete]
        public static void StopTelegram()
        {
            //BeleToken = BeleToken_;
            Bot.StopReceiving();
        }

        private static ReplyKeyboardMarkup markup = new ReplyKeyboardMarkup();

        [Obsolete]
        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (string.Equals(e.Message.Text, "/start", StringComparison.OrdinalIgnoreCase) && HM_ERP_System.Properties.Settings.Default.UsersId == 1)
                    {
                        await Bot.SendTextMessageAsync(e.Message.Chat.Id, "به ربات نرم افزار گروه *پیمانکاری شرکت ایران خزر* خوش آمدید" + '\n' + "این برنامه(ربات) به سفارش آقای *محمد حیدری* و با طراحی آقای *غلامزاده* انجام شده است. فعلا در وضعیت آزمایشی قرار دارد ");
                    }

                    if (string.Equals(e.Message.Text, "/inf", StringComparison.OrdinalIgnoreCase) && HM_ERP_System.Properties.Settings.Default.UsersId == 1)
                    {
                        var ComersHs = db.ComersHs.Count();
                        var ComersBs = db.ComersBs.Count();
                        var Transactions = db.Transactions.Where(c=>!c.Status).Count();
                        var Commissions = db.Commissions.Count();
                        var Customers = db.Customers.Count();

                        await Bot.SendTextMessageAsync(e.Message.Chat.Id,
                           "تعداد حواله: " + ComersHs + '\n' + "تعداد بارنامه: " + ComersBs + '\n' + "تعداد تراکنش مالی: " + Transactions + '\n' + "تعداد پرسانت ها: " + Commissions + '\n' + "تعداد مشتری ها: " + Customers);
                        return;
                    }


                    //if (e.Message.Text=="/c")
                    if (e.Message.Text.IndexOf("/c", StringComparison.OrdinalIgnoreCase) >= 0)
                    {

                        if (e.Message.Text.Length >= 12 && HM_ERP_System.Properties.Settings.Default.UsersId==1)
                        {
                            string txt = "";
                            var q = db.Customers.Where(c => c.CodMeli == e.Message.Text.Substring(2, 11));
                            if (q.Count() != 0)
                            {
                                var ct = db.Ciltys.Where(c => c.Id == q.FirstOrDefault().CityId).First();
                                var pr = db.Provinces.Where(c => c.Id == ct.ProvincesId).First();

                                txt = "نام و نام خانوادگی: " + q.First().Name + " " + q.First().Family + '\n';
                                txt += "شماره تماس: " + q.First().Tel + '\n';
                                txt += "استان و شهر: " + pr.Name + " - " + ct.Name + '\n';
                                txt += "آدرس: " + q.First().Adders + '\n';

                                var ctg = db.CustomerToGroups.Where(c => c.CustomerId == q.FirstOrDefault().Id).ToList();
                                string hf = "";
                                foreach (var item in ctg)
                                {
                                    var pg=db.PersonGroups.Where(c=>c.Id==item.PersonGroupId).First();
                                    hf += "🔘" + pg.Name + '\n';
                                }
                                    txt += "حوزه فعالیت: " + '\n'+ hf;

                                await Bot.SendTextMessageAsync(e.Message.Chat.Id, txt);
                            }
                            else
                            {
                                await Bot.SendTextMessageAsync(e.Message.Chat.Id, "هیچ اطلاعاتی برای این کد ملی یافت نشده است.");
                            }
                        }
                    }


                    if (e.Message.Text.Split('#').Length == 3)
                    {
                        string[] code = e.Message.Text.Split('#');
                        if (code[0] == "1")
                        {
                            string CodMeli = code[1];
                            string Tel = code[2];
                            var q = db.Customers.Where(c => c.CodMeli == CodMeli && c.Tel == Tel);
                            if (q.Count() != 0)
                            {
                                if (q.First().ChatId == null || q.First().ChatId == 0)
                                {
                                    q.First().ChatId = e.Message.Chat.Id;
                                    db.SaveChangesSafe();
                                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "ثبت نام شما با موفقیت انجام شد");
                                    return;
                                }
                                else
                                {
                                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "ثبت نام شما قبلا انجام شده است");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            await Bot.SendTextMessageAsync(e.Message.Chat.Id, "اطلاعات وارد شده معتبر نمی باشد");
                            return;
                        }

                    }
                }

            }
            catch (Exception)
            {
            }
        }

        [Obsolete]
        private static async void Bot_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {

        }

        private static async Task GetUpdates()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string requestUrl = $"{url}?offset={offset}";
                    var response = await client.GetStringAsync(requestUrl);
                    // پردازش JSON دریافتی  
                    dynamic updates = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                    foreach (var update in updates.result)
                    {
                        //Console.WriteLine($"پیام جدید: {update.message.text}");

                        // به روز رسانی offset برای جلوگیری از دریافت دوباره آن  
                        offset = update.update_id + 1;

                        // ارسال پاسخ به کاربر  
                        long chatId = update.message.chat.id;
                        string replyText = "شما پیامی دارید!";
                        await SendMessage(chatId, replyText);
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"خطا رخ داد: {ex.Message}");
                }
            }
        }

        private static async Task SendMessage(long chatId, string text)
        {
            using (HttpClient client = new HttpClient())
            {
                string sendMessageUrl = $"https://api.telegram.org/bot{BeleToken}/sendMessage";
                var parameters = new Dictionary<string, string>
            {
                { "chat_id", chatId.ToString() },
                { "text", text }
            };

                var content = new FormUrlEncodedContent(parameters);
                await client.PostAsync(sendMessageUrl, content);
            }
        }

        //متد ارسال فایل ها

    }



}


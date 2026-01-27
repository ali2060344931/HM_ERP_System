
using MyClass;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;
using Telegram.Bot.Types.ReplyMarkups;

namespace BotProgram
{
    /// <summary>
    /// کلاس متددها
    /// </summary>
    public static class MetohdsClass
    {
        /// <summary>
        /// کد غلامزاده - خط همراه اول
        /// </summary>
        public static long MyChatId = 359880214;
        static TelegramBotClient Bot = new TelegramBotClient(token: BaleBotClass.BeleToken, baseUrl: BaleBotClass.BeleApiUrl);
        static List<InlineKeyboardButton[]> Buttons = new List<InlineKeyboardButton[]>();
        static InlineKeyboardButton[][] keyboard = Buttons.ToArray();
        static InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(keyboard);

        [Obsolete]
        public static async Task SendMessageForAdminAsync(string message1, string message2)
        {
            try
            {
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                string vr  = "نسخه برنامه: " + version.ToString();

                await Bot.SendTextMessageAsync(MyChatId, message1 + '\n' + message2 + '\n' + DateTime.Now+'\n'+ vr);
            }
                catch (Exception er)
                {
                    //PublicClass.ShowErrorMessage(er);
                }
        }


    }


}

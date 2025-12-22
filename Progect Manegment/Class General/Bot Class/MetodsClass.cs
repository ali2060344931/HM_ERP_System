
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Exceptions;

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

        public static void SendMessageForAdmin(string message1, string message2)
        {
            try
            {
                Bot.SendTextMessageAsync(MyChatId, message1 + '\n' + message2 + '\n' + DateTime.Now);
            }
            catch (Exception)
            {

            }
        }


    }


}

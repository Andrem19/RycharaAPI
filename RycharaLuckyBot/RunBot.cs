using System;
using System.Threading;
using System.Threading.Tasks;

namespace RycharaAPI.RycharaLuckyBot
{
    public class RunBot
    {
        public static bool status { get; set; } = true;
        public static bool Rychara { get; set; } = true;
        public static long pause { get; set; } = 0;
        public static async Task Run()
        {
            Init.Initialize();

            //await IsPositionExist.IsPositionExistAsync();
            //if (Variables.IsPositionExist == true)
            //{
            //    Variables.OpenTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 60 * 30;
            //}
            //Thread.Sleep(1000);
            while (status == true)
            {
                try
                {
                    //await TelegramBot.ChekTelegram();
                    if (Rychara == true && pause <= DateTimeOffset.UtcNow.ToUnixTimeSeconds())
                    {
                        await GeneralLogic.Process();
                    }
                }
                catch (Exception ex)
                {
                    //await SaveLogs.SLogs("ERRORS", $"{DateTimeOffset.UtcNow}-{ex.Message.ToString()}");
                    //await LogsWorker.TelegramLog($"{Variables.Exchange}-{ex.Message.ToString()}");
                }
                Thread.Sleep(5000);
            }
        }
    }
}

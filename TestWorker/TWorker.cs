using Microsoft.Extensions.Logging;
using RycharaAPI.RycharaLuckyBot;
using RycharaAPI.RycharaLuckyBot.LoggerDB;
using RycharaAPI.RycharaLuckyBot.Settings;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RycharaAPI.TestWorker
{
    public class TWorker : ITWorker
    {
        public Guid id { get; set; }
        public int Count { get; set; } = 0;
        public int ident { get; set; } = 0;

        public TWorker(ILogger<TWorker> logger)
        {
            this.id = Guid.NewGuid();
        }
        public async Task DoWork(string name)
        {
            int num = Count;
            while (true)
            {
                SettingsModel model = await SaveToDb.SReadSettings(name);
                if (model.number != 0)
                {
                    num = model.number;
                }
                num++;
                Console.WriteLine($"{ident} - {ident}");
                await RunBot.Run(id, num, name);
                Thread.Sleep(10000);
            }
        }
    }
}

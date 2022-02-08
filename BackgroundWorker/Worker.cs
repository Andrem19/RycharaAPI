using RycharaAPI.RycharaLuckyBot;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundWorker
{
    public class Worker : IWorker
    {

        public async Task Run(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await RunBot.Run();
            }
        }
    }
}

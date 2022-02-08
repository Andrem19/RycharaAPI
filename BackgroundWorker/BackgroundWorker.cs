using BackgroundWorker;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace RycharaAPI
{
    public class BackgroundWorker : BackgroundService
    {
        private readonly IWorker worker;
        public BackgroundWorker(IWorker worker)
        {
            this.worker = worker;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await worker.Run(stoppingToken);
        }
    }
}

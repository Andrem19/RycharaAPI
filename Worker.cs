using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundWorker
{
    public class Worker : IWorker
    {
        public static int number { get; set; } = 0;

        public async Task Run(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                while (true)
                {
                    number++;
                    Console.WriteLine(number);
                    Thread.Sleep(5000);
                }
            }
        }
    }
}

using System.Threading;
using System.Threading.Tasks;

namespace BackgroundWorker
{
    public interface IWorker
    {
        public Task Run(CancellationToken cancellationToken);
    }
}
using System;
using System.Threading.Tasks;

namespace RycharaAPI.TestWorker
{
    public interface ITWorker
    {
        Guid id { get; set; }

        Task DoWork(string name);
    }
}
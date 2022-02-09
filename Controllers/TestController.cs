using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RycharaAPI.RycharaLuckyBot.LoggerDB;
using RycharaAPI.RycharaLuckyBot.Settings;
using RycharaAPI.TestWorker;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace RycharaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public TestController(IServiceProvider serviceProvider, ITWorker worker)
        {
            ServiceProvider = serviceProvider;
            Worker = worker;
        }

        public IServiceProvider ServiceProvider { get; }
        public ITWorker Worker { get; }

        [HttpPost("create")]
        public ActionResult Create([FromQuery] string name)
        {
            using (var scoped = ServiceProvider.CreateScope())
            {
                var _scopedService = scoped.ServiceProvider.GetRequiredService<ITWorker>();
                _scopedService.DoWork(name);
                return Ok();
            }
            return Ok();
        }
        [HttpPost("setvar")]
        public async Task<ActionResult> SetVar([FromQuery] int num, [FromQuery] string name)
        {
            SettingsModel model = new SettingsModel();
            model.number = num;
            await SaveToDb.SSettings(name, model);    
            return Ok();
        }
    }
}

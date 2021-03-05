using FplApp.DataImporter.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Workers
{
    public class ElementDataWorker : BackgroundService
    {
        private readonly ILogger<ElementDataWorker> logger;
        private readonly IElementService elementService;


        public ElementDataWorker(ILogger<ElementDataWorker> logger, IElementService elementService)
        {
            this.logger = logger;
            this.elementService = elementService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("ElementDataWorker initialized at: {0}", DateTime.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.LogInformation("Calling GetElements at: {0}", DateTime.Now);

                var players = await elementService.GetElementsAsync();

                logger.LogInformation("ElementDataWorker finished at: {0}", DateTime.Now);

                await Task.Delay(1000 * 5, stoppingToken);
            }
        }


    }
}

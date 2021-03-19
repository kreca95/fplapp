using FplApp.DataImporter.Helpers;
using FplApp.DataImporter.Interfaces;
using log4net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Workers
{
    public class ElementDataWorker : BackgroundService
    {
        private readonly IElementImporterService _elementService;
        private readonly IConfiguration _config;
        ILog logger;


        public ElementDataWorker(IElementImporterService elementService, IConfiguration config)
        {
            _elementService = elementService;
            logger = LogManager.GetLogger(Assembly.GetEntryAssembly(), "IMPORTER");
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.InfoFormat("ElementDataWorker initialized at: {0}", DateTime.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.InfoFormat("Calling GetElements at: {0}", DateTime.Now);

                var elements = await _elementService.GetElementsAsync();
                //insert preko http
                var elementsJson=JsonSerializer.Serialize(elements);
                var uri = _config.GetSection("fplappapi").Value;
                HttpHelper.Post(uri, elementsJson, "", "");

                logger.InfoFormat("ElementDataWorker finished at: {0}", DateTime.Now);

                await Task.Delay(1000 * 5, stoppingToken);
            }
        }


    }
}

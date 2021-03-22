using FplApp.DataImporter.Helpers;
using FplApp.DataImporter.Implementations;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using log4net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Workers
{
    class ImportAllFplDataWorker : BackgroundService
    {
        private readonly IImporterService<FplFullInfoResponse> _importerService;
        ILog logger;
        private readonly IConfiguration _config;
        public ImportAllFplDataWorker(IImporterService<FplFullInfoResponse> importerService, IConfiguration config)
        {
            _importerService = importerService;
            logger = LogManager.GetLogger(Assembly.GetEntryAssembly(), "IMPORTER");
            _config = config;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.InfoFormat("Starting ImportAllFplDataWorker");
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.InfoFormat("ImportAllFplDataWorker while loop");

                var data = _importerService.GetData(null);
                var elementsJson = JsonSerializer.Serialize(data);
                var uri = _config.GetSection("import").Value;
                HttpHelper.Post(uri, elementsJson, "", "");
                logger.InfoFormat("ImportAllFplDataWorker finished ");

                Thread.Sleep(1000 * 5);
            }

            return Task.CompletedTask;
        }
    }
}

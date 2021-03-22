﻿using FplApp.DataImporter.Implementations;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using log4net;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Workers
{
    class ImportAllFplDataWorker : BackgroundService
    {
        private readonly IImporterService<FplFullInfoResponse> _importerService;
        ILog logger;

        public ImportAllFplDataWorker(IImporterService<FplFullInfoResponse> importerService)
        {
            _importerService = importerService;
            logger = LogManager.GetLogger(Assembly.GetEntryAssembly(), "IMPORTER");

        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.InfoFormat("Starting ImportAllFplDataWorker");
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.InfoFormat("ImportAllFplDataWorker while loop");

                var data = _importerService.GetData(null);

                logger.InfoFormat("ImportAllFplDataWorker finished ");

                Thread.Sleep(1000 * 5);
            }

            return Task.CompletedTask;
        }
    }
}

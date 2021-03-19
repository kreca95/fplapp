using FplApp.DataImporter.Implementations;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Workers
{
    class ImportAllFplDataWorker : BackgroundService
    {
        private readonly IImporterService<FplFullInfoResponse> _importerService;

        public ImportAllFplDataWorker(IImporterService<FplFullInfoResponse> importerService)
        {
            _importerService = importerService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var data = _importerService.GetData(null);
                Task.Delay(1000 * 10);
            }

            return Task.CompletedTask;
        }
    }
}

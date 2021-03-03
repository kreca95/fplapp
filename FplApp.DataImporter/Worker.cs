using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FplApp.Models;
using FplApp.Models.Models;
using FplClient.Clients;
using FplClient.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FplApp.DataImporter
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTime.Now);

                var data = await GetLiveFplPlayerPoints();

                _logger.LogInformation("Worker done at: {time}", DateTime.Now);
                await Task.Delay(60 * 1000 * 5, stoppingToken);
            }
        }

        private async Task<FplLiveGameweekStats> GetLiveFplPlayerPoints()
        {
            FplLiveGameweekStatsClient client = new FplLiveGameweekStatsClient(new System.Net.Http.HttpClient());

            var team = await client.Get(26);

            return team;
        }
    }
}

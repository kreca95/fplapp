using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FplApp.DataImporter.Implementations;
using FplApp.DataImporter.Interfaces;
using FplApp.DataImporter.Workers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FplApp.DataImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddAutoMapper(typeof(Program));
                    services.AddHostedService<ElementDataWorker>();
                    services.AddSingleton<IElementService, ElementService>();
                });
    }
}

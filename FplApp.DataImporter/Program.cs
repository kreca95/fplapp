using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FplApp.DataImporter.Implementations;
using FplApp.DataImporter.Interfaces;
using FplApp.DataImporter.Workers;
using FplApp.EfCoreDbCommunication.Implementations;
using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models.Models;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FplApp.DataImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var logRepo = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepo, new FileInfo("log4net.config"));
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    //services.AddHostedService<ElementDataWorker>();
                    services.AddHostedService<ImportAllFplDataWorker>();

                    services.AddAutoMapper(typeof(Program));
                    services.AddSingleton<IElementImporterService, ElementImporterService>();
                    services.AddSingleton<IImporterService<FplFullInfoResponse>, ImportAllFplData>();
                });
    }
}

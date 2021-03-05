using AutoMapper;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using FplClient.Clients;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Implementations
{
    public class ElementService : IElementService
    {
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public ElementService(IMapper mapper, ILogger logger)
        {
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<List<Element>> GetElementsAsync()
        {

            try
            {
                FplPlayerClient client = new FplPlayerClient(new System.Net.Http.HttpClient());

                var players = await client.GetAllPlayers();

                var mapped = mapper.Map<List<Element>>(players);

                return mapped;
            }
            catch (System.Exception e)
            {
                logger.LogInformation(e.Message);
                throw;
            }
        }
    }
}

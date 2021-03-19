using AutoMapper;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using FplClient.Clients;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Implementations
{
    public class ElementImporterService : IElementImporterService
    {
        private readonly IMapper mapper;

        public ElementImporterService(IMapper mapper)
        {
            this.mapper = mapper;
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
                throw;
            }
        }
    }
}

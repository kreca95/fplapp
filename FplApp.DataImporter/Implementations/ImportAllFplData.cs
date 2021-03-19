using FplApp.DataImporter.Helpers;
using FplApp.DataImporter.Interfaces;
using FplApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Implementations
{
    public class ImportAllFplData : IImporterService<FplFullInfoResponse>
    {
        public FplFullInfoResponse GetData(string url)
        {
            var json = HttpHelper.Get("https://fantasy.premierleague.com/api/bootstrap-static/", "", "");
            FplFullInfoResponse fplFullInfoResponse = JsonSerializer.Deserialize<FplFullInfoResponse>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return fplFullInfoResponse;
        }
    }
}

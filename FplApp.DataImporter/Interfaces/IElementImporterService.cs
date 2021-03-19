using FplApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.DataImporter.Interfaces
{
    public interface IElementImporterService
    {
        Task<List<Element>> GetElementsAsync();
    }
}

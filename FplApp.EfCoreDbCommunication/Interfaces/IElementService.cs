using FplApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication.Interfaces
{
    public interface IElementService
    {
        List<Element> GetElements();
        bool InsertElement(List<Element> elements);
    }
}

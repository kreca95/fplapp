using FplApp.Models;
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
        List<Element> GetElements(GetElementsRequest request);
        List<ElementStat> GetElementStats();
        List<ElementType> GetElementTypes();

        bool InsertElements(List<Element> elements);
        bool InsertElementStat(List<ElementStat> elementStats);
        bool InsertElementType(List<ElementType> elementTypes);

        bool DeleteElement(Element element);
        bool DeleteElementStat(ElementStat elementStat);
        bool DeleteElementType(ElementType elementType);


    }
}

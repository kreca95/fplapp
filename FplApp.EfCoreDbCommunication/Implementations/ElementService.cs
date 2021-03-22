using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models;
using FplApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication.Implementations
{
    public class ElementService : IElementService
    {
        private readonly FplAppDbContext _dbContext;

        public ElementService(FplAppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public bool DeleteElement(Element element)
        {
            var check = _dbContext.Elements.Remove(element);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }

        public bool DeleteElementStat(ElementStat elementStat)
        {
            var check = _dbContext.ElementStats.Remove(elementStat);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }

        public bool DeleteElementType(ElementType elementType)
        {
            var check = _dbContext.ElementTypes.Remove(elementType);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }

        public List<Element> GetElements(GetElementsRequest request)
        {
            List<Element> elements = new List<Element>();
            elements = _dbContext.Elements.ToList();
            if (request.PlayerId != 0)
            {
                elements = _dbContext.Elements.Where(x => x.Id == request.PlayerId).ToList();
            }
            if (request.TeamId != 0)
            {
                elements = _dbContext.Elements.Where(x => x.Team == request.TeamId).ToList();
            }
            return elements;
        }

        public List<ElementStat> GetElementStats()
        {
            List<ElementStat> elementStats = new List<ElementStat>();
            elementStats = _dbContext.ElementStats.ToList();
            return elementStats;
        }

        public List<ElementType> GetElementTypes()
        {
            List<ElementType> elementTypes = new List<ElementType>();
            elementTypes = _dbContext.ElementTypes.ToList();
            return elementTypes;
        }

        public bool InsertElements(List<Element> elements)
        {
            _dbContext.Elements.UpdateRange(elements);
            var check = _dbContext.SaveChanges();
            return check > 0;
        }

        public bool InsertElementStat(List<ElementStat> elementStats)
        {
            _dbContext.ElementStats.AddRange(elementStats);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }

        public bool InsertElementType(List<ElementType> elementTypes)
        {
            _dbContext.ElementTypes.AddRange(elementTypes);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }
    }
}

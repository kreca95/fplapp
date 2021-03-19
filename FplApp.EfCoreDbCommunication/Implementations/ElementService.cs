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
        private readonly FplAppDbContext dbContext;

        public ElementService(FplAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Element> GetElements(GetElementsRequest request)
        {
            List<Element> elements = new List<Element>();
            elements = dbContext.Elements.ToList();
            if (request.PlayerId != 0)
            {
                elements = dbContext.Elements.Where(x => x.Id == request.PlayerId).ToList();
            }
            if (request.TeamId != 0)
            {
                elements = dbContext.Elements.Where(x => x.Team == request.TeamId).ToList();
            }
            return elements;
        }

        public bool InsertElements(List<Element> elements)
        {
            dbContext.Elements.UpdateRange(elements);
            var check = dbContext.SaveChanges();
            return check > 0;
        }
    }
}

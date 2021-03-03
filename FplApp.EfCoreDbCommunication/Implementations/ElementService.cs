using FplApp.EfCoreDbCommunication.Interfaces;
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
        public List<Element> GetElements()
        {
            var elements = dbContext.Elements.ToList();
            return elements;
        }

        public bool InsertElement(List<Element> elements)
        {
            dbContext.Elements.AddRange(elements);
            var check = dbContext.SaveChanges();
            return check > 0;
        }
    }
}

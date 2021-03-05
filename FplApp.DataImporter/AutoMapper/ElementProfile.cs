using AutoMapper;
using FplApp.Models.Models;
using FplClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.DataImporter.AutoMapper
{
    public class ElementProfile : Profile
    {
        public ElementProfile()
        {
            CreateMap<Element, FplPlayer>();
            CreateMap<FplPlayer,Element>();

        }
    }
}

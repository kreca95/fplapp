using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Helpers;
using FplApp.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FplApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly IElementService _elementService;
        [HttpPost]
        public IActionResult Import(FplFullInfoResponse fpl)
        {
            var elements = fpl.Elements;
            var elementStats = fpl.Element_Stats;
            var elementType = fpl.Element_Types;
            var phases = fpl.Phases;
            var events = fpl.Events;
            var gameSettings = fpl.Game_Settings;
            var teams = fpl.Teams;

            if (elements.Count > 0)
            {
                _elementService.InsertElements(elements);
            }
            if (elementStats.Count > 0)
            {
                _elementService.InsertElementStat(elementStats);
            }
            if (elementType.Count > 0)
            {
                _elementService.InsertElementType(elementType);
            }
            if (phases.Count > 0)
            {
                //implementirat
            }
            if (events.Count > 0)
            {
                //isto
            }
            if (gameSettings != null)
            {
                //
            }
            if (teams.Count > 0)
            {
                //
            }
            return Ok();
        }
    }
}

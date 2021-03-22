using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models.Models;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FplApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementStatController : ControllerBase
    {
        private readonly IElementService _elementService;
        ILog _logger;

        public ElementStatController(IElementService elementService)
        {
            _elementService = elementService;
            _logger = LogManager.GetLogger(Assembly.GetEntryAssembly(), "HTTP");

        }
        [HttpGet]
        public IActionResult GetElementStats()
        {
            var elementStats = _elementService.GetElementStats();
            if (elementStats.Count == 0)
            {
                return NotFound("No stats found.");
            }
            return Ok(elementStats);
        }

        [HttpPost("import")]
        public IActionResult InsertElementsStat(List<ElementStat> elementStats)
        {
            try
            {
                if (elementStats.Count == 0)
                {
                    _logger.Error("No stats sent.");
                    return BadRequest("No stats sent.");
                }
                var check = _elementService.InsertElementStat(elementStats);
                if (check)
                {
                    _logger.InfoFormat("ElementStats import finished. Inserter {0} elementStats.", elementStats.Count);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                _logger.ErrorFormat("Error {0}", e.Message);
                return BadRequest();
            }
        }


    }
}

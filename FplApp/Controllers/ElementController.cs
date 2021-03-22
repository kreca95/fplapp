using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models;
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
    public class ElementController : ControllerBase
    {
        readonly IElementService _elementService;
        ILog _logger;

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
            _logger = LogManager.GetLogger(Assembly.GetEntryAssembly(), "HTTP");

        }
        [HttpGet]
        public IActionResult GetElements([FromQuery] GetElementsRequest request)
        {
            var elements = _elementService.GetElements(request);
            if (elements.Count == 0)
            {
                return NotFound("No players found.");
            }
            return Ok(elements);
        }
        [HttpPost("import")]
        public IActionResult InsertElements(List<Element> elements)
        {

            try
            {
                _logger.Info("InsertElements init.");
                var check = _elementService.InsertElements(elements);
                _logger.Info("InsertElements finished.");
                return Ok();
            }
            catch (Exception e)
            {
                _logger.ErrorFormat("InserElements error: ", e.Message);
                return BadRequest();
            }
        }
    }
}

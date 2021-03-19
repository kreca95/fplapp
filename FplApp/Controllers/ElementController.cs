using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models;
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
    public class ElementController : ControllerBase
    {
        readonly IElementService _elementService;

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
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
                var check = _elementService.InsertElements(elements);
                return Ok();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}

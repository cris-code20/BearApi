using BearApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BearApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BearsController : ControllerBase
    {
        private readonly IBears _bears;

        public BearsController(IBears bears)
        {
            _bears = bears;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if(_bears.getId(id) == null)
            {
                return BadRequest(string.Empty);
            }
            else
            {
                return Ok(_bears.getId(id));
            }

        }

        [HttpGet("all")]
        public IActionResult All() 
        {
            return Ok(_bears.GetBears());
        }
    }
}

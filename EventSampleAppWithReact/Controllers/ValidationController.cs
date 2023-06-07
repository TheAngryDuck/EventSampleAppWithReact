using EventAppDataLayer.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventSampleAppWithReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {

        // GET api/<ValidationController>/5
        [HttpGet]
        public int Validate([FromBody] ValidationDto dto)
        {
            return StatusCodes.Status200OK;
        }
    }
}

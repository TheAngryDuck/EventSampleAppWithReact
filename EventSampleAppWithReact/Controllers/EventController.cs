using EventAppDataLayer.Dto;
using EventAppServices.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventSampleAppWithReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        private readonly ILogger<EventController> _logger;
        private readonly IEventService _eventService;

        public EventController(ILogger<EventController> logger, IEventService eventService)
        {
            _logger = logger;
            _eventService = eventService;
        }

        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<EventDto> Get()
        {
            return _eventService.getEvents();
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public EventDto Get(Guid id)
        {
            return _eventService.getEventById(id);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] EventDto dto)
        {
            _eventService.addEvent(dto);
        }

        // PUT api/<EventController>/5
        [HttpPut]
        public void Put([FromBody] EventDto dto)
        {
            _eventService.updateEvent(dto);
        }

        // DELETE api/<EventController>/5
        [HttpDelete]
        public void Delete(EventDto dto)
        {
            _eventService.removeEvent(dto);
        }
    }
}

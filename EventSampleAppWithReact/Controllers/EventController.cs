using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;
using EventAppDataLayer.Interface;
using EventAppDataLayer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventSampleAppWithReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public List<EventDto> Get()
        {
            return _eventService.getEvents().ToList();
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

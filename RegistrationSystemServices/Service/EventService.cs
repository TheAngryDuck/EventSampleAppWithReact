using EventAppDataLayer.Dto;
using EventAppDataLayer.Interface;
using EventAppServices.Interface;
using EventAppServices.Mapper;

namespace EventAppServices.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly EventMapper _eventMapper;

        public EventService(IEventRepository eventRepository, EventMapper eventMapper)
        {
            _eventRepository = eventRepository;
            _eventMapper = eventMapper;
        }

        public IEnumerable<EventDto> getEvents()
        {
            var result = new List<EventDto>();
            var data = _eventRepository.GetAll();
            foreach (var item in data)
            {
                result.Add(_eventMapper.MapToDto(item));
            }
            return result;
        }

        public void addEvent(EventDto dto)
        {

            _eventRepository.Add(_eventMapper.MapFromDto(dto));
        }

        public void removeEvent(EventDto dto)
        {
            _eventRepository.Remove(_eventMapper.MapFromDto(dto));
        }

        public void updateEvent(EventDto dto)
        {
            _eventRepository.Update(_eventMapper.MapFromDto(dto));
        }

        public EventDto getEventById(Guid id)
        {
            return _eventMapper.MapToDto(_eventRepository.GetById(id));
        }
    }
}

using EventAppDataLayer.Dto;

namespace EventAppServices.Interface
{
    public interface IEventService
    {
        IEnumerable<EventDto> getEvents();
        public void addEvent(EventDto dto);
        public void removeEvent(EventDto dto);
        public void updateEvent(EventDto dto);
        public EventDto getEventById(Guid id);

    }
}

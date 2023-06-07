using EventAppDataLayer.Dto;

namespace EventAppDataLayer.Interface
{
    public interface IEventService
    {
        IEnumerable<EventDto> getEvents();
        public void addEvent(EventDto eventOb);
        public void removeEvent(EventDto eventOb);
        public void updateEvent(EventDto eventOb);
        public EventDto getEventById(Guid id);

    }
}

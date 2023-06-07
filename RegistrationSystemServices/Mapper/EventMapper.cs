using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;

namespace EventAppServices.Mapper
{
    public class EventMapper
    {
        public Event MapFromDto(EventDto dto)
        {
            var eventOb = new Event();
            eventOb.Id = dto.Id;
            eventOb.Name = dto.Name;
            eventOb.Date = dto.Date;
            eventOb.Count = dto.Count;
            return eventOb;
        }

        public EventDto MapToDto(Event ob)
        {
            var dto = new EventDto();
            dto.Id = ob.Id;
            dto.Name = ob.Name;
            dto.Date = ob.Date;
            dto.Count = ob.Count;
            return dto;
        }
    }
}

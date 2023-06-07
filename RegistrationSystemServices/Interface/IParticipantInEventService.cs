using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;

namespace EventAppServices.Interface
{
    public interface IParticipantInEventService
    {
        IEnumerable<ParticipantInEventDto> getParticipantsInEvents();
        public void addParticipantInEvent(ParticipantInEventDto dto);
        public void removeParticipantInEvent(ParticipantInEventDto dto);
        public void updateParticipantInEvent(ParticipantInEventDto dto);
        public ParticipantInEventDto getParticipantInEventById(Guid id);
        public IEnumerable<ParticipantInEventDto> GetAllRelatedToEventId(Guid id);
    }
}

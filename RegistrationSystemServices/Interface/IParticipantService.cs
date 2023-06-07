using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;

namespace EventAppServices.Interface
{
    public interface IParticipantService
    {
        IEnumerable<ParticipantDto> getParticipants();
        public void addParticipant(ParticipantDto dto);
        public void removeParticipant(ParticipantDto dto);
        public void updateParticipant(ParticipantDto dto);
        public ParticipantDto getParticipantById(Guid id);
    }
}

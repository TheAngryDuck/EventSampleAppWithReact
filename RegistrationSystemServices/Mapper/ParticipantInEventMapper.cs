using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;

namespace EventAppServices.Mapper
{
    public class ParticipantInEventMapper
    {
        public ParticipantInEvent MapFromDto(ParticipantInEventDto dto)
        {
            var ob = new ParticipantInEvent();
            ob.Id = dto.Id;
            ob.ParticipantId = dto.ParticipantId;
            ob.Participant = dto.Participant;
            ob.Event = dto.Event;
            ob.EventId = dto.EventId;
            return ob;
        }

        public ParticipantInEventDto MapToDto(ParticipantInEvent ob)
        {
            var dto = new ParticipantInEventDto();
            dto.Id = ob.Id;
            dto.ParticipantId = ob.ParticipantId;
            dto.Participant = ob.Participant;
            dto.Event = ob.Event;
            dto.EventId = ob.EventId;
            return dto;
        }
    }
}

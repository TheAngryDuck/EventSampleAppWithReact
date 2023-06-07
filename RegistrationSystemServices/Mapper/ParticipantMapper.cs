using EventAppDataLayer.Dto;
using EventAppDataLayer.Entity;

namespace EventAppServices.Mapper
{
    public class ParticipantMapper
    {
        public Participant MapFromDto(ParticipantDto dto)
        {
            var ob = new Participant();
            ob.Id = dto.Id;
            ob.Name = dto.Name;
            ob.LastName = dto.LastName;
            ob.IdCode = dto.IdCode;
            return ob;
        }

        public ParticipantDto MapToDto(Participant ob)
        {
            var dto = new ParticipantDto();
            dto.Id = ob.Id;
            dto.Name = ob.Name;
            dto.LastName = ob.LastName;
            dto.IdCode = ob.IdCode;
            return dto;
        }
    }
}

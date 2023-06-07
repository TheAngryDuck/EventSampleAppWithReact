using EventAppDataLayer.Dto;
using EventAppDataLayer.Interface;
using EventAppServices.Interface;
using EventAppServices.Mapper;



namespace EventAppServices.Service
{
    public class ParticipantInEventService : IParticipantInEventService
    {
        private readonly IParticipantInEventRepository _participantInEventRepository;
        private readonly ParticipantInEventMapper _participantInEvent;


        public ParticipantInEventService(IParticipantInEventRepository participantInEventRepository, ParticipantInEventMapper participantInEvent)
        {
            _participantInEventRepository = participantInEventRepository;
            _participantInEvent = participantInEvent;
        }
        public void addParticipantInEvent(ParticipantInEventDto dto)
        {
            _participantInEventRepository.Add(_participantInEvent.MapFromDto(dto));
        }

        public IEnumerable<ParticipantInEventDto> GetAllRelatedToEventId(Guid id)
        {
            var result = new List<ParticipantInEventDto>();
            var data = _participantInEventRepository.GetAllRelatedToEventId(id);
            foreach (var item in data)
            {
                result.Add(_participantInEvent.MapToDto(item));
            }
            return result;
        }

        public ParticipantInEventDto getParticipantInEventById(Guid id)
        {
            return _participantInEvent.MapToDto(_participantInEventRepository.GetById(id));
        }

        public IEnumerable<ParticipantInEventDto> getParticipantsInEvents()
        {
            var result = new List<ParticipantInEventDto>();
            var data = _participantInEventRepository.GetAll();
            foreach (var item in data)
            {
                result.Add(_participantInEvent.MapToDto(item));
            }
            return result;
        }

        public void removeParticipantInEvent(ParticipantInEventDto dto)
        {
            _participantInEventRepository.Remove(_participantInEvent.MapFromDto(dto));
        }

        public void updateParticipantInEvent(ParticipantInEventDto dto)
        {
            _participantInEventRepository.Update(_participantInEvent.MapFromDto(dto));
        }
    }
}

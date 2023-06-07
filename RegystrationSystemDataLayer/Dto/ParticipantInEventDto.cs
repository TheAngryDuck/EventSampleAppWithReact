using EventAppDataLayer.Entity;

namespace EventAppDataLayer.Dto
{
    public class ParticipantInEventDto
    {
        public Guid Id { get; set; }
        public Participant Participant { get; set; }
        public Guid ParticipantId { get; set; }
        public Event Event { get; set; }
        public Guid EventId { get; set; }
    }
}

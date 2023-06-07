namespace EventAppDataLayer.Entity
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public List<ParticipantInEvent>? Participants { get; set; }

    }
}

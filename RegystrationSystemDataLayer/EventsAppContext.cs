using Microsoft.EntityFrameworkCore;
using EventAppDataLayer.Entity;

namespace EventAppDataLayer
{
    public class EventsAppContext : DbContext
    {
        public EventsAppContext(DbContextOptions<EventsAppContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<ParticipantInEvent> ParticipansInEvents { get; set; }
    }
}

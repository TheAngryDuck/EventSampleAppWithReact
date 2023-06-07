using EventAppDataLayer.Entity;
using EventAppDataLayer.Interface;

namespace EventAppDataLayer.Repository
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(EventsAppContext context) : base(context) { }
    }
}

using EventAppDataLayer.Entity;

namespace EventAppDataLayer.Interface
{
    public interface IParticipantInEventRepository : IGenericRepository<ParticipantInEvent>
    {
        IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id);
    }
}

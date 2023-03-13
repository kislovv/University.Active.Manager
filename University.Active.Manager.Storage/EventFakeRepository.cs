using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using AutoFixture;

namespace University.Active.Manager.Storage;

public class EventFakeRepository : IEventRepository
{
    private readonly Fixture _fixture = new Fixture();
    public Task<List<Event>> GetAllEvents()
    {
        return Task.FromResult(_fixture.Build<Event>().CreateMany(5).ToList());
    }
}
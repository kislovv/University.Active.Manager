using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Services;

public class EventRepository : IEventRepository
{
    public Task<List<Event>> GetAllEvents()
    {
        throw new System.NotImplementedException();
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IEventRepository
{
    Task<List<Event>> GetAllEvents();

    Task<Event> AddEvent(Event ev);
}
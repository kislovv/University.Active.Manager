using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Services;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;
    public EventService(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }
    public async Task<List<Event>> GetAllActiveEvents()
    {

        var addEvent = await _eventRepository.GetAllEvents();
        return addEvent.FindAll(x => !x.IsDone);
 
        throw new System.NotImplementedException();
    }

    public Task<bool> RegisterNewEvent(Event ev)
    { 
        return Task.FromResult(true);
    }
}
using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Event>> GetAllEvents()
        {
            return await _appDbContext.Events
                .Include(ev => ev.Participants)
                .ToListAsync();
        }

        public Task<Event> AddEvent(Event ev)
        {
            throw new NotImplementedException();
        }
    }
}

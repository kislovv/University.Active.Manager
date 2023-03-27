using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql
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
                .Include(ev => ev.Students)
                .ToListAsync();
        }

        public async Task<Event> AddEvent(Event ev)
        {
            var result = await _appDbContext.Events.AddAsync(ev);
            
            return result.Entity;
        }
    }
}

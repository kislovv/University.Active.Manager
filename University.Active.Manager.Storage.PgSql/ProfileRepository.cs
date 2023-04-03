using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql;

public class ProfileRepository : IProfileRepository
{
    private readonly AppDbContext _dbContext;
    public ProfileRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<User?> GetProfileByLogin(string login)
    {
        return await _dbContext.Users
            .AsNoTracking().SingleOrDefaultAsync(p => p.Login == login);
    }

    public async Task<User> AddProfile(User profile)
    {
        var result = await _dbContext.Users.AddAsync(profile);
        await _dbContext.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<User?> GetProfileById(Guid id)
    {
        return await _dbContext.Users
            .AsNoTracking()
            .Include(p => p.ParticipantEvents)
            .Include(p => p.Institute)
            .ThenInclude(i => i.Subjects).SingleOrDefaultAsync(p => p.Id == id);
    }
}
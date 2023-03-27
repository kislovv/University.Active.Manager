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
    public async Task<Profile?> GetProfileByLogin(string login)
    {
        return await _dbContext.Profiles
            .AsNoTracking()
            .Include(p => p.Events)
            .Include(p => p.Institute)
            .ThenInclude(i => i.Subjects).SingleOrDefaultAsync(p => p.Login == login);
    }

    public async Task<Profile> AddProfile(Profile profile)
    {
        var result = await _dbContext.Profiles.AddAsync(profile);
        await _dbContext.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<Profile?> GetProfileById(Guid id)
    {
        return await _dbContext.Profiles
            .AsNoTracking()
            .Include(p => p.Events)
            .Include(p => p.Institute)
            .ThenInclude(i => i.Subjects).SingleOrDefaultAsync(p => p.Id == id);
    }
}
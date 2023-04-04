using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;
    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<User?> GetUserByLogin(string login)
    {
        return await _dbContext.Users
            .AsNoTracking().SingleOrDefaultAsync(p => p.Login == login);
    }

    public async Task<User> AddUser(User profile)
    {
        var result = await _dbContext.Users.AddAsync(profile);
        await _dbContext.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<User?> GetUserById(Guid id)
    {
        return await _dbContext.Users
            .AsNoTracking()
            .Include(p => p.ParticipantsEvent)
            .Include(p => p.Institute)
            .ThenInclude(i => i.Subjects).SingleOrDefaultAsync(p => p.Id == id);
    }
}
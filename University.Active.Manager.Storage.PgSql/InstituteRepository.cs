using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql;

public class InstituteRepository : IInstituteRepository
{
    private readonly AppDbContext _appDbContext;
    public InstituteRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<List<Institute>> GetAllInstitutes()
    {
        return await _appDbContext.Institutes
            .Include(i => i.Subjects)
            .Include(i => i.Users)
            .ToListAsync();
    }

    public async Task<Institute> AddInstitute(Institute institute)
    {
        var result = await _appDbContext.Institutes.AddAsync(institute);
        await _appDbContext.SaveChangesAsync();
        
        return result.Entity;
    }

    public async Task<Institute?> GetInstituteById(long id)
    {
        return await _appDbContext.Institutes
            .Include(i => i.Subjects)
            .Include(i => i.Users).FirstOrDefaultAsync(ev => ev.Id == id);
    }

    public async Task<bool> RemoveInstitute(Institute institute)
    {
        try
        {
            _appDbContext.Remove(institute);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
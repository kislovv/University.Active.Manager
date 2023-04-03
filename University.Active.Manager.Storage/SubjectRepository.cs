using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage;

public class SubjectRepository : ISubjectRepository
{
    private readonly AppDbContext _appDbContext;

    public SubjectRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Subject> AddSubject(Subject subject)
    {
        await _appDbContext.Subjects.AddAsync(subject);
        await _appDbContext.SaveChangesAsync();
        
        return subject;
    }

    public async Task<Subject> GetSubjectById(long id)
    {
        return await _appDbContext.Subjects
            .Include(sub => sub.Insitute)
            .FirstOrDefaultAsync(sub => sub.Id == id) ?? throw new InvalidOperationException();
    }

    public async Task<Subject> UpdateSubject(Subject subject)
    {
        _appDbContext.Subjects.Update(subject);
        await _appDbContext.SaveChangesAsync();
        
        return subject;
    }

    public async Task<bool> DeleteSubject(Subject subject)
    {
        if (_appDbContext.Subjects.Contains(subject))
            _appDbContext.Subjects.Remove(subject);
        else 
            return false;
        
        await _appDbContext.SaveChangesAsync();

        return true;
    }
}
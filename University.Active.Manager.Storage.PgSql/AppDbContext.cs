using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql;

public class AppDbContext : DbContext
{
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Institute> Institutes => Set<Institute>();
    public DbSet<Subject> Subjects => Set<Subject>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}
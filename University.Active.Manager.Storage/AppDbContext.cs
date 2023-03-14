using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage;

public sealed class AppDbContext : DbContext
{
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Institute> Institutes => Set<Institute>();
    public DbSet<Subject> Subjects => Set<Subject>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=appmanager.db");
    }

}
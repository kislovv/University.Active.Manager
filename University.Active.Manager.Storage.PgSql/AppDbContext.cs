using Microsoft.EntityFrameworkCore;
using University.Active.Manager.Entity;
using University.Active.Manager.Storage.PgSql.Configuration;

namespace University.Active.Manager.Storage.PgSql;

public class AppDbContext : DbContext
{
    public DbSet<Event> Events => Set<Event>();
    public DbSet<Institute> Institutes => Set<Institute>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<EventRole> Roles => Set<EventRole>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Participation> Participating => Set<Participation>();
    public DbSet<ChooseSubject> ChooseSubjects => Set<ChooseSubject>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventEntityConfiguration());
        modelBuilder.ApplyConfiguration(new EventRoleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new InstituteEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ParticipantEntityConfiguration());
        
        
        base.OnModelCreating(modelBuilder);
    }
}
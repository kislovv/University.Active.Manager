using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        
        builder.Property(x => x.Email)
            .HasMaxLength(ProfileMeta.EmailMaxLength)
            .IsRequired();
        
        builder.Property(x => x.Login)
            .IsRequired();
        
        builder.Property(x => x.Password)
            .HasMaxLength(ProfileMeta.PasswordMaxLength);
        
        builder.Property(x => x.Role)
            .HasMaxLength(ProfileMeta.RoleMaxLength)
            .HasDefaultValue("Student");
        
        builder.Property(x => x.FirstName)
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .IsRequired();
    }
}
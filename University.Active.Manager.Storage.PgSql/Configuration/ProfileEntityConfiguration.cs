using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasDiscriminator(x => x.ProfileType)
            .HasValue<Student>(ProfileType.Student)
            .HasValue<UniversityAdministrator>(ProfileType.UniversityAdministration);
        
        builder.Property(x=> x.ProfileType).HasConversion(v => v.ToString(), 
                v => (ProfileType)Enum.Parse(typeof(ProfileType), v))
            .HasMaxLength(ProfileMeta.ProfileTypeMaxLength)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasMaxLength(ProfileMeta.EmailMaxLength)
            .IsRequired();
        
        builder.Property(x => x.Login)
            .IsRequired();
        
        builder.Property(x => x.Password)
            .HasMaxLength(ProfileMeta.PasswordMaxLength);
        
        builder.Property(x => x.Role)
            .HasMaxLength(ProfileMeta.RoleMaxLength)
            .HasDefaultValue("student");
        
        builder.Property(x => x.FirstName)
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .IsRequired();
    }
}
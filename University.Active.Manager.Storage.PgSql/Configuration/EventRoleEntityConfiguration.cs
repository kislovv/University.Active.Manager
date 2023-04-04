using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class EventRoleEntityConfiguration : IEntityTypeConfiguration<EventRole>
{
    public void Configure(EntityTypeBuilder<EventRole> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(EventRoleMeta.NameMaxLength)
            .IsRequired();

        builder.HasMany(r => r.Participants)
            .WithOne(p => p.EventRole)
            .HasForeignKey(p => p.EventRoleId);

    }
}
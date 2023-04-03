using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class EventEntityConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(EventMeta.NameMaxLength)
            .IsRequired();

        builder.Property(x => x.Place)
            .HasMaxLength(EventMeta.PlaceMaxLength);

        builder.HasOne(ev => ev.Creator)
            .WithMany(administrator => administrator.CreatedEvents)
            .HasForeignKey(x=> x.CreatorId);

        builder.HasMany(ev => ev.Participants)
            .WithMany(us => us.ParticipantEvents);
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class ParticipantEntityConfiguration : IEntityTypeConfiguration<Participation>
{
    public void Configure(EntityTypeBuilder<Participation> builder)
    {
        builder.HasKey(p => new { p.UserId, p.EventId, p.EventRoleId });
        
    }
}
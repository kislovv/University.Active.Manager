using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Storage.PgSql.Configuration;

public class SubjectEntityConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(SubjectMeta.NameMaxLength)
            .IsRequired();

        builder.Property(x => x.Specialty)
            .HasConversion(v => v.ToString(), 
                v => (Specialty)Enum.Parse(typeof(Specialty), v))
            .HasMaxLength(SubjectMeta.SpecialtyMaxLength)
            .IsRequired();
    }
}
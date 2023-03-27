using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Active.Manager.Entity;


namespace University.Active.Manager.Storage.PgSql.Configuration;

public class InstituteEntityConfiguration : IEntityTypeConfiguration<Institute>
{
    public void Configure(EntityTypeBuilder<Institute> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(InstituteMeta.NameMaxLength)
            .IsRequired();
        
        builder.Property(x => x.Specialty)
            .HasConversion(v => v.ToString(), 
                v => (Specialty)Enum.Parse(typeof(Specialty), v))
            .HasMaxLength(InstituteMeta.SpecialtyMaxLength)
            .IsRequired();
        
    }
}
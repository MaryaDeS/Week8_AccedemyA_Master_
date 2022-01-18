using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_RepositoryEF
{
    public class StudenteConfiguration : IEntityTypeConfiguration<Studente>
    {
        public void Configure(EntityTypeBuilder<Studente> builder)
        {
            builder.ToTable("Studente");
            builder.Property(s => s.ID);
            builder.HasKey(k => k.ID);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(25);
            builder.Property(s=>s.Cognome).IsRequired().HasMaxLength(30);
            builder.Property(s=>s.Email).IsRequired().HasMaxLength(50);
            builder.Property(s=>s.TitoloStudio).IsRequired().HasMaxLength(50);

            builder.HasOne(c=>c.Corso).WithMany(s=>s.Studenti).HasForeignKey(k=>k.CorsoCodice);
        }
    }
}
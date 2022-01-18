using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_RepositoryEF
{
    public class CorsoConfiguration : IEntityTypeConfiguration<Corso>
    {
        public void Configure(EntityTypeBuilder<Corso> builder)
        {
            builder.ToTable("Corso");
            builder.Property(c => c.CorsoCodice).IsFixedLength().HasMaxLength(3);
            builder.HasKey(k=>k.CorsoCodice);
            builder.Property(c=>c.Nome).IsRequired();
            builder.Property(d=>d.Descrizione).IsRequired();

            builder.HasMany(s => s.Studenti).WithOne(c => c.Corso);
        }
    }
}
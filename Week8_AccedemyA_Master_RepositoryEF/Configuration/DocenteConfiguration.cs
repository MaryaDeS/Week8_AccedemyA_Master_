using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_RepositoryEF
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)
        {
            builder.ToTable("Docente");
            builder.Property(i => i.ID);
            builder.HasKey(k => k.ID);
            builder.Property(i=>i.Nome).IsRequired();
            builder.Property(i=>i.Cognome).IsRequired();
            builder.Property(i=>i.Email).IsRequired();
            builder.Property(i=>i.Telefono).IsRequired();

            builder.HasMany(l => l.Lezioni).WithOne(d => d.Docente);
        }
    }
}
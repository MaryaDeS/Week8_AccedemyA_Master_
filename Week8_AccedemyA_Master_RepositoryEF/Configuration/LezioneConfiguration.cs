using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_RepositoryEF
{
    internal class LezioneConfiguration : IEntityTypeConfiguration<Lezione>
    {
        public void Configure(EntityTypeBuilder<Lezione> builder)
        {
            builder.ToTable("Lezione");

        }
    }
}
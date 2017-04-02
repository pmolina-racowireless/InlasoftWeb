using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Database.Configurations
{
    public class AudienciaConfiguration : EntityTypeConfiguration<Audiencia>
    {
        public override void Map(EntityTypeBuilder<Audiencia> builder)
        {
            builder.Property(p => p.Transferido).HasDefaultValue(false);

        }
    }
}
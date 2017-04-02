using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace InlasoftWeb.Database.Configurations
{
    public class GestionConfiguration : EntityTypeConfiguration<Gestion>
    {
        public override void Map(EntityTypeBuilder<Gestion> builder)
        {
            builder.Property(p => p.Transferido).HasDefaultValue(false);

        }
    }
}
using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Database.Configurations
{
    public class CasoConfiguration : EntityTypeConfiguration<Caso>
    {
        public override void Map(EntityTypeBuilder<Caso> builder)
        {
                builder.HasOne(typeof(Sucursal))
                    .WithMany()
                    .HasForeignKey("SucursalId")
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

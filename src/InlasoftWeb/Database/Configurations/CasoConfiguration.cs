using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Database.Configurations
{
    public class CasoConfiguration : EntityTypeConfiguration<Caso>
    {
        public override void Map(EntityTypeBuilder<Caso> builder)
        {
            //builder.HasKey(p => p.CasoId);
            //builder.Property(p => p.CasoId).ValueGeneratedOnAdd().IsRequired();
            //builder.HasOne(typeof(Sucursal))
            //        .WithMany()
            //        .HasForeignKey("SucursalId")
            //        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

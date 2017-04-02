using InlasoftWeb.Database.Configurations;
using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InlasoftWeb.Database
{
    public class InlasoftDbContext : IdentityDbContext
    {

        public DbSet<Caso> Casos { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Abogado> Abogados { get; set; }
        public DbSet<Audiencia> Audiencias { get; set; }
        public DbSet<Gestion> Gestiones { get; set; }
        
        public InlasoftDbContext(DbContextOptions<InlasoftDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddConfiguration(new CasoConfiguration());

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
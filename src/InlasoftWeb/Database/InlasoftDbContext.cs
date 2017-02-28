using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InlasoftWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InlasoftWeb.Database
{
    public class InlasoftDbContext : IdentityDbContext
    {

        public DbSet<Case> Cases { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public InlasoftDbContext(DbContextOptions<InlasoftDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
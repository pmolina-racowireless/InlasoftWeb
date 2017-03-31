using InlasoftWeb.Database;
using InlasoftWeb.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace InlasoftWeb.Extensions
{
    public static class IdentityExtension
    {
        public static void CreateDevUsersAndRoles(this IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetService<InlasoftDbContext>();
            var roleManager = app.ApplicationServices.GetService<RoleManager<IdentityRole>>();
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var adminRole = new IdentityRole { Name = "Admin" };
                var userManager = app.ApplicationServices.GetService<UserManager<ApplicationUser>>();
                var firmaDefault = context.Firma.FirstOrDefault();
                roleManager.CreateAsync(adminRole);
                var user = new ApplicationUser { UserName = "admin@innovosystems.com", Firma = firmaDefault, Email = "admin@innovosystems.com" };
                userManager.CreateAsync(user, "admin");
                userManager.AddToRoleAsync(user, "admin");
                context.SaveChanges();
            }

        }
    }
}

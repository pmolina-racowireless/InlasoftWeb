using InlasoftWeb.Database;
using InlasoftWeb.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace InlasoftWeb.Extensions
{
    public static class IdentityExtension
    {
        public static async void CreateDevUsersAndRoles(this IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetService<InlasoftDbContext>();
            var roleManager = app.ApplicationServices.GetService<RoleManager<IdentityRole>>();
            var userManager = app.ApplicationServices.GetService<UserManager<ApplicationUser>>();
            var firmaDefault = context.Firma.FirstOrDefault();

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var adminRole = new IdentityRole { Name = "Admin" };
                await roleManager.CreateAsync(adminRole);
            }

            if (!userManager.Users.Any())
            {
                var user = new ApplicationUser { UserName = "admin@innovosystems.com", Firma = firmaDefault, Email = "admin@innovosystems.com" };
                var result = await userManager.CreateAsync(user, "admin123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                    await userManager.AddClaimAsync(user, new Claim("FirmaId", user.Firma.FirmaId));
                }

            }

        }

        public static string GetFirmaId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FirmaId");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }

}

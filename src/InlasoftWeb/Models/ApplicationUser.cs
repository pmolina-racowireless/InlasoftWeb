using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InlasoftWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Firma Firma { get; set; }

    }
}

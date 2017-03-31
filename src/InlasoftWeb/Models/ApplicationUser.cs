using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InlasoftWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int ApplicationUserId { get; set; }

        public virtual Firma Firma { get; set; }


    }
}

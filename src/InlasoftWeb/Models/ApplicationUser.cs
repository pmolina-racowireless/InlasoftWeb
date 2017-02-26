using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InlasoftWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FirmId { get; set; }

    }
}

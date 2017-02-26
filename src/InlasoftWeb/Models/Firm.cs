using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Firm
    {
        public int FirmId { get; set; }
        public string FirmName { get; set; }
        public string Address { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public string FirmaNombre { get; set; }
        public string Direccion { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}

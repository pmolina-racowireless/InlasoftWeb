using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Firma
    {
        [Key]
        [Required]
        public int FirmaId { get; set; }
        public string FirmaNombre { get; set; }
        public string Direccion { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}

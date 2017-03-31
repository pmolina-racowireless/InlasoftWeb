using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Firma
    {
        [Key]
        public string FirmaId { get; set; }
        [Required]
        public string FirmaNombre { get; set; }
        public string Direccion { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}

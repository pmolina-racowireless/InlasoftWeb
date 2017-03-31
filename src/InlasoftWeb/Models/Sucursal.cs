using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Sucursal : BaseModel
    {
        [Key]
        public string SucursalId { get; set; }
        [Required]
        [Display(Name ="Sucursal")]
        public string SucursalNombre { get; set; }
        public string Direccion { get; set; }

        public string ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}

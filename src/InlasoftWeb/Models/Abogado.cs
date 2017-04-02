using System.ComponentModel.DataAnnotations;


namespace InlasoftWeb.Models
{
    public class Abogado : BaseModel
    {
        [Required]
        public string AbogadoId { get; set; }
        [Required]
        public string AbogadoNombre { get; set; }
    }
}

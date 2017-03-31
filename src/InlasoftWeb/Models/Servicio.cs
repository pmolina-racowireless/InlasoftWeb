using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Servicio : BaseModel
    {
        [Key]
        public string ServicioId { get; set; }
        [Required]
        [Display(Name = "Servicio")]
        public string ServicioNombre { get; set; }

        public string MateriaId { get; set; }
        public Materia Materia { get; set; }

    }
}

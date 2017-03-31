using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Materia : BaseModel
    {
        [Key]
        public string MateriaId { get; set; }
        [Required]
        [Display(Name = "Materia")]
        public string MateriaNombre { get; set; }

        public List<Servicio> Servicios { get; set; }


    }
}

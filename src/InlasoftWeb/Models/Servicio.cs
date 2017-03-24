using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Servicio : BaseModel
    {
        [Key]
        public string ServicioId { get; set; }
        [Required]
        public string ServicioNombre { get; set; }

        public string MateriaId { get; set; }
        public Materia Materia { get; set; }

    }
}

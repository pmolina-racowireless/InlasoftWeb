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
        [Required]
        public int ServicioId { get; set; }
        public string ServicioNombre { get; set; }

        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Materia : BaseModel
    {
        [Key]
        [Required]
        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; }

        public List<Servicio> Servicios { get; set; }


    }
}

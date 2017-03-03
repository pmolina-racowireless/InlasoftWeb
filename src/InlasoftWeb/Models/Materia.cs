using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Materia : BaseModel
    {
        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; }

        public List<Servicio> Servicios { get; set; }


    }
}

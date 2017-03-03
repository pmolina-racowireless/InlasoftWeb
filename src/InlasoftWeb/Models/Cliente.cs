using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Cliente : BaseModel
    {
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string Direccion { get; set; }

        public List<Sucursal> Sucursales { get; set; }
        public virtual List<Caso> Casos { get; set; }

    }
}

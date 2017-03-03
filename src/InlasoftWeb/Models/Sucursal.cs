using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Sucursal : BaseModel
    {
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; }
        public string Direccion { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Cliente : BaseModel
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string Direccion { get; set; }

        public virtual List<Sucursal> Sucursales { get; set; }
        public virtual List<Caso> Casos { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Caso : BaseModel
    {
        [Key]
        public string CasoId { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Contraparte { get; set; }
        public string Catastro { get; set; }
        [Required]
        public virtual Servicio Servicio { get; set; }
        [Required]
        public virtual Firma Firma { get; set; }
        [Required]
        public virtual Cliente Cliente { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}

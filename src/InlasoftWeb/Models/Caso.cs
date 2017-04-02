using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Caso : BaseModel
    {
        [Key]
        public string CasoId { get; set; }
        [Required]
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Descripción")]
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

        public virtual List<Audiencia> Audiencias { get; set; }
        public virtual List<Gestion> Gestiones { get; set; }
    }
}

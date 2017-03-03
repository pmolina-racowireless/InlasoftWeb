using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Caso : BaseModel
    {
        public int CasoId { get; set; }
        [Required]
        public int ServicioId { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Contraparte { get; set; }
        [Required]
        public int FirmaId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int SucursalId { get; set; }
        public string Catastro { get; set; }
            
        public Servicio Servicio { get; set; }
        public Firma Firma { get; set; }
        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }


        
    }
}

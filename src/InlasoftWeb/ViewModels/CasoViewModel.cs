using InlasoftWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.ViewModels
{
    public class CasoViewModel
    {
        [Key]
        public string CasoId { get; set; }
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Contraparte { get; set; }
        public string Catastro { get; set; }
        public string Materia { get; set; }
        public string Servicio { get; set; }
        public string Firma { get; set; }
        public string Cliente { get; set; }
        public string Sucursal { get; set; }

        public static explicit operator CasoViewModel (Caso caso)
        {
            return new CasoViewModel {
                CasoId = caso.CasoId,
                FechaInicio = caso.FechaInicio,
                Descripcion = caso.Descripcion,
                Contraparte = caso.Contraparte,
                Catastro = caso.Catastro,
                Materia = caso.Servicio.Materia.MateriaNombre,
                Servicio = caso.Servicio.ServicioNombre,
                Firma = caso.Firma.FirmaNombre,
                Cliente = caso.Cliente.ClienteNombre,
                Sucursal = caso.Sucursal.SucursalNombre
        };
        }
    }
}

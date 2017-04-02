﻿using InlasoftWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.ViewModels
{
    public class CasoDetailViewModel
    {
        [Key]
        public string CasoId { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Contraparte { get; set; }
        public string Catastro { get; set; }
        public string Cliente { get; set; }
        public string Sucursal { get; set; }

        public List<AudienciaViewModel> Audiencias { get; set; }

        public static explicit operator CasoDetailViewModel(Caso caso)
        {
            return new CasoDetailViewModel
            {
                CasoId = caso.CasoId,
                Descripcion = caso.Descripcion,
                Contraparte = caso.Contraparte,
                Catastro = caso.Catastro,
                Cliente = caso.Cliente.ClienteNombre,
                Sucursal = caso.Sucursal.SucursalNombre,
                Audiencias = caso.Audiencias.Select(x => (AudienciaViewModel)x).ToList()
            };
        }
    }
}

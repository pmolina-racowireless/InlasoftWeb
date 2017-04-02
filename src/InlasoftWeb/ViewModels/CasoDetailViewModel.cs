using InlasoftWeb.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace InlasoftWeb.ViewModels
{
    public class CasoDetailViewModel : BaseModel
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
        public List<GestionViewModel> Gestiones { get; set; }
        public List<DocumentoViewModel> Documentos { get; set; }

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
                Audiencias = caso.Audiencias.Select(x => (AudienciaViewModel)x).ToList(),
                Gestiones = caso.Gestiones.Select(x => (GestionViewModel)x).ToList(),
                Documentos = caso.Documentos.Select(x => (DocumentoViewModel)x).ToList()
            };
        }
    }
}
using InlasoftWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.ViewModels
{
    public class ReunionViewModel
    {
        public int ReunionId { get; set; }
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
        public Double Trabajo { get; set; }

        public string Caso { get; set; }
        public string Abogado { get; set; }

        public static explicit operator ReunionViewModel(Reunion reunion)
        {
            return new ReunionViewModel
            {
                ReunionId = reunion.ReunionId,
                Fecha = reunion.Fecha,
                Hora = reunion.Hora,
                Motivo = reunion.Motivo,
                Comentario = reunion.Comentario,
                Trabajo = reunion.Trabajo,
                Caso = reunion.Caso.Descripcion,
                Abogado = reunion.Abogado.AbogadoNombre
            };
        }
    }
}

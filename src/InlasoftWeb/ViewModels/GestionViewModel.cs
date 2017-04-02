using InlasoftWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.ViewModels
{
    public class GestionViewModel : BaseModel
    {
        public int GestionId { get; set; }
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
        public Double Trabajo { get; set; }
        public bool Transferido { get; set; }

        public string Caso { get; set; }
        public string Abogado { get; set; }

        public static explicit operator GestionViewModel(Gestion gestion)
        {
            return new GestionViewModel
            {
                GestionId = gestion.GestionId,
                Fecha = gestion.Fecha,
                Hora = gestion.Hora,
                Motivo = gestion.Motivo,
                Comentario = gestion.Comentario,
                Trabajo = gestion.Trabajo,
                Caso = gestion.Caso.Descripcion,
                Abogado = gestion.Abogado.AbogadoNombre,
                Transferido = gestion.Transferido
            };
        }
    }
}
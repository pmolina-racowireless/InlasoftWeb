using InlasoftWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.ViewModels
{
    public class AudienciaViewModel : BaseModel
    {
        public int AudienciaId { get; set; }
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

        public static explicit operator AudienciaViewModel(Audiencia audiencia)
        {
            return new AudienciaViewModel
            {
                AudienciaId = audiencia.AudienciaId,
                Fecha = audiencia.Fecha,
                Hora = audiencia.Hora,
                Motivo = audiencia.Motivo,
                Comentario = audiencia.Comentario,
                Trabajo = audiencia.Trabajo,
                Caso = audiencia.Caso.Descripcion,
                Abogado = audiencia.Abogado.AbogadoNombre,
                Transferido = audiencia.Transferido
            };
        }
    }


}
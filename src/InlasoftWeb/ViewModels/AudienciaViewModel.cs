using InlasoftWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.ViewModels
{
    public class AudienciaViewModel
    {
        public int AudienciaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
        public int Trabajo { get; set; }

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
                Abogado = audiencia.Abogado.AbogadoNombre
            };
        }
    }


}

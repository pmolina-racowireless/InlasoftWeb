using InlasoftWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.ViewModels
{
    public class DocumentoViewModel : BaseModel
    {
        [Key]
        [Required]
        public int DocumentoId { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public string DocumentoTipo { get; set; }
        public string Path { get; set; }

        public string Caso { get; set; }
        public string Abogado { get; set; }

        public static explicit operator DocumentoViewModel(Documento documento)
        {
            return new DocumentoViewModel
            {
                DocumentoId = documento.DocumentoId,
                DocumentoTipo = documento.DocumentoTipo,
                Fecha = documento.Fecha,
                Hora = documento.Hora,
                Descripcion = documento.Descripcion,
                Comentario = documento.Comentario,
                Path = documento.Path,
                Caso = documento.Caso.Descripcion,
                Abogado = documento.Abogado.AbogadoNombre,
            };
        }
    }
}
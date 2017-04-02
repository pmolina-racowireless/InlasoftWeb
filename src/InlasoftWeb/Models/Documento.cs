using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Documento : BaseModel
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

        public Caso Caso { get; set; }
        public virtual Abogado Abogado { get; set; }
    }
}
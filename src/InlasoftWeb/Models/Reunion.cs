using System;
using System.ComponentModel.DataAnnotations;

namespace InlasoftWeb.Models
{
    public class Reunion : BaseModel
    {
        [Key]
        [Required]
        public int ReunionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
        public Double Trabajo { get; set; }

        public Caso Caso { get; set; }
        public virtual Abogado Abogado { get; set; }
    }
}

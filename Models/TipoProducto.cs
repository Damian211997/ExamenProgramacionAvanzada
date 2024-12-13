using System.ComponentModel.DataAnnotations;

namespace ExamenProgramacionAvanzada.Models
{
    public class TipoProducto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }
    }
}

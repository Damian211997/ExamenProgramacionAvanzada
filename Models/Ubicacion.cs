using System.ComponentModel.DataAnnotations;

namespace ExamenProgramacionAvanzada.Models
{
    public class Ubicacion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public ICollection<Proveedor> Proveedores { get; set; } = new List<Proveedor>();
    }
}

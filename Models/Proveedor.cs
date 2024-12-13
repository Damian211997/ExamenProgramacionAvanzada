using System.ComponentModel.DataAnnotations;

namespace ExamenProgramacionAvanzada.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public int UbicacionId { get; set; }

        // Relación con Ubicacion
        public Ubicacion? Ubicacion { get; set; }
    }

}

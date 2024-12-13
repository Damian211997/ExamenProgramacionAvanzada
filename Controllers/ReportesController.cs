using ExamenProgramacionAvanzada.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenProgramacionAvanzada.Controllers
{
    public class ReportesController : Controller
    {
        private readonly ComercialSantaClaraContext _context;

        public ReportesController(ComercialSantaClaraContext context)
        {
            _context = context;
        }

        // Acción para mostrar el reporte de proveedores agrupados por ubicación
        public async Task<IActionResult> ProveedoresPorUbicacion()
        {
            // Agrupar proveedores por ubicación y contar los proveedores en cada ubicación
            var reporte = await _context.Proveedores
                .Include(p => p.Ubicacion) // Incluir la información de Ubicación
                .GroupBy(p => p.Ubicacion.Nombre) // Agrupar por nombre de ubicación
                .Select(g => new
                {
                    Ubicacion = g.Key, // Nombre de la ubicación
                    NumeroProveedores = g.Count() // Contar el número de proveedores
                })
                .ToListAsync();

            // Pasar los resultados a la vista
            return View(reporte);
        }
    }
}

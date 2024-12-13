using ExamenProgramacionAvanzada.Models;
using Microsoft.EntityFrameworkCore;

public class ComercialSantaClaraContext : DbContext
{
    public ComercialSantaClaraContext(DbContextOptions<ComercialSantaClaraContext> options) : base(options)
    {
    }

    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Ubicacion> Ubicaciones { get; set; }
    public DbSet<TipoProducto> TiposProducto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de la relación entre Proveedor y Ubicacion
        modelBuilder.Entity<Proveedor>()
            .HasOne(p => p.Ubicacion)
            .WithMany(u => u.Proveedores)
            .HasForeignKey(p => p.UbicacionId)
            .OnDelete(DeleteBehavior.Restrict); // Restricción en caso de eliminar una Ubicacion

        // Configuración de la relación entre TipoProducto y Proveedor (si corresponde)
        // Si un Proveedor está asociado a un TipoProducto, aquí puedes agregar configuraciones adicionales
    }
}

using Microsoft.EntityFrameworkCore;

public class ConcesionarioVehiculoContext(DbContextOptions<ConcesionarioVehiculoContext> options) : DbContext(options)
{
    public DbSet<ConcesionarioVehiculo.Models.Vehiculo> Vehiculo { get; set; } = default!;
}

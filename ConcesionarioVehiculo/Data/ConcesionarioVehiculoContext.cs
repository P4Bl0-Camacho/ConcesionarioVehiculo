using ConcesionarioVehiculo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioVehiculo.Data
{
    public class ConcesionarioVehiculoContext : IdentityDbContext<ApplicationUser>
    {
        public ConcesionarioVehiculoContext(DbContextOptions<ConcesionarioVehiculoContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; } = default!;
        public DbSet<Marca> Marcas { get; set; } = default!;
    }
}
using ConcesionarioVehiculo.Models;
using Microsoft.AspNetCore.Identity;

namespace ConcesionarioVehiculo.Data
{
    public static class SeedData
    {
        public static async Task InicializarAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roles = { "Vendedor", "Comprador" };
            foreach (var rol in roles)
            {
                if (!await roleManager.RoleExistsAsync(rol))
                {
                    await roleManager.CreateAsync(new IdentityRole(rol));
                }
            }

            await CrearUsuarioAsync(userManager, "vendedor@concesionario.com", "Vendedor123*", "Vendedor");
            await CrearUsuarioAsync(userManager, "comprador@concesionario.com", "Comprador123*", "Comprador");
        }

        private static async Task CrearUsuarioAsync(
            UserManager<ApplicationUser> userManager, string email, string password, string rol)
        {
            var usuario = await userManager.FindByEmailAsync(email);

            if (usuario == null)
            {
                usuario = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = true
                };
                var resultado = await userManager.CreateAsync(usuario, password);
                if (!resultado.Succeeded) return;
            }

            // Fuera del bloque de creación, verificando antes
            if (!await userManager.IsInRoleAsync(usuario, rol))
            {
                await userManager.AddToRoleAsync(usuario, rol);
            }
        }
    }
}
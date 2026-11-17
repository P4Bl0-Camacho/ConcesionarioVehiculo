using System.ComponentModel.DataAnnotations;

namespace ConcesionarioVehiculo.Models
{
    public class Marca
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la marca es obligatorio.")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "El país no puede superar los 50 caracteres.")]
        [Display(Name = "País de origen")]
        public string? PaisOrigen { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
}
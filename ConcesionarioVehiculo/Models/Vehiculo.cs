using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioVehiculo.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio.")]
        [StringLength(60, MinimumLength = 2,
            ErrorMessage = "El modelo debe tener entre 2 y 60 caracteres.")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año es obligatorio.")]
        [Range(1950, 2030, ErrorMessage = "El año debe estar entre 1950 y 2030.")]
        [Display(Name = "Año")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(1, 10000000, ErrorMessage = "El precio debe estar entre 1 y 10.000.000.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una marca.")]
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }

        public Marca? Marca { get; set; }
    }
}

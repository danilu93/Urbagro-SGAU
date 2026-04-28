using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    // Clase que representa una planta en el sistema de gestión de plantas.
    public class Planta
    {
        // Propiedades de la planta
        [Key]
        public int PlantaId { get; set; } // Clave primaria de la planta
        public TipoPlanta TipoPlanta { get; set; } // Tipo de planta 
        [Required]
        public string NombrePlanta { get; set; } = null!; // Nombre común de la planta
        public string? NombreCientifico { get; set; } // Nombre científico de la planta (opcional)
        public string? Descripcion { get; set; } // Descripción de la planta (opcional)
        public DateTime FechaSiembra { get; set; } // Fecha en la que se sembró la planta
        [Required]
        public string MetodoSiembra { get; set; } = null!; // Método de siembra utilizado

    }
}

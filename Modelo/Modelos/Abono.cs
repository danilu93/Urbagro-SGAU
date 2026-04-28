using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    // Clase que representa un abono aplicado a una planta
    public class Abono
    {
        // Propiedades del abono
        [Key]
        public int AbonoId { get; set; } // Clave primaria del abono
        public int PlantaId { get; set; } // Clave foránea que referencia a la planta a la que se aplica el abono
        public Planta Planta { get; set; } = null!; // Propiedad de navegación para acceder a la planta asociada al abono
        public TipoAbono TipoAbono { get; set; } // Tipo de abono aplicado 
        public DateTime FechaAbono { get; set; } // Fecha en la que se aplicó el abono
        public decimal CantidadAbono { get; set; } // Cantidad de abono aplicada 

        // Propiedad calculada para obtener el nombre de la planta asociada al abono
        public string NombrePlanta => Planta?.NombrePlanta;

    }
}

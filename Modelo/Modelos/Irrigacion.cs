using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    // Clase que representa la entidad de riego (irrigación) en el sistema
    public class Irrigacion
    {

        // Propiedades de la clase Irrigacion
        [Key]
        public int RiegoId { get; set; } // Clave primaria para identificar de manera única cada registro de riego
        public int PlantaId { get; set; }  // Clave foránea que hace referencia a la planta asociada al riego
        public Planta Planta { get; set; } = null!; // Propiedad de navegación para acceder a la planta asociada al riego
        public MetodoRiego MetodoRiego { get; set; } // Método de riego utilizado
        public DateTime FechaRiego { get; set; } // Fecha en la que se realizó el riego
        public decimal CantidadRiego { get; set; } // Cantidad de agua utilizada en el riego 
        public string NombrePlanta => Planta?.NombrePlanta; // Propiedad calculada para obtener el nombre de la planta asociada al riego

    }
}

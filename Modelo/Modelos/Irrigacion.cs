using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    public class Irrigacion
    {
        public int RiegoId { get; private set; }
        public int UserId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int PlantaId { get; set; }   
        public Planta Planta { get; set; } = null!;
        public MetodoRiego MetodoRiego { get; set; }
        public DateTime FechaRiego { get; set; }
        public decimal CantidadAgua { get; set; }

    }
}

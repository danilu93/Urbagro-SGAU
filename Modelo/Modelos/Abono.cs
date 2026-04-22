using Modelo.Enums;

namespace Modelo.Modelos
{
    public class Abono
    {
        public int AbonoId { get; private set; }
        public int UserId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int PlantaId { get; set; }
        public Planta Planta { get; set; } = null!;
        public TipoAbono TipoAbono { get; set; }
        public DateTime FechaAbono { get; set; }
        public decimal CantidadAbono { get; set; }

    }
}

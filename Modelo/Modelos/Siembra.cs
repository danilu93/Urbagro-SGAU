
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    public class Siembra
    {
        public int SiembraId { get; private set; }
        public int UserId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int PlantaId { get; set; }
        public Planta Planta { get; set; } = null!;
        public DateTime FechaSiembra { get; set; }
        [Required]
        public string MetodoSiembra { get; set; } = null!;


    }
}

using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    public class Planta
    {
        public int PlantaId { get; private set; }
        public int UserId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public TipoPlanta TipoPlanta { get; set; }
        [Required]
        public string NombrePlanta { get; set; } = null!;
        public string? NombreCientifico { get; set; }
        public string? Descripcion { get; set; }

    }
}

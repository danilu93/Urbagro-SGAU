using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    public class Usuario
    {
        public int UserId { get; private set; }
        [Required]
        public string NombreUsuario { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Contrasena { get; set; } = null!;
        public Rol Rol { get; set; }
        public bool Activo { get; set; }


    }
}

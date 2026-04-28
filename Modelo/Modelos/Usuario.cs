using Modelo.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Modelos
{
    // Clase que representa un usuario del sistema
    public class Usuario
    {
        // Propiedades del usuario
        [Key] 
        public int UserId { get; set; } // Clave primaria del usuario
        [Required]
        public string NombreUsuario { get; set; } = null!; // Nombre de usuario
        [EmailAddress]
        public string Email { get; set; } = null!; // Correo electrónico del usuario
        [Required]
        public string Contrasena { get; set; } = null!; // Contraseña del usuario 
        public Rol Rol { get; set; } // Rol del usuario
        public bool Activo { get; set; } // Indica si el usuario está activo o no


    }
}

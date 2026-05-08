using Modelo.Modelos;
using System.Diagnostics.Eventing.Reader;

namespace Sgau
{
    // Clase estática para gestionar la sesión abierta en la aplicación
    public static class SesionAbierta
    {
        public static Usuario? UsuarioIniciado { get; set; } // Propiedad estática para almacenar el usuario que ha iniciado sesión
        public static bool EstaAbierta => UsuarioIniciado != null; // Propiedad para verificar si hay una sesión abierta
        public static void CerrarSesion()
        {
            UsuarioIniciado = null; // Método para cerrar la sesión, estableciendo el usuario en null
        }
    }
}

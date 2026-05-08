using Modelo.Modelos;
using EntityFramework.Datos;

namespace Logica
{
    // Clase que contiene la lógica de negocio relacionada con los usuarios
    public class UsuarioLogica

    {
        // Instancia de la clase UsuarioDatos para acceder a los métodos de datos relacionados con los usuarios
        private UsuarioDatos usuarioDatos = new();

        // Método para autenticar a un usuario utilizando su nombre de usuario y contraseña
        public Usuario Login(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena)) // Validación para asegurarse de que el nombre de usuario y la contraseña no estén vacíos
            {
                throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos."); // Lanza una excepción si el nombre de usuario o la contraseña están vacíos
            }
            // Constructor de la clase UsuarioDatos para acceder a los métodos de datos relacionados con los usuarios
            var usuario = usuarioDatos.Login(nombreUsuario, contrasena); // Llama al método Login de la clase UsuarioDatos para autenticar al usuario con las credenciales proporcionadas

            if (usuario == null) // Si el método Login devuelve null, significa que las credenciales son inválidas
                throw new Exception("Credenciales inválidas. Por favor, verifica tu nombre de usuario y contraseña.");

            return usuario; // Devuelve el usuario autenticado si las credenciales son válidas
        }

        // Método para registrar a un nuevo usuario
        public void RegistrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario), "El objeto usuario no puede ser nulo.");
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                throw new ArgumentException("El nombre de usuario es obligatorio y no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(usuario.Contrasena))
                throw new ArgumentException("La contraseña es obligatoria y no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(usuario.Email)) // Validación para asegurarse de que el nombre de usuario, la contraseña y el correo electrónico no estén vacíos
                throw new ArgumentException("El correo electrónico es obligatorio y no puede estar vacío."); // Lanza una excepción si el nombre de usuario, la contraseña o el correo electrónico están vacíos
            if (usuarioDatos.ExisteUsuario(usuario.NombreUsuario)) // Validación para asegurarse de que el nombre de usuario no esté registrado previamente
                throw new Exception("El nombre de usuario ya está registrado."); // Lanza una excepción si el nombre de usuario ya está registrado


            bool resultado = usuarioDatos.RegistrarUsuario(usuario); // Llama al método RegistrarUsuario de la clase UsuarioDatos para registrar al nuevo usuario

            if (!resultado) // Si el método RegistrarUsuario devuelve false, significa que hubo un error al registrar al usuario
            {
                throw new Exception("Error al registrar el usuario."); // Lanza una excepción si hubo un error al registrar al usuario
            }
        }

        // Método para eliminar a un usuario utilizando su nombre de usuario
        public void EliminarUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario)) // Validación para asegurarse de que el nombre de usuario no esté vacío
            {
                throw new ArgumentException("El nombre de usuario es inválido."); // Lanza una excepción si el nombre de usuario no es válido
            }

            var usuario = usuarioDatos.ObtenerUsuario(nombreUsuario); // Obtiene el usuario por su nombre de usuario   

            if (usuario == null)
                throw new Exception("Usuario no encontrado."); // Lanza una excepción si el usuario no se encuentra

           bool resultado = usuarioDatos.EliminarUsuario(usuario.UserId); // Llama al método EliminarUsuario de la clase UsuarioDatos para eliminar al usuario por su ID

        }
    }
}

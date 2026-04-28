using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;

namespace EntityFramework.Datos
{
    // Clase que maneja las operaciones de datos relacionadas con la entidad Usuario
    public class UsuarioDatos
    {
        // Método para autenticar a un usuario utilizando su nombre de usuario y contraseña
        public Usuario? Login(string nombreUsuario, string contrasena)
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    // Busca un usuario que coincida con el nombre de usuario y la contraseña proporcionados
                    var usuario = context.Usuarios
                        .FirstOrDefault(u =>
                        u.NombreUsuario == nombreUsuario &&
                        u.Contrasena == contrasena &&
                        u.Activo);

                    if (usuario != null)
                    {
                        usuario.Contrasena = "";
                    }

                    return usuario; // Devuelve el usuario encontrado o null si no se encuentra
                }
            }
            catch (InvalidOperationException ex) // Captura errores relacionados con la consulta de la base de datos
            {
                throw new InvalidOperationException("Error en la consulta del Login.", ex);
            }
            catch (Exception ex) // Captura cualquier otro tipo de error inesperado
            {
                throw new Exception("Error inesperado en login.", ex);
            }
        }

        // Método para registrar un nuevo usuario en la base de datos
        public bool RegistrarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {

                    context.Usuarios.Add(nuevoUsuario); // Agrega el nuevo usuario al contexto
                    return context.SaveChanges() > 0; // Guarda los cambios en la base de datos


                }
            }
            catch (DbUpdateException ex) // Captura errores relacionados con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al registrar el usuario en la base de datos.", ex);
            }
            catch (Exception ex) // Captura cualquier otro tipo de error inesperado
            {
                throw new Exception("Error inesperado al registrar el usuario.", ex);
            }
        }

        // Método para eliminar un usuario de la base de datos (marcar como inactivo)
        public bool EliminarUsuario(int userId)
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var usuario = context.Usuarios.Find(userId); // Busca el usuario por su ID
                    if (usuario == null)

                        return false; // Usuario no encontrado

                    usuario.Activo = false; // Marca el usuario como inactivo en lugar de eliminarlo físicamente
                    context.SaveChanges(); // Guarda los cambios en la base de datos
                    return true;

                }

            }
            catch (InvalidOperationException ex) // Captura errores relacionados con la consulta de la base de datos
            {
                throw new InvalidOperationException("Error en la consulta para eliminar el usuario.", ex);
            }
            catch (DbUpdateException ex) // Captura errores relacionados con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al eliminar el usuario en la base de datos.", ex);
            }
            catch (Exception ex) // Captura cualquier otro tipo de error inesperado
            {
                throw new Exception("Error inesperado al eliminar el usuario.", ex);
            }
        }

        // Método para verificar si un usuario con un nombre de usuario específico ya existe en la base de datos
        public bool ExisteUsuario(string nombreUsuario)
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Usuarios.Any(u => u.NombreUsuario == nombreUsuario); // Verifica si existe un usuario con el nombre de usuario proporcionado
                }
            }
            catch (InvalidOperationException ex) // Captura errores relacionados con la consulta de la base de datos
            {
                throw new InvalidOperationException("Error en la consulta para verificar la existencia del usuario.", ex);
            }
            catch (Exception ex) // Captura cualquier otro tipo de error inesperado
            {
                throw new Exception("Error inesperado al verificar la existencia del usuario.", ex);
            }

        }

        // Método para obtener un usuario por su nombre de usuario
        public Usuario? ObtenerUsuario(string nombreUsuario)
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario); // Busca un usuario por su nombre de usuario
                }
            }
            catch (InvalidOperationException ex) // Captura errores relacionados con la consulta de la base de datos
            {
                throw new InvalidOperationException("Error en la consulta para obtener el usuario.", ex);
            }
            catch (Exception ex) // Captura cualquier otro tipo de error inesperado
            {
                throw new Exception("Error inesperado al obtener el usuario.", ex);
            }
        }
    }
}

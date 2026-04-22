using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;

namespace EntityFramework.Datos
{
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
                    // Verifica si ya existe un usuario con el mismo nombre de usuario
                    if (context.Usuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario))
                    {
                        return false; // No se puede registrar porque el nombre de usuario ya existe
                    }
                    context.Usuarios.Add(nuevoUsuario); // Agrega el nuevo usuario al contexto
                    context.SaveChanges(); // Guarda los cambios en la base de datos
                    return true; // Registro exitoso
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

        public bool
    }
}

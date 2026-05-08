using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configuraciones
{
    // Configuración de la entidad Usuario para Entity Framework Core
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            // Configuración adicional de la entidad Usuario si es necesario

            entity.ToTable("Usuarios"); // Especifica el nombre de la tabla en la base de datos
            entity.HasKey(u => u.UserId); // Especifica la clave primaria

            // Configura las propiedades de la entidad Usuario
            entity.Property(u => u.UserId).HasColumnName("user_id");
            entity.Property(u => u.NombreUsuario).HasColumnName("nombre_usuario");
            entity.Property(u => u.Email).HasColumnName("email");
            entity.Property(u => u.Contrasena).HasColumnName("contrasena");
            entity.Property(u => u.Rol).HasColumnName("rol").HasConversion<string>();
            entity.Property(u => u.Activo).HasColumnName("activo");

        }
    }
}
       


using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;

namespace EntityFramework.Conexion
{
    // Clase que representa el contexto de la base de datos
    public class AppDbContext : DbContext
    {
        public AppDbContext() { } // Constructor sin parámetros para permitir la creación del contexto sin opciones explícitas
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } // Constructor que acepta opciones de configuración

        // Definición de los DbSet para cada entidad
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Planta> Plantas { get; set; }
        public DbSet<Irrigacion> Irrigacion { get; set; }
        public DbSet<Abono> Abono { get; set; }

        // Configuración de la conexión a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Verifica si las opciones ya han sido configuradas
            {
                // Configura la cadena de conexión a la base de datos
                optionsBuilder.UseSqlServer("Server=DESKTOP-BH8AITS\\SQLEXPRESS; Database=sgau_db;Integrated Security = true; TrustServerCertificate=true");
            }
        }

        // Configuración adicional de las entidades y relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración adicional de las entidades
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); // Aplica todas las configuraciones de entidades definidas 

        }
    }    
}

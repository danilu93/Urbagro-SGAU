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
        public DbSet<Siembra> Siembras { get; set; }
        public DbSet<Irrigacion> Irrigaciones { get; set; }
        public DbSet<Abono> Abonos { get; set; }

        // Configuración de la conexión a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // Verifica si las opciones ya han sido configuradas
            {
                // Configura la cadena de conexión a la base de datos
                optionsBuilder.UseSqlServer("Server=DESKTOP-BH8AITS\\SQLEXPRESS; Database=sgau_db;Integrated Security = true; TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Configuración adicional de las entidades si es necesario
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Rol)
                .HasConversion<string>(); // Almacena el enum como string en la base de datos   

            modelBuilder.Entity<Planta>()
                .Property(p => p.TipoPlanta)
                .HasConversion<string>(); 

            modelBuilder.Entity<Abono>()
                .Property(a => a.TipoAbono)
                .HasConversion<string>(); 

            modelBuilder.Entity<Irrigacion>()
                .Property(i => i.MetodoRiego)
                .HasConversion<string>();

            // Convierte los nombres de las tablas y columnas a snake_case
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(ToSnakeCase(entity.GetTableName()));

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(ToSnakeCase(property.Name));
                }
            }
        }

        // Método auxiliar para convertir un nombre a snake_case
        private static string ToSnakeCase(string name)
        {
            return string.Concat(name.Select((x, i) =>
                i > 0 && char.IsUpper(x) ? "_" + x : x.ToString())).ToLower();  
        }

    }
}

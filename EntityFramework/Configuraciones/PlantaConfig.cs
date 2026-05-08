using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configuraciones
{
    // Configuración de la entidad Planta para Entity Framework Core
    public class PlantaConfig : IEntityTypeConfiguration<Planta>
    {
        // Configuración adicional de la entidad Planta si es necesario
        public void Configure(EntityTypeBuilder<Planta> entity)
        {
            entity.ToTable("Plantas"); // Especifica el nombre de la tabla en la base de datos
            entity.HasKey(p => p.PlantaId);

            // Configura las propiedades de la entidad Planta
            entity.Property(p => p.PlantaId).HasColumnName("planta_id");
            entity.Property(p => p.TipoPlanta).HasColumnName("tipo_planta").HasConversion<string>();
            entity.Property(p => p.NombrePlanta).HasColumnName("nombre_planta");
            entity.Property(p => p.NombreCientifico).HasColumnName("nombre_cientifico");
            entity.Property(p => p.Descripcion).HasColumnName("descripcion");
            entity.Property(p => p.FechaSiembra).HasColumnName("fecha_siembra");
            entity.Property(p => p.MetodoSiembra).HasColumnName("metodo_siembra");

        }
    }
}

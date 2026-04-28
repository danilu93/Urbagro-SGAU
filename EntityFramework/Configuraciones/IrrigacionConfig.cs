using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configuraciones
{
    // Configuración de la entidad Irrigacion
    public class IrrigacionConfig : IEntityTypeConfiguration<Irrigacion>
    {
        public void Configure(EntityTypeBuilder<Irrigacion> entity)
        {
            entity.ToTable("Irrigacion"); // Especifica el nombre de la tabla en la base de datos
            entity.HasKey(r => r.RiegoId);

            // Configura las propiedades y sus nombres de columna
            entity.Property(r => r.RiegoId).HasColumnName("riego_id");
            entity.Property(r => r.MetodoRiego).HasColumnName("metodo_riego").HasConversion<string>();
            entity.Property(r => r.FechaRiego).HasColumnName("fecha_riego");
            entity.Property(r => r.CantidadRiego).HasColumnName("cantidad_riego");
            entity.Property(r => r.PlantaId).HasColumnName("planta_id");

            entity.HasOne(r => r.Planta) // Configura la relación con la entidad Planta
                .WithMany()
                .HasForeignKey(r => r.PlantaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

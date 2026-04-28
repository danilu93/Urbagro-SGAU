using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configuraciones
{
    // Configuración de la entidad Abono
    public class AbonoConfig : IEntityTypeConfiguration<Abono>
    {
        public void Configure(EntityTypeBuilder<Abono> entity)
        {
            entity.ToTable("Abono"); // Especifica el nombre de la tabla en la base de datos
            entity.HasKey(a => a.AbonoId);

            // Configuración de las propiedades
            entity.Property(a => a.AbonoId).HasColumnName("abono_id");
            entity.Property(a => a.TipoAbono).HasColumnName("tipo_aplicado").HasConversion<string>();
            entity.Property(a => a.FechaAbono).HasColumnName("fecha_aplicacion");
            entity.Property(a => a.CantidadAbono).HasColumnName("cantidad_abono");
            entity.Property(a => a.PlantaId).HasColumnName("planta_id");

            // Configuración de la relación con Planta
            entity.HasOne(a => a.Planta)
                .WithMany() 
                .HasForeignKey(a => a.PlantaId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

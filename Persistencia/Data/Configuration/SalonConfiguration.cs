using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class SalonConfiguration : IEntityTypeConfiguration<Salon>
{
    public void Configure(EntityTypeBuilder<Salon> builder)
    {
        builder.ToTable("Salon");

        builder.Property(p => p.PKNombreSalon)
            .HasColumnName("PKSalon")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(p => p.Capacidad)
            .HasColumnName("Capacidad")
            .HasColumnType("int")
            .IsRequired();
    }
}

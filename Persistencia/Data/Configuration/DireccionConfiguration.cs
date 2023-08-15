using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
{
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable("Direccion");

        builder.Property(p => p.IdDireccion)
            .HasColumnName("IdDireccion")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.TipoViaId)
            .HasColumnName("TipoVia_Id")
            .HasColumnType("varchar")
            .HasMaxLength(25);


    }
}

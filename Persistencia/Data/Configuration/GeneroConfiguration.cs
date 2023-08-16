using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Genero");

        builder.Property(p => p.PKNombreGenero)
            .HasColumnName("Genero_PK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

    }
}

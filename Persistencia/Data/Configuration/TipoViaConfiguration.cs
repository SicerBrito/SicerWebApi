using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TipoViaConfiguration : IEntityTypeConfiguration<TipoVia>
{
    public void Configure(EntityTypeBuilder<TipoVia> builder)
    {
        builder.ToTable("TipoVia");

        builder.Property(p => p.PKNombreTipoVia)
            .HasColumnName("PKNombreTipoVia")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(p => p.Abreviatura)
           .HasColumnName("Abreviatura")
           .HasColumnType("varchar")
           .HasMaxLength(5)
           .IsRequired();

    }
}

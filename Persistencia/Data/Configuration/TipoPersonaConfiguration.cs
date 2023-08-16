using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("TipoPersona");

        builder.Property(p => p.PKTipoPersona)
            .HasColumnName("PKTipoPersona")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(p => p.Descripcion)
            .HasColumnName("Descripcion")
            .HasColumnType("varchar")
            .HasMaxLength(150)
            .IsRequired();

        
        
    }
}

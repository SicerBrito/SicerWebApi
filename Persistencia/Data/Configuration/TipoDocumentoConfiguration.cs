using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("TipoDeDocumento");

        builder.Property(p => p.PKNombreTipo)
            .HasColumnName("PKNombreTipo")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();


    }
}

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
{
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable("Direccion");

        builder.Property(p => p.PKDireccion)
            .HasColumnName("PKDireccion")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.TipoViaFK)
            .HasColumnName("TipoVia_FK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasOne(p => p.TipoDeVias)
            .WithMany(p => p.Direcciones)
            .HasForeignKey(p => p.TipoViaFK);

        builder.Property(p => p.NroDireccion)
            .HasColumnName("NroDireccion")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Letra)
            .HasColumnName("varchar")
            .HasMaxLength(5)
            .IsRequired();

        builder.Property(p => p.SufijoCardinal)
            .HasColumnName("SufijoCardinal")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(p => p.NroViaSecundaria)
            .HasColumnName("NroViaSecundaria")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.LetraVS)
            .HasColumnName("LetraViaSecundaria")
            .HasColumnType("varchar")
            .HasMaxLength(5)
            .IsRequired();

        builder.Property(p => p.SufijoCardinalVS)
            .HasColumnName("SufijoCardinalVS")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(p => p.PersonaFK)
            .HasColumnName("Persona_FK")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Personas)
            .WithMany(p => p.Direcciones)
            .HasForeignKey(p => p.PersonaFK);


    }
}

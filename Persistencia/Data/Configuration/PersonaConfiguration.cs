using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Persona");

        builder.Property(p => p.PKCedula)
            .HasColumnName("Cedula_PK")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombres)
            .HasColumnName("Nombres")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Apellidos)
            .HasColumnName("Apellidos")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.TipoDocumentoFK)
            .HasColumnName("TipoDeDocumento_FK")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();

        builder.HasOne(p => p.TiposDeDocumentos)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.TipoDocumentoFK);

        builder.Property(p => p.GeneroFK)
            .HasColumnName("Genero_FK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasOne(p => p.Generos)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.GeneroFK);

        builder.Property(p => p.CiudadFK)
            .HasColumnName("Ciudad_FK")
            .HasColumnType("varchar")
            .HasMaxLength(85)
            .IsRequired();

        builder.HasOne(p => p.Ciudades)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.CiudadFK);

        builder.Property(p => p.TipoPersonaFK)
            .HasColumnName("TipoPersona_FK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasOne(p => p.TipoDePersonas)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.TipoPersonaFK);


    }
}

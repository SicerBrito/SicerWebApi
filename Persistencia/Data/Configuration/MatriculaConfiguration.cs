using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.ToTable("Matricula");

        builder.Property(p => p.PKMatricula)
            .HasColumnName("PKMatricula")
            .HasColumnType("bigint")
            .IsRequired();

        builder.Property(p => p.PersonaFK)
            .HasColumnName("Persona_FK")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasOne(p => p.Personas)
            .WithMany(p => p.Matriculas)
            .HasForeignKey(p => p.PersonaFK);

        builder.Property(p => p.SalonFK)
            .HasColumnName("Salon_FK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasOne(p => p.Salones)
            .WithMany(p => p.Matriculas)
            .HasForeignKey(p => p.SalonFK);

    }
}

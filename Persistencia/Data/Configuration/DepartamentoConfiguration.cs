using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamento");

        builder.Property(p => p.IdDepartamento)
            .HasColumnName("IdDepartamento")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreDepartamento)
            .HasColumnName("NombreDepartamento")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.PaisId)
            .HasColumnName("Paises_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Paises)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.PaisId);


    }
}

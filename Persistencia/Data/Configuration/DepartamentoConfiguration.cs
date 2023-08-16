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

        builder.Property(p => p.PKNombreDepartamento)
            .HasColumnName("Departamento_FK")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.PaisFK)
            .HasColumnName("Pais_FK")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Paises)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.PaisFK);


    }
}

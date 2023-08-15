using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("Ciudad");

        builder.Property(p => p.IdCiudad)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdCiudad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreCiudad)
            .HasColumnName("NombreCiudad")
            .HasColumnType("varchar")
            .HasMaxLength(85) //La ciudad con el nombre mas largo del mundo es Taumatawhakatangihangakoauauotamateaturipukakapiki-maungahoronukupokaiwhenuakitnatahu con 85 caracteres.
            .IsRequired();

        builder.Property(p => p.DepartamentoId)
            .HasColumnName("Departamento_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Departamentos)
            .WithMany(p => p.Ciudades)
            .HasForeignKey(p => p.DepartamentoId);

        
    }
}

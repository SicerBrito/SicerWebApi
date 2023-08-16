using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>{
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");

            builder.Property(p => p.PKNombrePais)
                .HasColumnName("Pais_FK")
                .HasColumnType("varchar")
                .HasMaxLength(85)
                .IsRequired();


        }
    }

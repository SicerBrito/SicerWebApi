using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
{
    public void Configure(EntityTypeBuilder<TrainerSalon> builder)
    {
        builder.ToTable("TrainerSalon");

        builder.Property(p => p.PersonaFK)
            .HasColumnName("Persona_FK")
            .HasColumnType("bigint")
            .IsRequired();

        builder.HasOne(p => p.Personas)
            .WithMany(p => p.TrainersDeSalones)
            .HasForeignKey(p => p.PersonaFK);

        builder.Property(p => p.SalonFK)
            .HasColumnName("Salon_FK")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasOne(p => p.Salones)
            .WithMany(p => p.TrainersDeSalones)
            .HasForeignKey(p => p.SalonFK);


    }
}

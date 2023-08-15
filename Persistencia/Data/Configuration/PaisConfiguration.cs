using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>{
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            throw new NotImplementedException();
        }
    }

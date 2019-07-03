
namespace Industria.Data.Mappings
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class IndustriaMapping : IEntityTypeConfiguration<Industria.Domain.Entities.Industria>
    {
        public void Configure(EntityTypeBuilder<Industria.Domain.Entities.Industria> builder)
        {
             builder.ToTable("tbIndustria");
            
             builder.HasKey(i => i.Id);
             builder.Property(i => i.Id).UseSqlServerIdentityColumn();
            
             builder.Property(i => i.Codigo)
                    .IsRequired()
                    .HasColumnName("Codigo")
                    .HasColumnType("VARCHAR(6)");

             builder.HasIndex(i => i.Codigo)
                    .IsUnique();

             builder.Property(i => i.Descricao)
                    .IsRequired()
                    .HasColumnName("Descricao")
                    .HasColumnType("VARCHAR(100)");

             builder.Property(i => i.Tipo)                                
                    .HasColumnName("Tipo")
                    .HasColumnType("INT");
        }       
    }
}
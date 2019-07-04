using System.IO;
using Industria.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Industria.Data.Context
{
    public class IndustriaContext : DbContext
    {
        public DbSet<Industria.Domain.Entities.Industria> Industria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.HasDefaultSchema("Industria");
            
            modelBuilder.ApplyConfiguration(new IndustriaMapping());            
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Industria;User ID=sa;Password=123456;Trusted_Connection=False;Min Pool Size=5;Max Pool Size=250;Connect Timeout=30;MultipleActiveResultSets=True;Application Name=Industria");
        }
    }
}
using API1.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API1.Persistence.Contexts
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<TaxaJuros> TaxaJuros {get; set;}
        

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            
            builder.Entity<TaxaJuros>().ToTable("Taxajuros");
            builder.Entity<TaxaJuros>().HasKey(p => p.Id);
            builder.Entity<TaxaJuros>().Property(p => p.Valor).IsRequired();

            builder.Entity<TaxaJuros>().HasData(new TaxaJuros {Id = 1, Valor = 0.01});

        }
    }
}
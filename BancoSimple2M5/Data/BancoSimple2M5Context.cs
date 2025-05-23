using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple2M5.Data
{
    public class BancoSimple2M5Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =JOSEGFONSECA; database = BancoSimple2M5; trusted_Connection = true; trustserverCertificate = true;");
        }

        //Definicion de filtro Global
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasQueryFilter(c => c.Activa);
        }
    }
}

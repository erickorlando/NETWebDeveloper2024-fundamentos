using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sesion04.ECommerceWeb.Entidades;

namespace ECommerceWeb.DataAccess.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {

        }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ECommerceDB;Trusted_Connection=True",
                 o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<Categoria> Categorias { get; set; } = default!;
        public DbSet<Producto> Productos { get; set; } = default!;
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Venta> Ventas { get; set; } = default!;
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
    }
}

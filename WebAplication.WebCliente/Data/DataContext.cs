using Microsoft.EntityFrameworkCore;
using WebAplication.WebCliente.Data.Entities;

namespace WebAplication.WebCliente.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pedidos> Pedido { get; set; }
        public DbSet<Productos> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

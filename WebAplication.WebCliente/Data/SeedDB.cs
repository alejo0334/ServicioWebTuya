using System.Linq;
using System.Threading.Tasks;
using WebAplication.WebCliente.Data.Entities;

namespace WebAplication.WebCliente.Data
{
    public class SeedDB
    {

        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            this._context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProductosAsync();
        }

        public async Task CheckProductosAsync()
        {
            //CREACIÓN DE REGISTROS EN DB
            if (!_context.Producto.Any())
            {
                _context.Producto.Add(new Productos { Descripcion = "Baterias", Precio = 12000 });
                _context.Producto.Add(new Productos { Descripcion = "Tapete", Precio = 53000 });
                _context.Producto.Add(new Productos { Descripcion = "Silla Mesedora", Precio = 321000 });
                _context.Producto.Add(new Productos { Descripcion = "Guantes", Precio = 5000 });

                await _context.SaveChangesAsync();
            }
        }
    }
}

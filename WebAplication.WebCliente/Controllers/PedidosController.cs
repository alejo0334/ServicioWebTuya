using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebAplication.WebCliente.Data;

namespace WebAplication.WebCliente.Controllers
{
    public class PedidosController : Controller
    {
        private readonly DataContext _context;
        public PedidosController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedido.ToListAsync());
        }
    }
}

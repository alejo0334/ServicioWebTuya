using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAplication.WebCliente.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAplication.WebCliente.Data.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIRESTController : ControllerBase
    {

        private readonly DataContext _context;
        public APIRESTController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene la lista de productos a facturar
        /// </summary>
        /// <returns></returns>
        // GET: api/<APIController>
        [HttpGet]
        public IEnumerable<Productos> Get()
        {
            return _context.Producto.ToList();
        }

        /// <summary>
        /// Persiste los nuevos pedidos facturados
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Post(Pedidos pedido)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Pedido.Add(pedido);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(String.Empty, e.InnerException.Message);
                }
            }

            return true;
        }
    }
}

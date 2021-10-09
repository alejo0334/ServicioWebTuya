﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using WebAplication.WebCliente.Data;
using WebAplication.WebCliente.Data.Entities;

namespace WebAplication.WebCliente.Controllers
{
    public class FacturarController : Controller
    {

        private readonly DataContext _context;
        public FacturarController(DataContext context)
        {
            _context = context;
        }

        // GET: Facturar
        public IActionResult Index()
        {
            HttpClient clienteHttp = new HttpClient();

            clienteHttp.BaseAddress = new Uri("https://localhost:44362/");

            var request = clienteHttp.GetAsync("api/APIREST").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var lista = JsonConvert.DeserializeObject<List<Productos>>(resultString);
                
                return View(lista);

            }

            return View();

        }

        // POST: Facturar
        [HttpPost]
        public JsonResult Create()
        {

            try
            {
                var NumPedido = _context.Pedido.Count() == 0 ? 10001 : _context.Pedido.Max(x => x.NroPedido);
                var productos = _context.Producto;

                HttpClient clienteHttp = new HttpClient();

                clienteHttp.BaseAddress = new Uri("https://localhost:44362/");
                foreach (var item in productos)
                {
                    Pedidos pedido = new Pedidos();
                    pedido.NroPedido = NumPedido + 1;
                    pedido.Descripcion = item.Descripcion;
                    pedido.Valor = item.Precio;

                    var request = clienteHttp.PostAsync("api/APIREST", pedido, new JsonMediaTypeFormatter());
                }

            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.InnerException.Message);
            }

            return Json("Venta registrada");

        }
    }
}

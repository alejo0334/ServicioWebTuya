using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAplication.WebCliente.Data.Entities
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int NroPedido { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
    }
}

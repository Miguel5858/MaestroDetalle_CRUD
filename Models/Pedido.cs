using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaestroDetalle_CRUD.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
        
    }
}
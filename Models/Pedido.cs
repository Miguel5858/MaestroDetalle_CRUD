using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaestroDetalle_CRUD.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Detalles = new List<PedidoDetalle>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }=null!;

        public List<PedidoDetalle> Detalles { get; set; }=null!;
        
    }
}
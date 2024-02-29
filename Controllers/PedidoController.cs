using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MaestroDetalle_CRUD.Data;
using MaestroDetalle_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MaestroDetalle_CRUD.Controllers
{

    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
       {
           _context = context;
       }
       public async Task<ActionResult> Index()
       {
        var pedidos= await _context.Pedidos
        .Include(p=>p.Cliente)
        .ToListAsync();
        
        return View(pedidos);
       }

         public async Task<ActionResult> Create()
       {
        ViewBag.Clientes = await _context.Clientes.ToListAsync();
        ViewBag.Productos = await _context.Productos.ToListAsync();          
        return View();
       }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Pedido pedido, int[] poductoIds, int[] cantidades)
       {
        var cli = await _context.Clientes.FirstOrDefaultAsync(m=>m.ClienteId == pedido.ClienteId);
        if(cli!=null)        
            pedido.Cliente=cli;
        foreach (var item in poductoIds)
        {
            var producto = await _context.Productos.FindAsync(item);
            if(producto!=null)
            {
               pedido.Detalles.Add(new PedidoDetalle
                {
                    ProductoId=item,
                    Cantidad=cantidades[Array.IndexOf(poductoIds, item)],
                    Producto=producto
                });
            }
        }
        
         
        return View();
       }
  
  
    }
}
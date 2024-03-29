using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaestroDetalle_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace MaestroDetalle_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Pedido> Pedidos { get; set; } = null!;
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pedido>()
            .HasMany(p=>p.Detalles)
            .WithOne(d=>d.Pedido)
            .HasForeignKey(d=>d.PedidoId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
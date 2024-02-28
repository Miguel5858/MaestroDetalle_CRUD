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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        
    }
}
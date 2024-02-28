using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaestroDetalle_CRUD.Models
{
    public class Cliente
    {

      public int ClienteId { get; set;}  
      [Required]
      public string Nombre { get; set; }=null!;
    }
}
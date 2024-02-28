

namespace MaestroDetalle_CRUD.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }=null!;
        public decimal Precio { get; set; }
    }
}
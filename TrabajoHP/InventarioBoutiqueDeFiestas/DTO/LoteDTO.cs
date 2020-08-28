using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    class LoteDTO
    {
        public int Id { get; set; }
        public int CantidadProductos { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        // Hay que chequear si estado es un boolean o una enum
        public Boolean Vencido { get; set; }
        public int IdProducto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class LoteDTO
    {
        public int Id { get; set; }
        public int CantidadProductos { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Boolean Vencido { get; set; }
        public int IdProducto { get; set; }

        public int CantidadAIngresar { get; set; }

    }
}

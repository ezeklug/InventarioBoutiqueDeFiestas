using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Lote
    {
        public int Id { get; set; }
        public int CantidadProductos { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        // Hay que chequear si estado es un boolean o una enum
        public Boolean Estado { get; set; }
        public Producto Producto { get; set; }
    }
}

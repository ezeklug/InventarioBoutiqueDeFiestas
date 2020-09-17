using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class ProductoIngresarMercaderiaDTO
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}

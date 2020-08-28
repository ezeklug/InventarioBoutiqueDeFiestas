using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    class LineaPresupuestoDTO
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }

        public int IdPresupuesto { get; set; }

        public int Cantidad { get; set; }
        public double PorcentajeDescuento { get; set; }

        public double Subtotal { get; set; }
    }
}

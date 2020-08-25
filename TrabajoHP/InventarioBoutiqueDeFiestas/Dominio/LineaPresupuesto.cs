using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class LineaPresupuesto
    {
        public int Cantidad { get; set; }
        public double PorcentajeDescuento { get; set; }
        public Producto Producto { get; set; }

        public double Subtotal { get; set; }
        public LineaPresupuesto(int pCantidad, double pPorcentajeDescuento, Producto pProducto)
        {
            Producto = pProducto;
            Cantidad = pCantidad;
            PorcentajeDescuento = pPorcentajeDescuento;
            Subtotal = pProducto.PrecioVenta();
        }
    }
}

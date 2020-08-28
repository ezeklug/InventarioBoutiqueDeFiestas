using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class LineaPresupuesto
    {
     
        public int Id { get; set; }
        public Producto Producto { get; set; }

        public Presupuesto Presupuesto { get; set; }

        public int Cantidad { get; set; }
        public double PorcentajeDescuento { get; set; }

       
        public double Subtotal { get; set; }

        
        public LineaPresupuesto(int pCantidad, double pPorcentajeDescuento, Producto pProducto, Presupuesto pPresupuesto)
        {
            Producto = pProducto;
            Cantidad = pCantidad;
            PorcentajeDescuento = pPorcentajeDescuento;
            Subtotal = pProducto.PrecioVenta();
            Presupuesto = pPresupuesto;
        }

        public LineaPresupuesto() { }
    }
}

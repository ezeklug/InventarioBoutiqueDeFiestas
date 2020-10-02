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

        public Boolean Vencido { get; set; }
        public Producto Producto { get; set; }

        public Lote(int pCantidadProductos, DateTime pFechaVencimiento, Producto pProducto)
        {
            CantidadProductos = pCantidadProductos;
            FechaCompra = DateTime.Now;
            FechaVencimiento = pFechaVencimiento;
            Producto = pProducto;
            EstaVencido();
        }
        public void EstaVencido()
        {
            if (DateTime.Now < this.FechaVencimiento)
            {
                Vencido = false;
            }
            else { Vencido = true; }
        }
        public Lote() { }
    }
}

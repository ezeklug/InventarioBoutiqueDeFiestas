using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaDeVenta { get; set; }
        
        public Venta()
        {
            FechaDeVenta = DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class LoteVendido
    {
        public int Id { get; set; }
        public Venta Venta { get; set; }
        public Lote Lote { get; set; }
        public int Cantidad { get; set; }

        public  LoteVendido() { 
        }
        public LoteVendido(Venta venta, Lote lote)
        {
            Venta = venta;
            Lote = lote;
        }

    }
}

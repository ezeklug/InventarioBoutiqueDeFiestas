using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    class VentaDTO
    {
        public int Id { get; set; }
        public DateTime FechaDeVenta { get; set; }

        public int IdPresupuesto { get; set; }
    }
}

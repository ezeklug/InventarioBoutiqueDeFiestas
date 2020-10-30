using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class NotificacionDTO
    {
        public DateTime FechaVencimiento { get; set; }
        public String Descripcion { get; set; }
        public int IdPresupuesto { get; set; }
        public int IdLote { get; set; }
    }
}

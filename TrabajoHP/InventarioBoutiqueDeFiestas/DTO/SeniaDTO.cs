using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
   public class SeniaDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public DateTime ValidoHasta { get; set; }
        public int IdPresupuesto { get; set; }
    }
}

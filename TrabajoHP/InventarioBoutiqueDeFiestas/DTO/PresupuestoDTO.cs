using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class PresupuestoDTO
    {
        public int Id { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdCliente { get; set; }

        public String Cliente { get; set; }
        public string Estado { get; set; }
        public double Descuento { get; set; }

        

    }
}

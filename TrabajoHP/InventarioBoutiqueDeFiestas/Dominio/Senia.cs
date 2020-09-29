using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Senia
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public DateTime ValidoHasta { get; set; }
        public Presupuesto Presupuesto { get; set; }
        /// <summary>
        /// Construye una seña y le asigna la fecha actual
        /// </summary>
        /// <param name="pMonto"></param>
        public Senia(double pMonto,Presupuesto pPresupuesto)
        {
            Fecha = DateTime.Now;
            Monto = pMonto;
            Presupuesto = pPresupuesto;
        }

        public Senia() { }
    }
}

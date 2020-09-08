using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEvento { get; set; }
        //    public double TotalVenta { get; set; }
        public Cliente Cliente { get; set; }

        public string Estado { get; set; }
        public virtual ICollection<LineaPresupuesto> Lineas {get ;set ;}
        
        /*public enum Estado
        {
            Presupuestado,
            Vendido,
            Señado,
            Cancelado
        } */
        public Presupuesto(DateTime pFechaGeneracion, DateTime pFechaVencimiento, DateTime pFechaEvento, Cliente pCliente)
        {
            FechaGeneracion = pFechaGeneracion;
            FechaVencimiento = pFechaVencimiento;
            FechaEvento = pFechaEvento;
            Cliente = pCliente;
        }
        public Presupuesto() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{

    /// <summary>
    /// Clase usadad para unificar los estados del presupuesto
    /// </summary>
    public static class EstadoPresupuesto
    {
        public static string Presupuestado {
            get { return "Presupuestado"; } }

        public static string Vendido
        {
            get { return "Vendido"; }
        }

        public static string Seniado
        {
            get { return "Seniado"; }
        }

        public static string Cancelado
        {
            get { return "Cancelado"; }
        }
    }


    public class Presupuesto
    {
        public int Id { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEvento { get; set; }
        public Cliente Cliente { get; set; }

        public double Descuento { get; set; }
        public string Estado { get; set; }
        public virtual ICollection<LineaPresupuesto> Lineas {get ;set ;}
        
        public double TotalVenta()
        {
            double precio=0;
            foreach(LineaPresupuesto linea in Lineas)
            {
                precio += linea.Subtotal;
            }
            return precio * (1 - Descuento/100);
        }
        public string Observacion { get; set; }
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

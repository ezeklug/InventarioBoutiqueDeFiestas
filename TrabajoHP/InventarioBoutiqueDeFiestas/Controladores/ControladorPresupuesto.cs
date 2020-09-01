using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Database;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    public class ControladorPresupuesto
    {

        public Senia DTOASenia(SeniaDTO pSenia)  // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            Senia senia = new Senia();
            Repositorio repo = new Repositorio();

            senia.Id = pSenia.Id;
            senia.Fecha = pSenia.Fecha;
            senia.Monto = pSenia.Monto;
            Presupuesto presupuesto = repo.Presupuestos.Find(pSenia.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pSenia.IdPresupuesto + " no existe en Presupuestos");
            }

            senia.Presupuesto = presupuesto;
            return senia;
        }

        public Venta DTOAVenta(VentaDTO pVenta)  // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            Venta ven = new Venta();
            Repositorio repo = new Repositorio();

            ven.Id = pVenta.Id;
            ven.FechaDeVenta = pVenta.FechaDeVenta;
            Presupuesto presupuesto = repo.Presupuestos.Find(pVenta.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pVenta.IdPresupuesto + " no existe en Presupuestos");
            }

            ven.Presupuesto = presupuesto;
            return ven;
        }

        public LineaPresupuesto DTOALineaPresupuesto(LineaPresupuestoDTO pLinea) // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            LineaPresupuesto lin = new LineaPresupuesto();
            Repositorio repo = new Repositorio();

            lin.Id = pLinea.Id;
            lin.Cantidad = pLinea.Cantidad;
            lin.PorcentajeDescuento = pLinea.PorcentajeDescuento;
            Presupuesto presupuesto = repo.Presupuestos.Find(pLinea.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pLinea.IdPresupuesto + " no existe en Presupuestos");
            }
            lin.Presupuesto = presupuesto;
            Producto producto = repo.Productos.Find(pLinea.IdProducto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pLinea.IdProducto + " no existe en Productos");
            }
            lin.Producto = producto;

            return lin;
        }

        public ControladorPresupuesto()
        {
           

        }
        /// <summary>
        /// Método que permite agregar un presupuesto pasando sus parámetros para crearlo y guardarlo en db.
        /// </summary>
        /// <param name="presupuesto"></param>
        public void AgregarPresupuesto(PresupuestoDTO pPresupuesotDTO)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método que permite agregar una línea correspondiente a un presupuesto y un producto, pasando los siguientes parámetros.
        /// </summary>
        /// <param name="pPrecioVenta"></param>
        /// <param name="pCantidad"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pIdProducto"></param>
        public void AgregarLinea(LineaPresupuestoDTO pPresupuestoDTO)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este metodo permite señar un presupuesto pasando como parámetro el id del presupuesto y el monto de la seña.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pMontoSenia"></param>
        public void SeniarPresupuesto(int pIdPresupuesto, double pMontoSenia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite vender un presupuesto, pasando como parámetro el id del presupuesto
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        public void Vender(int pIdPresupuesto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este metodo permite asociar un cliente a un presupuesto, pasando como parámetro el id del presupuesto y el id del cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdPresupuesto"></param>
        public void AsociarCliente(int pIdCliente, int pIdPresupuesto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite aplicar un descuento a todo un presupuesto, pasando como parámetro el id del presupuesto y el monto de descuento
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoTotal(int pIdPresupuesto, float pDescuento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite listar todos los presupuestos guardados en BD.
        /// </summary>
        /// <returns></returns>
        public List<Presupuesto> ListarPresupuesto()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite aplicar un descuento a una linea de presupuesto, pasando como parámetro el id de la linea y el porcentaje de descuento.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="idProducto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoLinea(int pIdLinea, float pDescuento)
        {
            throw new NotImplementedException();
        }
    }
}

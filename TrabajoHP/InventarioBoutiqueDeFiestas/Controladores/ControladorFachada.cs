using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    class ControladorFachada
    {
        ControladorPresupuesto controladorPresupuesto;
        ControladorCliente controladorCliente;
        ControladorProducto controladorProducto;

        /// <summary>
        /// Constructor de controlador fachada
        /// </summary>
        public ControladorFachada()
        {
            controladorPresupuesto = new ControladorPresupuesto();
            controladorCliente = new ControladorCliente();
            controladorProducto = new ControladorProducto();
        }

        /// <summary>
        /// Método que permite agregar un presupuesto pasando sus parámetros para crearlo y guardarlo en db.
        /// </summary>
        /// <param name="presupuesto"></param>
        public void AgregarPresupuesto(PresupuestoDTO pPresupuesotDTO)
        {
            controladorPresupuesto.AgregarPresupuesto(pPresupuesotDTO);
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
            controladorPresupuesto.AgregarLinea(pPresupuestoDTO);
        }

        /// <summary>
        /// Este metodo permite señar un presupuesto pasando como parámetro el id del presupuesto y el monto de la seña.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pMontoSenia"></param>
        public void SeniarPresupuesto(int pIdPresupuesto, double pMontoSenia)
        {
            controladorPresupuesto.SeniarPresupuesto(pIdPresupuesto, pMontoSenia);
        }

        /// <summary>
        /// Este método permite vender un presupuesto, pasando como parámetro el id del presupuesto
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        public void Vender(int pIdPresupuesto)
        {
            controladorPresupuesto.Vender(pIdPresupuesto);
        }

        /// <summary>
        /// Este metodo permite asociar un cliente a un presupuesto, pasando como parámetro el id del presupuesto y el id del cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdPresupuesto"></param>
        public void AsociarCliente(int pIdCliente, int pIdPresupuesto)
        {
            controladorPresupuesto.AsociarCliente(pIdCliente, pIdPresupuesto);
        }

        /// <summary>
        /// Este método permite aplicar un descuento a todo un presupuesto, pasando como parámetro el id del presupuesto y el monto de descuento
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoTotal(int pIdPresupuesto, float pDescuento)
        {
            controladorPresupuesto.AplicarDescuentoTotal(pIdPresupuesto, pDescuento);
        }

        /// <summary>
        /// Este método permite listar todos los presupuestos guardados en BD.
        /// </summary>
        /// <returns></returns>
        public List<Presupuesto> ListarPresupuesto()
        {
            return controladorPresupuesto.ListarPresupuesto();
        }
        /// <summary>
        /// Este método permite aplicar un descuento a una linea de presupuesto, pasando como parámetro el id de la linea y el porcentaje de descuento.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="idProducto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoLinea(int pIdLinea, float pDescuento)
        {
            controladorPresupuesto.AplicarDescuentoLinea(pIdLinea, pDescuento);
        }

        /// <summary>
        /// Este método permite agregar un producto a la base de datos, pasando como parámetro un ProductoDTO
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void AgregarProducto(ProductoDTO pProductoDTO)
        {
            controladorProducto.AgregarProducto(pProductoDTO);
        }

        public void CrearLote(LoteDTO pLoteDTO)
        {
            controladorProducto.CrearLote();
        }

        public void ModificarProducto(ProductoDTO pProductoDTO)
        {
            controladorProducto.ModificarProducto();
        }

        public void BajaProducto(int pIdProducto)
        {
            controladorProducto.BajaProducto(pIdProducto);
        }
        public List<Producto> ListarTodosLosProductos()
        {
            return controladorProducto.ListarTodosLosProductos();
        }
        public List<Producto> ListarProductosBajoStockMinimo()
        {
            return controladorProducto.ListarProductosBajoStockMinimo();
        }
        public List<Producto> ListarProductosMasVendidos()
        {
            return controladorProducto.ListarProductosMasVendidos()
        }

        public void GuardarPDF(List<Producto> pProductos)
        {
            controladorProducto.GuardarPDF(pListaProductos);
        }
        public void IngresoMercarderias(List<ProductoDTO> pProductoDTOs)
        {
            controladorProducto.IngresoMercaderias(pProductoDTOs);
        }
    }
}
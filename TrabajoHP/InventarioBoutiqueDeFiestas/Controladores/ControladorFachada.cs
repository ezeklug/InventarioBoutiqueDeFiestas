﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    public class ControladorFachada
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
        public int AgregarModificarPresupuesto(PresupuestoDTO pPresupuesotDTO)
        {
            return controladorPresupuesto.AgregarModificarPresupuesto(pPresupuesotDTO);
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
            controladorPresupuesto.AgregarModificarLinea(pPresupuestoDTO);
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
        /// Este metodo permite agregar o modificar una categoria
        /// </summary>
        /// <param name=""></param>
        public void AgregarModificarCategoria(CategoriaProductoDTO categoriaDTO)
        {
            controladorProducto.AgregarModificarCategoria(categoriaDTO);
        }

        /// <summary>
        /// Este metodo permite aplicar un incremento a todos los productos.
        /// </summary>
        /// <param name="incremento"></param>
        public void AplicarIncrementoTodosLosProductos(int incremento)
        {
            controladorProducto.AplicarIncrementoTodosLosProductos(incremento);
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
        public List<PresupuestoDTO> ListarPresupuesto()
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
        public void AgregarModificarProducto(ProductoDTO pProductoDTO)
        {
            controladorProducto.AgregarModificarProducto(pProductoDTO);
        }

        /// <summary>
        /// Este metodo permite obtener el id de la categoria pasandole un nombre
        /// </summary>
        /// <param name="nombreCategoria"></param>
        /// <returns></returns>
        public int BuscarCategoriaPorNombre(String nombreCategoria)
        {
            return controladorProducto.BuscarCategoriaPorNombre(nombreCategoria);
        }


        /// <summary>
        /// Este método permite realizar la baja lógica de un producto, poniendo una propiedad "Activo" en falso.
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void BajaProducto(int pIdProducto)
        {
            controladorProducto.BajaProducto(pIdProducto);
        }

        public void BajaCategoria(int pIdCategoria)
        {
            controladorProducto.BajaCategoria(pIdCategoria);
        }
        /// <summary>
        /// Este método permite listar todos los productos que están guardados en base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarTodosLosProductos()
        {
            return controladorProducto.ListarTodosLosProductos();
        }

        public List<CategoriaProducto> ListarCategorias()
        {
            return controladorProducto.ListarCategorias();
        }

        /// <summary>
        /// Este método permite listar todos aquellos productos que estén debajo del stock Minimo.
        /// Esto se puede obtener haciendo la diferencia de las propiedades CantidadEnStock y StockMinimo de cada Producto.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosBajoStockMinimo()
        {
            return controladorProducto.ListarProductosBajoStockMinimo();
        }

        /// <summary>
        /// Este método permite listar los productos que más se venden.
        /// </summary>
        /// <returns></returns>
        public List<ProductoVendidoDTO> ListarProductosMasVendidos()
        {
            return controladorProducto.ListarProductosMasVendidos();
        }

        /// <summary>
        /// Este método permite descargar una lista que se muestra en pantalla.
        /// </summary>
        /// <param name="pListaId"></param>
        public void GuardarPDF(List<int> pListaId)
        {
            controladorProducto.GuardarPDF(pListaId);
        }
        /// <summary>
        /// Este método permite realizar el ingreso de mercadería de varios productos.
        /// Se pasa una lista de productos, y se agrega cada uno a la BD.
        /// </summary>
        /// <param name="pProductoDTOs"></param>
        public void IngresoMercarderias(List<ProductoDTO> pProductoDTOs)
        {
            controladorProducto.IngresoMercarderias(pProductoDTOs);
        }
        /// <summary>
        /// Este método permite agregar un cliente en la BD
        /// </summary>
        /// <param name="pClienteDTO"></param>
        public void AgregarModificarCliente(ClienteDTO pClienteDTO)
        {
            controladorCliente.AgregarModificarCliente(pClienteDTO);
        }
        /// <summary>
        /// Este método permite realizar la Baja lógica de un cliente poniendo una propiedad "Activo" en Falso
        /// </summary>
        public Boolean BajaCliente(int pIdCliente)
        {
            return controladorCliente.BajaCliente(pIdCliente);
        }

        /// <summary>
        /// Este método permite dar de alta a un cliente ya cargado que se encontraba inactivo
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public Boolean AltaCliente(int pIdCliente)
        {
            return controladorCliente.AltaCliente(pIdCliente);
        }

        /// <summary>
        /// Este metodo busca un cliente por su id y devuelve el objeto cliente
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public Cliente BuscarCliente(int pIdCliente)
        {
            return controladorCliente.BuscarCliente(pIdCliente);
        }

        public Presupuesto BuscarPresupuesto(int pIdPresupuesto)
        {
            return controladorPresupuesto.BuscarPresupuesto(pIdPresupuesto);
        }


        /// <summary>
        /// Este método permite listar todos los clientes cargados en BD.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ListarClientes()
        {
            return controladorCliente.ListarClientes();
        }

        public double CalcularSubtotal(double pCantidad, double pPrecioUnitario, double pPorcentajeDescuento)
        {
            return (pCantidad * pPrecioUnitario) * (1 - pPorcentajeDescuento / 100);
        }
        public double PrecioVenta(List<double> subtotales, double pPorcentajeDescuento)
        {
            double precioVenta = 0;
            foreach (double subtotal in subtotales)
            {
                precioVenta += subtotal;
            }
            return precioVenta * (1 - pPorcentajeDescuento / 100);
        }

        public string GetNombreCategoria(int pIdProducto)
        {
            return controladorProducto.GetNombreCategoria(pIdProducto);
        }
        public List<ProductoIngresarMercaderiaDTO> ListarProductosIngresoMercaderia(List<int> pIdProductos)
        {
            return controladorProducto.ListarProductosIngresoMercaderia(pIdProductos);
        }

        public List<ProductoPresupuestoDTO> ListarProductosPresupuesto(List<int> pIdProductos)
        {
            return controladorProducto.ListarProductosPresupuesto(pIdProductos);
        }

        public ProductoDTO BuscarProducto(int pIDProducto)
        {
            return controladorProducto.BuscarProducto(pIDProducto);
        }

        public Boolean VerificarSiCategoriaVence(int pIdProducto)
        {
            return controladorProducto.VerificarSiCategoriaVence(pIdProducto);
        }

        public void GuardarLote(LoteDTO pLoteDTO)
        {
            controladorProducto.GuardarLote(pLoteDTO);
        }
        public List<LineaPresupuestoDTO> ListarLineasPresupuesto(int pIdPresupuesto)
        {
            return controladorPresupuesto.ListarLineasPresupuesto(pIdPresupuesto);
        }

        public List<LineaPresupuestoDTO> ListarLineasConLotePresupuesto(int pIdPresupuesto)
        {
            return controladorPresupuesto.ListarLineasConLotePresupuesto(pIdPresupuesto);
        }

    }
}
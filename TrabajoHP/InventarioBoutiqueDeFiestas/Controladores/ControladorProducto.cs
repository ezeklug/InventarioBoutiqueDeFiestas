using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    class ControladorProducto
    {
        

        public ControladorProducto()
        {
            
        }

        /// <summary>
        /// Este método permite agregar un producto a la base de datos, pasando como parámetro un ProductoDTO
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void AgregarProducto(ProductoDTO pProductoDTO)
        {

        }

        /// <summary>
        /// Este método permite la creación de un lote, que pertenece a un producto que tiene vencimiento
        /// Esto se puede chequear mirando el campo Vence en CategoriaProducto del producto asociado al lote
        /// </summary>
        /// <param name="pLoteDTO"></param>
        public void CrearLote(LoteDTO pLoteDTO)
        {

        }

        /// <summary>
        /// Este método permite la modificación de un producto. Este se modifica en pantalla y se actualiza en la BD.
        /// </summary>
        /// <param name="pProductoDTO"></param>
        public void ModificarProducto(ProductoDTO pProductoDTO)
        {

        }

        /// <summary>
        /// Este método permite realizar la baja lógica de un producto, poniendo una propiedad "Activo" en falso.
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void BajaProducto(int pIdProducto)
        {

        }

        /// <summary>
        /// Este método permite listar todos los productos que están guardados en base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarTodosLosProductos()
        {
            return 
        }
        /// <summary>
        /// Este método permite listar todos aquellos productos que estén debajo del stock Minimo.
        /// Esto se puede obtener haciendo la diferencia de las propiedades CantidadEnStock y StockMinimo de cada Producto.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosBajoStockMinimo()
        {
            return 
        }

        /// <summary>
        /// Este método permite listar los productos que más se venden.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosMasVendidos()
        {
            return 
        }

        /// <summary>
        /// Este método permite descargar una lista que se muestra en pantalla.
        /// </summary>
        /// <param name="pListaId"></param>
        public void GuardarPDF(List<int> pListaId)
        {

        }
        /// <summary>
        /// Este método permite realizar el ingreso de mercadería de varios productos.
        /// Se pasa una lista de productos, y se agrega cada uno a la BD.
        /// </summary>
        /// <param name="pProductoDTOs"></param>
        public void IngresoMercarderias(List<ProductoDTO> pProductoDTOs)
        {
            foreach (ProductoDTO p in pProductoDTOs)
            {
                if (RepositorioCategorias.Get(p.IdCategoria).Vence)
                {
                    Lote lote=new Lote(p.CantidadAIngresar,ProductoDTO.FechaVencimiento, )
                    this.CrearLote()
                }
            }
        }

    }
}
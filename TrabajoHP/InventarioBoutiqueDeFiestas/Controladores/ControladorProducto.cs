using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.Database;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    public class ControladorProducto
    {
        

        public ControladorProducto()
        {
            
        }



        /// <summary>
        /// Convierte un ProductoDTO a Producto
        /// Si el id de la categoria de productoDTO no existe raise an exception
        /// </summary>
        /// <param name="pProducto"></param>
        /// <returns></returns>
        public Producto DTOAProducto(ProductoDTO pProducto)
        {
            Producto pro = new Producto();
            Repositorio repo = new Repositorio();

            if (pProducto.Id != null)
            {
                pro.Id = pProducto.Id;
            }
            pro.Nombre = pProducto.Nombre;
            pro.Descripcion = pProducto.Descripcion;
            pro.StockMinimo = pProducto.StockMinimo;
            pro.CantidadEnStock = pProducto.CantidadEnStock;
            pro.PorcentajeDeGanancia = pProducto.PorcentajeDeGanancia;
            pro.PrecioDeCompra = pProducto.PrecioDeCompra;

            
            CategoriaProducto cat = repo.CategoriaProductos.Find(pProducto.IdCategoria);
            if (cat == null)
            {
                throw new Exception("Id " + pProducto.IdCategoria + " no existe en CategoriaPreguntas");
            }

            pro.Categoria = cat;
            return pro;
        }
        /// <summary>
        /// Este método permite agregar un producto a la base de datos, pasando como parámetro un ProductoDTO
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void AgregarProducto(ProductoDTO pProductoDTO)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite la modificación de un producto. Este se modifica en pantalla y se actualiza en la BD.
        /// </summary>
        /// <param name="pProductoDTO"></param>
        public void ModificarProducto(ProductoDTO pProductoDTO)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite realizar la baja lógica de un producto, poniendo una propiedad "Activo" en falso.
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void BajaProducto(int pIdProducto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite listar todos los productos que están guardados en base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarTodosLosProductos()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite listar todos aquellos productos que estén debajo del stock Minimo.
        /// Esto se puede obtener haciendo la diferencia de las propiedades CantidadEnStock y StockMinimo de cada Producto.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosBajoStockMinimo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite listar los productos que más se venden.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosMasVendidos()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este método permite descargar una lista que se muestra en pantalla.
        /// </summary>
        /// <param name="pListaId"></param>
        public void GuardarPDF(List<int> pListaId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite realizar el ingreso de mercadería de varios productos.
        /// Se pasa una lista de productos, y se agrega cada uno a la BD.
        /// </summary>
        /// <param name="pProductoDTOs"></param>
        public void IngresoMercarderias(List<ProductoDTO> pProductoDTOs)
        {
            using (Repositorio repo = new Repositorio())
            {
                foreach (ProductoDTO p in pProductoDTOs)
                {
                    if (repo.CategoriaProductos.Find(p.IdCategoria).Vence)
                    {
                        Producto pProducto = this.DTOAProducto(p);
                        Lote lote = new Lote(p.CantidadAIngresar, p.FechaVencimiento, pProducto);
                        repo.Lotes.Add(lote);
                    }
                    if (p.Id==0)
                    {
                        AgregarProducto(p);
                    }
                    else { ModificarProducto(p); }
                }
            }
        }

    }
}
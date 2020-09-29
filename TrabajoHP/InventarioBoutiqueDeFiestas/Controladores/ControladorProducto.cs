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
        /// Devuelve todas las categorias
        /// </summary>
        /// <returns></returns>
        public List<CategoriaProducto> ListarCategorias()
        {
            using (var repo = new Repositorio())
            {
                //return repo.Productos.Where<CategoriaProducto>(p => (p.CantidadEnStock < p.StockMinimo)).ToList();
                //return repo.CategoriaProductos.ToList<CategoriaProducto>();
                return repo.CategoriaProductos.Where<CategoriaProducto>(p => (p.Activo == true)).ToList();
            }
        }

        /// <summary>
        /// Convierte de DTOCategoria a Categoria 
        /// </summary>
        /// <param name="categoriaDTO"></param>
        /// <returns></returns>
        public CategoriaProducto DTOACategoria(CategoriaProductoDTO categoriaDTO)
        {
            CategoriaProducto categoriaProducto = new CategoriaProducto
            {
                Id = categoriaDTO.Id,
                Nombre = categoriaDTO.Nombre,
                Descripcion = categoriaDTO.Descripcion,
                Vence = categoriaDTO.Vence
            };
            return categoriaProducto;
        }

        /// <summary>
        /// Agrega o modifica la categoría pasada como parametro
        /// </summary>
        /// <param name="categoriaDTO"></param>
        public void AgregarModificarCategoria(CategoriaProductoDTO categoriaDTO)
        {
            using (var repo = new Repositorio())
            {
                CategoriaProducto cat = repo.CategoriaProductos.Find(categoriaDTO.Id);
                CategoriaProducto categoriaAAgregar = this.DTOACategoria(categoriaDTO);
                
                if (cat == null)
                {
                    repo.CategoriaProductos.Add(categoriaAAgregar);
                    repo.SaveChanges();
                    
                }
                else  /// Modificar producto
                {
                    cat.Id = categoriaAAgregar.Id;
                    cat.Nombre = categoriaAAgregar.Nombre;
                    cat.Descripcion = categoriaAAgregar.Descripcion;
                    cat.Vence = categoriaAAgregar.Vence;
                    repo.SaveChanges();
                   
                }

            }
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

            pro.Id = pProducto.Id;
            pro.Nombre = pProducto.Nombre;
            pro.Descripcion = pProducto.Descripcion;
            pro.StockMinimo = pProducto.StockMinimo;
            pro.CantidadEnStock = pProducto.CantidadEnStock;
            pro.PorcentajeDeGanancia = pProducto.PorcentajeDeGanancia;
            pro.PrecioDeCompra = pProducto.PrecioDeCompra;
            pro.Activo = pProducto.Activo;
            
            CategoriaProducto cat = repo.CategoriaProductos.Find(pProducto.IdCategoria);
            if (cat == null)
            {
                throw new Exception("Id " + pProducto.IdCategoria + " no existe en CategoriaPreguntas");
            }

            pro.Categoria = cat;
            return pro;
        }

        /// <summary>
        /// Convierte un Producto a ProductoDTO
        /// </summary>
        /// <param name="pProducto"></param>
        /// <returns></returns>
        public ProductoDTO ProductoADTO(Producto pProducto)
        {
            ProductoDTO pro = new ProductoDTO();
            Repositorio repo = new Repositorio();

            pro.Id = pProducto.Id;
            pro.Nombre = pProducto.Nombre;
            pro.Descripcion = pProducto.Descripcion;
            pro.StockMinimo = pProducto.StockMinimo;
            pro.CantidadEnStock = pProducto.CantidadEnStock;
            pro.PorcentajeDeGanancia = pProducto.PorcentajeDeGanancia;
            pro.PrecioDeCompra = pProducto.PrecioDeCompra;
            pro.Activo = pProducto.Activo;

            CategoriaProducto cat = repo.CategoriaProductos.Find(pProducto.Categoria.Id);
            if (cat == null)
            {
                throw new Exception("Id " + pProducto.Categoria + " no existe en Categoria");
            }

            pro.IdCategoria = cat.Id;
            return pro;
        }


        /// <summary>
        /// Este método permite agregar o modificar un producto a la base de datos, pasando como parámetro un ProductoDTO
        /// Devuelve el Id del producto agregado/modificado
        /// Precondicion: El producto siempre tiene una categoria
        /// </summary>
        /// <param name="pIdProducto"></param>
        public int AgregarModificarProducto(ProductoDTO pProductoDTO)
        {
            using(var repo = new Repositorio())
            {
                Producto pro = repo.Productos.Find(pProductoDTO.Id);
                Producto proAAgregar = this.DTOAProducto(pProductoDTO);
                CategoriaProducto cat = repo.CategoriaProductos.Find(pProductoDTO.IdCategoria);
                proAAgregar.Categoria = cat;
                if (pro == null)
                {
                    repo.Productos.Add(proAAgregar);
                    repo.SaveChanges();
                    return proAAgregar.Id;
                }
                else  /// Modificar producto
                {
                    pro.Nombre = proAAgregar.Nombre;
                    pro.Descripcion = proAAgregar.Descripcion;
                    pro.StockMinimo = proAAgregar.StockMinimo;
                    pro.CantidadEnStock = proAAgregar.CantidadEnStock;
                    pro.PorcentajeDeGanancia = proAAgregar.PorcentajeDeGanancia;
                    pro.PrecioDeCompra = proAAgregar.PrecioDeCompra;
                    pro.Activo = proAAgregar.Activo;
                    pro.Categoria = proAAgregar.Categoria;
                    repo.SaveChanges();
                    return pro.Id;
                }

            }
            
        }
        /// <summary>
        /// Busca CategoriaProducto por nombre
        /// </summary>
        /// <param name="nombreCategoria"></param>
        /// <returns> El id de la categoria </returns>
        public int BuscarCategoriaPorNombre(String nombreCategoria)
        {
            List<CategoriaProducto> listaCategoria= ListarCategorias();
            CategoriaProducto categoria= listaCategoria.Find(x => x.Nombre == nombreCategoria);
            return categoria.Id;
        }


        /// <summary>
        /// Este método permite realizar la baja lógica de un producto, poniendo una propiedad "Activo" en falso.
        /// </summary>
        /// <param name="pIdProducto"></param>
        public void BajaProducto(int pIdProducto)
        {
            using (Repositorio repo=new Repositorio())
            {
                Producto prod = repo.Productos.Find(pIdProducto);
                prod.Activo = false;
            }
        }

        /// <summary>
        /// Este método permite listar todos los productos que están guardados en base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarTodosLosProductos()
        {
            using (var repo = new Repositorio())
            {
                return repo.Productos.Include("Categoria").ToList<Producto>();
            }
        }
        /// <summary>
        /// Este método permite listar todos aquellos productos que estén debajo del stock Minimo.
        /// Esto se puede obtener haciendo la diferencia de las propiedades CantidadEnStock y StockMinimo de cada Producto.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosBajoStockMinimo()
        {
            using (var repo = new Repositorio())
            {
                return repo.Productos.Where<Producto>(p => (p.CantidadEnStock < p.StockMinimo)).ToList();
            }
        }

        /// <summary>
        /// Este método permite listar los productos que más se venden.
        /// </summary>
        /// <returns></returns>
        public List<ProductoVendidoDTO> ListarProductosMasVendidos()
        {
            List<ProductoVendidoDTO> listaAMostrar = new List<ProductoVendidoDTO>();
            using(var repo=new Repositorio())
            {
                foreach (Venta venta in repo.Ventas.Where<Venta>(v =>((DateTime.Now - v.FechaDeVenta).TotalDays<=30)).ToList())
                {
                    foreach(LineaPresupuesto linea in venta.Presupuesto.Lineas)
                    {
                        ProductoVendidoDTO pDTO = new ProductoVendidoDTO();
                        pDTO.Producto = linea.Producto;
                        pDTO.VendidoMes = linea.Cantidad;
                        ProductoVendidoDTO prod = listaAMostrar.Find(p => p.Producto.Id == pDTO.Producto.Id);
                        if (prod!=null)
                        {
                            prod.VendidoMes += linea.Cantidad;
                            listaAMostrar.Remove(prod);
                            listaAMostrar.Add(pDTO);
                        }
                        else
                        {
                            listaAMostrar.Add(pDTO);
                        }
                    }
                }
            }
            return listaAMostrar;
        }

        /// <summary>
        /// Este método permite descargar una lista que se muestra en pantalla.
        /// </summary>
        /// <param name="pListaId"></param>
        public void GuardarPDF(List<int> pListaId)
        {
            throw new NotImplementedException();
        }

        public void GuardarLote(LoteDTO pLoteDTO)
        {
            using (Repositorio repo=new Repositorio())
            {
                Lote lote = new Lote(pLoteDTO.CantidadProductos, pLoteDTO.FechaVencimiento, repo.Productos.Find(pLoteDTO.IdProducto));
                
                repo.Lotes.Add(lote);
            }
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
                    int idProducto = AgregarModificarProducto(p);
                    
                   /* foreach (LoteDTO loteDto in p.LotesDTO)
                    {
                        loteDto.IdProducto = idProducto;
                        GuardarLote(loteDto);
                    }*/
                }
            }
        }
        public string GetNombreCategoria(int pIdProducto)
        {

             using (Repositorio repo=new Repositorio())
             {
                return repo.Productos.Include("Categoria").Where(p => p.Id == pIdProducto).First().Categoria.Nombre;
             }
        }
        public List<ProductoIngresarMercaderiaDTO> ListarProductosIngresoMercaderia(List<int> pIdProductos)
        {
            List<ProductoIngresarMercaderiaDTO> ADevolver = new List<ProductoIngresarMercaderiaDTO>();
            using (Repositorio repo = new Repositorio())
            {
                foreach(int pIdProducto in pIdProductos)
                {
                    Producto pProducto =repo.Productos.Include("Categoria").Where(p => p.Id == pIdProducto).First();
                    ProductoIngresarMercaderiaDTO productoDTO = new ProductoIngresarMercaderiaDTO();
                    productoDTO.IdProducto = pIdProducto;
                    productoDTO.Nombre = pProducto.Nombre;
                    CategoriaProductoDTO categoria=new CategoriaProductoDTO();
                    categoria.Vence = pProducto.Categoria.Vence;
                    //productoDTO.FechaVencimiento =;
                    ADevolver.Add(productoDTO);
                }
                return ADevolver;
            }
        }
        public List<ProductoPresupuestoDTO> ListarProductosPresupuesto(List<int> pIdProductos)
        {
            List<ProductoPresupuestoDTO> ADevolver = new List<ProductoPresupuestoDTO>();
            using (Repositorio repo = new Repositorio())
            {
                foreach (int pIdProducto in pIdProductos)
                {
                    Producto pProducto = repo.Productos.Where(p => p.Id == pIdProducto).First();
                    ProductoPresupuestoDTO productoDTO = new ProductoPresupuestoDTO();
                    productoDTO.Id = pProducto.Id;
                    productoDTO.Nombre = pProducto.Nombre;
                    productoDTO.PrecioUnitario = pProducto.PrecioVenta();
                    ADevolver.Add(productoDTO);
                }
                return ADevolver;
            }
        }

        public ProductoDTO BuscarProducto(int pProducto)
        {
            using (var repo = new Repositorio())
            {
                Producto pro = repo.Productos.Include("Categoria").Where(p => p.Id == pProducto).First();
                return (ProductoADTO(pro));
            }
        }

        public Boolean VerificarSiCategoriaVence(int pProductoId)
        {
            using (var repo = new Repositorio())
            {
                CategoriaProducto catpro = repo.Productos.Include("Categoria").Where(p => p.Id == pProductoId).First().Categoria;
                return catpro.Vence;
            }
        }

        



    }
}
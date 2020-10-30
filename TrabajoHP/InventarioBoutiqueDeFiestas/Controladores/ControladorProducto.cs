using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.Database;
using Microsoft.EntityFrameworkCore.Internal;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

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
                Vence = categoriaDTO.Vence,
                Activo = true
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
                else  /// Modificar Categoria
                {
                    cat.Id = categoriaAAgregar.Id;
                    cat.Nombre = categoriaAAgregar.Nombre;
                    cat.Descripcion = categoriaAAgregar.Descripcion;
                    cat.Vence = categoriaAAgregar.Vence;
                    cat.Activo = true;
                    repo.SaveChanges();
                   
                }

            }
        }

        public void DescontarProductosDeLote(int idLote, int pCantidadADescontar)
        {
            using (var repo=new Repositorio())
            {
                repo.Lotes.Find(idLote).CantidadProductos-=pCantidadADescontar;
                repo.SaveChanges();
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
            using (var repo = new Repositorio())
            {

                pro.Id = pProducto.Id;
                pro.Nombre = pProducto.Nombre;
                pro.Descripcion = pProducto.Descripcion;
                pro.StockMinimo = pProducto.StockMinimo;
                pro.CantidadEnStock = pProducto.CantidadEnStock;
                pro.PorcentajeDeGanancia = pProducto.PorcentajeDeGanancia;
                pro.PrecioDeCompra = pProducto.PrecioDeCompra;
                pro.Activo = pProducto.Activo;
                pro.CategoriaProductoDTO = this.CategoriaADTO(repo.Productos.Include("Categoria").Where(p => p.Id == pProducto.Id).First().Categoria);
                pro.Categoria = pro.CategoriaProductoDTO.Nombre;
                return pro;
            }
        }

        private CategoriaProductoDTO CategoriaADTO(CategoriaProducto categoria)
        {
            CategoriaProductoDTO categoriaProductoDTO = new CategoriaProductoDTO();
            categoriaProductoDTO.Id = categoria.Id;
            categoriaProductoDTO.Nombre = categoria.Nombre;
            categoriaProductoDTO.Descripcion = categoria.Descripcion;
            categoriaProductoDTO.Vence = categoria.Vence;
            return categoriaProductoDTO;
        }

        public void AltaCategoria(int idCategoria)
        {
            using (Repositorio repo = new Repositorio())
            {
                CategoriaProducto cate = repo.CategoriaProductos.Find(idCategoria);
                cate.Activo = true; ;
            }
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
                    proAAgregar.Activo = true;
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

        public List<CategoriaProducto> ListarCategoriasNoActivas()
        {
            using (var repo = new Repositorio())
            {
                return repo.CategoriaProductos.Where<CategoriaProducto>(p => (!p.Activo)).ToList();
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


        public void BajaCategoria(int pIdCategoria)
        {
            using (Repositorio repo = new Repositorio())
            {
                CategoriaProducto cate = repo.CategoriaProductos.Find(pIdCategoria);
                cate.Activo = false;
            }
        }

        /// <summary>
        /// Este método permite listar todos los productos activos que están guardados en base de datos.
        /// </summary>
        /// <returns></returns>
        public List<ProductoDTO> ListarTodosLosProductos()
        {
            List<ProductoDTO> Adevolver = new List<ProductoDTO>();
            using (var repo = new Repositorio())
            {
                foreach (Producto producto in repo.Productos.Include("Categoria").Where(p=>p.Activo).ToList<Producto>())
                {
                    if (producto.Categoria.Vence)
                    {
                        int cantidad = 0;
                        foreach (Lote lote in repo.Lotes.Include("Producto").Where(p=>p.Producto.Id==producto.Id && !p.Vencido))
                        {
                            cantidad += lote.CantidadProductos;
                        }
                        producto.CantidadEnStock = cantidad;
                    }
                    ProductoDTO pDTO = this.ProductoADTO(producto);
                    Adevolver.Add(pDTO);
                }
                return Adevolver;
            }
        }


        /// <summary>
        /// Este metodo permite aplicar un incremento a todos los productos.
        /// </summary>
        /// <param name="incremento"></param>
        public void AplicarIncrementoTodosLosProductos(float incremento)
        {
           using (var repo = new Repositorio())
            {
                foreach (Producto pro in repo.Productos)
                {
                    Console.WriteLine(pro.PrecioDeCompra * (1 + (incremento / 100)));
                    pro.PrecioDeCompra = pro.PrecioDeCompra * (1 + incremento / 100);
                    
                }
                repo.SaveChanges();

            }
        }


        /// <summary>
        /// Este método permite listar todos aquellos productos que estén debajo del stock Minimo.
        /// Esto se puede obtener haciendo la diferencia de las propiedades CantidadEnStock y StockMinimo de cada Producto.
        /// </summary>
        /// <returns></returns>
        public List<ProductoDTO> ListarProductosBajoStockMinimo()
        {
            List<ProductoDTO> productos= this.ListarTodosLosProductos();
            return productos.Where(p => (p.CantidadEnStock < p.StockMinimo)).ToList();
        }

        /// <summary>
        /// Este método permite listar los productos que más se venden.
        /// </summary>
        /// <returns></returns>
        public List<ProductoDTO> ListarProductosMasVendidos()
        {
           List<ProductoDTO> aDevolver = new List<ProductoDTO>();
            using(var repo=new Repositorio())
            {
                foreach (Venta venta in repo.Ventas.Include("Presupuesto").Where<Venta>(v =>(DbFunctions.DiffDays(DateTime.Now, v.FechaDeVenta) <= 30)).ToList())
                {
                    foreach(LineaPresupuesto linea in venta.Presupuesto.Lineas)
                    {
                        Tuple<ProductoDTO, int> tupla;
                        linea.Producto=repo.LineaPresupuestos.Include("Producto").Where(l=>l.Id==linea.Id).First().Producto;
                        ProductoDTO pProductoDTO = this.ProductoADTO(linea.Producto);
                        tupla = Tuple.Create(pProductoDTO, linea.Cantidad);
                        ProductoDTO Key = new ProductoDTO();
                        if (aDevolver.Where(p => p.Id == pProductoDTO.Id).ToList().Count>0)
                        {
                            Key = aDevolver.Where(p => p.Id == pProductoDTO.Id).First();
                        }
                        if (Key.Id!=0)
                        {
                            pProductoDTO.CantidadVendida = aDevolver.First(p => p.Id == pProductoDTO.Id).CantidadVendida;
                            aDevolver.Remove(Key);
                            aDevolver.Add(pProductoDTO);
                        }
                        else
                        {
                            pProductoDTO.CantidadVendida = linea.Cantidad;
                            aDevolver.Add(pProductoDTO);
                        }
                    }
                }
            }
            return aDevolver.OrderByDescending(l=>l.CantidadVendida).ToList();
        }

        /// <summary>
        /// Este método permite descargar una lista que se muestra en pantalla.
        /// </summary>
        /// <param name="pListaId"></param>
        public void GuardarPDF(List<int> pListaId)
        {
            throw new NotImplementedException();
        }

        public int GuardarLote(LoteDTO pLoteDTO)
        {
            using (Repositorio repo=new Repositorio())
            {
                Lote lote = new Lote(pLoteDTO.CantidadProductos, pLoteDTO.FechaVencimiento, repo.Productos.Find(pLoteDTO.IdProducto));
                Lote loteo=repo.Lotes.Add(lote);
                repo.SaveChanges();
                return loteo.Id ;
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
        public string GetNombreCategoriaConProductoId(int pIdProducto)
        {
             using (Repositorio repo=new Repositorio())
             {
                return repo.Productos.Include("Categoria").Where(p => p.Id == pIdProducto).First().Categoria.Nombre;
             }
        }
        public string GetNombreCategoriaConCategoriaId(int pIdCategoria)
        {
            using (Repositorio repo = new Repositorio())
            {
                return repo.CategoriaProductos.Find(pIdCategoria).Nombre;
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



        /// <summary>
        /// Devuelve una notificacion por cada lote proximo a vencer
        /// </summary>
        /// <param name="pTiempoDentroDe"></param>
        /// <returns></returns>
        public List<NotificacionDTO> getNotificaciones(int pTiempoDentroDe)
        {
            var notificaciones = new List<NotificacionDTO>();
            using (var repo = new Repositorio())
            {
                // Buscar lotes que no esten vencidos y 
                // la fecha de vencimiento este dentro de 15 dias
                var lotes = repo.Lotes.Where(l =>
                                ((l.Vencido == false) &&
                                (l.FechaVencimiento <= (DateTime.Now + TimeSpan.FromDays(pTiempoDentroDe))))
                                );
                foreach (var lote in lotes)
                {
                    var notif = new NotificacionDTO();
                    notif.IdLote = lote.Id;
                    notif.FechaVencimiento = lote.FechaVencimiento;
                    if (lote.FechaVencimiento <= DateTime.Now)
                    {
                        notif.Descripcion = $"Lote {lote.Id} vencido";
                    }
                    else
                    {
                        notif.Descripcion = $"Lote {lote.Id} proximo a vencerse";
                    }
                    notificaciones.Add(notif);
                }
            }

            return notificaciones;
        }
        



    }
}
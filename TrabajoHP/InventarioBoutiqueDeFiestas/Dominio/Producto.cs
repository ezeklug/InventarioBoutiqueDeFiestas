using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockMinimo { get; set; }
        public int CantidadEnStock { get; set; }
        public double PorcentajeDeGanancia { get; set;}
        public double PrecioDeCompra { get; set; }

        public CategoriaProducto Categoria { get; set; }
        public Boolean? Activo { get; set; }


        public double PrecioVenta()
        {
            return PrecioDeCompra * (1 + PorcentajeDeGanancia/100);
        }
        /// <summary>
        /// Constructor de Producto, cuando solo se quiere crear el producto sin un ingreso de mercaderia asociado
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pStockMinimo"></param>
        /// <param name="pPorcentajeDeGanancia"></param>
        public Producto(string pNombre, string pDescripcion, int pStockMinimo, double pPorcentajeDeGanancia, CategoriaProducto pCategoria)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
            StockMinimo = pStockMinimo;
            PorcentajeDeGanancia = pPorcentajeDeGanancia;
            Categoria = pCategoria;
            Activo = true;
        }
        /// <summary>
        /// Constructor de Producto, cuando se crea el producto desde un ingreso de mercaderia
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pStockMinimo"></param>
        /// <param name="pCantidadEnStock"></param>
        /// <param name="pPorcentajeDeGanancia"></param>
        /// <param name="pPrecioDeCompra"></param>
        public Producto(string pNombre, string pDescripcion, int pStockMinimo, int pCantidadEnStock, double pPorcentajeDeGanancia, double pPrecioDeCompra, CategoriaProducto pCategoria)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
            StockMinimo = pStockMinimo;
            CantidadEnStock = pCantidadEnStock;
            PorcentajeDeGanancia = pPorcentajeDeGanancia;
            PrecioDeCompra = pPrecioDeCompra;
            Categoria = pCategoria;
            Activo = true;
        }


        public Producto() { }
    }
}

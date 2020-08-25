﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockMinimo { get; set; }
        public int CantidadEnStock { get; set; }
        public double PorcentajeDeGanancia { get; set;}
        public double PrecioDeCompra { get; set; }

        public double PrecioDeVenta()
        {
            return PorcentajeDeGanancia * PrecioDeCompra + PrecioDeCompra;
        }

        /// <summary>
        /// Constructor de Producto, cuando solo se quiere crear el producto sin un ingreso de mercaderia asociado
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pNombre"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pStockMinimo"></param>
        /// <param name="pPorcentajeDeGanancia"></param>
        public Producto(int pId, string pNombre, string pDescripcion, int pStockMinimo, double pPorcentajeDeGanancia)
        {
            Id = pId;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            StockMinimo = pStockMinimo;
            PorcentajeDeGanancia = pPorcentajeDeGanancia;;
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
        public Producto(int pId, string pNombre, string pDescripcion, int pStockMinimo, int pCantidadEnStock, double pPorcentajeDeGanancia, double pPrecioDeCompra)
        {
            Id = pId;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            StockMinimo = pStockMinimo;
            CantidadEnStock = pCantidadEnStock;
            PorcentajeDeGanancia = pPorcentajeDeGanancia;
            PrecioDeCompra = pPrecioDeCompra;
        }
    }
}

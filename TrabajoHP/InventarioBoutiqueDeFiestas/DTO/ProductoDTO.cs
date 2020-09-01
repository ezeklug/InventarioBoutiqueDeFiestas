using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockMinimo { get; set; }
        public int CantidadEnStock { get; set; }
        public double PorcentajeDeGanancia { get; set; }
        public double PrecioDeCompra { get; set; }

        public int IdCategoria { get; set; }

        /// Se agregan dos propiedades a ProductoDTO que no están en Producto:
        /// CantidadAIngresar se utiliza en el metodo IngresarMercaderias y sirve para saber la cantidad a ingresar en ese momento
        /// Cantidad a ingresar se le debe sumar a CantidadEnStock
        public int CantidadAIngresar { get; set; }

        /// FechaVencimiento se utiliza cuando un producto pertenece a una Categoria con vencimiento, y por ello se debe ingresar una fecha
        /// de vencimiento, para crear un Lote
        public DateTime FechaVencimiento { get; set; }
    }
}

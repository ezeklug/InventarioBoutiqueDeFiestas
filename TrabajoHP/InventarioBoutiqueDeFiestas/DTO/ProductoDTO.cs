using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockMinimo { get; set; }
        public int CantidadEnStock { get; set; }
        public double PorcentajeDeGanancia { get; set; }
        public double PrecioDeCompra { get; set; }

        public int IdCategoria { get; set; }
    }
}

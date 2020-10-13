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

        public double PrecioVenta { get; set; }
        public Boolean Activo { get; set; }
        public int IdCategoria { get; set; }
        public CategoriaProductoDTO CategoriaProductoDTO{get;set;}
        public string Categoria { get; set; }
        public int CantidadVendida { get; set; }
        //public List<LoteDTO> LotesDTO { get; set; }
    }
}

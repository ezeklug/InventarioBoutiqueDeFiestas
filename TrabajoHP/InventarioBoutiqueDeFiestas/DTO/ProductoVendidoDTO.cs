using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class ProductoVendidoDTO
    {
        public Producto Producto { get; set; }
        public int VendidoMes { get; set; }
    }
}

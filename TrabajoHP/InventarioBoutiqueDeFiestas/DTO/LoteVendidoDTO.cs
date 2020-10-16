using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.DTO
{
    public class LoteVendidoDTO
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int idLote { get; set; }
    }
}

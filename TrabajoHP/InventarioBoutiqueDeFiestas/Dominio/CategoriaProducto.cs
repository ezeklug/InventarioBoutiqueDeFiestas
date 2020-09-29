using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{
    public class CategoriaProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Vence { get; set; }

        public Boolean Activo { get; set; }

        public CategoriaProducto(string pNombre, string pDescripcion, Boolean pVence)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Vence = pVence;
        }

        public override string ToString()
        {
            return Nombre;
        }

        public CategoriaProducto() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Database
{
    interface IOperacionesDB<Tentity>
        where Tentity : class
    {
        Boolean Insertar(Tentity pTentity);
        void Eliminar(int id);
        void Modificar(Tentity pTentity);
        IEnumerable<Tentity> ObtenerTodos();
        Tentity Obtener(int pId);
        Boolean Existe(int pId);

        Tentity Obtener(string iCampo, string pId);


    }
}

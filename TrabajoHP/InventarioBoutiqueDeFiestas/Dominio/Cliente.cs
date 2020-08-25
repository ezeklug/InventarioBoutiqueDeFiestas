using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBoutiqueDeFiestas.Dominio
{

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Cliente(int pId, string pNombre, string pApellido, string pDireccion, int pTelefono, string pEmail)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Direccion = pDireccion;
            Telefono = pTelefono;
            Email = pEmail;
        }
    }
}

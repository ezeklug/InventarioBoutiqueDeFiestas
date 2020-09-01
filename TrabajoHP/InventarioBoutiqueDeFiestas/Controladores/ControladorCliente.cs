using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{ 
    public class ControladorCliente
    {
        public Cliente DTOACliente(ClienteDTO pCliente)
        {
            Cliente cliente = new Cliente();

            if (pCliente.Id != null)
            {
                cliente.Id = pCliente.Id;
            }
            cliente.Id = pCliente.Id;
            cliente.Nombre = pCliente.Nombre;
            cliente.Apellido = pCliente.Apellido;
            cliente.Telefono = pCliente.Telefono;
            cliente.Email = pCliente.Email;
            cliente.Direccion = pCliente.Direccion;
            return cliente;
        }

        /// <summary>
        /// Este método permite agregar un cliente en la BD
        /// </summary>
        /// <param name="pClienteDTO"></param>
        public void AgregarCliente(ClienteDTO pClienteDTO)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite modificar un cliente ya agregado a BD
        /// </summary>
        /// <param name="pClienteDTO"></param>
        public void ModificaCliente(ClienteDTO pClienteDTO)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite realizar la Baja lógica de un cliente poniendo una propiedad "Activo" en Falso
        /// </summary>
        public void BajaCliente()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Este método permite listar todos los clientes cargados en BD.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }
    }
}

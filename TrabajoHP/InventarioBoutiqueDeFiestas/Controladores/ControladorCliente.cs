using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Database;
using System.Runtime.Remoting.Messaging;

namespace InventarioBoutiqueDeFiestas.Controladores
{ 
    public class ControladorCliente
    {

        /// <summary>
        /// Dado un DTO, devuelve un objeto cliente
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Cliente</returns>
        public Cliente DTOACliente(ClienteDTO pCliente)
        {
            Cliente cliente = new Cliente();
            
            cliente.Id = pCliente.Id;
            cliente.Id = pCliente.Id;
            cliente.Nombre = pCliente.Nombre;
            cliente.Apellido = pCliente.Apellido;
            cliente.Telefono = pCliente.Telefono;
            cliente.Email = pCliente.Email;
            cliente.Direccion = pCliente.Direccion;
            cliente.Activo = pCliente.Activo;
            return cliente;
        }

        /// <summary>
        /// Agrega o modifica un cliente la BD
        /// Devuelve el ID del cliente agregado/modificado
        /// </summary>
        /// <param name="pClienteDTO"></param>
        public int AgregarModificarCliente(ClienteDTO pClienteDTO)
        {
            using (var repo = new Repositorio())
            {
                Cliente cliente = repo.Clientes.Find(pClienteDTO.Id);
                Cliente clienteAAgregar = this.DTOACliente(pClienteDTO);
             
                if (cliente == null)
                {
                    clienteAAgregar.Activo = true;
                    repo.Clientes.Add(clienteAAgregar);
                    repo.SaveChanges();
                    return clienteAAgregar.Id;
                }
                else  /// Modifcar cliente
                {
                    cliente.Id = clienteAAgregar.Id;
                    cliente.Nombre = clienteAAgregar.Nombre;
                    cliente.Apellido = clienteAAgregar.Apellido;
                    cliente.Direccion = clienteAAgregar.Direccion;
                    cliente.Telefono = clienteAAgregar.Telefono;
                    cliente.Email = clienteAAgregar.Email;
                    cliente.Activo= clienteAAgregar.Activo;
                    repo.SaveChanges();
                    return cliente.Id;
                }

            }
        }

        /// <summary>
        /// Da de baja un cliente
        /// </summary>
        public Boolean BajaCliente(int pIdCliente)
        {
            using (Repositorio repo = new Repositorio())
            {
                Cliente cli = repo.Clientes.Find(pIdCliente);
                if(cli.Activo)
                {
                    cli.Activo = false;
                    return true;
                }
                else { return false; }
            }
        }
        /// <summary>
        /// Este método permite dar de alta a un cliente ya cargado que se encontraba inactivo
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public Boolean AltaCliente(int pIdCliente)
        {
            using (Repositorio repo = new Repositorio())
            {
                Cliente cli = repo.Clientes.Find(pIdCliente);
                if (!cli.Activo)
                {
                    cli.Activo = true;
                    return true;
                }
                else { return false; }
            }
        }
        /// <summary>
        /// Devuelve una lista con todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public List<Cliente> ListarClientes()
        {
            using (var repo = new Repositorio())
            {
                return repo.Clientes.Where(p=>p.Activo).ToList<Cliente>();
            }
        }
        /// <summary>
        /// Este metodo busca un cliente por su id y devuelve el objeto cliente
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public Cliente BuscarCliente(int pIdCliente)
        {
            using (var repo = new Repositorio())
            {
                Cliente cli = repo.Clientes.Find(pIdCliente);
                return cli;
            }
        }

        internal List<Cliente> ListarClientesNoActivos()
        {
            using (var repo = new Repositorio())
            {
                return repo.Clientes.Where(p => !p.Activo).ToList<Cliente>();
            }
        }
    }
}

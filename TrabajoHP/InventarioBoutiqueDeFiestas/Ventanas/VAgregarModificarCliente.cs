    using InventarioBoutiqueDeFiestas.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.Controladores;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VAgregarModificarCliente : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        ClienteDTO ClienteDTO { get; set; }

        Type Llamador { get; set; }
        public VAgregarModificarCliente(ClienteDTO pClienteDTO, Type pLlamador)
        {
            InitializeComponent();
            ClienteDTO = pClienteDTO;
            Nombre.Text = pClienteDTO.Nombre;
            Apellido.Text = pClienteDTO.Apellido;
            Direccion.Text = pClienteDTO.Direccion;
            Telefono.Text = pClienteDTO.Telefono;
            Email.Text = pClienteDTO.Email;
            Llamador = pLlamador;
        }
        public VAgregarModificarCliente(Type pLlamador)
        {
            InitializeComponent();
            Llamador = pLlamador;
        }

        public void AbrirLlamador()
        {
            this.Hide();
            Form ventana = (Form)Activator.CreateInstance(Llamador);
            ventana.ShowDialog();
            this.Close();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientes vControlClientes = new VControlClientes();
            vControlClientes.ShowDialog();
            this.Close();
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "" || Apellido.Text == "")
            {
                MessageBox.Show("Tiene que completar los campos obligatorios");
            }
            else
            {
                ClienteDTO pClienteDTO = new ClienteDTO();
                if (ClienteDTO != null)
                {
                    pClienteDTO.Id = ClienteDTO.Id;
                    pClienteDTO.Activo = ClienteDTO.Activo;
                }
                pClienteDTO.Nombre = Nombre.Text;
                pClienteDTO.Apellido = Apellido.Text;
                pClienteDTO.Direccion = Direccion.Text;
                pClienteDTO.Telefono = Telefono.Text;
                pClienteDTO.Email = Email.Text;
                controladorFachada.AgregarModificarCliente(pClienteDTO);
                AbrirLlamador();
            }
        }

        private void VAgregarModificarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

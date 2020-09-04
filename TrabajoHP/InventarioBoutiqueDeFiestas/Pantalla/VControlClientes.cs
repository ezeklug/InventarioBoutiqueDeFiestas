using InventarioBoutiqueDeFiestas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas
{
    public partial class VControlClientes : Form
    {
        ControladorFachada fachada = new ControladorFachada();
        public VControlClientes()
        {
            InitializeComponent();
        }

        private void VControlClientes_Load(object sender, EventArgs e)
        {
            List<Cliente> listaCliente = fachada.ListarClientes();
            foreach(Cliente cli in listaCliente)
            {
                int index = this.checkedListBox1.Items.Add(cli.Id);
                checkedListBox1.Items[index] = cli.Id;
                this.checkedListBox1.Items[1] = cli.Nombre;
                this.checkedListBox1.Items[2] = cli.Apellido;
                this.checkedListBox1.Items[3] = cli.Telefono;
                this.checkedListBox1.Items[4] = cli.Direccion;
                this.checkedListBox1.Items[5] = cli.Email;
            }
        }
    }
}

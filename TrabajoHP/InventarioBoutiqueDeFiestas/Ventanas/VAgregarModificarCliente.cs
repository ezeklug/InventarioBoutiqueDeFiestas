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

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VAgregarModificarCliente : Form
    {
        ClienteDTO ClienteDTO { get; set; }
        public VAgregarModificarCliente(ClienteDTO pClienteDTO)
        {
            InitializeComponent();
            ClienteDTO = pClienteDTO;
        }

    }
}

using InventarioBoutiqueDeFiestas.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioBoutiqueDeFiestas
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void ControlClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientes vControlClientes = new VControlClientes();
            vControlClientes.ShowDialog();
            this.Close();
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AdministrarPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto();
            vAdministrarPresupuesto.ShowDialog();
            this.Close();
        }

        private void ControlProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProductos = new VControlProducto();
            vControlProductos.ShowDialog();
            this.Close();
        }
    }
}

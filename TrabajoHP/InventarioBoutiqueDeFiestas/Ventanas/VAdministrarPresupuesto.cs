using InventarioBoutiqueDeFiestas.Controladores;
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
    public partial class VAdministrarPresupuesto : Form
    {
        int IdCliente { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VAdministrarPresupuesto()
        {
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente)
        {
            IdCliente = pIdCliente;
            InitializeComponent();
        }

        private void VAdministrarPresupuesto_Load(object sender, EventArgs e)
        {

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }
    }
}

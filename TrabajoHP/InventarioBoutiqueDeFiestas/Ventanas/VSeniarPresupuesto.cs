using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Controladores;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VSeniarPresupuesto : Form
    {
        Cliente iCliente;
        Presupuesto iPresupuesto;
        public VSeniarPresupuesto(int pIdCliente, int pPresupuestoId)
        {
            porcentajeSeniaTextBox.TextChanged += new System.EventHandler(this.porcentajeSeniaTextBox_HasChanged);
            

            var cont = new ControladorFachada();
            iCliente = cont.BuscarCliente(pIdCliente);
            iPresupuesto = cont.BuscarPresupuesto(pPresupuestoId);

            this.nombreClienteLabel.Text = iCliente.Nombre + " " + iCliente.Apellido;
            this.totalLabel.Text = iPresupuesto.TotalVenta().ToString();
            this.fechaDeSeniaLabel.Text = DateTime.Now.ToString();
            //this.cantidadProductosLabel.Text;
            InitializeComponent();
        }

        private void porcentajeSeniaTextBox_HasChanged(object sender, EventArgs e)
        {
            this.montoSeniaTextBox.Text = (double.Parse(this.totalLabel.Text) * (double.Parse(porcentajeSeniaTextBox.Text) / 100)).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VSeniarPresupuesto_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

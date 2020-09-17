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
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Cantidad";
            dataGridView1.Columns[3].Name = "Precio Unitario";
            dataGridView1.Columns[4].Name = "Porcentaje Descuento";
            dataGridView1.Columns[5].Name = "Subtotal";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            Total.ReadOnly = true;
            Cliente.ReadOnly = true;
            if(IdCliente!=0)
            {
                Cliente.Text = controladorFachada.BuscarCliente(IdCliente);
            }
            DescuentoTotal.Text = "0";

        }
        private void CalcularSubtotal()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[5].Value =controladorFachada.CalcularSubtotal(Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[4].Value));
            }
        }

        private double PrecioVenta()
        {
            List<double> subtotales = new List<double>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                subtotales.Add(Convert.ToDouble(row.Cells[5].Value));
            }
            return controladorFachada.PrecioVenta(subtotales,Convert.ToDouble(DescuentoTotal.Text));
        }
        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientesPresupuesto vControlClientesPresupuesto = new VControlClientesPresupuesto();
            vControlClientesPresupuesto.ShowDialog();
            this.Close();
        }
    }
}

using InventarioBoutiqueDeFiestas.Controladores;
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
    public partial class VAdministrarPresupuesto : Form
    {
        int IdCliente { get; set; }
        List<int> IdProductos { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VAdministrarPresupuesto()
        {
            InitializeComponent();
            IdProductos = new List<int>();

        }
        public VAdministrarPresupuesto(List<int> idProductos)
        {
            InitializeComponent();
            IdProductos = idProductos;
        }
        public VAdministrarPresupuesto(int pIdCliente)
        {
            IdCliente = pIdCliente;
            InitializeComponent();
        }

        private void VAdministrarPresupuesto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorFachada.ListarProductosPresupuesto(IdProductos);
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


        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientesPresupuesto vControlClientesPresupuesto = new VControlClientesPresupuesto();
            vControlClientesPresupuesto.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularSubtotal();
            Total.Text = PrecioVenta().ToString();
        }

        private void DescuentoTotal_TextChanged(object sender, EventArgs e)
        {
            Total.Text=PrecioVenta().ToString();
        }

        private void CargarProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProductosPresupuesto vControlProductosPresupuesto = new VControlProductosPresupuesto(IdProductos);
            vControlProductosPresupuesto.ShowDialog();
            this.Close();
        }

    }
}

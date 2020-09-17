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
    public partial class VIngresarMercaderia : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        List<int> Productos { get; set; }

        public VIngresarMercaderia(List<int> productos)
        {
            InitializeComponent();
            Productos = productos;
        }

        private void Listo_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto(Productos);
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void VIngresarMercaderia_Load(object sender, EventArgs e)
        {
            DataGridTextBoxColumn Producto = new DataGridTextBoxColumn();
            Producto.HeaderText = "Producto";
            dataGridView1.DataSource = controladorFachada.ListarProductos(Productos);
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
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

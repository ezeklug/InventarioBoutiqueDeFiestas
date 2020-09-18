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
using InventarioBoutiqueDeFiestas.DTO;

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
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                
            }
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
            dataGridView1.DataSource = controladorFachada.ListarProductos(Productos);
            dataGridView1.Columns[4].HeaderText = "Fecha de Vencimiento dd/mm/aaaa";
            dataGridView1.Columns[3].HeaderText = "Precio de Compra";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
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

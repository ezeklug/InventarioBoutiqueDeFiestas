using InventarioBoutiqueDeFiestas.Ventanas;
using System;
using InventarioBoutiqueDeFiestas.Controladores;
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

        ControladorFachada controladorFachada = new ControladorFachada();
        private void ControlClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientes vControlClientes = new VControlClientes();
            vControlClientes.ShowDialog();
            this.Close();
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorFachada.getNotificaciones();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
        }

        private void ControlPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlPresupuestos vControlPresupuestos = new VControlPresupuestos();
            vControlPresupuestos.ShowDialog();
            this.Close();
        }

        private void ControlProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProductos = new VControlProducto();
            vControlProductos.ShowDialog();
            this.Close();
        }

        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VVentanaNotificacionDetalle vVentanaNotificacionDetalle = new VVentanaNotificacionDetalle(dataGridView1.Rows[e.RowIndex]);
            vVentanaNotificacionDetalle.ShowDialog();
        }
    }
}

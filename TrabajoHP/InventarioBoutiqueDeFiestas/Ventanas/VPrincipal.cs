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
using InventarioBoutiqueDeFiestas.Style;

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
            this.GetNoficaciones(DiasNotificaciones.Text);
        }

        private void GetNoficaciones(string text)
        {
            if (text == "")
            {
                text = "0";
            }
            dataGridView1.DataSource = controladorFachada.getNotificaciones(Convert.ToInt32(text));
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
                NohayNotificaciones.Visible = true;
            }
            else
            {
                dataGridView1.Visible = true;
                NohayNotificaciones.Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                _ = new DatagridStyle(dataGridView1);
            }
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
            VNotificacionDetalle vNotificacionDetalle = new VNotificacionDetalle(dataGridView1.Rows[e.RowIndex]);
            vNotificacionDetalle.ShowDialog();
            VPrincipal_Load(sender, e);
        }

        private void DiasNotificaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.GetNoficaciones(DiasNotificaciones.Text);
            }
        }

        private void DiasNotificaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

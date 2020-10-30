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

        private void ControlClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientes vControlClientes = new VControlClientes();
            vControlClientes.ShowDialog();
            this.Close();
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {
            //var cont = new ControladorFachada();
            //var not = cont.Notificaciones();
            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Descripcion", "Descripcion");
            dataGridView1.Columns.Add("PresupuestoId", "PresupuestoId");
            dataGridView1.Columns.Add("LoteId", "LoteId");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            string[] r = new string[] { "25/12/2020", "Hola","5", "0"};
            dataGridView1.Rows.Add(r);
            string[] r2 = new string[] { "25/11/2015", "Hola2", "0", "7" };
            dataGridView1.Rows.Add(r2);
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
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }
    }
}

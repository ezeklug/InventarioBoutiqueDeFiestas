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
    public partial class VVenderPresupuesto : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        int IdCliente { get; set; }
        int IdPresupuesto { get; set; }
        public VVenderPresupuesto(int pIdCliente, int pPresupuestoId)
        {
            IdCliente = pIdCliente;
            IdPresupuesto = pPresupuestoId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VVenderPresupuesto_Load(object sender, EventArgs e)
        {
           /* NombreCliente.Text =;
            TotalVenta.Text =;*/
            List<LineaPresupuestoDTO> lineas = controladorFachada.ListarLineasConLotePresupuesto(IdPresupuesto);
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Lote", "Lote");
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            foreach (LineaPresupuestoDTO linea in lineas)
            {
                string[] row = new string[] {linea.NombreProducto, linea.Cantidad.ToString(),linea.Lotes };
                dataGridView1.Rows.Add(row);
            }
        }

    }
}

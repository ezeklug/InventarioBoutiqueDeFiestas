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
        List<LineaPresupuestoDTO> Lineas { get; set; }
        public VVenderPresupuesto(int pIdCliente, int pPresupuestoId)
        {
            IdCliente = pIdCliente;
            IdPresupuesto = pPresupuestoId;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VVenderPresupuesto_Load(object sender, EventArgs e)
        {
            NombreCliente.Text =controladorFachada.BuscarNombreCliente(IdCliente);
            Monto.Text = controladorFachada.TotalVentaPresupuesto(IdPresupuesto).ToString();
            Lineas = controladorFachada.ListarLineasConLotePresupuesto(IdPresupuesto);
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
            foreach (LineaPresupuestoDTO linea in Lineas)
            {
                string[] row = new string[] {linea.NombreProducto, linea.Cantidad.ToString(),linea.Lotes };
                dataGridView1.Rows.Add(row);
            }
        }

        private void Vender_Click(object sender, EventArgs e)
        {
            List<string> productosSinStock = controladorFachada.Vender(IdPresupuesto);
            foreach (LineaPresupuestoDTO linea in Lineas)
            {
                foreach (KeyValuePair<int,int> loteyCantidad in linea.LoteYCantidad)
                {
                    controladorFachada.DescontarProductosDeLote(loteyCantidad.Key, loteyCantidad.Value);
                }
            }
            this.Hide();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }
}

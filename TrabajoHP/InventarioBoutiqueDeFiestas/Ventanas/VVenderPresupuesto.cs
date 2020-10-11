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
            dataGridView2.Columns.Add("Producto", "Producto");
            dataGridView2.Columns.Add("CantidadStock", "Cantidad en stock");
            dataGridView2.Columns.Add("CantidadFaltante", "Cantidad faltante");
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].ReadOnly = true;
            dataGridView2.Visible = false;
            ProductosSinStock.Visible = false;
            OpcionVender.Visible = false;
            OpcionNoVender.Visible = false;
            dataGridView2.AllowUserToAddRows = false;
            NombreCliente.Text =controladorFachada.BuscarNombreCliente(IdCliente);
            Monto.Text = controladorFachada.TotalVentaPresupuesto(IdPresupuesto).ToString();
            Lineas = controladorFachada.ListarLineasConLotePresupuesto(IdPresupuesto);
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Lote", "Lote");
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "Listo";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            foreach (LineaPresupuestoDTO linea in Lineas)
            {
                string[] row = new string[] {linea.NombreProducto, linea.Cantidad.ToString(),linea.Lotes };
                dataGridView1.Rows.Add(row);
            }
            if (controladorFachada.BuscarPresupuesto(IdPresupuesto).Estado=="Vendido")
            {
                dataGridView1.Columns[3].ReadOnly = true;
                Cancelar.Text = "Volver";
                Vender.Visible = false;
            }
        }

        private void Vender_Click(object sender, EventArgs e)
        {
            Boolean seleccion = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (!isSelected)
                {
                    seleccion = false;
                }
            }
            if (seleccion)
            {
                List<Tuple<string, int, int>> productosSinStock = controladorFachada.Vender(IdPresupuesto);
                if (productosSinStock.Count>0)
                {
                    dataGridView2.Visible = true;
                    ProductosSinStock.Visible = true;
                    foreach (Tuple<string,int,int> tuple in productosSinStock)
                    {
                        string[] row = new string[] {tuple.Item1,tuple.Item2.ToString(),tuple.Item3.ToString()};
                        dataGridView2.Rows.Add(row);
                    }

                }
                else
                {
                    foreach (LineaPresupuestoDTO linea in Lineas)
                    {
                        foreach (KeyValuePair<int, int> loteyCantidad in linea.LoteYCantidad)
                        {
                            controladorFachada.DescontarProductosDeLote(loteyCantidad.Key, loteyCantidad.Value);
                        }
                    }
                     this.Hide();
                     this.Close();
                }

            }
            else
            {
                MessageBox.Show("Debe confirmar todas las extracciones de lotes");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }
}

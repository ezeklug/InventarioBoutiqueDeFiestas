using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Controladores;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VControlClientesPresupuesto : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        int IdCliente { get; set; }
        List<int> IdProductos { get; set; }
        List<DataGridViewRow> Filas { get; set; }
        
        public VControlClientesPresupuesto(int pIdCliente, List<int> pIdProductos, List<DataGridViewRow> filas)
        {
            IdCliente = pIdCliente;
            IdProductos = pIdProductos;
            Filas = filas;
            InitializeComponent();
        }

        private void VControlClientesPresupuesto_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.DataSource = controladorFachada.ListarClientes();
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }
        private void AsociarPresupuesto_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    IdCliente = Convert.ToInt32(row.Cells[1].Value);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(IdCliente,IdProductos,Filas);
                vAdministrarPresupuesto.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 0;
            if (e.ColumnIndex == columnIndex)
            {
                var isChecked = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[e.ColumnIndex].Value))
                    {
                        isChecked = true;
                    }
                }
                if (isChecked)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells[columnIndex].Value = !isChecked;
                        }
                    }
                }
            }
        }
    }
}

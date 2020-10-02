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
using InventarioBoutiqueDeFiestas.Controladores;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VControlPresupuestos : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        public VControlPresupuestos()
        {
            InitializeComponent();
        }

        private void VControlPresupuestos_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.DataSource = controladorFachada.ListarPresupuesto();
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto();
            vAdministrarPresupuesto.ShowDialog();
            this.Close();
        }

        private void Administrar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            PresupuestoDTO presupuestoDTO = new PresupuestoDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    presupuestoDTO.Id = Convert.ToInt32(row.Cells[1].Value);
                    presupuestoDTO.FechaGeneracion = Convert.ToDateTime(row.Cells[2].Value);
                    presupuestoDTO.FechaVencimiento = Convert.ToDateTime(row.Cells[3].Value);
                    presupuestoDTO.FechaEvento = Convert.ToDateTime(row.Cells[5].Value);
                    presupuestoDTO.IdCliente = Convert.ToInt32(row.Cells[6].Value);
                    presupuestoDTO.Estado = row.Cells[7].Value.ToString();
                    presupuestoDTO.Descuento = Convert.ToInt32(row.Cells[8].Value);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(presupuestoDTO);
                vAdministrarPresupuesto.ShowDialog();
                this.Close();

            }
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
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

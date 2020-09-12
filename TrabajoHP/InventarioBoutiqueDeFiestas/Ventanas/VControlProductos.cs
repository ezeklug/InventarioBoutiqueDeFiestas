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
    public partial class VControlProductos : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        public VControlProductos()
        {
            InitializeComponent();
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

        private void VControlProductos_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorFachada.ListarTodosLosProductos();
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 35;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 95;
            dataGridView1.Columns[6].Width = 125;
            dataGridView1.Columns[7].Width = 95;
            dataGridView1.Columns[8].Width = 115;
            dataGridView1.Columns[9].Width = 50;

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                }
            }
            if (seleccion)
            {
                MessageBox.Show("No puede agregar con un elemento seleccionado");
            }
            else
            {
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto();
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            ProductoDTO productoDTO = new ProductoDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    productoDTO.Id = Convert.ToInt32(row.Cells[1].Value);
                    productoDTO.Nombre = row.Cells[2].Value.ToString();
                    productoDTO.Descripcion= row.Cells[3].Value.ToString();
                    productoDTO.StockMinimo = Convert.ToInt32(row.Cells[4].Value);
                    productoDTO.CantidadEnStock = Convert.ToInt32(row.Cells[5].Value);
                    productoDTO.PorcentajeDeGanancia =Convert.ToDouble(row.Cells[6].Value);
                    productoDTO.PrecioDeCompra = Convert.ToDouble(row.Cells[7].Value);
                    productoDTO.IdCategoria = Convert.ToInt32(row.Cells[8].Value);
                    productoDTO.Activo = Convert.ToBoolean(row.Cells[9].Value);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto(productoDTO);
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }

        }

        private void IngresoMercaderia_Click(object sender, EventArgs e)
        {

        }

        private void PorcentajeIncremento_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}

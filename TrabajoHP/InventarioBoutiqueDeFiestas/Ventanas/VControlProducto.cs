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
    public partial class VControlProducto : Form
    {
        ControladorFachada controladorfachada = new ControladorFachada();
        DataGridView Filas { get; set; }
        public VControlProducto()
        {
            Filas = new DataGridView();
            InitializeComponent();
        }
        public VControlProducto(DataGridView filas)
        {
            Filas = filas;
            InitializeComponent();
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
            int cont = 0;
            DataGridViewRow row1 = new DataGridViewRow();
            ProductoDTO productoDTO = new ProductoDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    cont++;
                    row1 = row;
                }
            }
            if (cont==1)
            {
                productoDTO.Id = Convert.ToInt32(row1.Cells[1].Value);
                productoDTO.Nombre = row1.Cells[2].Value.ToString();
                productoDTO.Descripcion = row1.Cells[3].Value.ToString();
                productoDTO.StockMinimo = Convert.ToInt32(row1.Cells[4].Value);
                productoDTO.CantidadEnStock = Convert.ToInt32(row1.Cells[5].Value);
                productoDTO.PorcentajeDeGanancia = Convert.ToDouble(row1.Cells[6].Value);
                productoDTO.PrecioDeCompra = Convert.ToDouble(row1.Cells[7].Value);
                productoDTO.Activo = Convert.ToBoolean(row1.Cells[9].Value);
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto(productoDTO);
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
            else if (cont>1)
            {
                MessageBox.Show("Seleccione solo un producto");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Cb"].Value = false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void IngresoMercaderia_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            List<int> idProductos = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    int idProducto = Convert.ToInt32(row.Cells[1].Value);
                    idProductos.Add(idProducto);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VIngresarMercaderia vIngresarMercaderia = new VIngresarMercaderia(idProductos,Filas);
                vIngresarMercaderia.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void VControlProducto_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorfachada.ListarTodosLosProductos();
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 35;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 95;
            dataGridView1.Columns[6].Width = 125;
            dataGridView1.Columns[7].Width = 95;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[9].Visible = false;
        }

        private void PorcentajeIncremento_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPorcentajeIncremento vPorcentajeIncremento = new VPorcentajeIncremento();
            vPorcentajeIncremento.ShowDialog();
            this.Close();
        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlCategoria vCategoria= new VControlCategoria();
            vCategoria.ShowDialog();
            this.Close();
        }

    }
}

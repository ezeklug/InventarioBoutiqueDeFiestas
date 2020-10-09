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
    public partial class VControlCategoriaProducto : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        ProductoDTO Producto { get; set; }
        public VControlCategoriaProducto(ProductoDTO pProductoDTO)
        {
            Producto = pProductoDTO;
            InitializeComponent();
        }

        private void ControlCategoriaProducto_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorFachada.ListarCategorias();
            dataGridView1.Columns[5].Visible = false; //Columna de "Activo"
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void AsociarProducto_Click(object sender, EventArgs e)
        {
            int cont = 0;
            DataGridViewRow row1 = new DataGridViewRow();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    cont++;
                    row1 = row;
                }
            }

            if (cont == 1)
            {
                Producto.IdCategoria = controladorFachada.BuscarCategoriaPorNombre(row1.Cells[2].Value.ToString());
                Console.WriteLine(row1.Cells[2].Value.ToString());
                Console.WriteLine(controladorFachada.BuscarCategoriaPorNombre(row1.Cells[2].Value.ToString()));
                Console.WriteLine(Producto.IdCategoria);
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto(Producto);
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
            else if (cont > 1)
            {
                MessageBox.Show("Seleccione solo una categoría");
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

        private void Agregar_Click(object sender, EventArgs e)
        {
            VAgregarModifciarCategoria vAgregarModificarCategoria = new VAgregarModifciarCategoria(1);
            vAgregarModificarCategoria.ShowDialog();
            this.ControlCategoriaProducto_Load(sender,e);
        }
    }
}

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
    public partial class VControlCategoria : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        ProductoDTO Producto { get; set; }
        public VControlCategoria(ProductoDTO pProductoDTO)
        {
            Producto = pProductoDTO;
            InitializeComponent();
        }
        public VControlCategoria()
        {
            InitializeComponent();
            controladorFachada = new ControladorFachada();
        }

        private void VAgregarCategoria_Load(object sender, EventArgs e)
        {
            Listas.Items.Add("Activas");
            Listas.Items.Add("No Activas");
            if (Producto != null)
            {
                AsociarProducto.Visible = true;
            }
            else
            {
                AsociarProducto.Visible = false;
            }
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorFachada.ListarCategorias();
            dataGridView1.Columns[5].Visible = false; //Columna de "Activo"
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAgregarModificiarCategoria vAgregarModificarCategoria = new VAgregarModificiarCategoria();
            vAgregarModificarCategoria.ShowDialog();
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
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
                 CategoriaProductoDTO categoriaDTO = new CategoriaProductoDTO
                        {
                            Id = Convert.ToInt32(row1.Cells[1].Value),
                            Nombre = (row1.Cells[2].Value).ToString(),
                            Descripcion = (row1.Cells[3].Value).ToString(),
                            Vence = Convert.ToBoolean(row1.Cells[4].Value)

                        };

                   this.Hide();
                   VAgregarModificiarCategoria vAgregarModificarCategoria = new VAgregarModificiarCategoria(categoriaDTO);
                   vAgregarModificarCategoria.ShowDialog();
                   this.Close();
            }
            else if (cont>1)
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(fila.Cells[0].Value))
                {
                    int idCategoria = Convert.ToInt32(fila.Cells[1].Value);
                    if (Eliminar.Text=="Baja")
                    {
                        controladorFachada.BajaCategoria(idCategoria);
                        MessageBox.Show("Categoria/s dada/s de baja correctamente");
                    }
                    else
                    {
                        controladorFachada.AltaCategoria(idCategoria);
                        MessageBox.Show("Categoria/s dada/s de alta correctamente");
                    }

                                       
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            this.Listas_SelectedIndexChanged(sender, e);
            dataGridView1.Columns[5].Visible = false; //Columna de "Activo"

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
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

        private void Listas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listas.Text == "Activas")
            {
                dataGridView1.DataSource = controladorFachada.ListarCategorias();
                Agregar.Visible = true;
                Modificar.Visible = true;
                Eliminar.Text = "Baja";
            }
            else
            {
                dataGridView1.DataSource = controladorFachada.ListarCategoriasNoActivas();
                Agregar.Visible = false;
                Modificar.Visible = false;
                Eliminar.Text = "Alta";
            }
        }
    }
}

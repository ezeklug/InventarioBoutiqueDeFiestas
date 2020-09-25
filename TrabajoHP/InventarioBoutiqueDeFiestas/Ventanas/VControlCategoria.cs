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
        ControladorFachada controladorFachada;
        public VControlCategoria()
        {
            InitializeComponent();
            controladorFachada = new ControladorFachada();
        }

        private void VAgregarCategoria_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorFachada.ListarCategorias();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAgregarModifciarCategoria vAgregarModificarCategoria = new VAgregarModifciarCategoria();
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
                   VAgregarModifciarCategoria vAgregarModificarCategoria = new VAgregarModifciarCategoria(categoriaDTO);
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
             
            
           
        
    }
}

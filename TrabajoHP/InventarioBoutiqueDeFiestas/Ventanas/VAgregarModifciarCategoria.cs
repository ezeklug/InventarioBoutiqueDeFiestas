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
    public partial class VAgregarModifciarCategoria : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        CategoriaProductoDTO categoriaDTO { get; set; }
        public VAgregarModifciarCategoria()
        {
            InitializeComponent();

        }

        public VAgregarModifciarCategoria(CategoriaProductoDTO categoria)
        {
            InitializeComponent();
            this.nombreCategoria.Text = categoria.Nombre;
            this.descripcionCategoria.Text = categoria.Nombre;
            if (categoria.Vence)
            {
                this.siVence.Checked = true;
            }
            else
            {
                this.noVence.Checked = true;
            }
            categoriaDTO = categoria;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlCategoria vControlCategoria = new VControlCategoria();
            vControlCategoria.ShowDialog();
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (this.nombreCategoria.Text == "" || this.descripcionCategoria.Text == "")
            {
                MessageBox.Show("Tiene que completar los campos obligatorios");
            }
            else
            {
                CategoriaProductoDTO categoriaProductoDTO = new CategoriaProductoDTO();
                if (categoriaDTO != null)
                {
                    categoriaProductoDTO.Id = categoriaDTO.Id;

                }
                categoriaProductoDTO.Nombre = nombreCategoria.Text;
                categoriaProductoDTO.Descripcion = descripcionCategoria.Text;
                if (siVence.Checked)
                {
                    categoriaDTO.Vence = true;
                }
                else { categoriaDTO.Vence = false; }

                controladorFachada.AgregarModificarCategoria(categoriaDTO);
                this.Hide();
                VControlCategoria vControlCategoria = new VControlCategoria();
                vControlCategoria.ShowDialog();
                this.Close();
            }
        }
    }
}
    


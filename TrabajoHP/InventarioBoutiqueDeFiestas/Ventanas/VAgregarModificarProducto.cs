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
    
    public partial class VAgregarModificarProducto : Form
    {
        ControladorFachada controladorfachada = new ControladorFachada();
        ProductoDTO ProductoDTO { get; set; }
        public VAgregarModificarProducto()
        {
            InitializeComponent();
        }
        public VAgregarModificarProducto(ProductoDTO pProductoDTO)
        {
            ProductoDTO = pProductoDTO;
            InitializeComponent();
            Nombre.Text = pProductoDTO.Nombre;
            Descripcion.Text = pProductoDTO.Descripcion;
            StockMinimo.Text = pProductoDTO.StockMinimo.ToString();
            CantidadEnStock.Text = pProductoDTO.CantidadEnStock.ToString();
            PorcentajeDeGanancia.Text = pProductoDTO.PorcentajeDeGanancia.ToString();
            Categoria.Text = controladorfachada.GetNombreCategoria(pProductoDTO.Id);

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
            VControlProducto vControlProductos = new VControlProducto();
            vControlProductos.ShowDialog();
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "" || StockMinimo.Text == "" || CantidadEnStock.Text=="" || PorcentajeDeGanancia.Text==""|| Categoria.Text=="" )
            {
                MessageBox.Show("Tiene que completar los campos obligatorios");
            }
            else
            {
                ProductoDTO pProductoDTO = new ProductoDTO();
                if (ProductoDTO != null)
                {
                    pProductoDTO.Id = ProductoDTO.Id;
                    pProductoDTO.Activo = ProductoDTO.Activo;
                }
                pProductoDTO.Nombre = Nombre.Text;
                pProductoDTO.Descripcion = Descripcion.Text;
                pProductoDTO.CantidadEnStock = Convert.ToInt32(CantidadEnStock.Text);
                pProductoDTO.PorcentajeDeGanancia = Convert.ToInt32(PorcentajeDeGanancia.Text);
                pProductoDTO.StockMinimo = Convert.ToInt32(StockMinimo.Text);
                controladorfachada.AgregarModificarProducto(pProductoDTO);
                this.Hide();
                VControlProducto vControlProducto = new VControlProducto();
                vControlProducto.ShowDialog();
                this.Close();
            }

        }

    }
}

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
using InventarioBoutiqueDeFiestas.Dominio;

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
            PorcentajeDeGanancia.Text = pProductoDTO.PorcentajeDeGanancia.ToString();
            precioCompra.Text = pProductoDTO.PrecioDeCompra.ToString();
            if (pProductoDTO.IdCategoria==0)
            {
                Categoria.Text = controladorfachada.GetNombreCategoriaConProductoId(pProductoDTO.Id);
            }
            else
            {
                Categoria.Text = controladorfachada.GetNombreCategoriaConCategoriaId(pProductoDTO.IdCategoria);
            }


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
            if (Nombre.Text == "" || StockMinimo.Text == "" || PorcentajeDeGanancia.Text == "" || Categoria.Text == "")
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
                pProductoDTO.PorcentajeDeGanancia = Convert.ToDouble(PorcentajeDeGanancia.Text);
                pProductoDTO.StockMinimo = Convert.ToInt32(StockMinimo.Text);
                pProductoDTO.IdCategoria = controladorfachada.BuscarCategoriaPorNombre(Categoria.Text);
                pProductoDTO.PrecioDeCompra = Convert.ToDouble(precioCompra.Text);
                controladorfachada.AgregarModificarProducto(pProductoDTO);
                this.Hide();
                VControlProducto vControlProducto = new VControlProducto();
                vControlProducto.ShowDialog();
                this.Close();
            }

        }

        
        private void VAgregarModificarProducto_Load(object sender, EventArgs e)
        {
            List<String> listaCategorias = new List<string>();
            foreach (CategoriaProducto cate in controladorfachada.ListarCategorias())
            {
                listaCategorias.Add(cate.Nombre);
                Categoria.Items.Add(cate.Nombre);
                
            }
            
            this.Categoria.AutoCompleteCustomSource.AddRange(listaCategorias.ToArray());
            this.Categoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.Categoria.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            ProductoDTO pProductoDTO=new ProductoDTO();
            pProductoDTO.Id = ProductoDTO.Id;
            pProductoDTO.Nombre = Nombre.Text;
            pProductoDTO.Descripcion= Descripcion.Text;
            pProductoDTO.StockMinimo= Convert.ToInt32(StockMinimo.Text);
            pProductoDTO.PorcentajeDeGanancia = Convert.ToDouble(PorcentajeDeGanancia.Text);
            pProductoDTO.PrecioDeCompra= Convert.ToDouble(precioCompra.Text);
            this.Hide();
            VControlCategoria vControlCategoria = new VControlCategoria(pProductoDTO);
            vControlCategoria.ShowDialog();
            this.Close();
        }

    }
}

    
  
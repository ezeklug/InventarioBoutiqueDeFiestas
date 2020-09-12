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

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VAgregarModificarProducto : Form
    {
        ProductoDTO ProductoDTO { get; set; }
        public VAgregarModificarProducto()
        {
            InitializeComponent();
        }
        public VAgregarModificarProducto(ProductoDTO pProductoDTO)
        {
            ProductoDTO = pProductoDTO;
            InitializeComponent();
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
    }
}

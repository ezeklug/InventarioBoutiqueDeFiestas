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
    public partial class VPorcentajeIncremento : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();

        public VPorcentajeIncremento()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            int incremento = Convert.ToInt32(this.incremento.Text);
            controladorFachada.AplicarIncrementoTodosLosProductos(incremento);
        }
    }
}

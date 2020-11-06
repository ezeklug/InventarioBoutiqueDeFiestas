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
using InventarioBoutiqueDeFiestas.Style;

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
            if (incremento.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un porcentaje de incremento");
            }
            else
            {

                int incremento = Convert.ToInt32(this.incremento.Text);
                controladorFachada.AplicarIncrementoTodosLosProductos(incremento);
                VControlProducto.instancia.UpdateTable();
                MessageBox.Show("Incremento aplicado correctamente!");
                this.Close();
            } 
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void VPorcentajeIncremento_Load(object sender, EventArgs e)
        {

        }
    }
}

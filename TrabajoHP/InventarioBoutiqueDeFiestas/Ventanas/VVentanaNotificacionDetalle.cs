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
    public partial class VVentanaNotificacionDetalle : Form
    {
        public VVentanaNotificacionDetalle(DataGridViewRow iNotificacion)
        {
            InitializeComponent();
            this.VencimientoLabel.Text = iNotificacion.Cells[0].Value.ToString();
            this.DescripcionLabel.Text = iNotificacion.Cells[1].Value.ToString();
            this.NumeroPresupuestoLabel.Text = iNotificacion.Cells[2].Value.ToString();
            this.NumeroLoteLabel.Text = iNotificacion.Cells[3].Value.ToString();
        }

        private void VVentanaNotificacionDetalle_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

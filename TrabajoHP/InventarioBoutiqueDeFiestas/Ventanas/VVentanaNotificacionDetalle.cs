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
        NotificacionDTO iNotificacion;
        public VVentanaNotificacionDetalle()
        {
            InitializeComponent();
            this.NumeroLoteLabel.Text = iNotificacion.IdLote.ToString();
            this.NumeroPresupuestoLabel.Text = iNotificacion.IdPresupuesto.ToString();
            this.DescripcionLabel.Text = iNotificacion.Descripcion.ToString();
            this.VencimientoLabel.Text = iNotificacion.FechaVencimiento.ToString();

        }

        private void VVentanaNotificacionDetalle_Load(object sender, EventArgs e)
        {

        }

    }
}

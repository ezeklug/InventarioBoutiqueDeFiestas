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
            if (iNotificacion.Cells[2].Value.ToString()!="0")
            {
                this.NumeroPresupuestoLabel.Text = iNotificacion.Cells[2].Value.ToString();
                Producto.Visible = false;
                ProductoLabel.Visible = false;
                Cantidad.Visible = false;
                CantidadLabel.Visible = false;
                FechaCompra.Text = "Fecha de Creación";
                NumeroLote.Visible = false;
                NumeroLoteLabel.Visible = false;
            }
            else if (iNotificacion.Cells[3].Value.ToString()!="0")
            {
                this.NumeroLoteLabel.Text = iNotificacion.Cells[3].Value.ToString();
                NumeroPresupuesto.Visible = false;
                NumeroPresupuestoLabel.Visible = false;
                VerPresupuesto.Visible = false;
            }
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

        private void Vender_Click(object sender, EventArgs e)
        {
            //VAdministrarPresupuesto vAdministrarPresupuesto=new VAdministrarPresupuesto()
        }
    }
}

using InventarioBoutiqueDeFiestas.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VNotificacionDetalle : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        public VNotificacionDetalle(DataGridViewRow row)
        {
            InitializeComponent();
            FechaVencimientoLabel.Text = row.Cells[0].Value.ToString();
            DescripcionLabel.Text = row.Cells[1].Value.ToString();
            if (row.Cells[3].Value.ToString() != "0") //Lote
            {
                NumeroLoteOPresupuestoLabel.Text = row.Cells[3].Value.ToString();
                LoteDTO lote = controladorFachada.BuscarLote(Convert.ToInt32(row.Cells[3].Value));
                FechaCompraLabel.Text = lote.FechaCompra.ToString();
                CantidadLabel.Text = lote.CantidadProductos.ToString();
                ProductoLabel.Text = lote.NombreProducto;
                AdministrarPresupuesto.Visible = false;
            }
            else if (row.Cells[2].Value.ToString() != "0") //Presupuesto
            {
                NumeroLoteOPresupuestoLabel.Text = row.Cells[2].Value.ToString();
                PresupuestoDTO pres = controladorFachada.BuscarPresupuestoDTO(Convert.ToInt32(row.Cells[2].Value));
                FechaCompraLabel.Text = pres.FechaGeneracion.ToString();
                NumeroLote.Text = "Numero Presupuesto";
                FechaCompra.Text = "Fecha de Creación";
                Producto.Visible = false;
                ProductoLabel.Visible = false;
                Cantidad.Visible = false;
                CantidadLabel.Visible = false;
                EliminarLote.Visible = false;
            }
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EliminarLote_Click(object sender, EventArgs e)
        {
            controladorFachada.EliminarLote(Convert.ToInt32(NumeroLoteOPresupuestoLabel.Text));
            MessageBox.Show("Lote eliminado");
        }

        private void AdministrarPresupuesto_Click(object sender, EventArgs e)
        {
            VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(Convert.ToInt32(NumeroLoteOPresupuestoLabel.Text));
            vAdministrarPresupuesto.ShowDialog();

        }
    }
}

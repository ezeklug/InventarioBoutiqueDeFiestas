using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.Style;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VSeniarPresupuesto : Form
    {
        Cliente iCliente;
        SeniaDTO seniaDto;
        Presupuesto iPresupuesto;
        public VSeniarPresupuesto(int pIdCliente, int pPresupuestoId)
        {
            var cont = new ControladorFachada();
            var contP = new ControladorPresupuesto();
            iCliente = cont.BuscarCliente(pIdCliente);
            iPresupuesto = cont.BuscarPresupuesto(pPresupuestoId);
            seniaDto = contP.PresupuestoTieneSenia(pPresupuestoId);
            InitializeComponent();


            this.nombreClienteLabel.Text = iCliente.ToString();
            this.cantidadProductosLabel.Text = iPresupuesto.Lineas.Count.ToString();
            this.totalLabel.Text = iPresupuesto.TotalVenta().ToString();
            if (seniaDto != null)
            {
                this.dateTimePicker1.Value = seniaDto.ValidoHasta;
                this.fechaDeSeniaLabel.Text = seniaDto.Fecha.ToString();
                this.montoSeniaTextBox.Text = seniaDto.Monto.ToString();
                this.PorcentajeSeña.Text= ((Convert.ToDouble(montoSeniaTextBox.Text) * 100) / Convert.ToDouble(this.totalLabel.Text)).ToString();
            }
            else
            {
                this.fechaDeSeniaLabel.Text = DateTime.Now.ToString();
            }
            montoSeniaTextBox.TextChanged += new System.EventHandler(this.montoSeniaTextBox_HasChanged);

        }

        private void montoSeniaTextBox_HasChanged(object sender, EventArgs e)
        {
            if (montoSeniaTextBox.TextLength != 0)
            {
                if (Convert.ToDouble(montoSeniaTextBox.Text) >= Convert.ToDouble(this.totalLabel.Text))
                {
                    montoSeniaTextBox.Text = this.totalLabel.Text;
                    montoSeniaTextBox.SelectionStart = montoSeniaTextBox.Text.Length;
                }
                this.PorcentajeSeña.Text = ((Convert.ToDouble(montoSeniaTextBox.Text) * 100) / Convert.ToDouble(this.totalLabel.Text)).ToString();
            }
            montoSeniaTextBox.SelectionStart = montoSeniaTextBox.Text.Length;
        }

        private void VSeniarPresupuesto_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.MinDate = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now + TimeSpan.FromDays(15);
        }

        private void montoSeniaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                string senderText = (sender as TextBox).Text;
                string senderName = (sender as TextBox).Name;
                string[] splitByDecimal = senderText.Split(',');
                int cursorPosition = (sender as TextBox).SelectionStart;

                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }


                if (e.KeyChar == ','
                    && senderText.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }


                if (!char.IsControl(e.KeyChar)
                    && senderText.IndexOf(',') < cursorPosition
                    && splitByDecimal.Length > 1
                    && splitByDecimal[1].Length == 2)
                {
                    e.Handled = true;
                }

        }

        private void CerrarVentana()
        {
            this.Hide();
            this.Close();
        }

        private void Seniar_Click(object sender, EventArgs e)
        {
            if (this.montoSeniaTextBox.TextLength != 0)
            {

                var cont = new ControladorPresupuesto();
                if (seniaDto == null)
                {
                    var dto = new SeniaDTO();
                    dto.Fecha = DateTime.Parse(this.fechaDeSeniaLabel.Text);
                    dto.IdPresupuesto = iPresupuesto.Id;
                    dto.Monto = Convert.ToDouble(this.montoSeniaTextBox.Text);
                    dto.ValidoHasta = dateTimePicker1.Value;
                    cont.SeniarPresupuesto(dto);
                }
                else
                {
                    seniaDto.Monto = Convert.ToDouble(this.montoSeniaTextBox.Text);
                    seniaDto.Fecha = DateTime.Parse(this.fechaDeSeniaLabel.Text);
                    seniaDto.ValidoHasta = dateTimePicker1.Value;
                    cont.ModificarSenia(seniaDto);
                }

                MessageBox.Show("Se seño correctamente el presupuesto");
                CerrarVentana();
            }
            else
            {
                MessageBox.Show("Debe cargar correctamente el monto");  
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var s = (sender as DateTimePicker);
            if (s.Value < DateTime.Now)
            {
                
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}

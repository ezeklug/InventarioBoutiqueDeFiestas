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
            }
            else
            {
                this.fechaDeSeniaLabel.Text = DateTime.Now.ToString();
            }


            porcentajeSeniaTextBox.TextChanged += new System.EventHandler(this.porcentajeSeniaTextBox_HasChanged);
            montoSeniaTextBox.TextChanged += new System.EventHandler(this.montoSeniaTextBox_HasChanged);

        }

        private void porcentajeSeniaTextBox_HasChanged(object sender, EventArgs e)
        {
            var s = (sender as TextBox);
            if (s.TextLength != 0)
            {

                if (float.Parse(s.Text) > 100)
                {
                    s.Text = "100";
                    s.SelectionStart = s.Text.Length;
                }
               this.montoSeniaTextBox.Text = (double.Parse(this.totalLabel.Text) * (double.Parse(s.Text) / 100)).ToString();
            }
            
        }

        private void montoSeniaTextBox_HasChanged(object sender, EventArgs e)
        {
            var s = (sender as TextBox);
            if (s.TextLength != 0)
            {
                if (float.Parse(s.Text) >= float.Parse(this.totalLabel.Text))
                {
                    s.Text = this.totalLabel.Text;
                    s.SelectionStart = s.Text.Length;
                }
                this.porcentajeSeniaTextBox.Text = ((double.Parse(s.Text) * 100) / double.Parse(this.totalLabel.Text)).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VSeniarPresupuesto_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.MinDate = DateTime.Now;
            this.dateTimePicker1.Value = DateTime.Now + TimeSpan.FromDays(15);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void porcentajeSeniaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void porcentajeSeniaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void montoSeniaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                    dto.Monto = float.Parse(this.montoSeniaTextBox.Text);
                    dto.ValidoHasta = dateTimePicker1.Value;
                    cont.SeniarPresupuesto(dto);
                }
                else
                {
                    seniaDto.Monto = float.Parse(this.montoSeniaTextBox.Text);
                    seniaDto.Fecha = DateTime.Parse(this.fechaDeSeniaLabel.Text);
                    seniaDto.ValidoHasta = dateTimePicker1.Value;
                    cont.ModificarSenia(seniaDto);
                }
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
            var home = new VPrincipal();
            home.Show();
            this.Hide();
            this.Close();
        }
    }
}

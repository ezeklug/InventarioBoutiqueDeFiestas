using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
using IronPdf.Engines.WebKit.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VAdministrarPresupuesto : Form
    {
        int IdCliente { get; set; }
        DataGridView Filas { get; set; }
        List<int> IdProductos { get; set; }
        DateTime FechaEvento { get; set; }
        DateTime FechaVencimiento { get; set; }
        int IdPresupuesto { get; set; }
        string Descuento { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VAdministrarPresupuesto()
        {
            IdProductos = new List<int>();
            Filas = new DataGridView();
            IdCliente = 0;
            FechaEvento = DateTime.Now;
            FechaVencimiento = DateTime.Now.AddDays(15);
            Descuento = "0";
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente, List<int> idProductos, DataGridView filas, DateTime fechaEvento, DateTime fechaVencimiento, int idPresupuesto,string descuento)
        {
            IdCliente = pIdCliente;
            IdProductos = idProductos;
            Filas = filas;
            FechaEvento = fechaEvento;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente, DataGridView filas,DateTime fechaEvento,DateTime fechaVencimiento,int idPresupuesto,string descuento)
        {
            IdCliente = pIdCliente;
            Filas = filas;
            FechaEvento = fechaEvento;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
            InitializeComponent();
        }

        private void VAdministrarPresupuesto_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("PorcentajeDescuento", "Porcentaje Descuento");
            dataGridView1.Columns.Add("Subtotal", "Subtotal");
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            Total.ReadOnly = true;
            Cliente.ReadOnly = true;
            dateTimePicker2.Value = FechaEvento;
            dateTimePicker1.Value = FechaVencimiento;
            DescuentoTotal.Text = Descuento;
            if (IdCliente != 0)
            {
                Cliente.Text = controladorFachada.BuscarCliente(IdCliente).ToString();
            }
            if (Filas.RowCount != 0)
            {
                foreach (DataGridViewRow row in Filas.Rows)
                {
                    string[] r = new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString() };
                    dataGridView1.Rows.Add(r);
                }
            }
            if(IdProductos!=null)
            {
                Boolean existe = false;
                foreach (ProductoPresupuestoDTO p in controladorFachada.ListarProductosPresupuesto(IdProductos))
                {
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == p.Id.ToString())
                        {
                            existe = true;
                        }
                    }
                    if(!existe)
                    {
                        string[] row = new string[] { p.Id.ToString(), p.Nombre, "0", p.PrecioUnitario.ToString(), "0", "0" };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void CalcularSubtotal()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[5].Value =controladorFachada.CalcularSubtotal(Convert.ToInt32(row.Cells[2].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToInt32(row.Cells[4].Value)).ToString();
            }
        }

        private double PrecioVenta()
        {
            List<double> subtotales = new List<double>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotales.Add(Convert.ToDouble(row.Cells[5].Value));
            }
            return controladorFachada.PrecioVenta(subtotales, Convert.ToDouble(DescuentoTotal.Text));
        }
        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }


        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlClientesPresupuesto vControlClientesPresupuesto = new VControlClientesPresupuesto(IdCliente,dataGridView1,FechaEvento,FechaVencimiento,IdPresupuesto,DescuentoTotal.Text);
            vControlClientesPresupuesto.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularSubtotal();
            Total.Text = PrecioVenta().ToString();
        }

        private void DescuentoTotal_TextChanged(object sender, EventArgs e)
        {
           Total.Text = PrecioVenta().ToString();
        }

        private void CargarProductos_Click(object sender, EventArgs e)
        {
                this.Hide();
                VControlProductosPresupuesto vControlProductosPresupuesto = new VControlProductosPresupuesto(IdCliente, dataGridView1,FechaEvento,FechaVencimiento,IdPresupuesto,DescuentoTotal.Text);
                vControlProductosPresupuesto.ShowDialog();
                this.Close(); 
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
            else if (FechaEvento.Date<DateTime.Now.Date)
            {
                MessageBox.Show("Debe seleccionar una fecha de evento posterior a la seleccionada");
            }
            else if(FechaVencimiento.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe seleccionar una fecha de Vencimiento posterior a la seleccionada");
            }
            else
            {
                PresupuestoDTO pre = new PresupuestoDTO();
                pre.FechaGeneracion = DateTime.Now;
                pre.IdCliente = IdCliente;
                pre.FechaEvento = FechaEvento;
                pre.FechaVencimiento = FechaVencimiento;
                pre.Id = IdPresupuesto;
                pre.Descuento = Convert.ToDouble(DescuentoTotal.Text);
                IdPresupuesto = controladorFachada.AgregarModificarPresupuesto(pre);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    LineaPresupuestoDTO lin = new LineaPresupuestoDTO();
                    lin.Cantidad = int.Parse(row.Cells[2].Value.ToString());
                    lin.IdPresupuesto = IdPresupuesto;
                    lin.IdProducto = int.Parse(row.Cells[0].Value.ToString());
                    lin.PorcentajeDescuento = double.Parse(row.Cells[4].Value.ToString());
                    lin.Subtotal = double.Parse(row.Cells[5].Value.ToString());
                    controladorFachada.AgregarLinea(lin);
                }
                MessageBox.Show("Se guardó correctamente el presupuesto");
            }
        }

        private void Seniar_Click(object sender, EventArgs e)
        {
            if (IdPresupuesto==0)
            {
                this.Guardar_Click(sender, e);
            }

            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
            else
            {
                new VSeniarPresupuesto(IdCliente, IdPresupuesto).ShowDialog();
                this.Hide();
                this.Close();

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FechaEvento=dateTimePicker2.Value;
        }

        private void Vender_Click(object sender, EventArgs e)
        {
            if (IdPresupuesto == 0)
            {
                this.Guardar_Click(sender, e);
            }

            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
            else
            {
                new VSeniarPresupuesto(IdCliente, IdPresupuesto).ShowDialog();
                this.Hide();
                this.Close();

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlPresupuestos vControlPresupuestos = new VControlPresupuestos();
            vControlPresupuestos.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaVencimiento = dateTimePicker1.Value;
        }
    }
}

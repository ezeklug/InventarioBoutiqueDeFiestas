using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
using IronPdf.Engines.WebKit.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VAdministrarPresupuesto : Form
    {
        int IdCliente { get; set; }
        DataGridView Filas { get; set; }
        List<int> IdProductos { get; set; }
        DateTime FechaVencimiento { get; set; }
        int IdPresupuesto { get; set; }
        string Descuento { get; set; }
        string PObservacion { get; set; }
        PresupuestoDTO Presupuesto { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VAdministrarPresupuesto(int pIdPresupuesto)
        {
            IdProductos = new List<int>();
            Filas = new DataGridView();
            Presupuesto =controladorFachada.BuscarPresupuestoDTO(pIdPresupuesto);
            IdCliente = Presupuesto.IdCliente;
            FechaVencimiento = Presupuesto.FechaVencimiento;
            Descuento = Presupuesto.Descuento.ToString();
            IdPresupuesto = Presupuesto.Id;
            PObservacion = Presupuesto.Observacion;
            InitializeComponent();
        }
        public VAdministrarPresupuesto(PresupuestoDTO pPresupuestoDTO)
        {
            IdProductos = new List<int>();
            Filas = new DataGridView();
            Presupuesto = pPresupuestoDTO;
            IdCliente = pPresupuestoDTO.IdCliente;
            FechaVencimiento = pPresupuestoDTO.FechaVencimiento;
            Descuento = pPresupuestoDTO.Descuento.ToString();
            PObservacion = pPresupuestoDTO.Observacion;
            IdPresupuesto = pPresupuestoDTO.Id;

            InitializeComponent();
        }
        public VAdministrarPresupuesto()
        {
            IdProductos = new List<int>();
            Filas = new DataGridView();
            IdCliente = 0;
            FechaVencimiento = DateTime.Now.AddDays(15);
            Descuento = "0";
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente, List<int> idProductos, DataGridView filas, DateTime fechaEvento, DateTime fechaVencimiento, int idPresupuesto,string descuento, string observacion)
        {
            IdCliente = pIdCliente;
            IdProductos = idProductos;
            Filas = filas;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
            PObservacion = observacion;
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente, DataGridView filas,DateTime fechaEvento,DateTime fechaVencimiento,int idPresupuesto,string descuento,string observacion)
        {
            IdCliente = pIdCliente;
            Filas = filas;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
            PObservacion = observacion;
            InitializeComponent();
        }

        private void VAdministrarPresupuesto_Load(object sender, EventArgs e)
        {
            string EstadoPresupuesto = "";
            if (IdPresupuesto!=0)
            {
                EstadoPresupuesto=controladorFachada.BuscarPresupuesto(IdPresupuesto).Estado;
                if (EstadoPresupuesto=="Seniado")
                {
                    EstadoPresupuestoLabel.Text ="Estado:  " + "Señado";
                }
                else
                {
                    EstadoPresupuestoLabel.Text = "Estado:  " + EstadoPresupuesto;
                }
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
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
            Venta.Visible = false;
            dateTimePicker1.Value = FechaVencimiento;
            DescuentoTotal.Text = Descuento;
            Observacion.Text = PObservacion;
            if (IdCliente != 0)
            {
                Cliente.Text = controladorFachada.BuscarCliente(IdCliente).ToString();
            }
            //Lineas de presupuesto que vienen de otra pantalla (VControlProductos o VControlClientes)
            if (Filas.RowCount != 0)
            {
                foreach (DataGridViewRow row in Filas.Rows)
                {
                    string[] r = new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString() };
                    dataGridView1.Rows.Add(r);
                }
            }
            //Productos nuevos ingresados desde CARGAR PRODUCTOS 
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
            // Presupuesto que viene seleccionado de VControlPresupuestos (se seleccionó un presupuesto y se clickeo administrar)
            if(Presupuesto!=null)
            {
                foreach (LineaPresupuestoDTO lin in controladorFachada.ListarLineasPresupuesto(Presupuesto.Id))
                {
                    string[] row = new string[] { lin.IdProducto.ToString(), lin.NombreProducto, lin.Cantidad.ToString(), lin.PrecioUnitario.ToString(), lin.PorcentajeDescuento.ToString(), lin.Subtotal.ToString() };
                    dataGridView1.Rows.Add(row);
                }
                if (Presupuesto.Estado == "Vendido")
                {
                    dataGridView1.Columns[2].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    DescuentoTotal.ReadOnly = true;
                    Seniar.Visible = false;
                    Guardar.Visible = false;
                    Vender.Visible = false;
                    Venta.Visible = true;
                    Cancelar.Visible = false;
                    BuscarCliente.Visible = false;
                    CargarProductos.Visible = false;
                    dateTimePicker1.Visible = false;
                    label5.Visible = false;
                    ActualizarPrecios.Visible = false;
                }
            }
            Total.Text = PrecioVenta().ToString();
            if (EstadoPresupuesto=="Vendido")
            {
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                DescuentoTotal.ReadOnly = true;
                Seniar.Visible = false;
                Guardar.Visible = false;
                Vender.Visible = false;
                Venta.Visible = true;
                Cancelar.Visible = false;
                BuscarCliente.Visible = false;
                CargarProductos.Visible = false;
                dateTimePicker1.Visible = false;
                label5.Visible = false;
                ActualizarPrecios.Visible = false;
            }
            else if (EstadoPresupuesto=="Cancelado")
            {
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                DescuentoTotal.ReadOnly = true;
                Seniar.Visible = false;
                Guardar.Visible = false;
                Vender.Visible = false;
                Venta.Visible = false;
                Cancelar.Visible = false;
                BuscarCliente.Visible = false;
                CargarProductos.Visible = false;
                dateTimePicker1.Visible = false;
                label5.Visible = false;
                ActualizarPrecios.Visible = false;
            }
            else if (EstadoPresupuesto=="Seniado")
            {
                Seniar.Visible = false;
            }
        }

        private void CalcularSubtotal()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[5].Value =controladorFachada.CalcularSubtotal(Convert.ToDouble(row.Cells[2].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToDouble(row.Cells[4].Value)).ToString();
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
            VControlClientes vControlClientes= new VControlClientes(IdCliente,dataGridView1,FechaVencimiento,IdPresupuesto,DescuentoTotal.Text,Observacion.Text);
            vControlClientes.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDouble(row.Cells[4].Value)>100)
                {
                    MessageBox.Show("El porcentaje de descuento debe ser menor o igual a 100 %");
                    row.Cells[4].Value = "0";
                }
            }
            CalcularSubtotal();
            Total.Text = PrecioVenta().ToString();
            this.LimpiarError();
        }

        private void DescuentoTotal_TextChanged(object sender, EventArgs e)
        {
            if (DescuentoTotal.Text != "")
            {
                Total.Text = PrecioVenta().ToString();
                if (Convert.ToDouble(DescuentoTotal.Text) > 100)
                {
                    MessageBox.Show("El porcentaje de descuento debe ser menor o igual a 100 %");
                    DescuentoTotal.Text = "";
                }
            }

        }

        private void LimpiarError()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                this.dataGridView1.Rows[row.Index].Cells[2].ErrorText = string.Empty;
                row.Cells[2].Style.BackColor = Color.Empty;
            }
        }

        private void CargarProductos_Click(object sender, EventArgs e)
        {
                this.Hide();
                VControlProducto vControlProducto = new VControlProducto(IdCliente, dataGridView1,FechaVencimiento,IdPresupuesto,DescuentoTotal.Text,Observacion.Text);
                vControlProducto.ShowDialog();
                this.Close(); 
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Tuple<int,Boolean> tupla=this.GuardarPresupuesto(sender, e);
            if(tupla.Item1!=0)
            {
                string EstadoPresupuesto = controladorFachada.BuscarPresupuesto(tupla.Item1).Estado;
                if (EstadoPresupuesto == "Seniado")
                {
                    EstadoPresupuestoLabel.Text = "Estado:  " + "Señado";
                }
                else
                {
                    EstadoPresupuestoLabel.Text = "Estado:  " + EstadoPresupuesto;
                }
            }
            if (tupla.Item2)
            {
                MessageBox.Show("Se guardó el presupuesto correctamente");
            }

        }
        /// <summary>
        /// El primer elemento de la tupla indica el idPresupuesto, el segundo indica si se guardó correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private Tuple<int,Boolean> GuardarPresupuesto(object sender, EventArgs e)
        {
            Boolean Guardado = false;
            Boolean errorCantidad = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString() =="0" && !errorCantidad)
                {
                    errorCantidad = true;
                }
            }


            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
            else if (errorCantidad)
            {
                MessageBox.Show("Hay al menos un producto que tiene cantidad 0, modifiquelo");
            }
            else if (FechaVencimiento.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe seleccionar una fecha de Vencimiento posterior a la seleccionada");
            }
            else if (DescuentoTotal.Text=="")
            {
                DescuentoTotal.Text = "0";
            }
            else
            {
                PresupuestoDTO pre = new PresupuestoDTO();
                pre.FechaGeneracion = DateTime.Now;
                pre.IdCliente = IdCliente;
                pre.FechaVencimiento = FechaVencimiento;
                pre.Id = IdPresupuesto;
                pre.Descuento = Convert.ToDouble(DescuentoTotal.Text);
                pre.Observacion = Observacion.Text;
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
                Guardado = true;
            }
            return Tuple.Create(IdPresupuesto,Guardado);
        }

        private void Seniar_Click(object sender, EventArgs e)
        {
            this.GuardarPresupuesto(sender, e);

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
            }
        }

        private void Vender_Click(object sender, EventArgs e)
        {            
            this.GuardarPresupuesto(sender, e);
            List<int> idLineas = controladorFachada.CheckStockPresupuesto(IdPresupuesto);
            string EstadoPresupuesto = controladorFachada.BuscarPresupuesto(IdPresupuesto).Estado;
            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else if (dataGridView1.Rows.Count < 1) 
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
            else if (idLineas.Count == 0 && EstadoPresupuesto!="Vendido" && EstadoPresupuesto != "Cancelado") //Hay stock de todos los productos a vender 
            {
                new VVenderPresupuesto(IdCliente, IdPresupuesto).ShowDialog();
            }
            else if (idLineas.Count>0 && EstadoPresupuesto != "Vendido" && EstadoPresupuesto != "Cancelado")
            {
                foreach (int idLinea in idLineas)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == idLinea.ToString())
                        {
                            ProductoDTO producto = controladorFachada.BuscarProducto(Convert.ToInt32(row.Cells[0].Value));
                            this.dataGridView1.Rows[row.Index].Cells[2].ErrorText = ("Hay en stock " + producto.CantidadEnStock);
                            Console.WriteLine(dataGridView1.Rows[row.Index].Cells[2].Value);
                            row.Cells[2].Style.BackColor = Color.Salmon;
                        }
                    }
                }
            }
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            new VVenderPresupuesto(IdCliente, IdPresupuesto).ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaVencimiento = dateTimePicker1.Value;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column4_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column4_KeyPress);
                }
            }
            this.LimpiarError();
        }

        private void Column4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DescuentoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public LineaPresupuestoDTO RowALineaPresupuestoDTO(DataGridViewRow row)
        {
            var linea = new LineaPresupuestoDTO()
            {
                Id = Convert.ToInt32(row.Cells[1].Value),
                NombreProducto = Convert.ToString(row.Cells[2].Value),
                Cantidad = Convert.ToInt32(row.Cells[3].Value),
                PrecioUnitario = Convert.ToDouble(row.Cells[4].Value),
                PorcentajeDescuento = Convert.ToDouble(row.Cells[5].Value),
                Subtotal = Convert.ToDouble(row.Cells[6].Value)
            };

            return linea;
        }
           
        
        private void botonExportar_Click(object sender, EventArgs e)
        {
            controladorFachada.generarPDFPresupuesto(IdPresupuesto);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlPresupuestos vControlPresupuestos = new VControlPresupuestos();
            vControlPresupuestos.ShowDialog();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            controladorFachada.CancelarPresupuesto(IdPresupuesto);
            MessageBox.Show("Se ha cancelado el Presupuesto");
        }

        private void ActualizarPrecios_Click(object sender, EventArgs e)
        {
            Tuple<int,Boolean> tupla=this.GuardarPresupuesto(sender, e);
            if(tupla.Item2)
            {
                controladorFachada.ActualizarPreciosPresupuesto(tupla.Item1);
                this.VAdministrarPresupuesto_Load(sender, e);
                MessageBox.Show("Se han actualizado los precios a los actuales");
            }
        }
    }
}

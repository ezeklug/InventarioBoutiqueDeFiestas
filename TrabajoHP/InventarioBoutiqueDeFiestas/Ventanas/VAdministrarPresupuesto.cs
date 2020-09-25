using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
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
        ControladorFachada controladorFachada = new ControladorFachada();
        public VAdministrarPresupuesto()
        {
            IdProductos = new List<int>();
            Filas = new DataGridView();
            IdCliente = 0;
            InitializeComponent();
        }
        public VAdministrarPresupuesto(int pIdCliente,List<int> idProductos, DataGridView filas)
        {
            IdCliente = pIdCliente;
            IdProductos = idProductos;
            Filas = filas;
            InitializeComponent();
        }

        private void VAdministrarPresupuesto_Load(object sender, EventArgs e)
        {
            Total.ReadOnly = true;
            Cliente.ReadOnly = true;
            if (IdCliente != 0)
            {
                Cliente.Text = controladorFachada.BuscarCliente(IdCliente);
            }
            DataGridView nuevos = new DataGridView();
            nuevos.DataSource = controladorFachada.ListarProductosPresupuesto(IdProductos);
            if(Filas.RowCount==0)
            {
                dataGridView1.DataSource = nuevos.DataSource;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
            }
            else
            {
                List<ProductoPresupuestoDTO> lista = controladorFachada.ListarProductosPresupuesto(IdProductos);
                foreach (ProductoPresupuestoDTO p in lista)
                {
                      DataTable dt2 = new DataTable();
                      dt2 = dataGridView1.DataSource as DataTable;
                      DataRow datarow;
                      datarow = dt2.NewRow(); 
                      datarow["Id"] =p.Id;
                      datarow["Nombre"] = p.Nombre;
                      datarow["Cantidad"] = p.Cantidad;
                      datarow["PrecioUnitario"] = p.PrecioUnitario;
                      datarow["PorcentajeDescuento"] = p.PorcentajeDescuento;
                      datarow["Subtotal"] = p.Subtotal;
                      //Esto se encargará de agregar la fila.
                      dt2.Rows.Add(datarow);
                }
                dataGridView1.DataSource = Filas.DataSource;

                
            }

        }

        private void CalcularSubtotal()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[5].Value =controladorFachada.CalcularSubtotal(Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[4].Value));
            }
        }

        private double PrecioVenta()
        {
            List<double> subtotales = new List<double>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                subtotales.Add(Convert.ToDouble(row.Cells[5].Value));
            }
            return controladorFachada.PrecioVenta(subtotales,Convert.ToDouble(DescuentoTotal.Text));
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
            VControlClientesPresupuesto vControlClientesPresupuesto = new VControlClientesPresupuesto(IdCliente,IdProductos,dataGridView1);
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
            if(Total.Text=="")
            {
                Total.Text = "0";
            }
            else
            {
                Total.Text = PrecioVenta().ToString();
            }
        }

        private void CargarProductos_Click(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
            else
            {
                this.Hide();
                VControlProductosPresupuesto vControlProductosPresupuesto = new VControlProductosPresupuesto(IdCliente, dataGridView1);
                vControlProductosPresupuesto.ShowDialog();
                this.Close();
            }
            
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
            else
            {
                PresupuestoDTO pre = new PresupuestoDTO();
                pre.FechaGeneracion = DateTime.Now;
                pre.IdCliente = IdCliente;
                int idPresupuesto = controladorFachada.AgregarModificarPresupuesto(pre);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    LineaPresupuestoDTO lin = new LineaPresupuestoDTO();
                    lin.Cantidad = int.Parse(row.Cells[2].Value.ToString());
                    lin.IdPresupuesto = idPresupuesto;
                    lin.IdProducto = int.Parse(row.Cells[0].Value.ToString());
                    lin.PorcentajeDescuento = double.Parse(row.Cells[4].Value.ToString());
                    lin.Subtotal = double.Parse(row.Cells[5].Value.ToString());
                    controladorFachada.AgregarLinea(lin);
                }
            }

        }

        private void Seniar_Click(object sender, EventArgs e)
        {

        }
    }
}

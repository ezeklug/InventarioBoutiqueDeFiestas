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
            dataGridView1.DataSource = controladorFachada.ListarProductosPresupuesto(IdProductos);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            Total.ReadOnly = true;
            Cliente.ReadOnly = true;
            if (IdCliente != 0)
            {
                Cliente.Text = controladorFachada.BuscarCliente(IdCliente);
            }
            if (Filas!=null)
            {
                dataGridView1.DataSource = Filas + controladorFachada.ListarProductosPresupuesto(IdProductos);

               /* foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewRow fila = Filas.Find(r => r.Cells[0].Value == row.Cells[0].Value);
                    if (fila!=null)
                    {
                        Cliente.Text = "Entre";
                        int index=dataGridView1.Rows.IndexOf(row);
                        dataGridView1[2, index] = fila.Cells[2];
                        dataGridView1[4, index] = fila.Cells[4];
                    }
                }*/
            }
            else
            {
                Filas = new DataGridView();
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
            VControlClientesPresupuesto vControlClientesPresupuesto = new VControlClientesPresupuesto(IdCliente,IdProductos,Filas);
            vControlClientesPresupuesto.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularSubtotal();
            Total.Text = PrecioVenta().ToString();
          /*  foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int index = -1;
                index = Filas.FindIndex(r => r.Cells[0].Value == row.Cells[0].Value);
                if (index !=-1)
                {
                    Filas[index] = row;
                }
                else
                {
                    Filas.Add(row);
                }
            }*/
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
            this.Hide();
            VControlProductosPresupuesto vControlProductosPresupuesto = new VControlProductosPresupuesto(IdCliente,IdProductos,Filas);
            vControlProductosPresupuesto.ShowDialog();
            this.Close();
        }

    }
}

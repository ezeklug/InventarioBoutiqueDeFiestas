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
using InventarioBoutiqueDeFiestas.Controladores;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VControlProductosPresupuesto : Form
    {
        DataGridView Filas {get;set;}
        int IdCliente { get; set; }
        DateTime FechaEvento { get; set; }
        DateTime FechaVencimiento { get; set; }
        int IdPresupuesto { get; set; }
        string Descuento { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VControlProductosPresupuesto(int pIdCliente, DataGridView filas,DateTime fechaVencimiento,int idPresupuesto,string descuento)
        {
            InitializeComponent();
            Filas = filas;
            IdCliente = pIdCliente;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
        }

        private void CargarPresupuesto_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            List<int> idProductos = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    int idProducto = Convert.ToInt32(row.Cells[1].Value);
                    idProductos.Add(idProducto);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(IdCliente,idProductos,Filas,FechaEvento,FechaVencimiento,IdPresupuesto,Descuento) ;
                vAdministrarPresupuesto.ShowDialog();
                this.Close();
            }
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VControlProductosPresupuesto_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.DataSource = controladorFachada.ListarTodosLosProductos();
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
        }
    }
}

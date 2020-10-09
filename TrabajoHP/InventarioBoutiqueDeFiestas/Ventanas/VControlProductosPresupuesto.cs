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
using InventarioBoutiqueDeFiestas.Dominio;

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

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaProducto = controladorFachada.ListarTodosLosProductos();
            try
            {
                var consultaNombre = from producto in listaProducto where producto.Nombre.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;
                var consultaDescripcion = from producto in listaProducto where producto.Descripcion.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;
                var consultaCategoria = from producto in listaProducto where producto.Categoria.Nombre.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();


                List<Producto> HelpList = new List<Producto>();
                List<Producto> distinct = (consultaNombre.Concat(consultaDescripcion).Concat(consultaCategoria)).GroupBy(p => p.Id).Select(g => g.First()).ToList();

                foreach (var producto in distinct)
                {
                    Producto prod = new Producto()
                    {
                        Id = producto.Id,
                        Nombre = producto.Nombre,
                        Descripcion = producto.Descripcion,
                        CantidadEnStock = producto.CantidadEnStock,
                        Categoria = producto.Categoria,
                        PorcentajeDeGanancia = producto.PorcentajeDeGanancia,
                        Activo = producto.Activo,
                        PrecioDeCompra = producto.PrecioDeCompra,
                        StockMinimo = producto.StockMinimo,



                    };
                    HelpList.Add(prod);
                }

                dataGridView1.DataSource = HelpList;
                dataGridView1.Columns[9].Visible = false;

            }


            catch
            {
                throw;
            }
        }
    }
}

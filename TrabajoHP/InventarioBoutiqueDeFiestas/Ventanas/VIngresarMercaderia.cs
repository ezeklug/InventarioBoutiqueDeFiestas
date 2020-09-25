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
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VIngresarMercaderia : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        List<int> Productos { get; set; }
        DataGridView Filas { get; set; }

        public VIngresarMercaderia(List<int> productos, DataGridView filas)
        {
            Productos = productos;
            Filas = filas;
            InitializeComponent();

        }

        private void Listo_Click(object sender, EventArgs e)
        {
            List<ProductoDTO> ListaProductoDTO = new List<ProductoDTO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ProductoDTO unProducto = controladorFachada.BuscarProducto((Convert.ToInt32(row.Cells[0].Value)));
                unProducto.CantidadEnStock += Convert.ToInt32(row.Cells[2].Value);
                unProducto.PrecioDeCompra = Convert.ToDouble(row.Cells[3].Value);
                if (!(row.Cells[4].Value == null))
                {
                    LoteDTO unLote = new LoteDTO();
                    unLote.CantidadProductos = Convert.ToInt32(row.Cells[2].Value);
                    unLote.FechaCompra = DateTime.Now; // ARREGLAME
                    unLote.FechaVencimiento = Convert.ToDateTime(row.Cells[4].Value);
                    unLote.Vencido = false;
                    unLote.IdProducto = unProducto.Id;
                    controladorFachada.GuardarLote(unLote);
                   
                }
                ListaProductoDTO.Add(unProducto);

            }
            controladorFachada.IngresoMercarderias(ListaProductoDTO);
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
            this.Close();


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto(dataGridView1);
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void VIngresarMercaderia_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioCompra", "Precio de Compra");
            dataGridView1.Columns.Add("FechaVencimiento", "Fecha de Vencimiento dd/mm/aaaa");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            if (Filas.RowCount != 0)
            {
                foreach (DataGridViewRow row in Filas.Rows)
                {
                    string[] r = new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString() };
                    dataGridView1.Rows.Add(r);
                }
            }
            if (Productos != null)
            {
                Boolean existe = false;
                foreach (ProductoPresupuestoDTO p in controladorFachada.ListarProductosPresupuesto(Productos))
                {
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == p.Id.ToString())
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        string[] row = new string[] { p.Id.ToString(), p.Nombre, "0", "0", "" };
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }
    }
}

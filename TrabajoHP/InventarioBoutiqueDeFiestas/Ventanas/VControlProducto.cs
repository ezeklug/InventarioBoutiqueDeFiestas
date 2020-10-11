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
using InventarioBoutiqueDeFiestas.DTO;
namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VControlProducto : Form
    {
        DataGridView Filas { get; set; }
        int IdCliente { get; set; }
        DateTime FechaEvento { get; set; }
        DateTime FechaVencimiento { get; set; }
        int IdPresupuesto { get; set; }
        string Descuento { get; set; }
        ControladorFachada controladorFachada = new ControladorFachada();
        public VControlProducto(int pIdCliente, DataGridView filas, DateTime fechaVencimiento, int idPresupuesto, string descuento)
        {
            InitializeComponent();
            Filas = filas;
            IdCliente = pIdCliente;
            FechaVencimiento = fechaVencimiento;
            IdPresupuesto = idPresupuesto;
            Descuento = descuento;
        }

        public static VControlProducto instancia;
        public VControlProducto()
        {
            Descuento = "notengo";
            Filas = new DataGridView();
            InitializeComponent();
            instancia = this;
        }
        public VControlProducto(DataGridView filas)
        {
            Descuento = "notengo";
            Filas = filas;
            InitializeComponent();
            instancia = this;
        }

        public void UpdateTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = controladorFachada.ListarTodosLosProductos();
            dataGridView1.Columns[9].Visible = false;
            

        }
  
        private void Agregar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                }
            }
            if (seleccion)
            {
                MessageBox.Show("No puede agregar con un elemento seleccionado");
            }
            else
            {
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto();
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            DataGridViewRow row1 = new DataGridViewRow();
            ProductoDTO productoDTO = new ProductoDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    cont++;
                    row1 = row;
                }
            }
            if (cont==1)
            {
                productoDTO.Id = Convert.ToInt32(row1.Cells[1].Value);
                productoDTO.Nombre = row1.Cells[2].Value.ToString();
                productoDTO.Descripcion = row1.Cells[3].Value.ToString();
                productoDTO.StockMinimo = Convert.ToInt32(row1.Cells[4].Value);
                productoDTO.CantidadEnStock = Convert.ToInt32(row1.Cells[5].Value);
                productoDTO.PorcentajeDeGanancia = Convert.ToDouble(row1.Cells[6].Value);
                productoDTO.PrecioDeCompra = Convert.ToDouble(row1.Cells[7].Value);
                productoDTO.Activo = Convert.ToBoolean(row1.Cells[9].Value);
                this.Hide();
                VAgregarModificarProducto vAgregarModificarProducto = new VAgregarModificarProducto(productoDTO);
                vAgregarModificarProducto.ShowDialog();
                this.Close();
            }
            else if (cont>1)
            {
                MessageBox.Show("Seleccione solo un producto");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Cb"].Value = false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void IngresoMercaderia_Click(object sender, EventArgs e)
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
                VIngresarMercaderia vIngresarMercaderia = new VIngresarMercaderia(idProductos,Filas);
                vIngresarMercaderia.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void VControlProducto_Load(object sender, EventArgs e)
        {
            Listas.Items.Add("Todos");
            Listas.Items.Add("Por debajo stock mínimo");
            Listas.Items.Add("Más vendidos");
            if (Descuento== "notengo")
            {
                CargarPresupuesto.Visible = false;
                IngresoMercaderia.Visible = true;
                PorcentajeIncremento.Visible = true;
                Categoria.Visible = true;
                botonStockMinimo.Visible = true;
                Agregar.Visible = true;
                Modificar.Visible = true;
                Eliminar.Visible = true;
            }
            else
            {
                CargarPresupuesto.Visible = true;
                IngresoMercaderia.Visible = false;
                PorcentajeIncremento.Visible = false;
                Categoria.Visible = false;
                botonStockMinimo.Visible = false;
                Agregar.Visible = false;
                Modificar.Visible = false;
                Eliminar.Visible = false;
            }
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.ValueType = typeof(bool);
            cb.Name = "Cb";
            cb.HeaderText = "";
            dataGridView1.Columns.Add(cb);
            dataGridView1.DataSource = controladorFachada.ListarTodosLosProductos();
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 35;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 95;
            dataGridView1.Columns[6].Width = 125;
            dataGridView1.Columns[7].Width = 95;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[12].Width = 90;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void PorcentajeIncremento_Click(object sender, EventArgs e)
        {
           // this.Hide();
            VPorcentajeIncremento vPorcentajeIncremento = new VPorcentajeIncremento();
            vPorcentajeIncremento.ShowDialog();
            //this.Close();
        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
           this.Hide();
            VControlCategoria vCategoria= new VControlCategoria();
            vCategoria.ShowDialog();
           this.Close();
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            List<ProductoDTO> listaProducto = new List<ProductoDTO>();
            if (Listas.Text == Listas.Items[0].ToString())
            {
                //Todos
                listaProducto = controladorFachada.ListarTodosLosProductos();
            }
            else if (Listas.Text == Listas.Items[1].ToString())
            {
                //Debajo stock mínimo
                listaProducto = controladorFachada.ListarProductosBajoStockMinimo();
            }
            else
            {
                //Más vendidos
                listaProducto = controladorFachada.ListarProductosMasVendidos().Keys.ToList();
            }
            try
            {
                var consultaNombre = from producto in listaProducto where producto.Nombre.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;
                var consultaDescripcion = from producto in listaProducto where producto.Descripcion.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;
                var consultaCategoria = from producto in listaProducto where producto.CategoriaProductoDTO.Nombre.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select producto;

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();


                List<ProductoDTO> HelpList = new List<ProductoDTO>();
                List<ProductoDTO> distinct = (consultaNombre.Concat(consultaDescripcion).Concat(consultaCategoria)).GroupBy(p => p.Id).Select(g => g.First()).ToList();

                foreach (var producto in distinct)
                {
                    ProductoDTO prod = new ProductoDTO()
                    {
                        Id = producto.Id,
                        Nombre = producto.Nombre,
                        Descripcion = producto.Descripcion,
                        CantidadEnStock = producto.CantidadEnStock,
                        CategoriaProductoDTO = producto.CategoriaProductoDTO,
                        PorcentajeDeGanancia= producto.PorcentajeDeGanancia,
                        Activo = producto.Activo,
                        PrecioDeCompra= producto.PrecioDeCompra,
                        StockMinimo= producto.StockMinimo,
                                             

                        
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
                VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(IdCliente, idProductos, Filas, FechaEvento, FechaVencimiento, IdPresupuesto, Descuento);
                vAdministrarPresupuesto.ShowDialog();
                this.Close();
            }
        }

        private void botonStockMinimo_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
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
                foreach (int idProducto in idProductos)
                {
                    controladorFachada.BajaProducto(idProducto);
                }
                MessageBox.Show("Se dieron de baja el/los producto/s seleccionado/s");
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un producto");
            }
        }

        private void Listas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listas.Text==Listas.Items[0].ToString())
            {
                //Todos
                dataGridView1.DataSource = controladorFachada.ListarTodosLosProductos();
            }
            else if (Listas.Text == Listas.Items[1].ToString())
            {
                //Debajo stock mínimo
                dataGridView1.DataSource = controladorFachada.ListarProductosBajoStockMinimo();
            }
            else
            {
                //Más vendidos
                dataGridView1.DataSource = controladorFachada.ListarProductosMasVendidos();
            }
        }
    }
}

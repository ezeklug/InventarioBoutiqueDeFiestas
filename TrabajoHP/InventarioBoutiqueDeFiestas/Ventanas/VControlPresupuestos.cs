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
    public partial class VControlPresupuestos : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        public VControlPresupuestos()
        {
            InitializeComponent();
        }

        private void VControlPresupuestos_Load(object sender, EventArgs e)
        {
            Listas.Items.Add("Todos");
            Listas.Items.Add("Presupuestados");
            Listas.Items.Add("Señados");
            Listas.Items.Add("Vendidos");
            Listas.Items.Add("Cancelados");
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            
            dataGridView1.DataSource = controladorFachada.ListarPresupuesto();
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto();
            vAdministrarPresupuesto.ShowDialog();
            this.Close();
        }

        private void Administrar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            PresupuestoDTO presupuestoDTO = new PresupuestoDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    presupuestoDTO.Id = Convert.ToInt32(row.Cells[1].Value);
                    presupuestoDTO.FechaGeneracion = Convert.ToDateTime(row.Cells[2].Value);
                    presupuestoDTO.FechaVencimiento = Convert.ToDateTime(row.Cells[3].Value);
                    presupuestoDTO.IdCliente = Convert.ToInt32(row.Cells[4].Value);
                    presupuestoDTO.Estado = row.Cells[5].Value.ToString();
                    presupuestoDTO.Descuento = Convert.ToDouble(row.Cells[7].Value);
                }
            }
            if (seleccion)
            {
                this.Hide();
                VAdministrarPresupuesto vAdministrarPresupuesto = new VAdministrarPresupuesto(presupuestoDTO);
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
            var columnIndex = 0;
            if (e.ColumnIndex == columnIndex)
            {
                var isChecked = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[e.ColumnIndex].Value))
                    {
                        isChecked = true;
                    }
                }
                if (isChecked)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells[columnIndex].Value = !isChecked;
                        }
                    }
                }
            }
        }

        private void Listas_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PresupuestoDTO> listaPresupuesto = new List<PresupuestoDTO>();
            if (Listas.Text == Listas.Items[0].ToString())
            {
                //Todos
                dataGridView1.DataSource = controladorFachada.ListarPresupuesto();

            }
            else if (Listas.Text == Listas.Items[1].ToString())
            {
                //Presupuestados
                dataGridView1.DataSource = controladorFachada.ListarPresupuestoPresupuestados();

            }
            else if (Listas.Text == Listas.Items[2].ToString())
            {
                //Señados
                dataGridView1.DataSource = controladorFachada.ListarPresupuestoSeniados();

            }
            else if (Listas.Text == Listas.Items[3].ToString())
            {
                //Vendidos
                dataGridView1.DataSource = controladorFachada.ListarPresupuestoVendidos();

            }
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            List<PresupuestoDTO> listaPresupuesto = new List<PresupuestoDTO>();
            if (Listas.Text == Listas.Items[0].ToString())
            {
                //Todos
                listaPresupuesto = controladorFachada.ListarPresupuesto();

            }
            else if (Listas.Text == Listas.Items[1].ToString())
            {
                //Presupuestados
                listaPresupuesto = controladorFachada.ListarPresupuestoPresupuestados();

            }
            else if (Listas.Text == Listas.Items[2].ToString())
            {
                //Señados
                listaPresupuesto = controladorFachada.ListarPresupuestoSeniados();

            }
            else if (Listas.Text == Listas.Items[3].ToString())
            {
                //Vendidos
                listaPresupuesto = controladorFachada.ListarPresupuestoVendidos();

            }
            else
            {
                //Cancelados
                listaPresupuesto = controladorFachada.ListarPresupuestoCancelados();

            }
           try
            {
                var consultaNombreyApellido = from presupuesto in listaPresupuesto where presupuesto.Cliente.ToLower().StartsWith(this.buscar.Text.Trim().ToLower()) select presupuesto;
                var consultaFechaCreacion= from presupuesto in listaPresupuesto where presupuesto.FechaGeneracion.ToString().StartsWith(this.buscar.Text.Trim().ToLower()) select presupuesto;
               

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();


                List<PresupuestoDTO> HelpList = new List<PresupuestoDTO>();
                List<PresupuestoDTO> distinct = (consultaNombreyApellido.Concat(consultaFechaCreacion)).GroupBy(p => p.Id).Select(g => g.First()).ToList();

                foreach (var presupuesto in distinct)
                {
                    PresupuestoDTO pres = new PresupuestoDTO()
                    {
                        Id = presupuesto.Id,
                        FechaGeneracion= presupuesto.FechaGeneracion,
                        Cliente= presupuesto.Cliente,
                        Descuento= presupuesto.Descuento,
                        Estado= presupuesto.Estado,
                        FechaVencimiento= presupuesto.FechaVencimiento,
                        IdCliente= presupuesto.IdCliente
                    };
                    HelpList.Add(pres);
                }

               dataGridView1.DataSource = HelpList;
                dataGridView1.Columns[7].Visible = false;
                /*dataGridView1.Columns[0].Width = 25; //CB
               dataGridView1.Columns[1].Width = 35; //ID
               dataGridView1.Columns[9].Visible = false; //No se ve la columna ACTIVO
               dataGridView1.Columns[11].Visible = false; //No se ve la columna CATEGORIAPRODUCTODTO
               dataGridView1.Columns[10].Visible = false; //No se ve la columna IDCATEGORIAPRODUCTO
               dataGridView1.Columns[8].Visible = false; //No se ve la columna PrecioVenta
              */
            }


            catch
            {
                throw;
            }
        }
    }
}


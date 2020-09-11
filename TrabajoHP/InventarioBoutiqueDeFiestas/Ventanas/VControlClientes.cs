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
    public partial class VControlClientes : Form
    {
        ControladorFachada controladorfachada = new ControladorFachada();
        public VControlClientes()
        {
            InitializeComponent();
        }

        private void VControlClientes_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Cb";
            dgvCmb.HeaderText = "";
            dataGridView1.Columns.Add(dgvCmb);
            dataGridView1.DataSource = controladorfachada.ListarClientes();
            //   dataGridView1.DataSource = lista;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            ClienteDTO clienteDTO = new ClienteDTO();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    clienteDTO.Id = Convert.ToInt32(row.Cells[1].Value);
                    clienteDTO.Nombre = row.Cells[2].Value.ToString();
                    clienteDTO.Apellido= row.Cells[3].Value.ToString();
                    clienteDTO.Direccion = row.Cells[4].Value.ToString();
                    clienteDTO.Telefono = row.Cells[5].Value.ToString();
                    clienteDTO.Email = row.Cells[6].Value.ToString();
                    clienteDTO.Activo = Convert.ToBoolean(row.Cells[7].Value);
                }
            }
            if(seleccion)
            {
                this.Hide();
                VAgregarModificarCliente vAgregarModificarCliente = new VAgregarModificarCliente(clienteDTO);
                vAgregarModificarCliente.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }

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
            if(seleccion)
            {
                MessageBox.Show("No puede agregar con un elemento seleccionado");
            }
            else
            {
                this.Hide();
                VAgregarModificarCliente vAgregarModificarCliente = new VAgregarModificarCliente();
                vAgregarModificarCliente.ShowDialog();
                this.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            int idCliente=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    idCliente = Convert.ToInt32(row.Cells[1].Value);
                }
            }
            if (seleccion)
            {
                Boolean baja=controladorfachada.BajaCliente(idCliente);
                if(baja)
                {
                    MessageBox.Show("Usuario dado de baja con éxito");
                }
                else
                {
                    MessageBox.Show("El usuario ya se encontraba dado de baja");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            Boolean seleccion = false;
            int idCliente = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                if (isSelected)
                {
                    seleccion = true;
                    idCliente = Convert.ToInt32(row.Cells[1].Value);
                }
            }
            if (seleccion)
            {
                Boolean alta = controladorfachada.AltaCliente(idCliente);
                if (alta)
                {
                    MessageBox.Show("Usuario dado de alta con éxito");
                }
                else
                {
                    MessageBox.Show("El usuario ya se encontraba activo");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }
    }
}

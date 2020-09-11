﻿using System;
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
        ControladorFachada controladorfachada =new ControladorFachada();
        public VControlClientes()
        {
            InitializeComponent();
        }

        private void VControlClientes_Load(object sender, EventArgs e)
        {



            /*  List<Cliente> lista = new List<Cliente>();
               Cliente cli = new Cliente("Ezequiel", "Klug", "Callefalsa123", "1515151515", "ezepiyo@gmail.com");
               Cliente cli2 = new Cliente("Federico", "Lombardi", "callefalsa456", "1232414123", "nose");
               lista.Add(cli);
               lista.Add(cli2);*/
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Cb";
                dgvCmb.HeaderText = "";
                dataGridView1.Columns.Add(dgvCmb);
                dataGridView1.DataSource = controladorfachada.ListarClientes();
         //   dataGridView1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              //  var selectedPerson = dataGridView1.SelectedRows[0].DataBoundItem as ClienteDTO;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Cb"].Value);
                    if (isSelected)
                    {
                    this.Nombre.Text = "Holaquetal";
                    }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 0;
            if (e.ColumnIndex == columnIndex)
            {
                var isChecked=false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(Convert.ToBoolean(row.Cells[e.ColumnIndex].Value))
                    {
                        isChecked = true;
                    }
                }
                this.Nombre.Text = isChecked.ToString(); 
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
    }
}

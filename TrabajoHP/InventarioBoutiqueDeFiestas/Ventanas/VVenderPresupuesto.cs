﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VVenderPresupuesto : Form
    {
        int IdCliente { get; set; }
        int IdPresupuesto { get; set; }
        public VVenderPresupuesto(int pIdCliente, int pPresupuestoId)
        {
            IdCliente = pIdCliente;
            IdPresupuesto = pPresupuestoId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VVenderPresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}

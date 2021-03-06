﻿namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VVenderPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.TotalVenta = new System.Windows.Forms.Label();
            this.Vender = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.Label();
            this.MontoVenta = new System.Windows.Forms.Label();
            this.VendidoTexto = new System.Windows.Forms.Label();
            this.TotalSenia = new System.Windows.Forms.Label();
            this.TotalPagar = new System.Windows.Forms.Label();
            this.MontoSenia = new System.Windows.Forms.Label();
            this.MontoPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(239, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(350, 39);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Vender Presupuesto";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(68, 114);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(51, 17);
            this.Cliente.TabIndex = 11;
            this.Cliente.Text = "Cliente";
            // 
            // TotalVenta
            // 
            this.TotalVenta.AutoSize = true;
            this.TotalVenta.Location = new System.Drawing.Point(67, 159);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(96, 17);
            this.TotalVenta.TabIndex = 12;
            this.TotalVenta.Text = "Total de Venta";
            // 
            // Vender
            // 
            this.Vender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Vender.Cursor = System.Windows.Forms.Cursors.Default;
            this.Vender.FlatAppearance.BorderSize = 0;
            this.Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vender.Location = new System.Drawing.Point(71, 434);
            this.Vender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(87, 30);
            this.Vender.TabIndex = 15;
            this.Vender.Text = "Vender";
            this.Vender.UseVisualStyleBackColor = false;
            this.Vender.Click += new System.EventHandler(this.Vender_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(800, 434);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(87, 30);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(466, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 319);
            this.dataGridView1.TabIndex = 17;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Location = new System.Drawing.Point(191, 114);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(110, 17);
            this.NombreCliente.TabIndex = 18;
            this.NombreCliente.Text = "nombreyApellido";
            // 
            // MontoVenta
            // 
            this.MontoVenta.AutoSize = true;
            this.MontoVenta.Location = new System.Drawing.Point(191, 159);
            this.MontoVenta.Name = "MontoVenta";
            this.MontoVenta.Size = new System.Drawing.Size(60, 17);
            this.MontoVenta.TabIndex = 19;
            this.MontoVenta.Text = "$0000.00";
            // 
            // VendidoTexto
            // 
            this.VendidoTexto.AutoSize = true;
            this.VendidoTexto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendidoTexto.ForeColor = System.Drawing.Color.Black;
            this.VendidoTexto.Location = new System.Drawing.Point(190, 438);
            this.VendidoTexto.Name = "VendidoTexto";
            this.VendidoTexto.Size = new System.Drawing.Size(207, 20);
            this.VendidoTexto.TabIndex = 24;
            this.VendidoTexto.Text = "Se ha generado una venta";
            this.VendidoTexto.Visible = false;
            // 
            // TotalSenia
            // 
            this.TotalSenia.AutoSize = true;
            this.TotalSenia.Location = new System.Drawing.Point(68, 205);
            this.TotalSenia.Name = "TotalSenia";
            this.TotalSenia.Size = new System.Drawing.Size(97, 17);
            this.TotalSenia.TabIndex = 25;
            this.TotalSenia.Text = "Monto de seña";
            // 
            // TotalPagar
            // 
            this.TotalPagar.AutoSize = true;
            this.TotalPagar.Location = new System.Drawing.Point(67, 252);
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Size = new System.Drawing.Size(86, 17);
            this.TotalPagar.TabIndex = 26;
            this.TotalPagar.Text = "Total a Pagar";
            // 
            // MontoSenia
            // 
            this.MontoSenia.AutoSize = true;
            this.MontoSenia.Location = new System.Drawing.Point(191, 205);
            this.MontoSenia.Name = "MontoSenia";
            this.MontoSenia.Size = new System.Drawing.Size(60, 17);
            this.MontoSenia.TabIndex = 27;
            this.MontoSenia.Text = "$0000.00";
            // 
            // MontoPagar
            // 
            this.MontoPagar.AutoSize = true;
            this.MontoPagar.Location = new System.Drawing.Point(191, 252);
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.Size = new System.Drawing.Size(60, 17);
            this.MontoPagar.TabIndex = 28;
            this.MontoPagar.Text = "$0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(603, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Productos que vencen";
            this.label1.Visible = false;
            // 
            // VVenderPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontoPagar);
            this.Controls.Add(this.MontoSenia);
            this.Controls.Add(this.TotalPagar);
            this.Controls.Add(this.TotalSenia);
            this.Controls.Add(this.VendidoTexto);
            this.Controls.Add(this.MontoVenta);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VVenderPresupuesto";
            this.Text = "VVenderPresupuesto";
            this.Load += new System.EventHandler(this.VVenderPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label TotalVenta;
        private System.Windows.Forms.Button Vender;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NombreCliente;
        private System.Windows.Forms.Label MontoVenta;
        private System.Windows.Forms.Label VendidoTexto;
        private System.Windows.Forms.Label TotalSenia;
        private System.Windows.Forms.Label TotalPagar;
        private System.Windows.Forms.Label MontoSenia;
        private System.Windows.Forms.Label MontoPagar;
        private System.Windows.Forms.Label label1;
    }
}
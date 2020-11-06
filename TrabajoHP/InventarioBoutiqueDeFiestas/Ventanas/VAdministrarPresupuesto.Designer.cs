using System;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VAdministrarPresupuesto
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DescuentoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Seniar = new System.Windows.Forms.Button();
            this.Vender = new System.Windows.Forms.Button();
            this.CargarProductos = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.botonExportar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.EstadoPresupuestoLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Observacion = new System.Windows.Forms.TextBox();
            this.ActualizarPrecios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1239, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Presupuesto";
            // 
            // Cliente
            // 
            this.Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(96, 743);
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Size = new System.Drawing.Size(144, 22);
            this.Cliente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente: ";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuscarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BuscarCliente.FlatAppearance.BorderSize = 0;
            this.BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BuscarCliente.Location = new System.Drawing.Point(61, 771);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(113, 23);
            this.BuscarCliente.TabIndex = 17;
            this.BuscarCliente.Text = "Buscar Cliente";
            this.BuscarCliente.UseVisualStyleBackColor = false;
            this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 746);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descuento al total %";
            // 
            // DescuentoTotal
            // 
            this.DescuentoTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DescuentoTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTotal.Location = new System.Drawing.Point(607, 745);
            this.DescuentoTotal.Name = "DescuentoTotal";
            this.DescuentoTotal.Size = new System.Drawing.Size(34, 22);
            this.DescuentoTotal.TabIndex = 19;
            this.DescuentoTotal.Text = "0";
            this.DescuentoTotal.TextChanged += new System.EventHandler(this.DescuentoTotal_TextChanged);
            this.DescuentoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(928, 745);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total: $";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(988, 742);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(106, 22);
            this.Total.TabIndex = 21;
            // 
            // Guardar
            // 
            this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Guardar.Location = new System.Drawing.Point(918, 771);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 22;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Seniar
            // 
            this.Seniar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Seniar.AutoSize = true;
            this.Seniar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Seniar.FlatAppearance.BorderSize = 0;
            this.Seniar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seniar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seniar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Seniar.Location = new System.Drawing.Point(728, 769);
            this.Seniar.Name = "Seniar";
            this.Seniar.Size = new System.Drawing.Size(69, 27);
            this.Seniar.TabIndex = 23;
            this.Seniar.Text = "Señar";
            this.Seniar.UseVisualStyleBackColor = false;
            this.Seniar.Click += new System.EventHandler(this.Seniar_Click);
            // 
            // Vender
            // 
            this.Vender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Vender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Vender.FlatAppearance.BorderSize = 0;
            this.Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Vender.Location = new System.Drawing.Point(819, 771);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(75, 23);
            this.Vender.TabIndex = 24;
            this.Vender.Text = "Vender";
            this.Vender.UseVisualStyleBackColor = false;
            this.Vender.Click += new System.EventHandler(this.Vender_Click);
            // 
            // CargarProductos
            // 
            this.CargarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CargarProductos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CargarProductos.FlatAppearance.BorderSize = 0;
            this.CargarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CargarProductos.Location = new System.Drawing.Point(1132, 131);
            this.CargarProductos.Name = "CargarProductos";
            this.CargarProductos.Size = new System.Drawing.Size(123, 23);
            this.CargarProductos.TabIndex = 25;
            this.CargarProductos.Text = "Cargar Productos";
            this.CargarProductos.UseVisualStyleBackColor = false;
            this.CargarProductos.Click += new System.EventHandler(this.CargarProductos_Click);
            // 
            // Volver
            // 
            this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Volver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Volver.FlatAppearance.BorderSize = 0;
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Volver.Location = new System.Drawing.Point(1123, 771);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 26;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 21);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2020, 9, 29, 15, 35, 11, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Principal.FlatAppearance.BorderSize = 0;
            this.Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
            this.Principal.Location = new System.Drawing.Point(38, 9);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(74, 74);
            this.Principal.TabIndex = 14;
            this.Principal.UseVisualStyleBackColor = false;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // botonExportar
            // 
            this.botonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonExportar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonExportar.FlatAppearance.BorderSize = 0;
            this.botonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonExportar.Location = new System.Drawing.Point(474, 771);
            this.botonExportar.Name = "botonExportar";
            this.botonExportar.Size = new System.Drawing.Size(116, 23);
            this.botonExportar.TabIndex = 37;
            this.botonExportar.Text = "Exportar a pdf";
            this.botonExportar.UseVisualStyleBackColor = false;
            this.botonExportar.Click += new System.EventHandler(this.botonExportar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(1019, 771);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 38;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Venta
            // 
            this.Venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Venta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Venta.FlatAppearance.BorderSize = 0;
            this.Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Venta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Venta.Location = new System.Drawing.Point(819, 771);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(75, 23);
            this.Venta.TabIndex = 39;
            this.Venta.Text = "Venta";
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // EstadoPresupuestoLabel
            // 
            this.EstadoPresupuestoLabel.AutoSize = true;
            this.EstadoPresupuestoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoPresupuestoLabel.Location = new System.Drawing.Point(428, 127);
            this.EstadoPresupuestoLabel.Name = "EstadoPresupuestoLabel";
            this.EstadoPresupuestoLabel.Size = new System.Drawing.Size(183, 20);
            this.EstadoPresupuestoLabel.TabIndex = 40;
            this.EstadoPresupuestoLabel.Text = "Estado de Presupuesto: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(747, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 20);
            this.label.TabIndex = 41;
            this.label.Text = "Observación: ";
            // 
            // Observacion
            // 
            this.Observacion.Location = new System.Drawing.Point(866, 70);
            this.Observacion.Multiline = true;
            this.Observacion.Name = "Observacion";
            this.Observacion.Size = new System.Drawing.Size(211, 84);
            this.Observacion.TabIndex = 42;
            // 
            // ActualizarPrecios
            // 
            this.ActualizarPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualizarPrecios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ActualizarPrecios.FlatAppearance.BorderSize = 0;
            this.ActualizarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarPrecios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarPrecios.Location = new System.Drawing.Point(309, 771);
            this.ActualizarPrecios.Name = "ActualizarPrecios";
            this.ActualizarPrecios.Size = new System.Drawing.Size(139, 23);
            this.ActualizarPrecios.TabIndex = 43;
            this.ActualizarPrecios.Text = "Actualizar precios";
            this.ActualizarPrecios.UseVisualStyleBackColor = false;
            this.ActualizarPrecios.Click += new System.EventHandler(this.ActualizarPrecios_Click);
            // 
            // VAdministrarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1353, 831);
            this.Controls.Add(this.ActualizarPrecios);
            this.Controls.Add(this.Observacion);
            this.Controls.Add(this.label);
            this.Controls.Add(this.EstadoPresupuestoLabel);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.botonExportar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.CargarProductos);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.Seniar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescuentoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VAdministrarPresupuesto";
            this.Text = "VAdministrarPresupuesto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VAdministrarPresupuesto_FormClosing);
            this.Load += new System.EventHandler(this.VAdministrarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Estado_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FechaEvento_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FechaEntrega_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FechaVencimiento_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescuentoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Seniar;
        private System.Windows.Forms.Button Vender;
        private System.Windows.Forms.Button CargarProductos;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button botonExportar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label EstadoPresupuestoLabel;
        private System.Windows.Forms.TextBox Observacion;
        private System.Windows.Forms.Button ActualizarPrecios;
    }
}
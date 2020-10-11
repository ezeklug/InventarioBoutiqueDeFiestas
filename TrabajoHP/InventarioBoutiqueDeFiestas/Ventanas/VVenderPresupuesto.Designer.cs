namespace InventarioBoutiqueDeFiestas.Ventanas
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
            this.Monto = new System.Windows.Forms.Label();
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
            this.Cliente.Location = new System.Drawing.Point(91, 114);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(51, 17);
            this.Cliente.TabIndex = 11;
            this.Cliente.Text = "Cliente";
            // 
            // TotalVenta
            // 
            this.TotalVenta.AutoSize = true;
            this.TotalVenta.Location = new System.Drawing.Point(77, 186);
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
            this.Vender.Location = new System.Drawing.Point(62, 485);
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
            this.Cancelar.Location = new System.Drawing.Point(751, 485);
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
            this.dataGridView1.Location = new System.Drawing.Point(351, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 307);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Location = new System.Drawing.Point(191, 114);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(45, 17);
            this.NombreCliente.TabIndex = 18;
            this.NombreCliente.Text = "label2";
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(191, 186);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(45, 17);
            this.Monto.TabIndex = 19;
            this.Monto.Text = "label3";
            // 
            // VVenderPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.Monto);
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
        private System.Windows.Forms.Label Monto;
    }
}
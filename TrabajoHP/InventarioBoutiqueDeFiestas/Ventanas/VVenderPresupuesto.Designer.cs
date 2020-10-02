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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Principal = new System.Windows.Forms.Button();
            this.NombreCliente = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(205, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(350, 39);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Vender Presupuesto";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(76, 112);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 11;
            this.Cliente.Text = "Cliente";
            // 
            // TotalVenta
            // 
            this.TotalVenta.AutoSize = true;
            this.TotalVenta.Location = new System.Drawing.Point(64, 167);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(77, 13);
            this.TotalVenta.TabIndex = 12;
            this.TotalVenta.Text = "Total de Venta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 235);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.UTN_logo__1_;
            this.Principal.Location = new System.Drawing.Point(44, 3);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 9;
            this.Principal.TabStop = false;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Location = new System.Drawing.Point(162, 112);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(35, 13);
            this.NombreCliente.TabIndex = 18;
            this.NombreCliente.Text = "label2";            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(162, 167);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(35, 13);
            this.Monto.TabIndex = 19;
            this.Monto.Text = "label3";
            // 
            // VVenderPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Principal);
            this.Name = "VVenderPresupuesto";
            this.Text = "VVenderPresupuesto";
            this.Load += new System.EventHandler(this.VVenderPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label TotalVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NombreCliente;
        private System.Windows.Forms.Label Monto;
    }
}
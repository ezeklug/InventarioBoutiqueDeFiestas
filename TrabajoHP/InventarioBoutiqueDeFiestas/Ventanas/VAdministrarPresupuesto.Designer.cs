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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DescuentoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Seniar = new System.Windows.Forms.Button();
            this.Vender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Presupuesto";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.UTN_logo__1_;
            this.Principal.Location = new System.Drawing.Point(38, 9);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 14;
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(96, 404);
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Size = new System.Drawing.Size(144, 20);
            this.Cliente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente: ";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Location = new System.Drawing.Point(64, 435);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(113, 23);
            this.BuscarCliente.TabIndex = 17;
            this.BuscarCliente.Text = "Buscar Cliente";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descuento al total %";
            // 
            // DescuentoTotal
            // 
            this.DescuentoTotal.Location = new System.Drawing.Point(393, 404);
            this.DescuentoTotal.Name = "DescuentoTotal";
            this.DescuentoTotal.Size = new System.Drawing.Size(34, 20);
            this.DescuentoTotal.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total: $";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(517, 435);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 22;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Seniar
            // 
            this.Seniar.Location = new System.Drawing.Point(623, 435);
            this.Seniar.Name = "Seniar";
            this.Seniar.Size = new System.Drawing.Size(75, 23);
            this.Seniar.TabIndex = 23;
            this.Seniar.Text = "Señar";
            this.Seniar.UseVisualStyleBackColor = true;
            // 
            // Vender
            // 
            this.Vender.Location = new System.Drawing.Point(722, 435);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(75, 23);
            this.Vender.TabIndex = 24;
            this.Vender.Text = "Vender";
            this.Vender.UseVisualStyleBackColor = true;
            // 
            // VAdministrarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 470);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.Seniar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox1);
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
            this.Load += new System.EventHandler(this.VAdministrarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Seniar;
        private System.Windows.Forms.Button Vender;
    }
}
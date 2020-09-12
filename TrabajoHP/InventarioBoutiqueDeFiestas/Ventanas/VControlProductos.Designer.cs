namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.IngresoMercaderia = new System.Windows.Forms.Button();
            this.PorcentajeIncremento = new System.Windows.Forms.Button();
            this.AgregarCategoria = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 268);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(28, 367);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(138, 367);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 10;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // IngresoMercaderia
            // 
            this.IngresoMercaderia.Location = new System.Drawing.Point(260, 367);
            this.IngresoMercaderia.Name = "IngresoMercaderia";
            this.IngresoMercaderia.Size = new System.Drawing.Size(116, 23);
            this.IngresoMercaderia.TabIndex = 11;
            this.IngresoMercaderia.Text = "Ingresar Mercadería";
            this.IngresoMercaderia.UseVisualStyleBackColor = true;
            this.IngresoMercaderia.Click += new System.EventHandler(this.IngresoMercaderia_Click);
            // 
            // PorcentajeIncremento
            // 
            this.PorcentajeIncremento.Location = new System.Drawing.Point(417, 367);
            this.PorcentajeIncremento.Name = "PorcentajeIncremento";
            this.PorcentajeIncremento.Size = new System.Drawing.Size(133, 23);
            this.PorcentajeIncremento.TabIndex = 12;
            this.PorcentajeIncremento.Text = "Porcentaje Incremento";
            this.PorcentajeIncremento.UseVisualStyleBackColor = true;
            this.PorcentajeIncremento.Click += new System.EventHandler(this.PorcentajeIncremento_Click);
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.Location = new System.Drawing.Point(588, 367);
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(112, 23);
            this.AgregarCategoria.TabIndex = 13;
            this.AgregarCategoria.Text = "Agregar Categoría";
            this.AgregarCategoria.UseVisualStyleBackColor = true;
            this.AgregarCategoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.UTN_logo__1_;
            this.Principal.Location = new System.Drawing.Point(44, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 7;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // VControlProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 411);
            this.Controls.Add(this.AgregarCategoria);
            this.Controls.Add(this.PorcentajeIncremento);
            this.Controls.Add(this.IngresoMercaderia);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.label1);
            this.Name = "VControlProductos";
            this.Text = "Control Productos";
            this.Load += new System.EventHandler(this.VControlProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button IngresoMercaderia;
        private System.Windows.Forms.Button PorcentajeIncremento;
        private System.Windows.Forms.Button AgregarCategoria;
    }
}
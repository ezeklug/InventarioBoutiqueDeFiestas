namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlProducto
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
            this.Principal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.IngresoMercaderia = new System.Windows.Forms.Button();
            this.PorcentajeIncremento = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.botonStockMinimo = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Productos";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.UTN_logo__1_;
            this.Principal.Location = new System.Drawing.Point(44, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 7;
            this.Principal.TabStop = false;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 277);
            this.dataGridView1.TabIndex = 8;
            // 
            // Agregar
            // 
            this.Agregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Agregar.Location = new System.Drawing.Point(26, 385);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Modificar.Location = new System.Drawing.Point(144, 385);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 10;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // IngresoMercaderia
            // 
            this.IngresoMercaderia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IngresoMercaderia.Location = new System.Drawing.Point(256, 385);
            this.IngresoMercaderia.Name = "IngresoMercaderia";
            this.IngresoMercaderia.Size = new System.Drawing.Size(120, 23);
            this.IngresoMercaderia.TabIndex = 11;
            this.IngresoMercaderia.Text = "Ingreso Mercaderia";
            this.IngresoMercaderia.UseVisualStyleBackColor = true;
            this.IngresoMercaderia.Click += new System.EventHandler(this.IngresoMercaderia_Click);
            // 
            // PorcentajeIncremento
            // 
            this.PorcentajeIncremento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PorcentajeIncremento.Location = new System.Drawing.Point(419, 385);
            this.PorcentajeIncremento.Name = "PorcentajeIncremento";
            this.PorcentajeIncremento.Size = new System.Drawing.Size(133, 23);
            this.PorcentajeIncremento.TabIndex = 12;
            this.PorcentajeIncremento.Text = "Porcentaje incremento";
            this.PorcentajeIncremento.UseVisualStyleBackColor = true;
            this.PorcentajeIncremento.Click += new System.EventHandler(this.PorcentajeIncremento_Click);
            // 
            // Categoria
            // 
            this.Categoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Categoria.Location = new System.Drawing.Point(579, 385);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(110, 23);
            this.Categoria.TabIndex = 13;
            this.Categoria.Text = "Categorias";
            this.Categoria.UseVisualStyleBackColor = true;
            this.Categoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
            // 
            // botonStockMinimo
            // 
            this.botonStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonStockMinimo.Location = new System.Drawing.Point(706, 376);
            this.botonStockMinimo.Name = "botonStockMinimo";
            this.botonStockMinimo.Size = new System.Drawing.Size(144, 40);
            this.botonStockMinimo.TabIndex = 14;
            this.botonStockMinimo.Text = "Productos debajo stock minimo";
            this.botonStockMinimo.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar.Location = new System.Drawing.Point(732, 54);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(118, 20);
            this.buscar.TabIndex = 15;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar:";
            // 
            // VControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.botonStockMinimo);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.PorcentajeIncremento);
            this.Controls.Add(this.IngresoMercaderia);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.label1);
            this.Name = "VControlProducto";
            this.Text = "VControlProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VControlProducto_Load);
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
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button botonStockMinimo;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Label label2;
    }
}
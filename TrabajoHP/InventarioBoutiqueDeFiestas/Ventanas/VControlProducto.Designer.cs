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
            this.buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CargarPresupuesto = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Listas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Productos";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
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
            this.Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(27, 385);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Modificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Modificar.FlatAppearance.BorderSize = 0;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(121, 385);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 10;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // IngresoMercaderia
            // 
            this.IngresoMercaderia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IngresoMercaderia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.IngresoMercaderia.FlatAppearance.BorderSize = 0;
            this.IngresoMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresoMercaderia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoMercaderia.Location = new System.Drawing.Point(353, 385);
            this.IngresoMercaderia.Name = "IngresoMercaderia";
            this.IngresoMercaderia.Size = new System.Drawing.Size(156, 23);
            this.IngresoMercaderia.TabIndex = 11;
            this.IngresoMercaderia.Text = "Ingreso Mercaderia";
            this.IngresoMercaderia.UseVisualStyleBackColor = false;
            this.IngresoMercaderia.Click += new System.EventHandler(this.IngresoMercaderia_Click);
            // 
            // PorcentajeIncremento
            // 
            this.PorcentajeIncremento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PorcentajeIncremento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PorcentajeIncremento.FlatAppearance.BorderSize = 0;
            this.PorcentajeIncremento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PorcentajeIncremento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcentajeIncremento.Location = new System.Drawing.Point(538, 385);
            this.PorcentajeIncremento.Name = "PorcentajeIncremento";
            this.PorcentajeIncremento.Size = new System.Drawing.Size(154, 23);
            this.PorcentajeIncremento.TabIndex = 12;
            this.PorcentajeIncremento.Text = "Porcentaje incremento";
            this.PorcentajeIncremento.UseVisualStyleBackColor = false;
            this.PorcentajeIncremento.Click += new System.EventHandler(this.PorcentajeIncremento_Click);
            // 
            // Categoria
            // 
            this.Categoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Categoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Categoria.FlatAppearance.BorderSize = 0;
            this.Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(723, 385);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(110, 23);
            this.Categoria.TabIndex = 13;
            this.Categoria.Text = "Categorias";
            this.Categoria.UseVisualStyleBackColor = false;
            this.Categoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar:";
            // 
            // CargarPresupuesto
            // 
            this.CargarPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CargarPresupuesto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CargarPresupuesto.FlatAppearance.BorderSize = 0;
            this.CargarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarPresupuesto.Location = new System.Drawing.Point(353, 385);
            this.CargarPresupuesto.Name = "CargarPresupuesto";
            this.CargarPresupuesto.Size = new System.Drawing.Size(156, 23);
            this.CargarPresupuesto.TabIndex = 17;
            this.CargarPresupuesto.Text = "Cargar en presupuesto";
            this.CargarPresupuesto.UseVisualStyleBackColor = false;
            this.CargarPresupuesto.Click += new System.EventHandler(this.CargarPresupuesto_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(226, 385);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(96, 23);
            this.Eliminar.TabIndex = 18;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Listas
            // 
            this.Listas.FormattingEnabled = true;
            this.Listas.Location = new System.Drawing.Point(156, 53);
            this.Listas.Name = "Listas";
            this.Listas.Size = new System.Drawing.Size(121, 21);
            this.Listas.TabIndex = 19;
            this.Listas.Text = "Todos";
            this.Listas.SelectedIndexChanged += new System.EventHandler(this.Listas_SelectedIndexChanged);
            // 
            // VControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 420);
            this.Controls.Add(this.Listas);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.CargarPresupuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar);
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
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CargarPresupuesto;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ComboBox Listas;
    }
}
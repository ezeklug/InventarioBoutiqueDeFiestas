namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlClientes
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
            this.Modificar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            this.botonExportar = new System.Windows.Forms.Button();
            this.AsociarPresupuesto = new System.Windows.Forms.Button();
            this.Listas = new System.Windows.Forms.ComboBox();
            this.Baja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 268);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Modificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Modificar.FlatAppearance.BorderSize = 0;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(111, 367);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(84, 32);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(24, 367);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(69, 32);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
            this.Principal.Location = new System.Drawing.Point(44, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 6;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar:";
            // 
            // buscar
            // 
            this.buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar.Location = new System.Drawing.Point(732, 49);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(118, 20);
            this.buscar.TabIndex = 10;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // botonExportar
            // 
            this.botonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonExportar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonExportar.FlatAppearance.BorderSize = 0;
            this.botonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonExportar.Location = new System.Drawing.Point(738, 367);
            this.botonExportar.Name = "botonExportar";
            this.botonExportar.Size = new System.Drawing.Size(112, 28);
            this.botonExportar.TabIndex = 11;
            this.botonExportar.Text = "Exportar a pdf";
            this.botonExportar.UseVisualStyleBackColor = false;
            this.botonExportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AsociarPresupuesto
            // 
            this.AsociarPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AsociarPresupuesto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AsociarPresupuesto.FlatAppearance.BorderSize = 0;
            this.AsociarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsociarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsociarPresupuesto.Location = new System.Drawing.Point(566, 367);
            this.AsociarPresupuesto.Name = "AsociarPresupuesto";
            this.AsociarPresupuesto.Size = new System.Drawing.Size(149, 23);
            this.AsociarPresupuesto.TabIndex = 12;
            this.AsociarPresupuesto.Text = "Asociar a Presupuesto";
            this.AsociarPresupuesto.UseVisualStyleBackColor = false;
            this.AsociarPresupuesto.Click += new System.EventHandler(this.AsociarPresupuesto_Click);
            // 
            // Listas
            // 
            this.Listas.FormattingEnabled = true;
            this.Listas.Location = new System.Drawing.Point(149, 52);
            this.Listas.Name = "Listas";
            this.Listas.Size = new System.Drawing.Size(121, 21);
            this.Listas.TabIndex = 13;
            this.Listas.Text = "Activos";
            this.Listas.SelectedIndexChanged += new System.EventHandler(this.Listas_SelectedIndexChanged);
            // 
            // Baja
            // 
            this.Baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Baja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Baja.FlatAppearance.BorderSize = 0;
            this.Baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baja.Location = new System.Drawing.Point(212, 367);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(84, 32);
            this.Baja.TabIndex = 14;
            this.Baja.Text = "Baja";
            this.Baja.UseVisualStyleBackColor = false;
            this.Baja.Click += new System.EventHandler(this.Baja_Click);
            // 
            // VControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 411);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Listas);
            this.Controls.Add(this.AsociarPresupuesto);
            this.Controls.Add(this.botonExportar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "VControlClientes";
            this.Text = "Control Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VControlClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button botonExportar;
        private System.Windows.Forms.Button AsociarPresupuesto;
        private System.Windows.Forms.ComboBox Listas;
        private System.Windows.Forms.Button Baja;
    }
}
namespace InventarioBoutiqueDeFiestas
{
    partial class VPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlClientes = new System.Windows.Forms.Button();
            this.ControlPresupuesto = new System.Windows.Forms.Button();
            this.ControlProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlClientes
            // 
            this.ControlClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlClientes.FlatAppearance.BorderSize = 0;
            this.ControlClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlClientes.Location = new System.Drawing.Point(181, 341);
            this.ControlClientes.Name = "ControlClientes";
            this.ControlClientes.Size = new System.Drawing.Size(194, 65);
            this.ControlClientes.TabIndex = 0;
            this.ControlClientes.Text = "Control Clientes";
            this.ControlClientes.UseVisualStyleBackColor = false;
            this.ControlClientes.Click += new System.EventHandler(this.ControlClientes_Click);
            // 
            // ControlPresupuesto
            // 
            this.ControlPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlPresupuesto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlPresupuesto.FlatAppearance.BorderSize = 0;
            this.ControlPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlPresupuesto.Location = new System.Drawing.Point(408, 341);
            this.ControlPresupuesto.Name = "ControlPresupuesto";
            this.ControlPresupuesto.Size = new System.Drawing.Size(141, 65);
            this.ControlPresupuesto.TabIndex = 1;
            this.ControlPresupuesto.Text = "Control Presupuesto";
            this.ControlPresupuesto.UseVisualStyleBackColor = false;
            this.ControlPresupuesto.Click += new System.EventHandler(this.ControlPresupuesto_Click);
            // 
            // ControlProductos
            // 
            this.ControlProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlProductos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlProductos.FlatAppearance.BorderSize = 0;
            this.ControlProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlProductos.Location = new System.Drawing.Point(12, 341);
            this.ControlProductos.Name = "ControlProductos";
            this.ControlProductos.Size = new System.Drawing.Size(129, 72);
            this.ControlProductos.TabIndex = 2;
            this.ControlProductos.Text = "Control Productos";
            this.ControlProductos.UseVisualStyleBackColor = false;
            this.ControlProductos.Click += new System.EventHandler(this.ControlProductos_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(588, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlProductos);
            this.Controls.Add(this.ControlPresupuesto);
            this.Controls.Add(this.ControlClientes);
            this.Name = "VPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ControlClientes;
        private System.Windows.Forms.Button ControlPresupuesto;
        private System.Windows.Forms.Button ControlProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


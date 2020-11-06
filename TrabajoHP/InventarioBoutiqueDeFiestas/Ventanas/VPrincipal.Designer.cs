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
            this.NohayNotificaciones = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DiasNotificaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ControlClientes.Location = new System.Drawing.Point(439, 341);
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
            this.ControlPresupuesto.Location = new System.Drawing.Point(666, 341);
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
            this.ControlProductos.Location = new System.Drawing.Point(270, 341);
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
            this.panel1.Controls.Add(this.NohayNotificaciones);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(887, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 571);
            this.panel1.TabIndex = 3;
            // 
            // NohayNotificaciones
            // 
            this.NohayNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NohayNotificaciones.AutoSize = true;
            this.NohayNotificaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NohayNotificaciones.Location = new System.Drawing.Point(88, 29);
            this.NohayNotificaciones.Name = "NohayNotificaciones";
            this.NohayNotificaciones.Size = new System.Drawing.Size(177, 21);
            this.NohayNotificaciones.TabIndex = 1;
            this.NohayNotificaciones.Text = "No hay notificaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 565);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(905, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notificaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiasNotificaciones
            // 
            this.DiasNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiasNotificaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasNotificaciones.Location = new System.Drawing.Point(1168, 57);
            this.DiasNotificaciones.Name = "DiasNotificaciones";
            this.DiasNotificaciones.Size = new System.Drawing.Size(23, 26);
            this.DiasNotificaciones.TabIndex = 5;
            this.DiasNotificaciones.Text = "7";
            this.DiasNotificaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiasNotificaciones_KeyDown);
            this.DiasNotificaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiasNotificaciones_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1235, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Días";
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiasNotificaciones);
            this.Controls.Add(this.label1);
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ControlClientes;
        private System.Windows.Forms.Button ControlPresupuesto;
        private System.Windows.Forms.Button ControlProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NohayNotificaciones;
        private System.Windows.Forms.TextBox DiasNotificaciones;
        private System.Windows.Forms.Label label2;
    }
}


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
            this.AdministrarPresupuesto = new System.Windows.Forms.Button();
            this.ControlProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ControlClientes
            // 
            this.ControlClientes.Location = new System.Drawing.Point(287, 198);
            this.ControlClientes.Name = "ControlClientes";
            this.ControlClientes.Size = new System.Drawing.Size(194, 65);
            this.ControlClientes.TabIndex = 0;
            this.ControlClientes.Text = "Control Clientes";
            this.ControlClientes.UseVisualStyleBackColor = true;
            this.ControlClientes.Click += new System.EventHandler(this.ControlClientes_Click);
            // 
            // AdministrarPresupuesto
            // 
            this.AdministrarPresupuesto.Location = new System.Drawing.Point(545, 186);
            this.AdministrarPresupuesto.Name = "AdministrarPresupuesto";
            this.AdministrarPresupuesto.Size = new System.Drawing.Size(141, 77);
            this.AdministrarPresupuesto.TabIndex = 1;
            this.AdministrarPresupuesto.Text = "AdministrarPresupuesto";
            this.AdministrarPresupuesto.UseVisualStyleBackColor = true;
            this.AdministrarPresupuesto.Click += new System.EventHandler(this.AdministrarPresupuesto_Click);
            // 
            // ControlProductos
            // 
            this.ControlProductos.Location = new System.Drawing.Point(84, 194);
            this.ControlProductos.Name = "ControlProductos";
            this.ControlProductos.Size = new System.Drawing.Size(129, 72);
            this.ControlProductos.TabIndex = 2;
            this.ControlProductos.Text = "Control Productos";
            this.ControlProductos.UseVisualStyleBackColor = true;
            this.ControlProductos.Click += new System.EventHandler(this.ControlProductos_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlProductos);
            this.Controls.Add(this.AdministrarPresupuesto);
            this.Controls.Add(this.ControlClientes);
            this.Name = "VPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ControlClientes;
        private System.Windows.Forms.Button AdministrarPresupuesto;
        private System.Windows.Forms.Button ControlProductos;
    }
}


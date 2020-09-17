namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlProductosPresupuesto
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
            this.CargarPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Productos";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.UTN_logo__1_;
            this.Principal.Location = new System.Drawing.Point(44, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 8;
            this.Principal.TabStop = false;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 268);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CargarPresupuesto
            // 
            this.CargarPresupuesto.Location = new System.Drawing.Point(56, 376);
            this.CargarPresupuesto.Name = "CargarPresupuesto";
            this.CargarPresupuesto.Size = new System.Drawing.Size(140, 23);
            this.CargarPresupuesto.TabIndex = 10;
            this.CargarPresupuesto.Text = "Cargar en presupuesto";
            this.CargarPresupuesto.UseVisualStyleBackColor = true;
            this.CargarPresupuesto.Click += new System.EventHandler(this.CargarPresupuesto_Click);
            // 
            // VControlProductosPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 411);
            this.Controls.Add(this.CargarPresupuesto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.label1);
            this.Name = "VControlProductosPresupuesto";
            this.Text = "VControlProductosPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CargarPresupuesto;
    }
}
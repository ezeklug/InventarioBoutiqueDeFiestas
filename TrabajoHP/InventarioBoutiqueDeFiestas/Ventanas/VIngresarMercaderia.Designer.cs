namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VIngresarMercaderia
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.Button();
            this.Listo = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(203, 10);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(383, 39);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Ingreso de Mercaderia";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
            this.Principal.Location = new System.Drawing.Point(44, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 8;
            this.Principal.TabStop = false;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // Listo
            // 
            this.Listo.Location = new System.Drawing.Point(594, 438);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(75, 23);
            this.Listo.TabIndex = 9;
            this.Listo.Text = "Listo";
            this.Listo.UseVisualStyleBackColor = true;
            this.Listo.Click += new System.EventHandler(this.Listo_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(710, 438);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(655, 60);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(130, 23);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar Mercaderia";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // VIngresarMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Listo);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VIngresarMercaderia";
            this.Text = "VIngresarMercaderia";
            this.Load += new System.EventHandler(this.VIngresarMercaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.Button Listo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Agregar;
    }
}
namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlCategoriaProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AsociarProducto = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "Control Categoria";
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
            this.Principal.Location = new System.Drawing.Point(68, 12);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(74, 74);
            this.Principal.TabIndex = 16;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 271);
            this.dataGridView1.TabIndex = 18;
            // 
            // AsociarProducto
            // 
            this.AsociarProducto.Location = new System.Drawing.Point(489, 396);
            this.AsociarProducto.Name = "AsociarProducto";
            this.AsociarProducto.Size = new System.Drawing.Size(128, 23);
            this.AsociarProducto.TabIndex = 19;
            this.AsociarProducto.Text = "Asociar a Producto";
            this.AsociarProducto.UseVisualStyleBackColor = true;
            this.AsociarProducto.Click += new System.EventHandler(this.AsociarProducto_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(387, 396);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 20;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // VControlCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.AsociarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Principal);
            this.Name = "VControlCategoriaProducto";
            this.Text = "ControlCategoriaProducto";
            this.Load += new System.EventHandler(this.ControlCategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AsociarProducto;
        private System.Windows.Forms.Button Agregar;
    }
}
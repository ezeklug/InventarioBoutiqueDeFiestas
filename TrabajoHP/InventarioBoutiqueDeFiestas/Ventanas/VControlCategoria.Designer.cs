namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VControlCategoria
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.AsociarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Control Categoria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 354);
            this.dataGridView1.TabIndex = 3;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(297, 524);
            this.Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(87, 30);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Modificar.FlatAppearance.BorderSize = 0;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(404, 524);
            this.Modificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(87, 30);
            this.Modificar.TabIndex = 6;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(516, 524);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 30);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Principal
            // 
            this.Principal.Image = global::InventarioBoutiqueDeFiestas.Properties.Resources.ccae0744_6be7_4659_84a8_a597aa2764f1;
            this.Principal.Location = new System.Drawing.Point(88, 21);
            this.Principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 74);
            this.Principal.TabIndex = 1;
            this.Principal.UseVisualStyleBackColor = true;
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(632, 524);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(87, 30);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // AsociarProducto
            // 
            this.AsociarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AsociarProducto.FlatAppearance.BorderSize = 0;
            this.AsociarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsociarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsociarProducto.Location = new System.Drawing.Point(121, 524);
            this.AsociarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsociarProducto.Name = "AsociarProducto";
            this.AsociarProducto.Size = new System.Drawing.Size(149, 30);
            this.AsociarProducto.TabIndex = 4;
            this.AsociarProducto.Text = "Asociar a Producto";
            this.AsociarProducto.UseVisualStyleBackColor = false;
            this.AsociarProducto.Click += new System.EventHandler(this.AsociarProducto_Click);
            // 
            // VControlCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(776, 588);
            this.Controls.Add(this.AsociarProducto);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VControlCategoria";
            this.Text = "VAgregarCategoria";
            this.Load += new System.EventHandler(this.VAgregarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Principal;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button AsociarProducto;
    }
}
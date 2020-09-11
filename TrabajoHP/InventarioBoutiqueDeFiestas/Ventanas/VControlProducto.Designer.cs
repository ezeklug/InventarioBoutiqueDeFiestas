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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VControlProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.ingresarMercaderia = new System.Windows.Forms.Button();
            this.GuardarPDF = new System.Windows.Forms.Button();
            this.porcentajeIncremento = new System.Windows.Forms.Button();
            this.agregarCategoria = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 403);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 35);
            this.agregar.TabIndex = 3;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(109, 403);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 35);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(212, 403);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 35);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // ingresarMercaderia
            // 
            this.ingresarMercaderia.Location = new System.Drawing.Point(318, 403);
            this.ingresarMercaderia.Name = "ingresarMercaderia";
            this.ingresarMercaderia.Size = new System.Drawing.Size(75, 35);
            this.ingresarMercaderia.TabIndex = 6;
            this.ingresarMercaderia.Text = "Ingresar Mercadería";
            this.ingresarMercaderia.UseVisualStyleBackColor = true;
            // 
            // GuardarPDF
            // 
            this.GuardarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarPDF.Image = ((System.Drawing.Image)(resources.GetObject("GuardarPDF.Image")));
            this.GuardarPDF.Location = new System.Drawing.Point(424, 403);
            this.GuardarPDF.Name = "GuardarPDF";
            this.GuardarPDF.Size = new System.Drawing.Size(80, 35);
            this.GuardarPDF.TabIndex = 7;
            this.GuardarPDF.UseVisualStyleBackColor = true;
            // 
            // porcentajeIncremento
            // 
            this.porcentajeIncremento.Location = new System.Drawing.Point(543, 403);
            this.porcentajeIncremento.Name = "porcentajeIncremento";
            this.porcentajeIncremento.Size = new System.Drawing.Size(75, 35);
            this.porcentajeIncremento.TabIndex = 8;
            this.porcentajeIncremento.Text = "Porcentaje Incremento";
            this.porcentajeIncremento.UseVisualStyleBackColor = true;
            // 
            // agregarCategoria
            // 
            this.agregarCategoria.Location = new System.Drawing.Point(652, 403);
            this.agregarCategoria.Name = "agregarCategoria";
            this.agregarCategoria.Size = new System.Drawing.Size(75, 35);
            this.agregarCategoria.TabIndex = 9;
            this.agregarCategoria.Text = "Agregar Categoria";
            this.agregarCategoria.UseVisualStyleBackColor = true;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(763, 403);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 35);
            this.volver.TabIndex = 10;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            // 
            // listar
            // 
            this.listar.BackColor = System.Drawing.SystemColors.Control;
            this.listar.FormattingEnabled = true;
            this.listar.Location = new System.Drawing.Point(34, 52);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(150, 21);
            this.listar.TabIndex = 12;
            // 
            // VControlProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.agregarCategoria);
            this.Controls.Add(this.porcentajeIncremento);
            this.Controls.Add(this.GuardarPDF);
            this.Controls.Add(this.ingresarMercaderia);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "VControlProducto";
            this.Text = "VControlProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button ingresarMercaderia;
        private System.Windows.Forms.Button GuardarPDF;
        private System.Windows.Forms.Button porcentajeIncremento;
        private System.Windows.Forms.Button agregarCategoria;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.ComboBox listar;
    }
}
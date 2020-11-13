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
            this.Confirmar = new System.Windows.Forms.Button();
            this.ConfirmarText = new System.Windows.Forms.Label();
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
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
            this.Listo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Listo.FlatAppearance.BorderSize = 0;
            this.Listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listo.Location = new System.Drawing.Point(594, 438);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(75, 23);
            this.Listo.TabIndex = 9;
            this.Listo.Text = "Listo";
            this.Listo.UseVisualStyleBackColor = false;
            this.Listo.Click += new System.EventHandler(this.Listo_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(710, 438);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(655, 60);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(130, 23);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar Mercaderia";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Confirmar.FlatAppearance.BorderSize = 0;
            this.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(594, 438);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 12;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // ConfirmarText
            // 
            this.ConfirmarText.AutoSize = true;
            this.ConfirmarText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarText.Location = new System.Drawing.Point(430, 418);
            this.ConfirmarText.Name = "ConfirmarText";
            this.ConfirmarText.Size = new System.Drawing.Size(355, 17);
            this.ConfirmarText.TabIndex = 13;
            this.ConfirmarText.Text = "Ingrese los numeros en cada lote y presione confirmar";
            // 
            // VIngresarMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 491);
            this.Controls.Add(this.ConfirmarText);
            this.Controls.Add(this.Confirmar);
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
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Label ConfirmarText;
    }
}
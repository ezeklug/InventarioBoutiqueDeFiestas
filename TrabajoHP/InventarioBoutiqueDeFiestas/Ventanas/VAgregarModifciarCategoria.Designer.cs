namespace InventarioBoutiqueDeFiestas.Ventanas
{
    partial class VAgregarModifciarCategoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descripcionCategoria = new System.Windows.Forms.TextBox();
            this.nombreCategoria = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.siVence = new System.Windows.Forms.RadioButton();
            this.noVence = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vence: ";
            // 
            // descripcionCategoria
            // 
            this.descripcionCategoria.Location = new System.Drawing.Point(215, 182);
            this.descripcionCategoria.Name = "descripcionCategoria";
            this.descripcionCategoria.Size = new System.Drawing.Size(208, 20);
            this.descripcionCategoria.TabIndex = 8;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Location = new System.Drawing.Point(215, 124);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(208, 20);
            this.nombreCategoria.TabIndex = 9;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(348, 293);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 10;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(246, 293);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // siVence
            // 
            this.siVence.AutoSize = true;
            this.siVence.Location = new System.Drawing.Point(215, 237);
            this.siVence.Name = "siVence";
            this.siVence.Size = new System.Drawing.Size(34, 17);
            this.siVence.TabIndex = 12;
            this.siVence.TabStop = true;
            this.siVence.Text = "Si";
            this.siVence.UseVisualStyleBackColor = true;
            // 
            // noVence
            // 
            this.noVence.AutoSize = true;
            this.noVence.Location = new System.Drawing.Point(299, 237);
            this.noVence.Name = "noVence";
            this.noVence.Size = new System.Drawing.Size(39, 17);
            this.noVence.TabIndex = 13;
            this.noVence.TabStop = true;
            this.noVence.Text = "No";
            this.noVence.UseVisualStyleBackColor = true;
            // 
            // VAgregarModifciarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.noVence);
            this.Controls.Add(this.siVence);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.nombreCategoria);
            this.Controls.Add(this.descripcionCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VAgregarModifciarCategoria";
            this.Text = "VAgregarModifciarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descripcionCategoria;
        private System.Windows.Forms.TextBox nombreCategoria;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.RadioButton siVence;
        private System.Windows.Forms.RadioButton noVence;
    }
}
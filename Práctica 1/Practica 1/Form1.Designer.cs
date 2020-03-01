namespace Practica_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxExam1 = new System.Windows.Forms.TextBox();
            this.tbxExam2 = new System.Windows.Forms.TextBox();
            this.tbxExam3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPromedio = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exámen 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exámen 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exámen 3";
            // 
            // tbxExam1
            // 
            this.tbxExam1.Location = new System.Drawing.Point(72, 6);
            this.tbxExam1.Name = "tbxExam1";
            this.tbxExam1.Size = new System.Drawing.Size(100, 20);
            this.tbxExam1.TabIndex = 3;
            // 
            // tbxExam2
            // 
            this.tbxExam2.Location = new System.Drawing.Point(72, 32);
            this.tbxExam2.Name = "tbxExam2";
            this.tbxExam2.Size = new System.Drawing.Size(100, 20);
            this.tbxExam2.TabIndex = 4;
            // 
            // tbxExam3
            // 
            this.tbxExam3.Location = new System.Drawing.Point(72, 58);
            this.tbxExam3.Name = "tbxExam3";
            this.tbxExam3.Size = new System.Drawing.Size(100, 20);
            this.tbxExam3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio";
            // 
            // tbxPromedio
            // 
            this.tbxPromedio.Enabled = false;
            this.tbxPromedio.Location = new System.Drawing.Point(72, 106);
            this.tbxPromedio.Name = "tbxPromedio";
            this.tbxPromedio.Size = new System.Drawing.Size(100, 20);
            this.tbxPromedio.TabIndex = 7;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(15, 146);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(96, 146);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(178, 146);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 183);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbxPromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxExam3);
            this.Controls.Add(this.tbxExam2);
            this.Controls.Add(this.tbxExam1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxExam1;
        private System.Windows.Forms.TextBox tbxExam2;
        private System.Windows.Forms.TextBox tbxExam3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPromedio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}


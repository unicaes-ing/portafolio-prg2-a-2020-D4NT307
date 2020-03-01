namespace Practica_1
{
    partial class Form2
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
            this.tbxDecimal = new System.Windows.Forms.TextBox();
            this.gpbEquivalencia = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBinario = new System.Windows.Forms.TextBox();
            this.tbxOctal = new System.Windows.Forms.TextBox();
            this.tbxHexadecimal = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.gpbEquivalencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decimal";
            // 
            // tbxDecimal
            // 
            this.tbxDecimal.Location = new System.Drawing.Point(64, 10);
            this.tbxDecimal.Name = "tbxDecimal";
            this.tbxDecimal.Size = new System.Drawing.Size(100, 20);
            this.tbxDecimal.TabIndex = 1;
            // 
            // gpbEquivalencia
            // 
            this.gpbEquivalencia.Controls.Add(this.tbxHexadecimal);
            this.gpbEquivalencia.Controls.Add(this.tbxOctal);
            this.gpbEquivalencia.Controls.Add(this.tbxBinario);
            this.gpbEquivalencia.Controls.Add(this.label4);
            this.gpbEquivalencia.Controls.Add(this.label3);
            this.gpbEquivalencia.Controls.Add(this.label2);
            this.gpbEquivalencia.Location = new System.Drawing.Point(13, 47);
            this.gpbEquivalencia.Name = "gpbEquivalencia";
            this.gpbEquivalencia.Size = new System.Drawing.Size(236, 136);
            this.gpbEquivalencia.TabIndex = 2;
            this.gpbEquivalencia.TabStop = false;
            this.gpbEquivalencia.Text = "Equivale a:";
            this.gpbEquivalencia.Enter += new System.EventHandler(this.gpbEquivalencia_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hexadecimal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Octal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxBinario
            // 
            this.tbxBinario.Enabled = false;
            this.tbxBinario.Location = new System.Drawing.Point(91, 23);
            this.tbxBinario.Name = "tbxBinario";
            this.tbxBinario.Size = new System.Drawing.Size(100, 20);
            this.tbxBinario.TabIndex = 3;
            // 
            // tbxOctal
            // 
            this.tbxOctal.Enabled = false;
            this.tbxOctal.Location = new System.Drawing.Point(91, 61);
            this.tbxOctal.Name = "tbxOctal";
            this.tbxOctal.Size = new System.Drawing.Size(100, 20);
            this.tbxOctal.TabIndex = 6;
            // 
            // tbxHexadecimal
            // 
            this.tbxHexadecimal.Enabled = false;
            this.tbxHexadecimal.Location = new System.Drawing.Point(91, 99);
            this.tbxHexadecimal.Name = "tbxHexadecimal";
            this.tbxHexadecimal.Size = new System.Drawing.Size(100, 20);
            this.tbxHexadecimal.TabIndex = 7;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(12, 189);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(93, 189);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(174, 189);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 229);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.gpbEquivalencia);
            this.Controls.Add(this.tbxDecimal);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Sistemas";
            this.gpbEquivalencia.ResumeLayout(false);
            this.gpbEquivalencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDecimal;
        private System.Windows.Forms.GroupBox gpbEquivalencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHexadecimal;
        private System.Windows.Forms.TextBox tbxOctal;
        private System.Windows.Forms.TextBox tbxBinario;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}
namespace Practica_1
{
    partial class Form4
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
            this.cbxTitulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.tbxImpuesto = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título del libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxTitulo
            // 
            this.cbxTitulo.FormattingEnabled = true;
            this.cbxTitulo.Items.AddRange(new object[] {
            "1984 - George Orwell",
            "Divina Comedia - Dante Alighieri",
            "El Ingenioso Hidalgo Don Quijote De La Mancha - Miguel De Cervantes",
            "El Señor De Las Moscas - William Golding",
            "La Espada Del Destino - Andrzej Sapkowski",
            "Un Mundo Feliz - Aldous Huxley",
            "El Guardián Entre El Centeno - J. D. Salinger",
            "Sin Novedad En El Frente - Ercih Maria Remarque",
            "La Republica - Platón",
            "El Principe - Nicolás Maquiavelo",
            "El Arte De La Guerra - Tsun Zu",
            "El Anillo De Los Nibelungos - Richard Wagner",
            "Los Hijos De Húrin - J. R. R. Tolkien",
            "El Fin De La Infancia - Arthur Clarke",
            "Meditaciones - Marco Aurelio",
            "La Isla Del Tesoro - Robert Louis Stevenson"});
            this.cbxTitulo.Location = new System.Drawing.Point(93, 10);
            this.cbxTitulo.Name = "cbxTitulo";
            this.cbxTitulo.Size = new System.Drawing.Size(246, 21);
            this.cbxTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(93, 44);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecio.TabIndex = 4;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(93, 78);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbxCantidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subtotal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Impuesto (13%)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total a pagar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Enabled = false;
            this.tbxSubtotal.Location = new System.Drawing.Point(93, 115);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbxSubtotal.TabIndex = 9;
            // 
            // tbxImpuesto
            // 
            this.tbxImpuesto.Enabled = false;
            this.tbxImpuesto.Location = new System.Drawing.Point(93, 146);
            this.tbxImpuesto.Name = "tbxImpuesto";
            this.tbxImpuesto.Size = new System.Drawing.Size(100, 20);
            this.tbxImpuesto.TabIndex = 10;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(93, 180);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 11;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(16, 218);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(119, 218);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(222, 218);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 14;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 264);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxImpuesto);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Librería Universitaria";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.TextBox tbxImpuesto;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}
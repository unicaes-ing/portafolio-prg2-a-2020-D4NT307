using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxPrecio.Text, out double precio) && int.TryParse(tbxCantidad.Text, out int cantidad))
            {
                double subtotal = precio * cantidad, impuesto = subtotal * 0.13, total = subtotal + impuesto;
                tbxSubtotal.Text = subtotal.ToString("C2");
                tbxImpuesto.Text = impuesto.ToString("C2");
                tbxTotal.Text = total.ToString("C2");
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbxPrecio.Text = "";
            tbxCantidad.Text = "";
            tbxSubtotal.Text = "";
            tbxImpuesto.Text = "";
            tbxTotal.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

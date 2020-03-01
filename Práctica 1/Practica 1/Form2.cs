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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gpbEquivalencia_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbxDecimal.Text, out int numDecimal))
            {
                tbxBinario.Text = Convert.ToString(numDecimal, 2);
                tbxOctal.Text = Convert.ToString(numDecimal, 8);
                tbxHexadecimal.Text = Convert.ToString(numDecimal, 16);

            }
            else
            {
                MessageBox.Show("El número ingresado debe ser un número entero del sistema decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbxBinario.Text = "";
            tbxDecimal.Text = "";
            tbxHexadecimal.Text = "";
            tbxOctal.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

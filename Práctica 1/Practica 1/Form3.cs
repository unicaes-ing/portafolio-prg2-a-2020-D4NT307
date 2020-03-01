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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxInver1.Text, out double inver1) && double.TryParse(tbxInver2.Text, out double inver2) && double.TryParse(tbxInver3.Text, out double inver3))
            {
                double sum = inver1 + inver2 + inver3, porcentaje1 = inver1 / sum, porcentaje2 = inver2 / sum, porcentaje3 = inver3 / sum;
                tbxPorcentaje1.Text = porcentaje1.ToString("P2");
                tbxPorcentaje2.Text = porcentaje2.ToString("P2");
                tbxPorcentaje3.Text = porcentaje3.ToString("P2");
                tbxTotal.Text = sum.ToString("C2");
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbxInver1.Text = "";
            tbxInver2.Text = "";
            tbxInver3.Text = "";
            tbxPorcentaje1.Text = "";
            tbxPorcentaje2.Text = "";
            tbxPorcentaje3.Text = "";
            tbxTotal.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxExam1.Text, out double exam1) && (double.TryParse(tbxExam2.Text, out double exam2) && double.TryParse(tbxExam3.Text, out double exam3)))
            {
                if ((exam1 >= 1 && exam1 <= 10) && (exam2 >= 1 && exam2 <= 10) && (exam3 >= 1 && exam3 <= 10))
                {
                    double promedio = (exam1 + exam2 + exam3) / 3;
                    tbxPromedio.Text = promedio.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Los números ingresados deben estar entre 1 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe asegurarse que los datos ingresados sean números y no letras u otro tipo de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbxExam1.Text = "";
            tbxExam2.Text = "";
            tbxExam3.Text = "";
            tbxPromedio.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

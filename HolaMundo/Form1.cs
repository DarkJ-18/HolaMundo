using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;

            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);

            int total = numero1 * numero2;

            lbltotal.Text = total.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + txtnombre.Text);

        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;

            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);

            int total = numero1 + numero2;

            lbltotal.Text = total.ToString();
        }

        private void Bntresta_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;

            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);

            int total = numero1 - numero2;

            lbltotal.Text = total.ToString();
        }

        private void Bntdivision_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;

            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);

            int total = numero1 / numero2;

            lbltotal.Text = total.ToString();
        }
    }
}

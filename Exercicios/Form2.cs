using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txbNumeroUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            double numero = 0;
            numero = double.Parse(txbNumeroUm.Text);

            if (numero % 2 == 0)
            {
                MessageBox.Show("Este númpero é par.");
            }
            else 
            {
                MessageBox.Show("Este número é ímpar.");
            }

            if (numero <= (-1))
            {
                MessageBox.Show("Este número é negativo");

            }
            else
            {
                MessageBox.Show("Este número é positivo");
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form3 Formulario3 = new Form3();
            Formulario3.Show();
            this.Close();
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form4 Formulario4 = new Form4();
            Formulario4.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int numeroEntrada = 0;
            int numeroSaida = 0;
            numeroEntrada=int.Parse(txbInicio.Text);
            numeroSaida=int.Parse(txbFim.Text);
            int[] sequencia = new int[numeroSaida];

            for (int i = numeroEntrada; i <= numeroSaida; i++)
            {
                ltbSequencia.Items.Add(i);

            }

        }

        private void txbNumeroUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

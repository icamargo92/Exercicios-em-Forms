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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int numeroEntrada = 0;
            int numeroSaida = 0;
            numeroEntrada = int.Parse(txbInicio.Text);
            numeroSaida = int.Parse(txbFim.Text);
            int[] sequencia = new int[numeroSaida];

            for (int i = numeroEntrada; i <= numeroSaida; i++)
            {
                if (i < 0)
                {
                    ltbSequencia1.Items.Add(i);
                }
                if (i % 2 == 0)
                 {
                     ltbSequencia2.Items.Add(i);
                 }

                if (i % 7 == 0)
                 {
                     ltbSequencia3.Items.Add(i);
                 }

            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form5 Formulario5 = new Form5();
            Formulario5.Show();
            this.Close();
        }
    } 
}

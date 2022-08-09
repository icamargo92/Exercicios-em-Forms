namespace Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNumeroMenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            double numero1 = 0;
            double numero2 = 0;
            double numero3 = 0;

            numero1 = double.Parse(txbNumeroUm.Text);
            numero2 = double.Parse(txbNumeroDois.Text);
            numero3 = double.Parse(txbNumeroTres.Text);

            if (numero1 > numero2 && numero1 > numero3)
            {
                txbNumeroMaior.Text = numero1.ToString();
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                txbNumeroMaior.Text = numero2.ToString();
            }
            else
            {

                txbNumeroMaior.Text = numero3.ToString();
            }

            if (numero1 < numero2 && numero1 < numero3)
            {
                txbNumeroMenor.Text = numero1.ToString();
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                txbNumeroMenor.Text = numero2.ToString();
            }
            else
            {
                txbNumeroMenor.Text = numero3.ToString();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form2 Formulario2 = new Form2();
            Formulario2.Show();
            this.Hide();
       }
    }
}
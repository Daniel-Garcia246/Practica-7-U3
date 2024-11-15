using System.Configuration;

namespace Practica_7_U3
{
    public partial class Form1 : Form
    {
        double v1, farh1;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(valor.Text);
            farh1 =  v1 * (9.0/5.0) + 32;
            Resultado.Text = farh1.ToString();
            label5.Text = " Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(valor.Text);
            cent1 = (v1-32)*(5.0/9.0);
            Resultado.Text = cent1.ToString();
            label5.Text = "Centigrados";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor.Text = " ";
            Resultado.Text = " ";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab006.lab006
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private void MaiorDeTres()
        {
            int Valor1 = Convert.ToInt32(numValor1.Text);
            int Valor2 = Convert.ToInt32(numValor2.Text);
            int Valor3 = Convert.ToInt32(numValor3.Text);
            int maior = 0;

            if (Valor1 == Valor2 && Valor2 == Valor3)
            {
                lblResultado.Text = "Os tres valorez são iguais";
                return;
            }

            maior = Valor1;

            if (Valor2 > maior)
            {
                maior = Valor2;
            }

            if (Valor3 > maior)
            {
                maior = Valor3;

            }

            lblResultado.Text = maior.ToString();
        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
        }
    }
}

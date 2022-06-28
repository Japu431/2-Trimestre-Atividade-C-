using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurosSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valorParcela_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcJuros_Click(object sender, EventArgs e)
        {
            double vlrParcela = Convert.ToDouble(valorParcela.Text);
            double txDeJuros = Convert.ToDouble(taxaDeJuros.Text) / 100;
            double tempoAtraso = Convert.ToDouble(diasDeAtraso.Text);

            double jurosFinal = vlrParcela * (1 + (txDeJuros * (tempoAtraso / 30)));

            montante.Text = $"R$ {jurosFinal}";
        }
    }
}

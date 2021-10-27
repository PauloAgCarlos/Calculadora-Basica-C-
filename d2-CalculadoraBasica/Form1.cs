using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d2_CalculadoraBasica
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void operacao_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(text1.Text);
            valor2 = Double.Parse(text2.Text);
            string tipo_operacao = (sender as Button).Text;
            labelResult.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(), tipo_operacao, valor2.ToString(), operacao(tipo_operacao));
        }

        private string operacao(string tipo)
        {
            double resultado = 0;
            switch (tipo)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case ":":
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }

            return resultado.ToString();
        }
    }
}

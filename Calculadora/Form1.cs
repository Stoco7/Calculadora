﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0, valor3 = 0, valor4 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "MULTIPLICA";
                labeloperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efutuar a Multiplicação");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!textBoxResultado.Text.Contains("."))
            {
                textBoxResultado.Text += ".";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "DIVIDE";
                labeloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efutuar a Divisão");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efutuar a soma");
            }
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SUBTRAI";
                labeloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efutuar a subtração");
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2, CultureInfo.InvariantCulture);
            }
            else if (operacao == "SUBTRAI")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2, CultureInfo.InvariantCulture);
            }
            else if (operacao == "MULTIPLICA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
            }
            else if (operacao == "DIVIDE")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
            }
            else if (operacao == "RAIZ")
            {

                if (textBoxResultado.Text != "")
                {
                    if (valor1 >= 0)
                    {
                    double raiz = Math.Sqrt((double)valor1);
                    textBoxResultado.Text = raiz.ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                    MessageBox.Show("Não é possível calcular a raiz quadrada de um número negativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxResultado.Text = "";
                    }
                }
            }
            else if (operacao == "EXPONENCIACAO")
            {
                double resultado = Math.Pow((double)valor1, (double)valor2);
                textBoxResultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
            }
            else if (operacao == "MODULO")
            {
                decimal resultado = valor1 % valor2;
                textBoxResultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
            }
            else if (operacao == "PORCENTAGEM")
            {
                decimal resultado = valor1 * (valor2 / 100);
                textBoxResultado.Text = resultado.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            labeloperacao.Text = " ";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labeloperacao.Text = " ";
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                operacao = "RAIZ";
                labeloperacao.Text = "√";
            }
            else
            {
                MessageBox.Show("Digite um número antes de calcular a raiz quadrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExponenciacao_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "EXPONENCIACAO";
                labeloperacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a exponenciação");
            }
        }
        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "MODULO";
                labeloperacao.Text = "|x|";
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular o módulo");
            }
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "PORCENTAGEM";
                labeloperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a porcentagem");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            textBoxResultado2.Text = Convert.ToString(valor3 + valor4, CultureInfo.InvariantCulture);
            textBoxResultado2_1.Text = textBoxResultado2.Text;
            textBoxValor4_1.Text = textBoxValor4.Text;
        }

        private void textBoxValor3_TextChanged(object sender, EventArgs e)
        {
            valor3 = decimal.Parse(textBoxValor3.Text, CultureInfo.InvariantCulture);
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            decimal Resultado2 = decimal.Parse(textBoxResultado2_1.Text, CultureInfo.InvariantCulture);
            decimal Valor4 = decimal.Parse(textBoxValor4_1.Text, CultureInfo.InvariantCulture);
            decimal Resultado3 = Resultado2 - Valor4;
            textBoxResultado3.Text = Convert.ToString(Resultado3, CultureInfo.InvariantCulture);
            textBoxValor3_1.Text = textBoxValor3.Text;
            textBoxResultado3_1.Text = textBoxResultado3.Text;

        }

        private void textBoxValor3_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {

            decimal Valor1 = decimal.Parse(textBoxValor3.Text, CultureInfo.InvariantCulture);
            decimal Resultado2 = decimal.Parse(textBoxResultado3.Text, CultureInfo.InvariantCulture);
            decimal Resultado4 = Valor1 * Resultado2;
            textBoxResultado4.Text = Convert.ToString(Resultado4, CultureInfo.InvariantCulture);
        }

        private void textBoxResultado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValor4_TextChanged(object sender, EventArgs e)
        {
            valor4 = decimal.Parse(textBoxValor4.Text, CultureInfo.InvariantCulture);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }
    }
}

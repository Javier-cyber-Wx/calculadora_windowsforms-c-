using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        double number_1;
        double number_2;
        double resultado;
        string operador;
        string mensaje_division = "dividiste entre cero";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 1;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 8;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label_resultado.Text = label_resultado.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "+";
            number_1 = double.Parse(label_resultado.Text);
            label_resultado.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            operador = "-";
            number_1 = double.Parse(label_resultado.Text);
            label_resultado.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            operador = "*";
            number_1 = double.Parse(label_resultado.Text);
            label_resultado.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            operador = "/";
            number_1 = double.Parse(label_resultado.Text);
            label_resultado.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label_resultado.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label_resultado.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            number_2 = double.Parse(label_resultado.Text);
            switch(operador)
            {
                case "+":
                    {
                        resultado = number_1 + number_2;
                        label_resultado.Text = resultado.ToString();
                        break;
                    }
                    case "-":
                    {
                        resultado = number_1 - number_2;
                        label_resultado.Text= resultado.ToString();
                        break;
                    }
                    case "*":
                    {
                        resultado = number_1 * number_2;
                        label_resultado.Text = resultado.ToString();
                        break;
                    }
                    case "/":
                    {
                        resultado = number_1/ number_2;
                        label_resultado.Text = resultado.ToString();
                        break;
                    }

            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        float numero1, numero2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            numero2 = float.Parse(textNumero2.Text);
            float resultado = numero1 - numero2;
            textNumero3.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            numero2 = float.Parse(textNumero2.Text);
            float resultado = numero1 * numero2;
            textNumero3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            numero2 = float.Parse(textNumero2.Text);
            float resultado = numero1 / numero2;
            textNumero3.Text = resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            numero2 = float.Parse(textNumero2.Text);
            Double resultado = Math.Pow(numero1,numero2);
            textNumero3.Text = resultado.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            float resultado = factorial(numero1);
            textNumero3.Text = resultado.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           numero1 = float.Parse(textNumero1.Text);
           numero2 = float.Parse(textNumero2.Text);
           float resultado = numero1 + numero2;
            textNumero3.Text = resultado.ToString();
            
        }


        private float factorial(float numero)
        {
            float res = 1;
            for(int i = 1; i <= numero; i++)
            {
                res *= i;
            }

            return res;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(textNumero1.Text);
            numero2 = float.Parse(textNumero2.Text);
            Double resultado = raizN(numero1, numero2);
            textNumero3.Text = resultado.ToString();
        }

        private Double raizN(float base1,float raiz)
        {
            return (Math.Pow(base1, (1 / raiz)));
        }
    }
}

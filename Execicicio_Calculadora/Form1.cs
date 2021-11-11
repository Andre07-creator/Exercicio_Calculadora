using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execicicio_Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToUInt16( textBox1.Text);
            valor2 = Convert.ToUInt16(textBox2.Text);
            resultado = valor1 + valor2;
            label3.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToUInt16(textBox1.Text);
            valor2 = Convert.ToUInt16(textBox2.Text);

            resultado = valor1 - valor2;
            label3.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToUInt16(textBox1.Text);
            valor2 = Convert.ToUInt16(textBox2.Text);
            
            if(valor2 != 0)
            {
                resultado = valor1 / valor2;
                label3.Visible = true;
                textBox3.Visible = true;
                textBox3.Text = Convert.ToString(resultado); 

            }
            else
            {
                MessageBox.Show("Não é possivel divisão por zero");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToUInt16(textBox1.Text);
            valor2 = Convert.ToUInt16(textBox2.Text);
            resultado = valor1 * valor2;
            label3.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = Convert.ToString(resultado);
        }

        private void btlsair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente fechar esta aplicação ?", "Atenção!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( result == DialogResult.No)
            {

            }
            else
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            label3.Visible = false;
            textBox3.Visible = false;
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }     
}

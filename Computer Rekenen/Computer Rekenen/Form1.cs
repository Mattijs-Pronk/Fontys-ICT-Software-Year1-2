using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Rekenen
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;
        double solution;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btTimes_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);
            solution = number1 * number2;
            tbNumber1.Text = solution.ToString();

            tbSolution.Text = solution.ToString();

            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);
            solution = number1 - number2;
            tbNumber1.Text = solution.ToString();

            tbSolution.Text = solution.ToString();
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);
            solution = number1 / number2;
            tbNumber1.Text = solution.ToString();

            tbSolution.Text = solution.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSolution_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);
            solution = number1 + number2;
            tbNumber1.Text = solution.ToString();

            tbSolution.Text = solution.ToString();
        }
    }
}

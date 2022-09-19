using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worpengenerator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRolls_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btDice_Click(object sender, EventArgs e)
        {
            int Rolls;
            int Random;
            int Totaleyes;

            lbSolution.Items.Clear();
            Rolls = Convert.ToInt32(nudRolls.Value);
            Totaleyes = Convert.ToInt32(nudEyes.Value);
            Random rnd = new Random();

            for (int i = 0; i < Rolls; i++)
            {
                Random = rnd.Next(1, Totaleyes);
                lbSolution.Items.Add(Random);
            }
            {
                int i = 0, Solution = 0;
                while (i < lbSolution.Items.Count)
                {
                    Solution += Convert.ToInt32(lbSolution.Items[i++]);
                }

                tbSolution.Text = Convert.ToString(Solution);
            }
        }
        private void lbSolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}

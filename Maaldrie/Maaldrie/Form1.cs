using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maaldrie
{
    public partial class Form1 : Form
    {   int Timesthree(int input)
        {
            int output = input * 3;
            return output;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Solution;
            for (int i = 1; i < 11; i++)
            {
                Solution = Timesthree(i);
                lbSolution.Items.Add(Solution);
            }
        }
    }
}

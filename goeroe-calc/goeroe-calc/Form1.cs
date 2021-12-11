using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goeroe_calc
{
    public partial class Form1 : Form
    {
        double getal1, getal2, uitkomst;
        public Form1()
        {
            InitializeComponent();
        }

        private void getal1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            getal1 = Convert.ToDouble(tbgetal1.Text);
            getal2 = Convert.ToDouble(tbgetal2.Text);
            uitkomst = getal1 + getal2;
            uitkomst = Math.Round(uitkomst, 2);
            tbuitkomst.Text = uitkomst.ToString();
        }

        private void tbgetal2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btkeer_Click(object sender, EventArgs e)
        {
            getal1 = Convert.ToDouble(tbgetal1.Text);
            getal2 = Convert.ToDouble(tbgetal2.Text);
            uitkomst = getal1 * getal2;
            uitkomst = Math.Round(uitkomst, 2);
            tbuitkomst.Text = uitkomst.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

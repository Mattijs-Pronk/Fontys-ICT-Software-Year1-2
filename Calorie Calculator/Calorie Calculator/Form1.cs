using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class Form1 : Form
    {
        double Male = 2500;
        double Female = 2000;
        double Active = 1;
        double Inactive = 0.9;
        double Age = 200;
        double Cal;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbGeslacht_Enter(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
                Cal = (Male);

            else
            {
                Cal = (Female);
            }
            {
                if (rbActive.Checked == true)
                    Cal = (Cal * Active);

                else

                    Cal = (Cal * Inactive);
            }
            {
                if (Convert.ToInt32(tbAge.Text) > 50 == true)
                    Cal = (Cal - Age);

                else

                    Cal = Cal;

            }
            MessageBox.Show(Cal + "Calories");
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televisie
{

    public partial class Form1 : Form
    {
        TextBox[] programs = new TextBox[100];
        Button Add = new Button();
        public Form1()
        {
            InitializeComponent();
            string[] programs = new string[100];
            programs[0] = "NPO1";
            programs[1] = "NPO2";
            programs[2] = "NPO3";
            lbPrograms.Items.Add(programs[0]);
            lbPrograms.Items.Add(programs[1]);
            lbPrograms.Items.Add(programs[2]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOn.Checked == true)
                lbSolution.Text = ("On");


        }

        private void rbOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOff.Checked == true)
                lbSolution.Text = ("Off");
        }

        private void lbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
         
        }
    }
}

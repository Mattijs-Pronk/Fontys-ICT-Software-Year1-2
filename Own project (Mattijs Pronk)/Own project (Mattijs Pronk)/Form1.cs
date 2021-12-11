using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Own_project__Mattijs_Pronk_
{
    public partial class Form1 : Form
    {
        double balance = 5000;

        void Add(int i)
        {
            tbInterface.Text += Convert.ToString(i);
        }

        void MoneyAdd()
        {
            balance = balance + Convert.ToDouble(tbInterface.Text);
            tbInterface.Text = Convert.ToString("Balance " + balance);
        }

        void MoneyTake()
        {
            balance = balance - Convert.ToDouble(tbInterface.Text);
            tbInterface.Text = Convert.ToString("Balance " + balance);
        }   


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btNumber1_Click(object sender, EventArgs e)
        {
            Add(1);
        }

        private void btNumber2_Click(object sender, EventArgs e)
        {
            Add(2);
        }

        private void btNumber3_Click(object sender, EventArgs e)
        {
            Add(3);
        }

        private void btNumber0_Click(object sender, EventArgs e)
        {
            Add(0);
        }

        private void btNumber4_Click(object sender, EventArgs e)
        {
            Add(4);
        }

        private void btNumber5_Click(object sender, EventArgs e)
        {
            Add(5);
        }

        private void btNumber6_Click(object sender, EventArgs e)
        {
            Add(6);
        }

        private void btNumber7_Click(object sender, EventArgs e)
        {
            Add(7);
        }

        private void btNumber8_Click(object sender, EventArgs e)
        {
            Add(8);
        }

        private void btNumber9_Click(object sender, EventArgs e)
        {
            Add(9);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbInterface.Text = String.Empty;
        }

        private void btBalance_Click(object sender, EventArgs e)
        {

        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btLoan_Click(object sender, EventArgs e)
        {

        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbInterface_Enter(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            if (rbDeposit.Checked == true) {
                lbHistory.Items.Add("+" + Convert.ToString(tbInterface.Text));
                MoneyAdd();
                lbHistory.Items.Add("Balance " + balance);
            }

            if (rbWithdraw.Checked == true){
                lbHistory.Items.Add("-" + Convert.ToString(tbInterface.Text));
                MoneyTake();
                lbHistory.Items.Add("Balance " + balance);
            }

            if (rbBalance.Checked == true)
            {
                tbInterface.Text = Convert.ToString(balance);
            }

            string[] names = new string[] { "Succesfull", "Done", "Okay" };
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            MessageBox.Show(Convert.ToString(names[index]));

            tbInterface.Text = String.Empty;
        }

        private void tbInterface_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbInterface.Text = String.Empty;
            lbHistory.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

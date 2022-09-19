using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using Fitnessplanner3;

namespace InterfaceLayer
{
    public partial class LoginUser : Form
    {
        Login login = new Login();

        public string Email;
        public string Password;

        public LoginUser()
        {
            InitializeComponent();

            tbPassword.ForeColor = Color.Black;
            tbPassword.UseSystemPasswordChar = true;
        }

        public void Checktb()
        {
            Email = tbEmail.Text;
            Password = tbPassword.Text;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Checktb();

            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            login.LoginUser(Email, Password);

            if (login.usertype == 1)
            {
                MessageBox.Show("User logged in", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reservation reservation = new Reservation();
                reservation.Show();
                this.Hide();
            }

            else if(login.usertype == 2)
            {
                MessageBox.Show("Admin logged in", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagement accmanagement = new AccountManagement();
                accmanagement.Show();
                this.Hide();
            }

            else if(login.usertype == 3)
            {
                tbPassword.Text = "";
                MessageBox.Show("User not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked == true)
            {
                tbPassword.ForeColor = Color.Black;
                tbPassword.UseSystemPasswordChar = false;
            }

            else
            {
                tbPassword.ForeColor = Color.Black;
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

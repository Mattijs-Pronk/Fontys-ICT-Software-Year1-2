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
using DatabaseLayer;

namespace ViewLayer
{
    public partial class LoginUser : Form
    {
        Login login;

        public LoginUser()
        {
            InitializeComponent();
            login = new Login(new LoginDAL());

            tbPassword.ForeColor = Color.Black;
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Login lg = new Login(tbEmail.Text, tbPassword.Text);
            if(login.LoginUserExists(lg) == true)
            {
                login.LoginUser(lg);
                AccountManagement account = new AccountManagement();
                this.Hide();
                account.Show();
            } 

            else
            {
                MessageBox.Show("Incorrect Email or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btSkip_Click(object sender, EventArgs e)
        {
            AccountManagement account = new AccountManagement();
            this.Hide();
            account.Show();
        }
    }
}

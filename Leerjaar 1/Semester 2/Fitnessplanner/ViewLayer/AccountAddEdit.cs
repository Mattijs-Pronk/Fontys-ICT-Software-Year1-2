using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitnessplanner3;
using BusinessLogicLayer;
using InterfaceLayer;

namespace InterfaceLayer
{
    public partial class AccountAddEdit : Form
    {
        AccountContainer accContainer;
        Account account;

        public int Id;

        public string Firstname;

        public string Lastname;

        public string Adress;

        public string Email;

        public string Password;

        public string Usertype;

        public AccountAddEdit()
        {
            InitializeComponent();

            accContainer = new AccountContainer();
            account = new Account();
            Filltb();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbFirstname.Text = "";
            tbLastname.Text = "";
            tbAdress.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbUsertype.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to exit", "Edit account", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btSavecreate_Click(object sender, EventArgs e)
        {
            Checktb();
            
            if (tbFirstname.Text == "" || tbLastname.Text == "" || tbAdress.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" || cbUsertype.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (tbPassword.Text.Length < 6)
            {
                MessageBox.Show("Password is to short, use password with atleast 6 characters", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to create this account", "Update Timeslot/day", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    accContainer.CheckForDoubleAccount(Email);

                    if (accContainer.check == true)
                    {
                        MessageBox.Show("Email already exists, please choose a different email adress", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (accContainer.check == false)
                    {
                        accContainer.CreateOneAccount(Firstname, Lastname, Adress, Email, Password, Usertype);

                        MessageBox.Show(string.Format("Account succesfully created with" + Environment.NewLine + "" + Environment.NewLine + "Firstname: {0}" + Environment.NewLine + "Lastname: {1}" + Environment.NewLine + "Adress: {2}" + Environment.NewLine + "Email: {3}"
                        + Environment.NewLine + "Password: {4}" + Environment.NewLine + "Usertype: {5}", Firstname, Lastname, Adress, Email, Password, Usertype));

                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Account not updated", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Checktb()
        {
            Firstname = tbFirstname.Text;
            Lastname = tbLastname.Text;
            Adress = tbAdress.Text;
            Email = tbEmail.Text;
            Password = tbPassword.Text;
            Usertype = cbUsertype.Text;
        }

        public void Filltb()
        {
            tbFirstname.Text = AccountManagement.Firstname;
            tbLastname.Text = AccountManagement.Lastname;
            tbAdress.Text = AccountManagement.Adress;
            tbEmail.Text = AccountManagement.Email;
            tbPassword.Text = AccountManagement.Password;
            cbUsertype.Text = AccountManagement.Usertype;
        }

        private void btSaveedit_Click(object sender, EventArgs e)
        {
            Checktb();

            if (tbFirstname.Text == "" || tbLastname.Text == "" || tbAdress.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" || cbUsertype.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (tbPassword.Text.Length < 6)
            {
                MessageBox.Show("Password is to short, use password with atleast 6 characters", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to update this account", "Account manager", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    account.EditOneAccount(AccountManagement.Id, Firstname, Lastname, Adress, Email, Password, Usertype);

                    MessageBox.Show(string.Format("Account succesfully updated with" + Environment.NewLine + "" + Environment.NewLine + "Firstname: {0}" + Environment.NewLine + "Lastname: {1}" + Environment.NewLine + "Adress: {2}" + Environment.NewLine + "Email: {3}"
                    + Environment.NewLine + "Password: {4}" + Environment.NewLine + "Usertype: {5}", Firstname, Lastname, Adress, Email, Password, Usertype));

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Account has not been updated", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }
    }
}

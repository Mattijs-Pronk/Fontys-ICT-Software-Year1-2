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
    public partial class AccountAddEdit : Form
    {
        UserContainer userContainer;
        User user;

        public string StartDay;
        public string EndDay;

        public AccountAddEdit()
        {
            InitializeComponent();
            userContainer = new UserContainer(new UserDAL());
            user = new User(new UserDAL());

            Filltb();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbFirstname.Text = "";
            tbLastname.Text = "";
            tbAdress.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbSubscription.Text = "";
            cbUsertype.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
           this.Close();
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
                    if (userContainer.UserExists(tbEmail.Text) == true)
                    {
                        MessageBox.Show("Email already exists, please choose a different email adress", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User us1 = new User(tbFirstname.Text, tbLastname.Text, tbAdress.Text, tbEmail.Text, tbPassword.Text, cbUsertype.Text, StartDay, DateTime.Now.AddDays(1).ToString());
                        userContainer.AddOneUser(us1);

                        MessageBox.Show("Account succesfully created", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            StartDay = DateTime.Now.ToString();
            EndDay = AccountManagement.SubscriptionEnd;

            var Currentdate = DateTime.Now;
            var Enddate1 = Currentdate.AddMonths(1);
            var Enddate3 = Currentdate.AddMonths(3);
            var Enddate6 = Currentdate.AddMonths(6);
            var Enddate9 = Currentdate.AddMonths(9);
            var Enddate12 = Currentdate.AddMonths(12);
            if (cbSubscription.Text == "1 Month")
            {
                EndDay = Enddate1.ToString();
            }

            else if (cbSubscription.Text == "3 Months")
            {
                EndDay = Enddate3.ToString();
            }

            else if (cbSubscription.Text == "6 Months")
            {
                EndDay = Enddate6.ToString();
            }

            else if (cbSubscription.Text == "9 Months")
            {
                EndDay = Enddate9.ToString();
            }

            else if (cbSubscription.Text == "12 Months")
            {
                EndDay = Enddate12.ToString();
            }
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
                    if (userContainer.CheckForPermisson(AccountManagement.Id) == true)
                    {
                        User us1 = new User(AccountManagement.Id, tbFirstname.Text, tbLastname.Text, tbAdress.Text, tbEmail.Text, tbPassword.Text, cbUsertype.Text, AccountManagement.SubscriptionStart, EndDay);
                        user.EditOneUserById(us1);

                        MessageBox.Show("Account succesfully updated", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Invalid permissions", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Account has not been updated", "Account manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
        }
    }
}

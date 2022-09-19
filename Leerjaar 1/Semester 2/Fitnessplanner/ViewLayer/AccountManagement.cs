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
using InterfaceLayer;
using Fitnessplanner3;

namespace Fitnessplanner3
{
    public partial class AccountManagement : Form
    {
        AccountContainer accContainer;

        static public int Id;
        static public string Firstname;
        static public string Lastname;
        static public string Adress;
        static public string Email;
        static public string Password;
        static public string Usertype;

        public string Search;

        public AccountManagement()
        {
            InitializeComponent();

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            //datagridview opmaak.
            dgvUsers.ColumnCount = 7;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[1].Name = "Firstname";
            dgvUsers.Columns[2].Name = "Lastname";
            dgvUsers.Columns[3].Name = "Email";
            dgvUsers.Columns[4].Name = "Adress";
            dgvUsers.Columns[5].Name = "Password";
            dgvUsers.Columns[6].Name = "Usertype";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnDelete.HeaderText = "Delete";
            btnEdit.Name = "ButtonEdit";
            btnDelete.Name = "ButtonDelete";
            btnEdit.Text = "Edit";
            btnDelete.Text = "Delete";
            btnEdit.UseColumnTextForButtonValue = true;
            btnDelete.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Add(btnEdit);
            dgvUsers.Columns.Add(btnDelete);

            accContainer = new AccountContainer();

            //datagridview vullen.
            FillGridView();

            
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["Id"].Value);
            Firstname = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Firstname"].Value);
            Lastname = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Lastname"].Value);
            Adress = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Adress"].Value);
            Email = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Email"].Value);
            Password = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Password"].Value);
            Usertype = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Usertype"].Value);

            if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                    AccountAddEdit edit = new AccountAddEdit();
                    edit.btSavecreate.Visible = false;
                    edit.btSavecreate.Enabled = false;
                    edit.btSaveedit.Visible = true;
                    edit.btSaveedit.Enabled = true;
                    edit.ShowDialog();
                    FillGridView();
            }

            else if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete acount", "Delete account", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    accContainer.CheckForPermissonAccount(Id);

                    if(accContainer.usertype == true)
                    {
                        accContainer.DeleteOneAccount(Id);
                        MessageBox.Show(string.Format("Account with Id: {0} has been deleted", Id, "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information));
                        FillGridView();
                    }

                    else if (accContainer.usertype == false)
                    {
                        MessageBox.Show("Invalid permissions, chosen account is Admin", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Account has not been deleted", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAddaccount_Click(object sender, EventArgs e)
        {
            AccountAddEdit edit = new AccountAddEdit();
            edit.btSavecreate.Visible = true;
            edit.btSavecreate.Enabled = true;
            edit.btSaveedit.Visible = false;
            edit.btSaveedit.Enabled = false;
            edit.ShowDialog();
            FillGridView();
        }

        public void FillGridView()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();

            //datagridview vullen.
            foreach (Account accounts in accContainer.GetAllAccounts())
            {
                dgvUsers.Rows.Add(accounts.Id, accounts.Firstname, accounts.Lastname, accounts.Adress, accounts.Email, accounts.Password, accounts.Usertype);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();

            Search = tbSearch.Text;

            //datagridview vullen.
            foreach (Account accounts in accContainer.GetOneAccount(Search))
            {
                dgvUsers.Rows.Add(accounts.Id, accounts.Firstname, accounts.Lastname, accounts.Adress, accounts.Email, accounts.Password, accounts.Usertype);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btResmanager_Click(object sender, EventArgs e)
        {
            ReservationManagement resmanager = new ReservationManagement();
            this.Hide();
            resmanager.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser loginuser = new LoginUser();
            loginuser.Show();
            this.Hide();
        }

        private void btReservations_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }
    }
}

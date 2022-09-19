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
using ViewLayer;

namespace ViewLayer
{
    public partial class AccountManagement : Form
    {
        UserContainer userContainer;

        static public int Id;
        static public string Firstname;
        static public string Lastname;
        static public string Adress;
        static public string Email;
        static public string Password;
        static public string Usertype;
        static public string SubscriptionStart;
        static public string SubscriptionEnd;

        public string Search;

        public AccountManagement()
        {
            InitializeComponent();
            userContainer = new UserContainer(new UserDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvUsers.ReadOnly = true;
            //datagridview opmaak.
            dgvUsers.ColumnCount = 9;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[1].Name = "Firstname";
            dgvUsers.Columns[2].Name = "Lastname";
            dgvUsers.Columns[3].Name = "Adress";
            dgvUsers.Columns[4].Name = "Email";
            dgvUsers.Columns[5].Name = "Password";
            dgvUsers.Columns[6].Name = "Usertype";
            dgvUsers.Columns[7].Name = "SubStart";
            dgvUsers.Columns[8].Name = "SubEnd";
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
            SubscriptionStart = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["SubStart"].Value);
            SubscriptionEnd = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["SubEnd"].Value);

            if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                AccountAddEdit edit = new AccountAddEdit();
                edit.btSavecreate.Visible = false;
                edit.btSavecreate.Enabled = false;
                edit.btSaveedit.Visible = true;
                edit.btSaveedit.Enabled = true;
                edit.cbSubscription.Visible = true;
                edit.lbSub.Visible = true;
                edit.ShowDialog();
                FillGridView();
            }

            else if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete acount", "Delete account", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if(userContainer.CheckForPermisson(Id) == true)
                    {
                        userContainer.DeleteOneUserById(Id);
                        MessageBox.Show(string.Format("Account with Email: {0} has been deleted", Email, "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information));
                        FillGridView();
                    }

                    else
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
            edit.cbSubscription.Visible = false;
            edit.lbSub.Visible = false;
            edit.ShowDialog();
            FillGridView();
        }

        public void FillGridView()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();

            //datagridview vullen.
            foreach (User user in userContainer.GetAllUsers())
            {
                dgvUsers.Rows.Add(user.Id, user.Firstname, user.Lastname, user.Adress, user.Email, user.Password, user.Usertype, user.SubscriptionStart, user.SubscriptionEnd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();

            //datagridview vullen.
            User user = userContainer.GetOneUserByEmail(tbSearch.Text);
            {
                dgvUsers.Rows.Add(user.Id, user.Firstname, user.Lastname, user.Adress, user.Email, user.Password, user.Usertype, user.SubscriptionStart, user.SubscriptionEnd);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            FillGridView();
        }


        #region Navigation
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

        private void btMyreservations_Click(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Close();
            myreservations.Show();
        }

        private void btMachinemanager_Click(object sender, EventArgs e)
        {
            MachineManagement machine = new MachineManagement();
            this.Hide();
            machine.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            this.Hide();
            accountManagement.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserreservationManagement userreservation = new UserreservationManagement();
            this.Hide();
            userreservation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subscriptions subscriptions = new Subscriptions();
            this.Hide();
            subscriptions.Show();
        }
        #endregion


    }
}

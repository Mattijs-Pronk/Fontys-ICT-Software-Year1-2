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
    public partial class ReservationManagement : Form
    {
        TimeslotContainer timeslotContainer;
        BusinessLogicLayer.Reservation reservation;
        ReservationContainer reservationContainer;

        static public int ReservationId;
        static public string Day;
        static public string Timeslots;
        static public int Currentreservations;
        static public int Maxreservations = 60;

        public ReservationManagement()
        {
            InitializeComponent();
            timeslotContainer = new TimeslotContainer(new TimeslotDAL());
            reservation = new BusinessLogicLayer.Reservation(new ReservationDAL());
            reservationContainer = new ReservationContainer(new ReservationDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvReservations.ColumnCount = 5;
            dgvReservations.Columns[0].Name = "ReservationId";
            dgvReservations.Columns[1].Name = "Day";
            dgvReservations.Columns[2].Name = "Timeslot";
            dgvReservations.Columns[3].Name = "Currentreservations";
            dgvReservations.Columns[4].Name = "Maxreservations";
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dgvReservations.Columns.Add(btnEdit);
            dgvReservations.Columns.Add(btnDelete);

            FillGridView();
        }

        private void btResmanager_Click(object sender, EventArgs e)
        {
            AccountManagement accmanagement = new AccountManagement();
            this.Hide();
            accmanagement.Show();
        }

        private void btAddaccount_Click(object sender, EventArgs e)
        {
            ReservationAddEdit edit = new ReservationAddEdit();
            edit.btSaveRes.Visible = true;
            edit.btSaveRes.Enabled = true;
            edit.btSaveedit.Visible = false;
            edit.btSaveedit.Enabled = false;
            edit.cbWeek.Visible = true;
            edit.lbCbDescription.Visible = true;
            edit.ShowDialog();
            FillGridView();
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        public void FillGridView()
        {
            dgvReservations.Rows.Clear();
            dgvReservations.Refresh();

            //datagridview vullen.
            foreach (Timeslot timeslot in timeslotContainer.GetAllTimeslots())
            {
                timeslot.Currentreservations = reservation.CurrentReservations(timeslot.TimeslotID);
                dgvReservations.Rows.Add(timeslot.TimeslotID, timeslot.Day, timeslot.Timeslots, timeslot.Currentreservations, timeslot.Maxreservations);
            }
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReservationId = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["ReservationId"].Value);
            Day = Convert.ToString(dgvReservations.Rows[e.RowIndex].Cells["Day"].Value);
            Timeslots = Convert.ToString(dgvReservations.Rows[e.RowIndex].Cells["Timeslot"].Value);
            Currentreservations = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["Currentreservations"].Value);
            Maxreservations = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["Maxreservations"].Value);

            if (dgvReservations.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                ReservationAddEdit edit = new ReservationAddEdit();
                edit.btSaveRes.Visible = false;
                edit.btSaveRes.Enabled = false;
                edit.btSaveedit.Visible = true;
                edit.btSaveedit.Enabled = true;
                edit.cbWeek.Visible = false;
                edit.lbCbDescription.Visible = false;
                edit.ShowDialog();
                FillGridView();
            }

            else if (dgvReservations.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete Timeslot/day", "Delete Timeslot/day", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    timeslotContainer.DeleteOneTimeslotById(ReservationId);
                    MessageBox.Show("Timeslot/day has been deleted", "Delete Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGridView();
                }

                else
                {
                    MessageBox.Show("Timeslot/day has not been deleted", "Delete Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvReservations.Rows.Clear();
            dgvReservations.Refresh();

            foreach (Timeslot timeslot in timeslotContainer.GetTimeslotsByDay(tbSearch.Text))
            {
                dgvReservations.Rows.Add(timeslot.TimeslotID, timeslot.Day, timeslot.Timeslots, timeslot.Currentreservations, timeslot.Maxreservations);
            }
        }


        #region Navigation
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btResmanager_Click_1(object sender, EventArgs e)
        {
            ReservationManagement reservation = new ReservationManagement();
            this.Hide();
            reservation.Show();
        }

        private void btMachinemanager_Click_1(object sender, EventArgs e)
        {
            MachineManagement machine = new MachineManagement();
            this.Hide();
            machine.Show();
        }

        private void btReservations_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            this.Hide();
            reservation.Show();
        }

        private void btMyreservations_Click_1(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Hide();
            myreservations.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Subscriptions subscriptions = new Subscriptions();
            this.Hide();
            subscriptions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserreservationManagement userreservation = new UserreservationManagement();
            this.Hide();
            userreservation.Show();
        }
        #endregion


    }
}

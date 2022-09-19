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

namespace InterfaceLayer
{
    public partial class ReservationManagement : Form
    {
        TimereservationContainer trContainer = new TimereservationContainer();

        static public int ReservationId;
        static public string Day;
        static public string Timeslots;
        static public int Currentreservations;
        static public int Maxreservations;

        public string Search;

        public ReservationManagement()
        {
            InitializeComponent();

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
            foreach (Timereservation timeslots in trContainer.GetAllTimeslots())
            {
                dgvReservations.Rows.Add(timeslots.TimeslotID, timeslots.Day, timeslots.Timeslot, timeslots.Currentreservations, timeslots.Maxreservations);
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
                    edit.ShowDialog();
                    FillGridView();
            }

            else if (dgvReservations.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete Timeslot/day", "Delete Timeslot/day", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    trContainer.DeleteOneTimeslot(ReservationId);
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
            Search = tbSearch.Text;

            dgvReservations.Rows.Clear();
            dgvReservations.Refresh();

            foreach (Timereservation timeslots in trContainer.GetOneTimeslot(Search))
            {
                dgvReservations.Rows.Add(timeslots.TimeslotID, timeslots.Day, timeslots.Timeslot, timeslots.Currentreservations, timeslots.Maxreservations);
            }
        }

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
    }
}

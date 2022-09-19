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
    public partial class Myreservations : Form
    {
        ReservationContainer reservationContainer;
        BusinessLogicLayer.Reservation reservation;

        public static int UserbookingId;
        public int UserreservationId;
        public string Userday;
        public string Usertimeslot;
        public int Usercurrentreservations;
        public int Usermaxreservations;

        public Myreservations()
        {
            InitializeComponent();
            reservationContainer = new ReservationContainer(new ReservationDAL());
            reservation = new BusinessLogicLayer.Reservation(new ReservationDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvMyreservations.ColumnCount = 8;
            dgvMyreservations.Columns[0].Name = "BookingID";
            dgvMyreservations.Columns[0].Visible = false;
            dgvMyreservations.Columns[1].Name = "UserID";
            dgvMyreservations.Columns[1].Visible = false;
            dgvMyreservations.Columns[2].Name = "TimeslotID";
            dgvMyreservations.Columns[2].Visible = false;
            dgvMyreservations.Columns[3].Name = "Day";
            dgvMyreservations.Columns[4].Name = "Timeslot";
            dgvMyreservations.Columns[5].Name = "Currentreservations";
            dgvMyreservations.Columns[6].Name = "Maxreservations";
            dgvMyreservations.Columns[7].Name = "ProgramName";
            dgvMyreservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnProgram = new DataGridViewButtonColumn();
            btnCancel.HeaderText = "Cancel";
            btnProgram.HeaderText = "Choose Program";
            btnCancel.Name = "Cancel";
            btnProgram.Name = "Program";
            btnCancel.Text = "Cancel";
            btnProgram.Text = "Program";
            btnCancel.UseColumnTextForButtonValue = true;
            btnProgram.UseColumnTextForButtonValue = true;
            dgvMyreservations.Columns.Add(btnProgram);
            dgvMyreservations.Columns.Add(btnCancel);
            FillGridView();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            this.Close();
            login.Show();
        }

        public void FillGridView()
        {
            dgvMyreservations.Rows.Clear();
            dgvMyreservations.Refresh();

            //datagridview vullen.
            foreach(BusinessLogicLayer.Reservation reservate in reservationContainer.GetAllReservationsById(Login.userId))
            {
                dgvMyreservations.Rows.Add(reservate.BookingID, reservate.UserID, reservate.TimeslotID, reservate.Timeslot.Day, reservate.Timeslot.Timeslot, reservate.Timeslot.Currentreservations, reservate.Timeslot.Maxreservations, reservate.Program.Programname);
            }
        }

        private void dgvMyreservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserbookingId = Convert.ToInt32(dgvMyreservations.Rows[e.RowIndex].Cells["BookingID"].Value);
            UserreservationId = Convert.ToInt32(dgvMyreservations.Rows[e.RowIndex].Cells["UserID"].Value);
            Userday = Convert.ToString(dgvMyreservations.Rows[e.RowIndex].Cells["Day"].Value);
            Usertimeslot = Convert.ToString(dgvMyreservations.Rows[e.RowIndex].Cells["Timeslot"].Value);
            Usercurrentreservations = Convert.ToInt32(dgvMyreservations.Rows[e.RowIndex].Cells["Currentreservations"].Value);
            Usermaxreservations = Convert.ToInt32(dgvMyreservations.Rows[e.RowIndex].Cells["Maxreservations"].Value);

            if (dgvMyreservations.Columns[e.ColumnIndex].HeaderText == "Cancel")
            {
                var res = MessageBox.Show("Are you sure you want to Cancel booking", "MyReservations", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    reservationContainer.DeleteOneReservationByBookingId(UserbookingId);
                    MessageBox.Show(string.Format("Reservation on day: {0} at {1} has been canceled", Userday, Usertimeslot, "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    FillGridView();
                }

                else
                {
                    MessageBox.Show("Booking has not been canceled", "MyReservations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (dgvMyreservations.Columns[e.ColumnIndex].HeaderText == "Choose Program")
            {
                BookingPrograms booking = new BookingPrograms();
                this.Hide();
                booking.Show();
            }
        }


        #region Navigation
        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            this.Hide();
            accountManagement.Show();
        }

        private void btResmanager_Click(object sender, EventArgs e)
        {
            ReservationManagement reservation = new ReservationManagement();
            this.Hide();
            reservation.Show();
        }

        private void btMachinemanager_Click(object sender, EventArgs e)
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

        private void btMyreservations_Click(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Hide();
            myreservations.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

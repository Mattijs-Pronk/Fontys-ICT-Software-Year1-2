using BusinessLogicLayer;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayer;

namespace ViewLayer
{
    public partial class UserreservationManagement : Form
    {
        ReservationContainer reservationContainer;

        public static int UserbookingId;
        public int UserreservationId;
        public string Useremail;
        public string Userday;
        public string Usertimeslot;
        public int Usercurrentreservations;
        public int Usermaxreservations;

        public UserreservationManagement()
        {
            InitializeComponent();
            reservationContainer = new ReservationContainer(new ReservationDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvUserreservations.ColumnCount = 6;
            dgvUserreservations.Columns[0].Name = "BookingID";
            dgvUserreservations.Columns[0].Visible = false;
            dgvUserreservations.Columns[1].Name = "Day";
            dgvUserreservations.Columns[2].Name = "Timeslot";
            dgvUserreservations.Columns[3].Name = "Currentreservations";
            dgvUserreservations.Columns[4].Name = "Maxreservations";
            dgvUserreservations.Columns[5].Name = "Program";
            dgvUserreservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn();
            btnCancel.HeaderText = "Cancel";
            btnCancel.Name = "ButtonCancel";
            btnCancel.Text = "Cancel";
            btnCancel.UseColumnTextForButtonValue = true;
            dgvUserreservations.Columns.Add(btnCancel);

            FillGridView();
        }

        public void FillGridView()
        {
            dgvUserreservations.Rows.Clear();
            dgvUserreservations.Refresh();

            //datagridview vullen.
            foreach (BusinessLogicLayer.Reservation reservation in reservationContainer.GetAllReservations())
            {
                dgvUserreservations.Rows.Add(reservation.BookingID, reservation.Timeslot.Day, reservation.Timeslot.Timeslot, reservation.Timeslot.Currentreservations, reservation.Timeslot.Maxreservations, reservation.Program.Programname);
            }
        }

        private void dgvUserreservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserbookingId = Convert.ToInt32(dgvUserreservations.Rows[e.RowIndex].Cells["BookingId"].Value);
            Userday = Convert.ToString(dgvUserreservations.Rows[e.RowIndex].Cells["Day"].Value);
            Usertimeslot = Convert.ToString(dgvUserreservations.Rows[e.RowIndex].Cells["Timeslot"].Value);
            Usercurrentreservations = Convert.ToInt32(dgvUserreservations.Rows[e.RowIndex].Cells["Currentreservations"].Value);
            Usermaxreservations = Convert.ToInt32(dgvUserreservations.Rows[e.RowIndex].Cells["Maxreservations"].Value);

            if (dgvUserreservations.Columns[e.ColumnIndex].HeaderText == "Cancel")
            {
                var res = MessageBox.Show("Are you sure you want to Cancel booking", "UserReservations", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    reservationContainer.DeleteOneReservationByBookingId(UserbookingId);
                    MessageBox.Show(string.Format("Reservation on day: {0} at {1} has been canceled", Userday, Usertimeslot, "UserReservations", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    FillGridView();
                }

                else
                {
                    MessageBox.Show("Booking has not been canceled", "UserReservations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            FillGridView();
        }


        #region Navigation
        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            this.Hide();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            this.Hide();
            accountManagement.Show();
        }

        private void btResmanager_Click(object sender, EventArgs e)
        {
            ReservationManagement resmanager = new ReservationManagement();
            this.Hide();
            resmanager.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserreservationManagement userreservation = new UserreservationManagement();
            this.Hide();
            userreservation.Show();
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
            reservation.Show();
            this.Hide();
        }

        private void btMyreservations_Click(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Close();
            myreservations.Show();
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

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
    public partial class Reservation : Form
    {
        Timeslot timeslot;
        TimeslotContainer timeslotContainer;
        BusinessLogicLayer.Reservation reservation;
        ReservationContainer reservationContainer;

        static public int UsertimeslotId;
        static public string Userday;
        static public string Usertimeslot;
        static public int Usercurrentreservations;
        static public int Usermaxreservations;
        static public int UserprogramId = 1;

        public string day;

        public Reservation()
        {
            InitializeComponent();
            timeslot = new Timeslot(new TimeslotDAL());
            timeslotContainer = new TimeslotContainer(new TimeslotDAL());
            reservation = new BusinessLogicLayer.Reservation(new ReservationDAL());
            reservationContainer = new ReservationContainer(new ReservationDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvTimeslots.ColumnCount = 5;
            dgvTimeslots.Columns[0].Name = "TimeslotId";
            dgvTimeslots.Columns[0].Visible = false;
            dgvTimeslots.Columns[1].Name = "Day";
            dgvTimeslots.Columns[2].Name = "Timeslot";
            dgvTimeslots.Columns[3].Name = "Currentreservations";
            dgvTimeslots.Columns[4].Name = "Maxreservations";
            dgvTimeslots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btnReserve = new DataGridViewButtonColumn();
            btnReserve.HeaderText = "Reserve";
            btnReserve.Name = "ButtonReserve";
            btnReserve.Text = "Reserve";
            btnReserve.UseColumnTextForButtonValue = true;
            dgvTimeslots.Columns.Add(btnReserve);

            Fillcb();
            //FillList();
        }

        public void FillGridView()
        {
            day = cbDays.Text;

            dgvTimeslots.Rows.Clear();
            dgvTimeslots.Refresh();

            //datagridview vullen.
            foreach (Timeslot usertimeslot in timeslotContainer.GetTimeslotsByDay(day))
            {
                usertimeslot.Currentreservations =  reservation.CurrentReservations(usertimeslot.TimeslotID);
                dgvTimeslots.Rows.Add(usertimeslot.TimeslotID, usertimeslot.Day, usertimeslot.Timeslots, usertimeslot.Currentreservations, usertimeslot.Maxreservations);
            }
        }

        public void Fillcb()
        {
            cbDays.Items.Clear();
            cbDays.Refresh();

            foreach (Timeslot userdays in timeslotContainer.GetAllDays())
            {
                cbDays.Items.Add(userdays.Day);
            }
        }

        private void cbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            this.Hide();
        }

        private void dgvTimeslots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsertimeslotId = Convert.ToInt32(dgvTimeslots.Rows[e.RowIndex].Cells["TimeslotId"].Value);
            Userday = Convert.ToString(dgvTimeslots.Rows[e.RowIndex].Cells["Day"].Value);
            Usertimeslot = Convert.ToString(dgvTimeslots.Rows[e.RowIndex].Cells["Timeslot"].Value);
            Usercurrentreservations = Convert.ToInt32(dgvTimeslots.Rows[e.RowIndex].Cells["Currentreservations"].Value);
            Usermaxreservations = Convert.ToInt32(dgvTimeslots.Rows[e.RowIndex].Cells["Maxreservations"].Value);

            if (dgvTimeslots.Columns[e.ColumnIndex].HeaderText == "Reserve")
            {
                var res = MessageBox.Show("Are you sure you want to Reserve timeslot", "Reserve", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    //Vergelijk abbonementeinde met huidige dag.
                    if(Convert.ToDateTime(Login.usersubend) < Convert.ToDateTime(Userday))
                    {
                        MessageBox.Show("You dont have a valid subscription", "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        BusinessLogicLayer.Reservation reser = new BusinessLogicLayer.Reservation(Convert.ToInt32(Login.userId), UsertimeslotId);
                        if (reservation.CheckReservationsById(reser) == true)
                        {
                            MessageBox.Show(string.Format("You already have a reservation on day: {0} at {1} " + Environment.NewLine + "Booking not made!", Userday, Usertimeslot, "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Error));
                        }

                        else
                        {
                            BusinessLogicLayer.Reservation reser1 = new BusinessLogicLayer.Reservation(Convert.ToInt32(Login.userId), UsertimeslotId, UserprogramId);
                            reservationContainer.AddOneReservation(reser1);
                            MessageBox.Show(string.Format("Day: {0} at {1} hour has been reserved", Userday, Usertimeslot, "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Information));
                            FillGridView();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Timeslot not reserved", "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        #region Navigation
        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            this.Hide();
            accountManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subscriptions subscriptions = new Subscriptions();
            this.Hide();
            subscriptions.Show();
        }

        private void btMachinemanager_Click(object sender, EventArgs e)
        {
            MachineManagement machine = new MachineManagement();
            this.Hide();
            machine.Show();
        }

        private void btMyreservations_Click_1(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Hide();
            myreservations.Show();
        }

        private void btReservations_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            this.Hide();
            reservation.Show();
        }

        private void btResmanager_Click(object sender, EventArgs e)
        {
            ReservationManagement reservation = new ReservationManagement();
            this.Hide();
            reservation.Show();
        }

        private void btAllreservations_Click(object sender, EventArgs e)
        {

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

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
using Fitnessplanner3;

namespace InterfaceLayer
{
    public partial class Reservation : Form
    {
        TimereservationContainer trContainer = new TimereservationContainer();

        public string day;

        public Reservation()
        {
            InitializeComponent();

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            if(Login.userusertype == "Admin")
            {
                btAccountmanager.Visible = true;
                btReservationsmanager.Visible = true;
            }

            else if(Login.userusertype == "User")
            {
                btAccountmanager.Visible = false;
                btReservationsmanager.Visible = false;
            }

            dgvTimeslots.ColumnCount = 4;
            dgvTimeslots.Columns[0].Name = "Day";
            dgvTimeslots.Columns[1].Name = "Timeslot";
            dgvTimeslots.Columns[2].Name = "Currentreservations";
            dgvTimeslots.Columns[3].Name = "Maxreservations";
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
            foreach (Timereservation usertimeslots in trContainer.UserGetTimeslots(day))
            {
                dgvTimeslots.Rows.Add(usertimeslots.Day, usertimeslots.Timeslot, usertimeslots.Currentreservations, usertimeslots.Maxreservations);
            }
        }

        public void Fillcb()
        {
            cbDays.Items.Clear();
            cbDays.Refresh();

            foreach (Timereservation userdays in trContainer.UserGetDays())
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

        private void btAccountmanager_Click(object sender, EventArgs e)
        {
            AccountManagement account = new AccountManagement();
            account.Show();
            this.Hide();
        }

        private void btReservationsmanager_Click(object sender, EventArgs e)
        {
            ReservationManagement reservation = new ReservationManagement();
            reservation.Show();
            this.Hide();
        }
    }
}

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
    public partial class Subscriptions : Form
    {
        User user;

        public string CurrentDay;
        public string EndDay;
        public int Price;

        public Subscriptions()
        {
            InitializeComponent();
            user = new User(new UserDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;
            lbSubend.Text = Login.usersubend;
        }

        public void Checktb()
        {
            var Currentdate = DateTime.Now;
            var Enddate1 = Currentdate.AddMonths(1);
            var Enddate3 = Currentdate.AddMonths(3);
            var Enddate6 = Currentdate.AddMonths(6);
            var Enddate9 = Currentdate.AddMonths(9);
            var Enddate12 = Currentdate.AddMonths(12);
            if (cbSubscription.Text == "1 Month")
            {
                CurrentDay = Currentdate.ToString();
                EndDay = Enddate1.ToString();
                Price = 25;
            }

            else if (cbSubscription.Text == "3 Months")
            {
                CurrentDay = Currentdate.ToString();
                EndDay = Enddate3.ToString();
                Price = 60;
            }

            else if (cbSubscription.Text == "6 Months")
            {
                CurrentDay = Currentdate.ToString();
                EndDay = Enddate6.ToString();
                Price = 90;
            }

            else if (cbSubscription.Text == "9 Months")
            {
                CurrentDay = Currentdate.ToString();
                EndDay = Enddate9.ToString();
                Price = 110;
            }

            else if (cbSubscription.Text == "12 Months")
            {
                CurrentDay = Currentdate.ToString();
                EndDay = Enddate12.ToString();
                Price = 125;
            }

            lbPrice.Text = Price.ToString();

        }

        private void btPay_Click(object sender, EventArgs e)
        {
            
            if(cbSubscription.Text == "")
            {
                MessageBox.Show("Please choose a subscription", "Subscription", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Checken of user al een actievere reservering heeft.
            else if(Convert.ToDateTime(Login.usersubend) > Convert.ToDateTime(EndDay))
            {
                MessageBox.Show("Subscription is still active", "Subscription", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to pay for subscription", "Subscription", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    User us = new User(Convert.ToInt32(Login.userId), CurrentDay, EndDay);
                    user.ChangeSubscription(us);
                    MessageBox.Show("Subscription succesfully added to account", "Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login.usersubend = EndDay;
                    lbSubend.Text = Login.usersubend;
                }
                
                else
                {
                    MessageBox.Show("Subscription not added to account", "Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checktb();
        }


        #region Navigation
        private void btReservations_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            this.Hide();
            reservation.Show();
        }

        private void btMyreservations_Click(object sender, EventArgs e)
        {
            Myreservations myreservations = new Myreservations();
            this.Close();
            myreservations.Show();
        }

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

        private void btReservations_Click_1(object sender, EventArgs e)
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

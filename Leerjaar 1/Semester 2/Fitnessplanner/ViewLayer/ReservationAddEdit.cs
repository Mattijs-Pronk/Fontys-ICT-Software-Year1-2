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
    public partial class ReservationAddEdit : Form
    {
        TimereservationContainer trContainer = new TimereservationContainer();
        Timereservation timereservation = new Timereservation();

        public string Day;
        public string Timeslot;
        public int Currentreservations = 0;
        public string Maxreservations;

        public ReservationAddEdit()
        {
            InitializeComponent();

            Filltb();
        }

        public void Checktb()
        {
            Day = tbDay.Text;
            Timeslot = tbTimeslot.Text;
            Maxreservations = tbMaxres.Text;
        }

        public void Filltb()
        {
            tbDay.Text = ReservationManagement.Day;
            tbTimeslot.Text = ReservationManagement.Timeslots;
            tbMaxres.Text = Convert.ToString(ReservationManagement.Maxreservations);
        }

        private void btSaveRes_Click(object sender, EventArgs e)
        {
            Checktb();

            if (tbDay.Text == "" || tbMaxres.Text == "" )
            {
                MessageBox.Show("Please fill in all forms", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var res = MessageBox.Show("Are you sure you want to Add Timeslot/day", "Add Timeslot/day", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (cbWeek.SelectedItem.ToString() == "Normal workday")
                {
                    Dayselection();
                    MessageBox.Show("Timeslot/Day has been created", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
                    MessageBox.Show("Timeslot/Day has been created", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }   
            }

            else if(res == DialogResult.No)
            {
                MessageBox.Show("Timeslot/Day has not been created", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSaveedit_Click(object sender, EventArgs e)
        {
            Checktb();

            label1.Visible = false;
            cbWeek.Visible = false;

            if (tbDay.Text == "" || tbTimeslot.Text == "" || tbMaxres.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var res = MessageBox.Show("Are you sure you want to edit timeslot/day", "Edit Timeslot/day", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                timereservation.EditOneTimeslot(ReservationManagement.ReservationId, Day, Timeslot, Convert.ToInt32(Maxreservations));
                MessageBox.Show("Timeslot/Day has been edited", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else if (res == DialogResult.No)
            {
                MessageBox.Show("Timeslot/Day has not been edited", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dayselection();
        }

        public void Dayselection()
        {
            Timeslot = "09:00 - 10:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "10:00 - 11:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "11:00 - 12:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "12:00 - 13:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "13:00 - 14:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "14:00 - 15:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "15:00 - 16:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "16:00 - 17:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "17:00 - 18:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "18:00 - 19:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "19:00 - 20:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "20:00 - 21:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
            Timeslot = "21:00 - 22:00";
            trContainer.AddOneTimeslot(Day, Timeslot, Currentreservations, Convert.ToInt32(Maxreservations));
        }
    }
}

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

namespace ViewLayer
{
    public partial class ReservationAddEdit : Form
    {
        TimeslotContainer timeslotContainer;
        Timeslot timeslot;

        public int Currentreservations = 0;

        public ReservationAddEdit()
        {
            InitializeComponent();
            timeslotContainer = new TimeslotContainer(new TimeslotDAL());
            timeslot = new Timeslot(new TimeslotDAL());

            Filltb();
        }

        public void Filltb()
        {
            tbDay.Text = ReservationManagement.Day;
            tbTimeslot.Text = ReservationManagement.Timeslots;
            tbMaxres.Text = Convert.ToString(ReservationManagement.Maxreservations);
        }

        private void btSaveRes_Click(object sender, EventArgs e)
        {
            if (tbDay.Text == "" || tbMaxres.Text == "" )
            {
                MessageBox.Show("Please fill in all forms", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var res = MessageBox.Show("Are you sure you want to Add Timeslot/day", "Add Timeslot/day", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Timeslot time = new Timeslot(tbDay.Text, tbTimeslot.Text, Convert.ToInt32(tbMaxres.Text));
                timeslotContainer.AddOneTimeslot(time);
                MessageBox.Show("Timeslot/Day has been created", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else if(res == DialogResult.No)
            {
                MessageBox.Show("Timeslot/Day has not been created", "Add Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSaveedit_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            cbWeek.Visible = false;

            if (tbDay.Text == "" || tbTimeslot.Text == "" || tbMaxres.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to edit timeslot/day", "Edit Timeslot/day", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (ReservationManagement.Currentreservations > Convert.ToInt32(tbMaxres.Text))
                    {
                        MessageBox.Show("The current reservations of this Timeslot/day is higher than {0}", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        Timeslot time = new Timeslot(ReservationManagement.ReservationId, tbDay.Text, tbTimeslot.Text, Convert.ToInt32(tbMaxres.Text));
                        timeslot.EditOneTimeslotById(time);
                        MessageBox.Show("Timeslot/Day has been edited", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

                else if (res == DialogResult.No)
                {
                    MessageBox.Show("Timeslot/Day has not been edited", "Edit Timeslot/day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dayselection();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbDay.Text = "";
            tbTimeslot.Text = "";
            tbMaxres.Text = "";
            cbWeek.Text = "Loose timeslot";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class BookingPrograms : Form
    {
        ProgramContainer programContainer;
        BusinessLogicLayer.Reservation reservation;

        public static int ProgramId;
        public static string Programname;
        public string Programdescription;

        public BookingPrograms()
        {
            InitializeComponent();
            programContainer = new ProgramContainer(new ProgramDAL());
            reservation = new BusinessLogicLayer.Reservation(new ReservationDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            dgvBookingprogram.ColumnCount = 3;
            dgvBookingprogram.Columns[0].Name = "ProgramId";
            dgvBookingprogram.Columns[0].Visible = false;
            dgvBookingprogram.Columns[1].Name = "ProgramName";
            dgvBookingprogram.Columns[2].Name = "ProgramDescription";

            dgvBookingprogram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btninfo = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnprogram = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btncancel = new DataGridViewButtonColumn();
            btninfo.HeaderText = "Info";
            btnprogram.HeaderText = "Reserve program";
            btncancel.HeaderText = "Cancel";
            btninfo.Name = "ButtonInfo";
            btnprogram.Name = "Reserve";
            btncancel.Name = "Cancel";
            btninfo.Text = "Info";
            btnprogram.Text = "Reserve";
            btncancel.Text = "Cancel";
            btninfo.UseColumnTextForButtonValue = true;
            btnprogram.UseColumnTextForButtonValue = true;
            btncancel.UseColumnTextForButtonValue = true;
            dgvBookingprogram.Columns.Add(btnprogram);
            dgvBookingprogram.Columns.Add(btninfo);
            dgvBookingprogram.Columns.Add(btncancel);

            FillGridView();
        }

        public void FillGridView()
        {
            dgvBookingprogram.Rows.Clear();
            dgvBookingprogram.Refresh();

            //datagridview vullen.
            foreach (BusinessLogicLayer.Program program in programContainer.GetAllPrograms())
            {
                dgvBookingprogram.Rows.Add(program.ProgramId, program.ProgramName, program.ProgramDescription);
            }
        }

        private void dgvBookingprogram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgramId = Convert.ToInt32(dgvBookingprogram.Rows[e.RowIndex].Cells["ProgramId"].Value);
            Programname = Convert.ToString(dgvBookingprogram.Rows[e.RowIndex].Cells["ProgramName"].Value);
            Programdescription = Convert.ToString(dgvBookingprogram.Rows[e.RowIndex].Cells["ProgramDescription"].Value);

            if (dgvBookingprogram.Columns[e.ColumnIndex].HeaderText == "Reserve program")
            {
                var res = MessageBox.Show("Are you sure you want to Reserve program", "Reserve program", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    BusinessLogicLayer.Reservation reser = new BusinessLogicLayer.Reservation(Myreservations.UserbookingId, ProgramId);
                    reservation.EditOneReservationById(reser);
                    MessageBox.Show("Program has been Reserved", "Reserve program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Program has not been reserved", "Reserve program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (dgvBookingprogram.Columns[e.ColumnIndex].HeaderText == "Info")
            {
                ProgramInfo program = new ProgramInfo();
                program.ShowDialog();
            }

            else if (dgvBookingprogram.Columns[e.ColumnIndex].HeaderText == "Cancel")
            {
                MessageBox.Show(string.Format("Reservation has been canceled", "Reserve", MessageBoxButtons.OK, MessageBoxIcon.Information));  
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
        #endregion


    }
}

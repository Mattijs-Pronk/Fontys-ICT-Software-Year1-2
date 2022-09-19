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
    public partial class MachineManagement : Form
    {
        MachineContainer machineContainer;

        public string Search;

        static public int MachineId;
        static public string Machinetype;
        static public string Machinename;
        static public string Machinedescription;

        public MachineManagement()
        {
            InitializeComponent();
            machineContainer = new MachineContainer(new MachineDAL());

            lbFirstname.Text = Login.userfirstname;
            lbLastname.Text = Login.userlastname;
            lbEmail.Text = Login.useremail;

            //datagridview opmaak.
            dgvMachines.ColumnCount = 4;
            dgvMachines.Columns[0].Name = "MachineId";
            dgvMachines.Columns[0].Visible = false;
            dgvMachines.Columns[1].Name = "Machinetype";
            dgvMachines.Columns[2].Name = "Machinename";
            dgvMachines.Columns[3].Name = "Machinedescription";
            dgvMachines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dgvMachines.Columns.Add(btnEdit);
            dgvMachines.Columns.Add(btnDelete);

            FillGridView();
        }

        public void FillGridView()
        {
            dgvMachines.Rows.Clear();
            dgvMachines.Refresh();

            //datagridview vullen.
            foreach (Machine machine in machineContainer.GetAllMachines())
            {
                dgvMachines.Rows.Add(machine.MachineId, machine.Machinetype, machine.Machinename, machine.Machinedescription);
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            this.Hide();
            login.Show();
        }

        private void dgvMachines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MachineId = Convert.ToInt32(dgvMachines.Rows[e.RowIndex].Cells["MachineId"].Value);
            Machinetype = Convert.ToString(dgvMachines.Rows[e.RowIndex].Cells["Machinetype"].Value);
            Machinename = Convert.ToString(dgvMachines.Rows[e.RowIndex].Cells["Machinename"].Value);
            Machinedescription = Convert.ToString(dgvMachines.Rows[e.RowIndex].Cells["Machinedescription"].Value);

            if (dgvMachines.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                MachineAddEdit machine = new MachineAddEdit();
                machine.btSaveMachine.Visible = false;
                machine.btSaveedit.Visible = true;
                machine.ShowDialog();
                FillGridView();
            }

            else if (dgvMachines.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete machine", "Delete Machine", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    machineContainer.DeleteOneMachineById(MachineId);
                    MessageBox.Show("Machine has been deleted", "Delete Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGridView();
                }

                else
                {
                    MessageBox.Show("Machine has not been deleted", "Delete Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btAddmachine_Click(object sender, EventArgs e)
        {
            MachineAddEdit machine = new MachineAddEdit();
            machine.btSaveMachine.Visible = true;
            machine.btSaveedit.Visible = false;
            machine.ShowDialog();
            FillGridView();
        }

        private void btViewall_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvMachines.Rows.Clear();
            dgvMachines.Refresh();

            //Machine mach = new Machine(tbSearch.Text);
            //datagridview vullen.
            //Machine machine = machineContainer.GetAllMachinesByMachineType(tbSearch.Text);
            //{
            //    dgvMachines.Rows.Add(machine.MachineId, machine.Machinetype, machine.Machinename, machine.Machinedescription);
            //}
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

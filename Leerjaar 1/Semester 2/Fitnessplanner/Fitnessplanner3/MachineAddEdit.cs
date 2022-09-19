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
    public partial class MachineAddEdit : Form
    {
        MachineContainer machineContainer;
        Machine machine;

        public MachineAddEdit()
        {
            InitializeComponent();
            machineContainer = new MachineContainer(new MachineDAL());
            machine = new Machine(new MachineDAL());
            Filltb();
        }

        private void btSaveMachine_Click(object sender, EventArgs e)
        {
            Machine mach = new Machine(cbMachinetype.Text, tbMachinename.Text, tbMachinedescription.Text);
            machineContainer.AddOneMachine(mach);

            this.Close();
        }

        public void Filltb()
        {
            cbMachinetype.Text = MachineManagement.Machinetype;
            tbMachinename.Text = MachineManagement.Machinename;
            tbMachinedescription.Text = MachineManagement.Machinedescription;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSaveedit_Click(object sender, EventArgs e)
        {
            if(cbMachinetype.Text == "" || tbMachinename.Text == "" || tbMachinedescription.Text == "")
            {
                MessageBox.Show("Please fill in all forms", "Edit Machine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var res = MessageBox.Show("Are you sure you want to edit machine", "Edit Machine", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Machine mach = new Machine(MachineManagement.MachineId, cbMachinetype.Text, tbMachinename.Text, tbMachinedescription.Text);
                machine.EditOneMachineById(mach);
                MessageBox.Show("Machine has been Edited", "Edit Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else if (res == DialogResult.No)
            {
                MessageBox.Show("Machine has not been Edited", "Edit Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ProgramInfo : Form
    {
        ProgramMachineContainer programmachineContainer;

        public int ProgramID;
        public ProgramInfo()
        {
            InitializeComponent();
            programmachineContainer = new ProgramMachineContainer(new ProgramMachineDAL());

            dgvProgramInfo.ColumnCount = 4;
            dgvProgramInfo.Columns[0].Name = "ProgramID";
            dgvProgramInfo.Columns[0].Visible = false;
            dgvProgramInfo.Columns[1].Name = "Machinetype";
            dgvProgramInfo.Columns[2].Name = "Machinename";
            dgvProgramInfo.Columns[3].Name = "Machinedescription";

            dgvProgramInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            FillGridView();
        }

        public void FillGridView()
        {
            dgvProgramInfo.Rows.Clear();
            dgvProgramInfo.Refresh();

            //datagridview vullen.
            foreach (ProgramMachine programmachine in programmachineContainer.GetAllProgramMachinesById(BookingPrograms.ProgramId))
            {
                dgvProgramInfo.Rows.Add(programmachine.MachineID, programmachine.Machine.Machinetype, programmachine.Machine.Machinename, programmachine.Machine.Machinedescription);
            }
        }
    }
}

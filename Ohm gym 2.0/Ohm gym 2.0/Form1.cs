using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ohm_gym_2._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btConnect.Enabled = true;
            btDisconnect.Enabled = false;
            cbBautrate.Text = "9600";
        }

        private void cbComport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbComport_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            cbComport.Items.Clear();
            cbComport.Items.AddRange(portLists);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbComport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBautrate.Text);
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Kapoet");
            }
        }
        
    }
}

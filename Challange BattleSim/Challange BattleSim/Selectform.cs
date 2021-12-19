using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange_BattleSim
{
    public partial class Selectform : Form
    {
        public int weaponselectKnight = 0;
        public int weaponselectRanger = 0;
        public Selectform()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 1;
            Weaponchange();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 2;
            Weaponchange();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 1;
            Weaponchange();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 2;
            Weaponchange();
        }

        public void Weaponchange()
        {
            if(weaponselectKnight == 1)
            {
                pbSwordKnight.BorderStyle = BorderStyle.Fixed3D;
                pbShieldKnight.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectKnight == 2)
            {
                pbSwordKnight.BorderStyle = BorderStyle.None;
                pbShieldKnight.BorderStyle = BorderStyle.Fixed3D;
            }

            if(weaponselectRanger == 1)
            {
                pbCrossbowRanger.BorderStyle = BorderStyle.Fixed3D;
                pbShieldRanger.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectRanger == 2)
            {
                pbCrossbowRanger.BorderStyle = BorderStyle.None;
                pbShieldRanger.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(weaponselectKnight, weaponselectRanger);
            this.Hide();
            form1.Show();
        }
    }
}

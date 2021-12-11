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
    public partial class Form1 : Form
    {
        Speler Knight = new Speler(100);
        Speler Ranger = new Speler(100);

        public Form1()
        {
            InitializeComponent();
        }

        private void btAttackKnight_Click(object sender, EventArgs e)
        {
            Ranger.GiveDamage();
            pbRanger.Value = Convert.ToInt32(Ranger.hitpoints);
        }

        private void btAttackRanger_Click(object sender, EventArgs e)
        {
            Knight.GiveDamage();
            pbKnight.Value = Convert.ToInt32(Knight.hitpoints);
        }
    }

    //hieronder is een constructor te zien.
    public class Speler
    {
        public double hitpoints;

        public Speler(int hitpoints)
        {
            this.hitpoints = hitpoints;
        }

        //hieronder is de method te zien die voor de damage output zorgt.
        public void TakeDamage()
        {
            
        }

        public void GiveDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(0, 31);

            hitpoints -= damage;

            if (damage < 1)
            {
                MessageBox.Show("Hit or miss, i guess you missed huh...");
            }

            else if (damage > 24)
            {
                MessageBox.Show("Critical hit!");
            }

            if(hitpoints < 1)
            {
                MessageBox.Show("Bruh you lost (Loser's hp resetting...)");
                hitpoints = 100;
            }
        }
    }
}

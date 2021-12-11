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
        //Hieronder worden 2 spelers aangemaakt met beide 100 hitpoints.
        Speler Knight = new Speler(100);
        Speler Ranger = new Speler(100);

        public Form1()
        {
            InitializeComponent();
        }

        private void btAttackKnight_Click(object sender, EventArgs e)
        {
            Ranger.GiveDamage();
            Ranger.TakeDamage();

            //hieronder worden de hitpoints weergegeven in een progressbar.
            pbRanger.Value = Ranger.hitpoints;

            //hieronder worden de buttons gecheckt en uitgeschakeld.
            btAttackKnight.Enabled = false;

            if (btAttackRanger.Enabled == false)
            {
                btAttackRanger.Enabled = true;
            }
        }

        private void btAttackRanger_Click(object sender, EventArgs e)
        {
            Knight.GiveDamage();
            Knight.TakeDamage();

            //hieronder worden de hitpoints weergegeven in een progressbar.
            pbKnight.Value = Knight.hitpoints;

            //hieronder worden de buttons gecheckt en uitgeschakeld.
            btAttackRanger.Enabled = false;

            if (btAttackKnight.Enabled == false)
            {
                btAttackKnight.Enabled = true;
            }
        }
    }

    //hieronder is een constructor te zien die voor de hitpoints zorgt.
    public class Speler
    {
        public int hitpoints;

        public Speler(int hitpoints)
        {
            this.hitpoints = hitpoints;
        }

        //hieronder is encapsulation te zien door een variabele op private te zetten.
        private int damage;

        //hieronder is een property te zien die voor de random damage tussen 0 en 30 zorgt.
        public int Damage
        {
            get
            {
                Random rnd = new Random();
                return damage = rnd.Next(0, 31);
            }
        }

        //hieronder is de method te zien die voor ervoor zorgt dat de hitpoints niet onder de 0 kunnen en gereset worden.
        public void TakeDamage()
        {
            if (hitpoints < 0)
            {
                hitpoints = 100;
                MessageBox.Show("You win congratualations(Loser's HP resetting");
            }
        }

        //hieronder is de method te zien die voor de damage output zorgt.
        public void GiveDamage()
        {
            hitpoints -= Damage;

            if (Damage < 1)
            {
                MessageBox.Show("Hit or miss, i guess you missed huh...");
            }

            else if (Damage > 24)
            {
                MessageBox.Show("Critical hit!");
            }
        }
    }
}

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
            //hieronder worden de 2 aangemaakte methodes aangeroepen.
            Ranger.GiveDamage();
            Ranger.TakeDamage();

            //hieronder worden de hitpoints weergegeven in een progressbar.
            pbRanger.Value = Ranger.hitpoints;

            //hieronder worden de buttons gecheckt en in/uitgeschakeld.
            btAttackKnight.Enabled = false;
            btHealKnight.Enabled = false;

            if (btAttackRanger.Enabled == false)
            {
                btAttackRanger.Enabled = true;
                btHealRanger.Enabled = true;
            }

            //als de ranger geen hitpoints meer heeft word de game herstart (ranger en knight weer 100 hitpoints).
            if (Ranger.hitpoints < 1)
            {
                Knight.hitpoints = 100;
                pbKnight.Value = Knight.hitpoints;

                Ranger.hitpoints = 100;
                pbRanger.Value = Ranger.hitpoints;

                MessageBox.Show("Knight has won, Congratulations(Resetting)");
            }
        }

        private void btAttackRanger_Click(object sender, EventArgs e)
        {
            //hieronder worden de 2 aangemaakte methodes aangeroepen.
            Knight.GiveDamage();
            Knight.TakeDamage();

            //hieronder worden de hitpoints weergegeven in een progressbar.
            pbKnight.Value = Knight.hitpoints;

            //hieronder worden de buttons gecheckt en in/uitgeschakeld.
            btAttackRanger.Enabled = false;
            btHealRanger.Enabled = false;

            if (btAttackKnight.Enabled == false)
            {
                btAttackKnight.Enabled = true;
                btHealKnight.Enabled = true;
            }

            //als de knight geen hitpoints meer heeft word de game herstart (ranger en knight weer 100 hitpoints).
            if (Knight.hitpoints < 1)
            {
                Knight.hitpoints = 100;
                pbKnight.Value = Knight.hitpoints;

                Ranger.hitpoints = 100;
                pbRanger.Value = Ranger.hitpoints;

                MessageBox.Show("Ranger has won, Congratulations(Resetting)");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            //als er op de reset knop word gedrukt word de game herstart (ranger en knight weer 100 hitpoints).
            Knight.hitpoints = 100;
            pbKnight.Value = Knight.hitpoints;

            Ranger.hitpoints = 100;
            pbRanger.Value = Ranger.hitpoints;

            btAttackKnight.Enabled = true;
            btHealKnight.Enabled = true;

            btAttackRanger.Enabled = true;
            btHealRanger.Enabled = true;

            MessageBox.Show("Game restarted");
        }

        private void btHealKnight_Click(object sender, EventArgs e)
        {
            //hieronder worden de 2 aangemaakte methodes aangeroepen.
            Knight.Healing();
            Knight.TakeDamage();
            pbKnight.Value = Knight.hitpoints;

            //hieronder worden de buttons gecheckt en in/uitgeschakeld.
            btHealKnight.Enabled = false;
            btAttackKnight.Enabled = false;

            if (btHealKnight.Enabled == false)
            {
                btHealRanger.Enabled = true;
                btAttackRanger.Enabled = true;
            }
        }

        private void btHealRanger_Click(object sender, EventArgs e)
        {
            //hieronder worden de 2 aangemaakte methodes aangeroepen.
            Ranger.Healing();
            Ranger.TakeDamage();
            pbRanger.Value = Ranger.hitpoints;

            //hieronder worden de buttons gecheckt en in/uitgeschakeld.
            btHealRanger.Enabled = false;
            btAttackRanger.Enabled = false;

            if (btHealRanger.Enabled == false)
            {
                btHealKnight.Enabled = true;
                btAttackKnight.Enabled = true;
            }
        }
    }
}

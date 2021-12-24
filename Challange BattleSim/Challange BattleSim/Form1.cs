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
        static int Starthitpoints = 100;
        Speler Knight = new Speler(Starthitpoints);
        Speler Ranger = new Speler(Starthitpoints);

        Weapon selectedweapon = new Weapon();
        Armor selectedarmor = new Armor();

        public Form1()
        {
            InitializeComponent();

            #region pbSelection weapon/armor
            if (selectedweapon.weaponselectKnight == 1)
            {
                pbWeaponKnight.Image = Properties.Resources.Sword;
            }

            else if (selectedweapon.weaponselectKnight == 2)
            {
                pbWeaponKnight.Image = Properties.Resources.Shield;
            }

            else if (selectedweapon.weaponselectKnight == 3)
            {
                pbWeaponKnight.Image = Properties.Resources.Spear;
            }

            else if (selectedweapon.weaponselectKnight == 4)
            {
                pbWeaponKnight.Image = Properties.Resources.Morningstar;
            }

            if (selectedweapon.weaponselectRanger == 1)
            {
                pbWeaponRanger.Image = Properties.Resources.Crossbow;
            }

            else if (selectedweapon.weaponselectRanger == 2)
            {
                pbWeaponRanger.Image = Properties.Resources.Shield;
            }

            else if (selectedweapon.weaponselectRanger == 3)
            {
                pbWeaponRanger.Image = Properties.Resources.Slingshot;
            }

            else if (selectedweapon.weaponselectRanger == 4)
            {
                pbWeaponRanger.Image = Properties.Resources.Hammer;
            }

            if(selectedarmor.armorselectKnight == 1)
            {
                pbArmorKnight.Image = Properties.Resources.Cloth;
            }

            else if (selectedarmor.armorselectKnight == 2)
            {
                pbArmorKnight.Image = Properties.Resources.Traveler;
            }

            else if (selectedarmor.armorselectKnight == 3)
            {
                pbArmorKnight.Image = Properties.Resources.Heavy;
            }

            else if (selectedarmor.armorselectKnight == 4)
            {
                pbArmorKnight.Image = Properties.Resources.Godly;
            }

            if(selectedarmor.armorselectRanger == 1)
            {
                pbArmorRanger.Image = Properties.Resources.Cloth;
            }

            else if (selectedarmor.armorselectRanger == 2)
            {
                pbArmorRanger.Image = Properties.Resources.Traveler;
            }

            else if (selectedarmor.armorselectRanger == 3)
            {
                pbArmorRanger.Image = Properties.Resources.Heavy;
            }

            else if (selectedarmor.armorselectRanger == 4)
            {
                pbArmorRanger.Image = Properties.Resources.Godly;
            }
            #endregion
        }

        private void btAttackKnight_Click(object sender, EventArgs e)
        {
            Ranger.GiveDamageKnight();
            Ranger.TakeDamage();
            KnightbuttonOff();

            if (Ranger.hitpoints < 1)
            {
                UpdateStats();
                MessageBox.Show("Knight has won, Congratulations(Resetting)");
            }
        }

        private void btAttackRanger_Click(object sender, EventArgs e)
        {
            Knight.GiveDamageRanger();
            Knight.TakeDamage();
            RangerbuttonOff();

            if (Knight.hitpoints < 1)
            {
                UpdateStats();
                MessageBox.Show("Ranger has won, Congratulations(Resetting)");
            }
        }

        private void btHealKnight_Click(object sender, EventArgs e)
        {
            Knight.HealingDone();
            Knight.TakeDamage();
            pbKnight.Value = Knight.hitpoints;
            KnightbuttonOff();
        }

        private void btHealRanger_Click(object sender, EventArgs e)
        {
            Ranger.HealingDone();
            Ranger.TakeDamage();
            pbRanger.Value = Ranger.hitpoints;
            RangerbuttonOff();
        }

        private void btGambleRanger_Click(object sender, EventArgs e)
        {
            Knight.GambleDamage();
            Knight.TakeDamage();
            RangerbuttonOff();

            if (Knight.hitpoints < 1)
            {
                UpdateStats();
                MessageBox.Show("Knight has won, Congratulations(Resetting)");
            }
        }

        private void btGambleKnight_Click(object sender, EventArgs e)
        {
            Ranger.GambleDamage();
            Ranger.TakeDamage();
            KnightbuttonOff();

            if (Ranger.hitpoints < 1)
            {
                UpdateStats();
                MessageBox.Show("Knight has won, Congratulations(Resetting)");
            }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            Selectform selectform = new Selectform();
            this.Hide();
            selectform.Show();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Knight.hitpoints = Starthitpoints;
            pbKnight.Value = Knight.hitpoints;

            Ranger.hitpoints = Starthitpoints;
            pbRanger.Value = Ranger.hitpoints;

            btGambleKnight.Enabled = false;
            btGambleRanger.Enabled = false;

            btAttackKnight.Enabled = true;
            btHealKnight.Enabled = true;

            btAttackRanger.Enabled = true;
            btHealRanger.Enabled = true;

            MessageBox.Show("Game restarted");
        }

        #region Formupdates
        //Methodes voor updates op het form.
        public void UpdateStats()
        {
            Ranger.hitpoints = Starthitpoints;
            pbRanger.Value = Ranger.hitpoints;

            Knight.hitpoints = Starthitpoints;
            pbKnight.Value = Knight.hitpoints;

            btGambleKnight.Enabled = true;
            btGambleRanger.Enabled = true;

            btAttackKnight.Enabled = true;
            btHealKnight.Enabled = true;

            btAttackRanger.Enabled = true;
            btHealRanger.Enabled = true;
        }

        public void KnightbuttonOff()
        {
            pbRanger.Value = Ranger.hitpoints;

            btAttackKnight.Enabled = false;
            btHealKnight.Enabled = false;
            btGambleKnight.Enabled = false;

            if (btAttackRanger.Enabled == false)
            {
                btAttackRanger.Enabled = true;
                btHealRanger.Enabled = true;
                btGambleRanger.Enabled = true;
            }
        }

        public void RangerbuttonOff()
        {
            pbKnight.Value = Knight.hitpoints;

            btAttackRanger.Enabled = false;
            btHealRanger.Enabled = false;
            btGambleRanger.Enabled = false;

            if (btAttackKnight.Enabled == false)
            {
                btAttackKnight.Enabled = true;
                btHealKnight.Enabled = true;
                btGambleKnight.Enabled = true;
            }
        }
        #endregion
    }
}

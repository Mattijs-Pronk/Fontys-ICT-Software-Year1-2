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
        private int coinsKnight = 50;
        private int coinsRanger = 50;

        private int costweaponKnight;
        private int costweaponRanger;

        private int costarmorKnight;
        private int costarmorRanger;

        public static int weaponselectKnight = 0;
        public static int weaponselectRanger = 0;

        public static int armorselectKnight = 0;
        public static int armorselectRanger = 0;

        enum costweapons
        {
            Sword = 10,
            Spear = 20,
            Shield = 30,
            Morningstar = 40,

            Crossbow = 10,
            Slingshot = 20,
            Hammer = 40

        }

        enum costarmor
        {
            Cloth = 10,
            Traveler = 20,
            Heavy = 30,
            Godly = 40
        }

        public Selectform()
        {
            InitializeComponent();
        }

        #region All picturebox button's
        //alle picture boxen krijgen een waarde als deze geselecteerd worden.
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 1;
            costweaponKnight = (int)costweapons.Sword;
            CurrentCoinsKnightWeapon();
            Weaponchange();
            DisablepbWeaponKnight();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 2;
            costweaponKnight = (int)costweapons.Shield;
            CurrentCoinsKnightWeapon();
            Weaponchange();
            DisablepbWeaponKnight();
        }

        private void pbSpearKnight_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 3;
            costweaponKnight = (int)costweapons.Spear;
            CurrentCoinsKnightWeapon();
            Weaponchange();
            DisablepbWeaponKnight();
        }

        private void pbMorningstarKnight_Click(object sender, EventArgs e)
        {
            weaponselectKnight = 4;
            costweaponKnight = (int)costweapons.Morningstar;
            CurrentCoinsKnightWeapon();
            Weaponchange();
            DisablepbWeaponKnight();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 1;
            costweaponRanger = (int)costweapons.Crossbow;
            CurrentCoinsRangerWeapon();
            Weaponchange();
            DisablepbWeaponRanger();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 2;
            costweaponRanger = (int)costweapons.Shield;
            CurrentCoinsRangerWeapon();
            Weaponchange();
            DisablepbWeaponRanger();
        }

        private void pbSlingshotRanger_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 3;
            costweaponRanger = (int)costweapons.Slingshot;
            CurrentCoinsRangerWeapon();
            Weaponchange();
            DisablepbWeaponRanger();
        }

        private void pbHammerRanger_Click(object sender, EventArgs e)
        {
            weaponselectRanger = 4;
            costweaponRanger = (int)costweapons.Hammer;
            CurrentCoinsRangerWeapon();
            Weaponchange();
            DisablepbWeaponRanger();
        }

        private void pbClothKnight_Click(object sender, EventArgs e)
        {
            armorselectKnight = 1;
            costarmorKnight = (int)costarmor.Cloth;
            CurrentCoinsKnightArmor();
            Armorchange();
            DisablepbArmorKnight();
        }

        private void pbTravelerKnight_Click(object sender, EventArgs e)
        {
            armorselectKnight = 2;
            costarmorKnight = (int)costarmor.Traveler;
            CurrentCoinsKnightArmor();
            Armorchange();
            DisablepbArmorKnight();
        }

        private void pbHeavyKnight_Click(object sender, EventArgs e)
        {
            armorselectKnight = 3;
            costarmorKnight = (int)costarmor.Heavy;
            CurrentCoinsKnightArmor();
            Armorchange();
            DisablepbArmorKnight();
        }

        private void pbGodlyKnight_Click(object sender, EventArgs e)
        {
            armorselectKnight = 4;
            costarmorKnight = (int)costarmor.Godly;
            CurrentCoinsKnightArmor();
            Armorchange();
            DisablepbArmorKnight();
        }

        private void pbClothRanger_Click(object sender, EventArgs e)
        {
            armorselectRanger = 1;
            costarmorRanger = (int)costarmor.Cloth;
            CurrentCoinsRangerArmor();
            Armorchange();
            DisablepbArmorRanger();
        }

        private void pbTravelerRanger_Click(object sender, EventArgs e)
        {
            armorselectRanger = 2;
            costarmorRanger = (int)costarmor.Traveler;
            CurrentCoinsRangerArmor();
            Armorchange();
            DisablepbArmorRanger();
        }

        private void pbHeavyRanger_Click(object sender, EventArgs e)
        {
            armorselectRanger = 3;
            costarmorRanger = (int)costarmor.Heavy;
            CurrentCoinsRangerArmor();
            Armorchange();
            DisablepbArmorRanger();
        }

        private void pbGodlyRanger_Click(object sender, EventArgs e)
        {
            armorselectRanger = 4;
            costarmorRanger = (int)costarmor.Godly;
            CurrentCoinsRangerArmor();
            Armorchange();
            DisablepbArmorRanger();
        }
        #endregion

        private void btStart_Click(object sender, EventArgs e)
        {
            if (coinsKnight < 0 && coinsRanger < 0)
            {
                MessageBox.Show("Knight and Ranger have spent to much");
                Selectform selectform = new Selectform();
                this.Hide();
                selectform.Show();
            }

            else if (coinsKnight < 0)
            {
                MessageBox.Show("Knight has spent to much");
                Selectform selectform = new Selectform();
                this.Hide();
                selectform.Show();
            }

            else if (coinsRanger < 0)
            {
                MessageBox.Show("Ranger has spent to much");
                Selectform selectform = new Selectform();
                this.Hide();
                selectform.Show();
            }

            else if (coinsKnight > -1 && coinsRanger > -1)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void btResetcoins_Click(object sender, EventArgs e)
        {
            Selectform selectform = new Selectform();
            this.Hide();
            selectform.Show();
        }

        private void CurrentCoinsKnightWeapon()
        {
            coinsKnight -= costweaponKnight;
            lblCoinsKnight.Text = Convert.ToString("Balance: " + coinsKnight + " coins");
        }

        private void CurrentCoinsKnightArmor()
        {
            coinsKnight -= costarmorKnight;
            lblCoinsKnight.Text = Convert.ToString("Balance: " + coinsKnight + " coins");
        }

        private void CurrentCoinsRangerWeapon()
        {
            coinsRanger -= costweaponRanger;
            lblCoinsRanger.Text = Convert.ToString("Balance: " + coinsRanger + " coins");
        }

        private void CurrentCoinsRangerArmor()
        {
            coinsRanger -= costarmorRanger;
            lblCoinsRanger.Text = Convert.ToString("Balance: " + coinsRanger + " coins");
        }

        #region picturebox controller
        private void DisablepbWeaponKnight()
        {
            pbSwordKnight.Enabled = false;
            pbSpearKnight.Enabled = false;
            pbShieldKnight.Enabled = false;
            pbMorningstarKnight.Enabled = false;
        }

        private void DisablepbArmorKnight()
        {
            pbClothKnight.Enabled = false;
            pbTravelerKnight.Enabled = false;
            pbHeavyKnight.Enabled = false;
            pbGodlyKnight.Enabled = false;
        }

        private void DisablepbWeaponRanger()
        {
            pbCrossbowRanger.Enabled = false;
            pbSlingshotRanger.Enabled = false;
            pbShieldRanger.Enabled = false;
            pbHammerRanger.Enabled = false;
        }

        private void DisablepbArmorRanger()
        {
            pbClothRanger.Enabled = false;
            pbTravelerRanger.Enabled = false;
            pbHeavyRanger.Enabled = false;
            pbGodlyRanger.Enabled = false;
        }
        //checken welke picturebox actief is van armor.
        private void Armorchange()
        {
            if(armorselectKnight == 1)
            {
                pbClothKnight.BorderStyle = BorderStyle.Fixed3D;
                pbTravelerKnight.BorderStyle = BorderStyle.None;
                pbHeavyKnight.BorderStyle = BorderStyle.None;
                pbGodlyKnight.BorderStyle = BorderStyle.None;
            }

            else if (armorselectKnight == 2)
            {
                pbClothKnight.BorderStyle = BorderStyle.None;
                pbTravelerKnight.BorderStyle = BorderStyle.Fixed3D;
                pbHeavyKnight.BorderStyle = BorderStyle.None;
                pbGodlyKnight.BorderStyle = BorderStyle.None;
            }

            else if (armorselectKnight == 3)
            {
                pbClothKnight.BorderStyle = BorderStyle.None;
                pbTravelerKnight.BorderStyle = BorderStyle.None;
                pbHeavyKnight.BorderStyle = BorderStyle.Fixed3D;
                pbGodlyKnight.BorderStyle = BorderStyle.None;
            }

            else if (armorselectKnight == 4)
            {
                pbClothKnight.BorderStyle = BorderStyle.None;
                pbTravelerKnight.BorderStyle = BorderStyle.None;
                pbHeavyKnight.BorderStyle = BorderStyle.None;
                pbGodlyKnight.BorderStyle = BorderStyle.Fixed3D;
            }

            if(armorselectRanger == 1)
            {
                pbClothRanger.BorderStyle = BorderStyle.Fixed3D;
                pbTravelerRanger.BorderStyle = BorderStyle.None;
                pbHeavyRanger.BorderStyle = BorderStyle.None;
                pbGodlyRanger.BorderStyle = BorderStyle.None;
            }

            else if (armorselectRanger == 2)
            {
                pbClothRanger.BorderStyle = BorderStyle.None;
                pbTravelerRanger.BorderStyle = BorderStyle.Fixed3D;
                pbHeavyRanger.BorderStyle = BorderStyle.None;
                pbGodlyRanger.BorderStyle = BorderStyle.None;
            }

            else if (armorselectRanger == 3)
            {
                pbClothRanger.BorderStyle = BorderStyle.None;
                pbTravelerRanger.BorderStyle = BorderStyle.None;
                pbHeavyRanger.BorderStyle = BorderStyle.Fixed3D;
                pbGodlyRanger.BorderStyle = BorderStyle.None;
            }

            else if (armorselectRanger == 4)
            {
                pbClothRanger.BorderStyle = BorderStyle.None;
                pbTravelerRanger.BorderStyle = BorderStyle.None;
                pbHeavyRanger.BorderStyle = BorderStyle.None;
                pbGodlyRanger.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        //checken welke picturebox actief is van wapens.
        private void Weaponchange()
        {
            if(weaponselectKnight == 1)
            {
                pbSwordKnight.BorderStyle = BorderStyle.Fixed3D;
                pbShieldKnight.BorderStyle = BorderStyle.None;
                pbSpearKnight.BorderStyle = BorderStyle.None;
                pbMorningstarKnight.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectKnight == 2)
            {
                pbSwordKnight.BorderStyle = BorderStyle.None;
                pbShieldKnight.BorderStyle = BorderStyle.Fixed3D;
                pbSpearKnight.BorderStyle = BorderStyle.None;
                pbMorningstarKnight.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectKnight == 3)
            {
                pbSwordKnight.BorderStyle = BorderStyle.None;
                pbSpearKnight.BorderStyle = BorderStyle.Fixed3D;
                pbShieldKnight.BorderStyle = BorderStyle.None;
                pbMorningstarKnight.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectKnight == 4)
            {
                pbSwordKnight.BorderStyle = BorderStyle.None;
                pbSpearKnight.BorderStyle = BorderStyle.None;
                pbShieldKnight.BorderStyle = BorderStyle.None;
                pbMorningstarKnight.BorderStyle = BorderStyle.Fixed3D;
            }

            if (weaponselectRanger == 1)
            {
                pbSlingshotRanger.BorderStyle = BorderStyle.None;
                pbCrossbowRanger.BorderStyle = BorderStyle.Fixed3D;
                pbShieldRanger.BorderStyle = BorderStyle.None;
                pbHammerRanger.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectRanger == 2)
            {
                pbSlingshotRanger.BorderStyle = BorderStyle.None;
                pbCrossbowRanger.BorderStyle = BorderStyle.None;
                pbShieldRanger.BorderStyle = BorderStyle.Fixed3D;
                pbHammerRanger.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectRanger == 3)
            {
                pbSlingshotRanger.BorderStyle = BorderStyle.Fixed3D;
                pbShieldRanger.BorderStyle = BorderStyle.None;
                pbCrossbowRanger.BorderStyle = BorderStyle.None;
                pbHammerRanger.BorderStyle = BorderStyle.None;
            }

            else if (weaponselectRanger == 4)
            {
                pbSlingshotRanger.BorderStyle = BorderStyle.None;
                pbShieldRanger.BorderStyle = BorderStyle.None;
                pbCrossbowRanger.BorderStyle = BorderStyle.None;
                pbHammerRanger.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        #endregion
    }
}

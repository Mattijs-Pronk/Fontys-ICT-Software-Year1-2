using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange_BattleSim
{
    public class Speler
    {
        RandomGenerator randomizer = new RandomGenerator();
        Weapon selectedweapon = new Weapon();
        Armor selectedarmor = new Armor();

        public int hitpoints;
        private int currentDamage;
        private int bonusDamage;

        public Speler(int my)
        {
            hitpoints = my;
        }

        enum Hits
        {
            Critical,
            miss
        }

        public void TakeDamage()
        {
            if (hitpoints < 1)
            {
                hitpoints = 0;
            }

            else if (hitpoints > 99)
            {
                hitpoints = 100;
            }
        }

        public void GiveDamageKnight()
        {
            selectedweapon.Chosenweapons();
            selectedarmor.ChosenArmor();
            bonusDamage = selectedweapon.weaponKnight - selectedarmor.armorRanger;

            if (bonusDamage < 1)
            {
                bonusDamage = 0;
            }

            currentDamage = randomizer.Damage + bonusDamage;
            hitpoints -= currentDamage;

            if (currentDamage < 1)
            {
                currentDamage = 0;
                MessageBox.Show("Hit or " + Hits.miss + ", i guess you missed huh...");
            }

            else if (currentDamage > 24)
            {
                MessageBox.Show(Hits.Critical + " hit!");
            }
        }

        public void GiveDamageRanger()
        {
            selectedweapon.Chosenweapons();
            selectedarmor.ChosenArmor();
            bonusDamage = selectedweapon.weaponRanger - selectedarmor.armorKnight;

            if(bonusDamage < 1)
            {
                bonusDamage = 0;
            }

            currentDamage = randomizer.Damage + bonusDamage;
            hitpoints -= currentDamage;

            if (currentDamage < 1)
            {
                MessageBox.Show("Hit or " + Hits.miss + ", i guess you missed huh...");
            }

            else if (currentDamage > 24)
            {
                MessageBox.Show(Hits.Critical + " hit!");
            }
        }

        public void HealingDone()
        {
            hitpoints += randomizer.Heal;
        }

        public void GambleDamage()
        {
            randomizer.GambleDamageCalculator();
            hitpoints -= randomizer.hitchance;
        }
    }
}


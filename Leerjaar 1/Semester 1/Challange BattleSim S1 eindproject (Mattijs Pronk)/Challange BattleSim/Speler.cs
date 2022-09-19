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

        public int hitpoints;
        public int weapons;
        public int armor;
        public int currentDamage;
        private int bonusDamage;

        public Speler(int my, int weap, int arm)
        {
            hitpoints = my;
            weapons = weap;
            armor = arm;
        }

        public enum Hits
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

        public void GiveDamage()
        {
            bonusDamage = weapons - armor;
            currentDamage = randomizer.Damage + bonusDamage;
            hitpoints -= currentDamage;

            Spelerupdates();
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

        private void Spelerupdates()
        {
            if (bonusDamage < 1)
            {
                bonusDamage = 0;
            }

            if (currentDamage < 1)
            {
                currentDamage = 0;
            }
        }
    }
}


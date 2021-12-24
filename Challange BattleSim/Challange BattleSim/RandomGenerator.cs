using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_BattleSim
{
    class RandomGenerator
    {
        private int totalgamble;
        private int heal;
        private int damage;

        public int hitchance;

        public int Totalgamble
        {
            get
            {
                Random rnd = new Random();
                return totalgamble = rnd.Next(1, 7);
            }
            set { }
        }

        public int Heal
        {
            get
            {
                Random rnd = new Random();
                return heal = rnd.Next(6, 21);
            }
            set { }
        }

        public int Damage
        {
            get
            {
                Random rnd = new Random();
                return damage = rnd.Next(0, 31);
            }
            set { }
        }

        public void GambleDamageCalculator()
        {
            int[] gambledamage = new int[8];

            gambledamage[0] = 0;
            gambledamage[1] = 0;
            gambledamage[2] = 0;
            gambledamage[3] = 70;
            gambledamage[4] = 0;
            gambledamage[5] = 0;

            if (Totalgamble == 1)
            {
                hitchance = gambledamage[0];
            }

            else if (Totalgamble == 2)
            {
                hitchance = gambledamage[1];
            }

            else if (Totalgamble == 3)
            {
                hitchance = gambledamage[2];
            }

            else if (Totalgamble == 4)
            {
                hitchance = gambledamage[3];
            }

            else if (Totalgamble == 5)
            {
                hitchance = gambledamage[4];
            }

            else if (Totalgamble == 6)
            {
                hitchance = gambledamage[5];
            }
        }
    }
}

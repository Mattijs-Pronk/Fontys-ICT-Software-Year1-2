using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_BattleSim
{
    class Shop
    {
        private int costselectweaponKnight;
        private int costselectweaponRanger;
        private int costselectarmorKnight;
        private int costselectarmorRanger;

        public int costweaponKnight;
        public int costweaponRanger;
        public int costarmorKnight;
        public int costarmorRanger;

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

        #region variabele aanmaken
        public Shop()
        {
            if (Selectform.weaponselectKnight == 1)
            {
                costselectweaponKnight = 1;
            }

            else if (Selectform.weaponselectKnight == 2)
            {
                costselectweaponKnight = 2;
            }

            else if (Selectform.weaponselectKnight == 3)
            {
                costselectweaponKnight = 3;
            }

            else if (Selectform.weaponselectKnight == 4)
            {
                costselectweaponKnight = 4;
            }

            if (Selectform.weaponselectRanger == 1)
            {
                costselectweaponRanger = 1;
            }

            else if (Selectform.weaponselectRanger == 2)
            {
                costselectweaponRanger = 2;
            }

            else if (Selectform.weaponselectRanger == 3)
            {
                costselectweaponRanger = 3;
            }

            else if (Selectform.weaponselectRanger == 4)
            {
                costselectweaponRanger = 4;
            }

            if (Selectform.armorselectKnight == 1)
            {
                costselectarmorKnight = 1;
            }

            else if (Selectform.armorselectKnight == 2)
            {
                costselectarmorKnight = 2;
            }

            else if (Selectform.armorselectKnight == 3)
            {
                costselectarmorKnight = 3;
            }

            else if (Selectform.armorselectKnight == 4)
            {
                costselectarmorKnight = 4;
            }

            if (Selectform.armorselectRanger == 1)
            {
                costselectarmorRanger = 1;
            }

            else if (Selectform.armorselectRanger == 2)
            {
                costselectarmorRanger = 2;
            }

            else if (Selectform.armorselectRanger == 3)
            {
                costselectarmorRanger = 3;
            }

            else if (Selectform.armorselectRanger == 4)
            {
                costselectarmorRanger = 4;
            }
        }
        #endregion

        public void CostChosenWeapon()
        {
            if (costselectweaponKnight == 1)
            {
                costweaponKnight = (int)costweapons.Sword;
            }

            else if (costselectweaponKnight == 2)
            {
                costweaponKnight = (int)costweapons.Spear;
            }

            else if (costselectweaponKnight == 3)
            {
                costweaponKnight = (int)costweapons.Shield;
            }

            else if (costselectweaponKnight == 4)
            {
                costweaponKnight = (int)costweapons.Morningstar;
            }

            if (costselectweaponRanger == 1)
            {
                costweaponRanger = (int)costweapons.Crossbow;
            }

            else if (costselectweaponRanger == 2)
            {
                costweaponRanger = (int)costweapons.Slingshot;
            }

            else if (costselectweaponRanger == 3)
            {
                costweaponRanger = (int)costweapons.Shield;
            }

            else if (costselectweaponRanger == 4)
            {
                costweaponRanger = (int)costweapons.Hammer;
            }
        }

        public void CostChosenArmor()
        {
            if (costselectarmorKnight == 1)
            {
                costarmorKnight = (int)costarmor.Cloth;
            }

            else if (costselectarmorKnight == 2)
            {
                costarmorKnight = (int)costarmor.Traveler;
            }

            else if (costselectarmorKnight == 3)
            {
                costarmorKnight = (int)costarmor.Heavy;
            }

            else if (costselectarmorKnight == 4)
            {
                costarmorKnight = (int)costarmor.Godly;
            }

            if (costselectarmorRanger == 1)
            {
                costarmorRanger = (int)costarmor.Cloth;
            }

            else if (costselectarmorRanger == 2)
            {
                costarmorRanger = (int)costarmor.Traveler;
            }

            else if (costselectarmorRanger == 3)
            {
                costarmorRanger = (int)costarmor.Heavy;
            }

            else if (costselectarmorRanger == 4)
            {
                costarmorRanger = (int)costarmor.Godly;
            }
        }
    }
}

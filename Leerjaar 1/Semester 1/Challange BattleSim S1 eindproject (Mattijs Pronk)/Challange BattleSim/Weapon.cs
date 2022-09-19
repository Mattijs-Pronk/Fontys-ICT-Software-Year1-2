using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_BattleSim
{
    public class Weapon
    {
        public int weaponselectKnight;
        public int weaponselectRanger;

        public int weaponKnight;
        public int weaponRanger;

        enum weapons
        {
            Sword = 1,
            Shield = 3,
            Crossbow = 1,
            Spear = 2,
            Slingshot = 2,
            Morningstar = 4,
            Hammer = 4
        }

        #region variabele aanmaken
        public Weapon()
        {
            if (Selectform.weaponselectKnight == 1)
            {
                weaponselectKnight = 1;
            }

            else if (Selectform.weaponselectKnight == 2)
            {
                weaponselectKnight = 2;
            }

            else if (Selectform.weaponselectKnight == 3)
            {
                weaponselectKnight = 3;
            }

            else if (Selectform.weaponselectKnight == 4)
            {
                weaponselectKnight = 4;
            }

            if (Selectform.weaponselectRanger == 1)
            {
                weaponselectRanger = 1;
            }

            else if (Selectform.weaponselectRanger == 2)
            {
                weaponselectRanger = 2;
            }

            else if (Selectform.weaponselectRanger == 3)
            {
                weaponselectRanger = 3;
            }

            else if (Selectform.weaponselectRanger == 4)
            {
                weaponselectRanger = 4;
            }
        }
        #endregion

        public void Chosenweapons()
        {
            if (weaponselectKnight == 1)
            {
                weaponKnight = (int)weapons.Sword;
            }

            else if (weaponselectKnight == 2)
            {
                weaponKnight = (int)weapons.Spear;
            }

            else if (weaponselectKnight == 3)
            {
                weaponKnight = (int)weapons.Shield;
            }

            else if (weaponselectKnight == 4)
            {
                weaponKnight = (int)weapons.Morningstar;
            }

            if (weaponselectRanger == 1)
            {
                weaponRanger = (int)weapons.Crossbow;
            }

            else if (weaponselectRanger == 2)
            {
                weaponRanger = (int)weapons.Slingshot;
            }

            else if (weaponselectRanger == 3)
            {
                weaponRanger = (int)weapons.Shield;
            }

            else if (weaponselectRanger == 4)
            {
                weaponRanger = (int)weapons.Hammer;
            }
        }
    }
}

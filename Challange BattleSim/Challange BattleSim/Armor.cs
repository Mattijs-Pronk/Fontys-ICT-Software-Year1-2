using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_BattleSim
{
    class Armor
    {
        public int armorselectKnight;
        public int armorselectRanger;

        public int armorKnight;
        public int armorRanger;

        enum armors
        {
            cloth = 2,
            traveler = 3,
            heavy = 4,
            godly = 5
        }

        #region Variabele aanmaken
        public Armor()
        {
            if(Selectform.armorselectKnight == 1)
            {
                armorselectKnight = 1;
            }

            else if (Selectform.armorselectKnight == 2)
            {
                armorselectKnight = 2;
            }

            else if (Selectform.armorselectKnight == 3)
            {
                armorselectKnight = 3;
            }

            else if (Selectform.armorselectKnight == 4)
            {
                armorselectKnight = 4;
            }

            if(Selectform.armorselectRanger == 1)
            {
                armorselectRanger = 1;
            }

            else if (Selectform.armorselectRanger == 2)
            {
                armorselectRanger = 2;
            }

            else if (Selectform.armorselectRanger == 3)
            {
                armorselectRanger = 3;
            }

            else if (Selectform.armorselectRanger == 4)
            {
                armorselectRanger = 4;
            }
        }
        #endregion

        public void ChosenArmor()
        {
            if (armorselectKnight == 1)
            {
                armorKnight = (int)armors.cloth;
            }

            else if (armorselectKnight == 2)
            {
                armorKnight = (int)armors.traveler;
            }

            else if (armorselectKnight == 3)
            {
                armorKnight = (int)armors.heavy;
            }

            else if (armorselectKnight == 4)
            {
                armorKnight = (int)armors.godly;
            }

            if (armorselectRanger == 1)
            {
                armorRanger = (int)armors.cloth;
            }

            else if (armorselectRanger == 2)
            {
                armorRanger = (int)armors.traveler;
            }

            else if (armorselectRanger == 3)
            {
                armorRanger = (int)armors.heavy;
            }

            else if (armorselectRanger == 4)
            {
                armorRanger = (int)armors.godly;
            }
        }
    }
}

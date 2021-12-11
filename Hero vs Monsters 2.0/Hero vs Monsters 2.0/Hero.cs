using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_vs_Monsters_2._0
{
    public class Hero
    {
        public Hero()
        {

        }

        public void Attack(Monster monster, int damage)
        {
            monster.LooseHealth(damage);
        }
    }
}

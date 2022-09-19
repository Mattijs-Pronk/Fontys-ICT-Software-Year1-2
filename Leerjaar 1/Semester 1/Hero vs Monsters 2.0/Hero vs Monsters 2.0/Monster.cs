using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_vs_Monsters_2._0
{
    public class Monster
    {
        private int health = 100;

        public Monster(int initialHealth)
        {
            this.health = initialHealth;
        }

        public void LooseHealth(int damage)
        {
            this.health = this.health - damage;
        }
    }
}

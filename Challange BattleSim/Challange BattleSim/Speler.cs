using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange_BattleSim
{
    //hieronder is een constructor te zien die voor de hitpoints zorgt.
    public class Speler
    {
        //hieronder word een public variabele aangemaakt
        public int hitpoints;

        //hieronder is encapsulation te zien door een variabele op private te zetten.
        private int damage;
        private int heal;

        public Speler(int hitpoints)
        {
            this.hitpoints = hitpoints;
        }

        //hieronder is een property te zien die voor de random damage tussen 0 en 30 zorgt.
        public int Damage
        {
            get
            {
                Random rnd = new Random();
                return damage = rnd.Next(0, 31);
            }
            set { }
        }

        //hieronder is een property te zien die voor de random healing tussen 2 en 15 zorgt.
        public int Heal
        {
            get
            {
                Random rnd = new Random();
                return heal = rnd.Next(2, 16);
            }
            set { }
        }

        //hieronder is een enum te zien.
        enum Hits
        {
            Critical,
            miss
        }

        enum weapons
        {
            Sword = 5,
            Shield = 8,
            Crossbow = 5,
        }

        //hieronder is de method te zien die voor ervoor zorgt dat de hitpoints niet onder de 0 kunnen en niet boven de 100.
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
            //hieronder krijgt de enum een waarde, en word deze toegepast bij de MessageBox.Show().
            Hits raak = Hits.Critical;
            Hits nietraak = Hits.miss;

            if(Form1.weapondamageKnight == 1)
            {
                Damage += (int)weapons.Sword;
                hitpoints -= Damage;
            }

            else if(Form1.weapondamageKnight == 2)
            {
                Damage -= (int)weapons.Shield;
                hitpoints -= Damage;
            }

            else if(Form1.weapondamageRanger == 1)
            {
                Damage += (int)weapons.Crossbow;
                hitpoints -= Damage;
            }

            else if (Form1.weapondamageRanger == 2)
            {
                Damage -= (int)weapons.Shield;
                hitpoints -= Damage;
            }

            if (Damage < 1)
            {
                MessageBox.Show("Hit or " + nietraak + ", i guess you missed huh...");
            }

            else if (Damage > 24)
            {
                MessageBox.Show(raak + " hit!");
            }
        }

        //hieronder is de method te zien die voor de healing output zorgt.
        public void Healing()
        {
            hitpoints += Heal;
        }
    }
}


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
        //hieronder worden public variabele aangemaakt
        public int hitpoints;
        public int currentDamage;

        //hieronder is encapsulation te zien door een variabele op private te zetten.
        private int damage;
        private int heal;

        //hieronder zijn 2 enum's te zien.
        enum Hits
        {
            Critical,
            miss
        }

        enum weapons
        {
            Sword = 3,
            Shield = 4,
            Crossbow = 3,
        }

        //hieronder is een constructor te zien die voor de hitpoints zorgt.
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

        public void GiveDamageKnight()
        {
            //hieronder krijgt de enum een waarde, en word deze toegepast bij de MessageBox.Show().
            //ook word de andere enum gebruikt door de (int) waarde toe te passen als extra of juist minder damage.
            Hits raak = Hits.Critical;
            Hits nietraak = Hits.miss;

            if(Form1.weapondamageKnight == 1 || Form1.weapondamageRanger == 1)
            {
                currentDamage = Damage + (int)weapons.Sword;
                hitpoints -= currentDamage;
            }

            else if (Form1.weapondamageKnight == 1 || Form1.weapondamageRanger == 2)
            {
                Damage += (int)weapons.Sword;
                currentDamage = Damage - (int)weapons.Shield;
                hitpoints -= currentDamage;
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

        public void GiveDamageRanger()
        {
            //hieronder krijgt de enum een waarde, en word deze toegepast bij de MessageBox.Show().
            //ook word de andere enum gebruikt door de (int) waarde toe te passen als extra of juist minder damage.
            Hits raak = Hits.Critical;
            Hits nietraak = Hits.miss;

            if (Form1.weapondamageRanger == 1 || Form1.weapondamageKnight == 1)
            {
                currentDamage = Damage + (int)weapons.Crossbow;
                hitpoints -= currentDamage;
            }

            else if (Form1.weapondamageKnight == 2 || Form1.weapondamageRanger == 1)
            {
                Damage += (int)weapons.Crossbow;
                currentDamage = Damage - (int)weapons.Shield;
                hitpoints -= currentDamage;
            }

            else
            {
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


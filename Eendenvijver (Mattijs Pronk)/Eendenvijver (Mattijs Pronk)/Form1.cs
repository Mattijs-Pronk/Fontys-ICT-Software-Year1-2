using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eendenvijver__Mattijs_Pronk_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btManEend_Click(object sender, EventArgs e)
        {
            //tellen hoeveel mannelijke eend objecten er zijn.
        }

        enum geslacht
        {
            man,
            vrouw
        }

        private void btVulVijver_Click(object sender, EventArgs e)
        {
            Eend[] maneend = new Eend[13];
            for (int i = 0; i < 13; i++)
                maneend[i] = new Eend("Mannetje", (int)geslacht.man);

            Eend[] vrouweend = new Eend[13];
            for (int j = 0; j < 13; j++)
                vrouweend[j] = new Eend("Vrouwtje", (int)geslacht.vrouw);


            Kikker[] kikkertje = new Kikker[10];
            for (int k = 0; k < 10; k++)
                kikkertje[k] = new Kikker(8);
        }
    }

    public class Eend
    {
        private string geslacht;
        private int nummer;

        public Eend(string geslacht, int nummer)
        {
            this.geslacht = geslacht;
            this.nummer = nummer;
        }
    }

    public class Kikker
    {
        private int health;

        public Kikker(int health)
        {
            this.health = health;
        }
    }

    public class Ooievaar
    {
        //private int damage = 8;

        public void Eetkikker()
        {
            //health -= damage
        }
    }
}

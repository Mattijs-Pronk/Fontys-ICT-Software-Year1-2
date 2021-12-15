using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Galgje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void btCheck_Click(object sender, EventArgs e)
        {

        }


        public class Woord
        {
            private string woord;

            public Woord(string w)
            {
                this.woord = w;
                w = File.ReadAllText(@"C:\Users\matti\source\repos\Fontys-ICT-Software\Galgje\Tekst to C#\Tekst.txt");
            }

            public void GetWord()
            {

            }
        }
    }
}

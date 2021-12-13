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
        Woord galgje = new Woord(filePath);
        private string woord;

        public Form1()
        {
            InitializeComponent();
        }

        public class Woord
        {
            public string woord;
            
            public Woord(string w)
            {
                this.woord = w;

                string filePath = @"C:\Users\matti\source\repos\Fontys-ICT-Software\Galgje\Tekst to C#\Tekst.txt";

                List<String> lines = File.ReadAllLines(filePath).ToList();

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {

        }
    }
}

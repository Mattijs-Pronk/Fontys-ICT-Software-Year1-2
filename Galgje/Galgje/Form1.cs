﻿using System;
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
        Woord galgje = new Woord(woord);

        public Form1()
        {
            InitializeComponent();
        }




        public class Woord
        {
            public string woord = System.IO.File.ReadAllText(@"C:\Users\matti\source\repos\Galgje\Tekst to C#\Tekst.txt");
            public string hetwoord;

            public Woord(string woord)
            {
                this.woord = woord;
            }
            
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            tbChecklines.Text = Convert.ToString(galgje);
        }
    }
}

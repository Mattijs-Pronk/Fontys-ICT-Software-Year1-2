using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankrekening
{
    public partial class Bankzaken : Form
    {
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;

        public Bankzaken()
        {
            InitializeComponent();
            bankrekeningLinks = new Bankrekening("Duck, Dagobert");
            bankrekeningRechts = new Bankrekening("Gans, Gijs");
        }
    }
}

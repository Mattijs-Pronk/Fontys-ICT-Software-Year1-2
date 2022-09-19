using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Fitness_diet
{
    public partial class Form1 : Form
    {
        double cal;
        double carb;
        double protein;
        double fat;
        double goodfat;
        double badfat;

        double multifruitCal = 240;
        double multifruitCarb = 32;
        double multifruitProtein = 3.6;
        double multifruitFat = 7.9;
        double multifruitGoodfat = 5.2;

        double shakeCal = 605.8;
        double shakeCarb = 87.3;
        double shakeProtein = 24.4;
        double shakeFat = 24.6;
        double shakeGoodfat = 12.8;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            {
                if (cbMultifruit.Checked == true)
                {
                    cal = multifruitCal;
                    carb = multifruitCarb;
                    protein = multifruitProtein;
                    fat = multifruitFat;
                    goodfat = multifruitGoodfat;
                }

                else if (cbShake.Checked == true)
                {
                    cal = shakeCal;
                    carb = shakeCarb;
                    protein = shakeProtein;
                    fat = shakeFat;
                    goodfat = shakeGoodfat;
                }

                badfat = fat - goodfat;
            }
            lbSolution.Items.Add(Convert.ToString(cal));
            lbSolution.Items.Add(Convert.ToString(carb));
            lbSolution.Items.Add(Convert.ToString(protein));
            lbSolution.Items.Add(Convert.ToString(fat));
            lbSolution.Items.Add(Convert.ToString(goodfat));
            lbSolution.Items.Add(Convert.ToString(badfat));
        }
    }
}

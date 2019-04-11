using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a2
{
    public partial class Form1 : Form
    {
        private double BMI = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void calculateBMI()
        {
            weightTB.Text = "125";
            heightFeetTB.Text = "5";
            heightInchesTB.Text = "3";


            //Math.Pow(2, 2);
            double weight,height, heightF, heightI;
            double.TryParse(weightTB.Text,out weight);
            double.TryParse(heightFeetTB.Text, out heightF);
            double.TryParse(heightInchesTB.Text, out heightI);

            weight = weight * 0.45;//3592;
            height = ((heightF * 12) + heightI) * 0.025;//4;
            double BMI = weight / Math.Pow(height, 2);

            calculatedBMI.Text = BMI.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculateBMI();
            //calculatedBMI.Text = "yeet";
        }
    }
}

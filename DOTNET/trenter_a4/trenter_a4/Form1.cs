using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a4
{
    public partial class Form1 : Form
    {
        const double TaxRate = .076;
        
        public Form1()
        {
            InitializeComponent();
            tipListBox.BeginUpdate();
            tipListBox.Items.Add("None");
            for (int i = 10; i <= 36; i=i+5)
            {
                tipListBox.Items.Add( i.ToString()+"%");
            }

            tipListBox.EndUpdate();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double mealCost;
            double.TryParse(mealCostTB.Text,out mealCost);
            double discountedMealCost = mealCost;
           
            if (military.Checked) { discountedMealCost = discountedMealCost - mealCost * .1; }
            if (student.Checked) { discountedMealCost = discountedMealCost - mealCost * .1; }
            if (senior.Checked) { discountedMealCost = discountedMealCost - mealCost * .1; }
            //String tipString = tipListBox.SelectedValue.ToString();
            //double tip = double.Parse(tipString);
            String tipbox = tipListBox.SelectedItem.ToString().TrimEnd('%');
            double tip;
            double.TryParse(tipbox, out tip);
            tip = tip / 100;
            if(tipbox == "None")
            {
                MessageBox.Show(String.Format("Meal Cost: {0:C}", discountedMealCost));
            }
            else
            {
                double finalMealCost = discountedMealCost + (tip * discountedMealCost);
                MessageBox.Show(String.Format("Meal Cost: {0:C}", finalMealCost));
            }
            //MessageBox.Show("Button clicked \n\r" +
            //    mealCost + "\n\r" +
            //     tipbox + "\r\n" +
            //     "tip" + tip.ToString());
        }

        private void LessThan6_Click(object sender, EventArgs e)
        {
            tipListBox.BeginUpdate();
            tipListBox.Items.Clear();
            //tipListBox.Items.Add("None");
            for (int i = 15; i <= 36; i = i + 5)
            {
                tipListBox.Items.Add(i.ToString() + "%");
            }

            tipListBox.EndUpdate();
        }

        private void MoreThan6_Click(object sender, EventArgs e)
        {
            tipListBox.BeginUpdate();
            tipListBox.Items.Clear();
            tipListBox.Items.Add("None");
            for (int i = 10; i <= 36; i = i + 5)
            {
                tipListBox.Items.Add(i.ToString() + "%");
            }

            tipListBox.EndUpdate();
        }
    }
}

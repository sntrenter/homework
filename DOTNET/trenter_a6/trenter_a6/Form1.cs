using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FtoC();
        }
        void FtoC()
        {
            String F = textBox1.Text;
            double Fnum;
            double.TryParse(F, out Fnum);
            //MessageBox.Show(Fnum.ToString());
            //(Fnum - 32) * (5 / 9);
            MessageBox.Show(F + " degrees F is equal to " +
               ((Fnum - 32.00) * (5.00 / 9.00)).ToString("###.##") + " degrees Celsius");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ShowDivisors();
        }
        void ShowDivisors()
        {
            String snum = textBox2.Text;
            int num;
            int.TryParse(snum, out num);
            String S = "The factors of "+snum+" are: ";
            for(int i = 1;i<num+1 ; i++)
            {
                //MessageBox.Show((num % i).ToString());
                if (num % i == 0) { S += (i).ToString() + ","; }
            }
            MessageBox.Show(S);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (isLeapYear(Int32.Parse(textBox3.Text.ToString()))){ MessageBox.Show(textBox3.Text+" is a leap year!"); }
            else { MessageBox.Show(textBox3.Text + " is not leap year!"); }
        }
        bool isLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Nyears();
        }
        void Nyears()
        {
            int date = DateTime.Now.Year;
            int year = Int32.Parse(textBox4.Text);
            String S = "Leap years in the next " + year.ToString() + " are: ";
            for (int i = date; i < date + year; i++)
            {
                if (isLeapYear(i)) { S += i.ToString() + ","; }
            }
            MessageBox.Show(S);
        }
    }
}

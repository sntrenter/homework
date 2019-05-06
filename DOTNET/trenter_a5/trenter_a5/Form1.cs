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

namespace trenter_a5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        String generateRand()
        {
            Random rand = new Random();
            String temp = number.Text;
            int repeats;
            int.TryParse(temp, out repeats);
            repeats = repeats - 1;
            //MessageBox.Show(repeats.ToString());
            List<String> numberMessage = new List<string> { "", "", "", "", "" };
            for(int i = 0;i <= repeats ;i++ )
            {
                int num = rand.Next(101);
                //MessageBox.Show(num.ToString());
                if (num < 20)      { numberMessage[0] += " " + num.ToString()+","; }
                else if (num < 40) { numberMessage[1] += " " + num.ToString() + ","; }
                else if (num < 60) { numberMessage[2] += " " + num.ToString() + ","; }
                else if (num < 80) { numberMessage[3] += " " + num.ToString() + ","; }
                else if (num < 100){ numberMessage[4] += " " + num.ToString() + ","; }
            }

            String fullString = "Here are your numbers: \n\r" +
               "0-19:" + numberMessage[0] + "\n\r" +
               "20-39:" + numberMessage[1] + "\n\r" +
               "40-59:" + numberMessage[2] + "\n\r" +
               "60-79:" + numberMessage[3] + "\n\r" +
               "80-100:" + numberMessage[4];

            MessageBox.Show(fullString);
            return fullString;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String x = generateRand();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Save File
            //if (File.Exists("numbers.txt")) { File.Delete("numbers.txt"); }
            StreamWriter outputFile;
            outputFile = File.CreateText("numbers.txt");
            String x = generateRand();
            outputFile.Write(x);
            outputFile.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Open File
            //these two lines are the cool way to do it
            //if (File.Exists("numbers.txt")){ System.Diagnostics.Process.Start("numbers.txt"); }
            //else { MessageBox.Show("the file didn't exits"); }
            StreamReader reader = new StreamReader("numbers.txt");
            String text = reader.ReadToEnd();
            MessageBox.Show(text);
            reader.Close();
            
        }
    }
}

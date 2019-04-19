using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String usernameOnFile = "user";
        String passwordOnFile = "123";
        int number3;

        private void Login_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("you need to enter your username and/or password!");
                return;
            }
            if (EquationTB.Text == "") {
                MessageBox.Show("you need to fill in a solution to the captcha!");
                return;
            }
            if (UsernameTB.Text == usernameOnFile && PasswordTB.Text == passwordOnFile && EquationTB.Text == number3.ToString()) {
                MessageBox.Show("you have succesfully logged in!");
            }
            else
            {
                MessageBox.Show("something you entered wasn't quite right!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int number1 = r.Next(1, 10);
            int number2 = r.Next(1, 10);
            number3 = number1 + number2;
            Num1.Text = number1.ToString();
            Num2.Text = number2.ToString();
        }

    }
}

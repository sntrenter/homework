using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a1
{
    public partial class classes : Form
    {
        public classes()
        {
            InitializeComponent();
        }

        private void selfPorterait_Click(object sender, EventArgs e)
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            aboutMe.Text = text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void fallButton_Click(object sender, EventArgs e)
        {
            //fallButton.Text = "list of classes goes here \n is a newline \n \n \n test";
            classList.Text = "list of fall classes goes here \r\n is a newline \n \n \n test";
        }

        private void springButton_Click(object sender, EventArgs e)
        {
            //springButton.Text = "list of classes goes here \n is a newline \n \n \n test";
            classList.Text = "list of spring classes goes here \r\n is a newline \n \n \n test";
        }
    }
}

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
            var text = "My name is Sam Trenter and I am a senior computer science student at Missouri State. My home town is St. Louis Missouri. Right now I am slated to move to Japan next semester with my significat other to teach Japan. In my freetime I like to research digital modeling synthesis.";
            aboutMe.Text = text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void fallButton_Click(object sender, EventArgs e)
        {
            if (fallButton.Text == "Hide Fall Course")
            {
                classList.Text = "";
                fallButton.Text = "Show Fall Course";
            }
            else
            {
                classList.Text = "\r\n\r\nCSC338 - Parallel and dist. computing " +
                    "\r\n CSC388 - Intro to secure computing" +
                    "\r\n CSC515 - Advanced Internet Programing";
                fallButton.Text = "Hide Fall Course";
                springButton.Text = "Show Spring Course";
            }
        }

        private void springButton_Click(object sender, EventArgs e)
        {
            
            if (springButton.Text == "Hide Spring Course")
            {
                classList.Text = "";
                springButton.Text = "Show Spring Course";
            }
            else
            {
                classList.Text = "\r\n\r\nENG210 - Intro to Short Story" +
                    "\r\nCIS200 - Critical and Creative Thinking" +
                    "\r\nMTH333 - Linear Algebra";
                springButton.Text = "Hide Spring Course";
                fallButton.Text = "Show Fall Course";
            }
        }
    }
}

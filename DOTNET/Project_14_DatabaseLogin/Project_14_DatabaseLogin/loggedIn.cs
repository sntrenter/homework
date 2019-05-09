using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_14_DatabaseLogin
{
    public partial class loggedIn : Form
    {
        public loggedIn()
        {
            InitializeComponent();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {

        }

        private void LoggedIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

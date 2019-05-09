using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_14_DatabaseLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@" Data Source=LAPTOP-SR3771M1\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True");
            string query = "select * from logins where username = '"+ textBox1.Text.Trim()+"' and password = '"+textBox2.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                loggedIn objfrmLoggedIn = new loggedIn();
                this.Hide();
                objfrmLoggedIn.Show();

            }
            else
            {
                MessageBox.Show("Please Check your username and password");
            }

         }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

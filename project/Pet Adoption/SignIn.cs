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

namespace Pet_Addaptation
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
            string query = "Select * from Customer Where Name = '"+txtUserName.Text.Trim()+"' and Password = '"+txtPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}

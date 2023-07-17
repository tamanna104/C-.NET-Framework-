using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Pet_Addaptation
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
        string connectionString = @"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill mandatory field");
            else if (txtPassword.Text != txtCPassword.Text)
                MessageBox.Show("Password do not match");
            else if (Regex.IsMatch(txtEmail.Text.Trim(), pattern) == false)
            {
                txtEmail.Focus();
                MessageBox.Show("Invalid Email");
            }
            else
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is successfull");
                        Clear();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Email already exist");
                }
            }
        }
        void Clear()
        {
            txtName.Text = txtEmail.Text = txtAddress.Text = txtPassword.Text = txtCPassword.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text.Trim(), pattern) == false)
            {
                lblerror.ForeColor = Color.Red;
                lblerror.Text = "Invalid Email";
            }
            else
            {
                lblerror.ForeColor = Color.Green;
                lblerror.Text = "Valid email";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
            string query = "Select * from AdminTb Where AdminID = '"+ txtAdminId.Text.Trim() +"' and AccessCD = '" + txtAccessCode.Text.Trim() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                HomeA homeA = new HomeA();
                this.Hide();
                homeA.Show();
            }
            else
            {
                MessageBox.Show("Check your Id And Access Code");
            }
        }

        private void txtAdminId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

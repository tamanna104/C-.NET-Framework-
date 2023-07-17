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
    public partial class HomeA : Form
    {
        public HomeA()
        {
            InitializeComponent();
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
        private void HomeA_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridViewCusA.DataSource = customer.GetAll();
        }
        
        private void lblVeterinarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VeterinarianA().Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridViewCusA.DataSource = customer.search(txtSearch.Text);
        }

        private void dataGridViewCusA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCusA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewCusA.CurrentRow.Selected = true;
                txtName.Text = dataGridViewCusA.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtAddress.Text = dataGridViewCusA.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtEmail.Text = dataGridViewCusA.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            }
        }

        private void pnlPets_Click(object sender, EventArgs e)
        {
            new PetsA().Show();
            this.Close();
        }

        private void pnlCus_Click(object sender, EventArgs e)
        {
            new HomeA().Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new HomeA().Show();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

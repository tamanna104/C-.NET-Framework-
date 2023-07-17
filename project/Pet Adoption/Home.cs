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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {   
            new SignIn().Show();
            this.Close();
        }

        private void lblVeterinarian_Click(object sender, EventArgs e)
        {
            new Veterinarian().Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
        private void Home_Load(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            dataGridViewPetC.DataSource = pet.GetAll();
        }
        

        private void dataGridViewPetC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPetC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewPetC.CurrentRow.Selected = true;
                txtBreed.Text = dataGridViewPetC.Rows[e.RowIndex].Cells["Breed"].FormattedValue.ToString();
                txtPrice.Text = dataGridViewPetC.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            dataGridViewPetC.DataSource = pet.search(txtSearch.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfirmAdoption confirmAdoption = new ConfirmAdoption();
            confirmAdoption.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

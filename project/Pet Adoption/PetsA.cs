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
    public partial class PetsA : Form
    {
        public PetsA()
        {
            InitializeComponent();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeA().Show();
        }

        private void lblVeterinarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VeterinarianA().Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Breed = txtBreed.Text;
            pet.Category = cboxCategory.Text;
            pet.Age = txtAge.Text;
            pet.Price = txtPrice.Text;
            pet.create();
            MessageBox.Show("Successfully saved");
            Clear();
        }
        void Clear()
        {
            txtBreed.Text = cboxCategory.Text = txtAge.Text = txtPrice.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Id = txtId.Text;
            pet.Breed = txtBreed.Text;
            pet.Category = cboxCategory.Text;
            pet.Age = txtAge.Text;
            pet.Price = txtPrice.Text;

            pet.update();
            MessageBox.Show("Successfully Edited");
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Id = txtId.Text;
            pet.delete();
            MessageBox.Show("Successfully Deleted");
            Clear();
        }
        

        private void PetsA_Load(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            dataGridViewPet.DataSource = pet.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            dataGridViewPet.DataSource = pet.search(txtSearch.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new PetsA().Show();
            this.Close();
        }

        private void dataGridViewPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewPet.CurrentRow.Selected = true;
                txtId.Text = dataGridViewPet.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtBreed.Text = dataGridViewPet.Rows[e.RowIndex].Cells["Breed"].FormattedValue.ToString();
                cboxCategory.Text = dataGridViewPet.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                txtAge.Text = dataGridViewPet.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                txtPrice.Text = dataGridViewPet.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBreed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

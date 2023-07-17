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
    public partial class VeterinarianA : Form
    {
        public VeterinarianA()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeA().Show();
        }

        private void PetsA_Click(object sender, EventArgs e)
        {
            new PetsA().Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void VeterinarianA_Load(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            dataGridViewVetA.DataSource = vet.GetAll();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Vet vet = new Vet();
                vet.Name = txtName.Text;
                vet.Email = txtEmail.Text;
                vet.Time_Schedule = txtTimeSc.Text;
                vet.create();
                MessageBox.Show("Successfully saved");
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Email already exist");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            Vet vet = new Vet();
            vet.Id = txtId.Text;
            vet.Name = txtName.Text;
            vet.Email = txtEmail.Text;
            vet.Time_Schedule = txtTimeSc.Text;

            vet.update();
            MessageBox.Show("Successfully Edited");
            Clear();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Id = txtId.Text;
            vet.delete();
            MessageBox.Show("Successfully Deleted");
            Clear();
        }
        
        void Clear()
        {
            txtName.Text = txtEmail.Text = txtTimeSc.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            dataGridViewVetA.DataSource = vet.search(txtSearch.Text);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new VeterinarianA().Show();
            this.Close();
        }

        private void dataGridViewVetA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVetA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewVetA.CurrentRow.Selected = true;
                txtName.Text = dataGridViewVetA.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmail.Text = dataGridViewVetA.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                txtTimeSc.Text = dataGridViewVetA.Rows[e.RowIndex].Cells["Time_Schedule"].FormattedValue.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

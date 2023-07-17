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
    public partial class Veterinarian : Form
    {
        public Veterinarian()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new SignIn().Show();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfirmAppoint confirmAppoint = new ConfirmAppoint();
            confirmAppoint.Show();
        }

        private void lblVeterinarian_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
        private void Veterinarian_Load(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            dataGridViewVet.DataSource = vet.GetAll();
        }
        

        private void dataGridViewVet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewVet.CurrentRow.Selected = true;
                txtVeterinarian.Text = dataGridViewVet.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtSchedule.Text = dataGridViewVet.Rows[e.RowIndex].Cells["Time_Schedule"].FormattedValue.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            new Veterinarian().Show();
            this.Close();
        }

        private void dataGridViewVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

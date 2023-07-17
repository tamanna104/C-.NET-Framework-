using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Addaptation
{
    public partial class ConfirmAppoint : Form
    {
        public ConfirmAppoint()
        {
            InitializeComponent();
        }

        private void ConfirmAppoint_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment Confirmed");
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Veterinarian veterinarian = new Veterinarian();
            veterinarian.Show();
            this.Close();
        }
    }
}

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
    public partial class ConfirmAdoption : Form
    {
        public ConfirmAdoption()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adoption Confirmed");
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void ConfirmAdoption_Load(object sender, EventArgs e)
        {

        }
    }
}

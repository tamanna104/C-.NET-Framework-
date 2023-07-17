using System;
using System.Windows.Forms;

namespace Pet_Addaptation
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 5;
            progressBar.Value = startP;
            lblPercentage.Text = startP + "%";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                SignIn obj = new SignIn();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
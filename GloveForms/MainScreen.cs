
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloveForms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {



        }

        private void PlayButton_Click(object sender, EventArgs e)
        {



        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            
            PatientSignUp patientForm = new PatientSignUp();
            patientForm.Dock = DockStyle.Fill;
            this.Hide();
            patientForm.ShowDialog();
            this.Show();

        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {



        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {



        }

    }
}

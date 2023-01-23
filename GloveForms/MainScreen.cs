
using Microsoft.VisualBasic;

namespace GloveForms
{
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            PatientSignUp patientForm = new PatientSignUp();
            patientForm.Dock = DockStyle.Fill;
            patientForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            patientForm.ShowDialog();
            this.Show();

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

            GetDocument documentForm = new GetDocument();
            documentForm.Dock = DockStyle.Fill;
            documentForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            documentForm.ShowDialog();
            this.Show();

        }

    }
}
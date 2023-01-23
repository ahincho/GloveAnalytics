
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

            int document = int.Parse(Interaction.InputBox("Ingrese su DNI: ", "Iniciar Sesión", "123456789"));
            MessageBox.Show(("Documento: " + document), "Documento Ingresado!", MessageBoxButtons.OK);

        }

    }
}
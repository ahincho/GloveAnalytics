
using System.Media;

namespace GloveForms
{
    public partial class MainScreen : Form
    {

        private static string AppPath = Application.StartupPath.Replace("\\", "/");
        private static string BasePath = AppPath.Substring(0, AppPath.IndexOf("/GloveForms"));
        private static string PathBackgroundSong = "/GloveSounds/We Fell In Love In October.wav";
        private static SoundPlayer BackgroundSong = new SoundPlayer(BasePath + PathBackgroundSong);

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
            if (GetDocument.GetSuccessfulLoginFlag())
            {
                // Here we can merge the forms or GUI with the videogame!
                Application.Exit();
            }
            else
            {
                this.Show();
            }

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            MainScreen.BackgroundSong.PlayLooping();

        }

    }
}
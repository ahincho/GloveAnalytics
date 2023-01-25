
using System.Media;

namespace GloveForms
{

    # pragma warning disable IDE0057, IDE0090, IDE0017
    public partial class MainScreen : Form
    {

        private readonly static string AppPath = Application.StartupPath.Replace("\\", "/");
        private readonly static string BasePath = AppPath.Substring(0, AppPath.IndexOf("/GloveForms"));
        private readonly static string PathBackgroundSong = "/GloveSounds/We Fell In Love In October.wav";
        private readonly static SoundPlayer BackgroundSong = new SoundPlayer(BasePath + PathBackgroundSong);

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
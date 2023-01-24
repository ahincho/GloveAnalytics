
using System.Media;
using WMPLib;

namespace GloveForms
{
    public partial class MainScreen : Form
    {

        SoundPlayer backgroundSong = new SoundPlayer(@"D:/Proyectos Visual Studio/GloveAnalytics/GloveSounds/We Fell In Love In October.wav");

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

        private void MainScreen_Load(object sender, EventArgs e)
        {

            this.backgroundSong.PlayLooping();

        }

    }
}
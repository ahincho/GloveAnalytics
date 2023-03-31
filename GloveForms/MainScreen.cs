
using GloveClasses;
using GloveQueries;
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
            // CreateSessionAndMoves();
        }

        /*
        private void CreateSessionAndMoves()
        {
            for (int i = 0; i < 30; i++)
            {
                DatabaseOperations.InsertRecord(new HandMotion(10, RandomNumber(), RandomNumber(), RandomNumber(), RandomNumber(), RandomNumber(), (int) new Random().Next(1, 6), 1));
            }
        }

        private float RandomNumber()
        {
            Random random = new Random();
            return random.Next(20, 100);
        }
        */

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
                int patientId = documentForm.GetPatientId();
                // Here we can merge the forms or GUI with the videogame!
                Application.Exit();
                // We need to give the path directory of the exec application for our videogame
                // Here i'm trying to execute the DB Browser for SQLite
                // string browser = "C:/Program Files/DB Browser for SQLite/DB Browser for SQLite.exe";
                // System.Diagnostics.Process.Start(browser);
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

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            GetDocument documentForm = new GetDocument();
            documentForm.Dock = DockStyle.Fill;
            documentForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            documentForm.ShowDialog();
            if (GetDocument.GetSuccessfulLoginFlag())
            {
                int patientId = documentForm.GetPatientId();
                documentForm.Close();
                StatisticsScreen statisticsScreen = new StatisticsScreen(patientId);
                statisticsScreen.Dock = DockStyle.Fill;
                statisticsScreen.StartPosition = FormStartPosition.CenterScreen;
                statisticsScreen.ShowDialog();
            }
            this.Show();
        }

    }

}
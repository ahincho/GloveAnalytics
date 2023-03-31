
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GloveClasses;
using GloveQueries;
using ScottPlot;

namespace GloveForms
{

    # pragma warning disable IDE0090
    public partial class StatisticsScreen : Form
    {

        private int PatientId;
        private List<int> SessionsIds = new List<int>();
        private int InvolvedSessions = 4;

        public StatisticsScreen(int patientId)
        {
            InitializeComponent();
            SetPatientId(patientId);
            SetSessionIds();
            textBox1.Text = this.PatientId.ToString();
            MetersBarGraph();
            CoinsBarGraph();
        }

        public void SetPatientId(int patientId)
        {
            this.PatientId = patientId;
        }

        public int GetPatientId()
        {
            return this.PatientId;
        }

        private void SetSessionIds()
        {
            List<int> l = TransactOperations.RecoverSesions(this.PatientId);
            for (int i = 0 ; i < l.Count ; i++)
            {
                SessionsIds.Add(l.ElementAt(i));
                this.listBox1.Items.Add(l.ElementAt(i));
            }
        }

        private void MetersBarGraph()
        {
            var plt = new ScottPlot.Plot(560, 265);
            double[] values = new double[InvolvedSessions + 1];
            for (int i = 0 ; i < InvolvedSessions ; i++)
            {
                values[i] = TransactOperations.RecoverMetersOfSession(this.SessionsIds.ElementAt(i));
            }
            double[] positions = new double[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                positions[i] = InvolvedSessions - i; // From Involved to 1
            }
            string[] labels = new string[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                labels[i] = ("Sesión " + this.SessionsIds.ElementAt(i));
            }
            values[InvolvedSessions] = TransactOperations.RecoverAverageMeters(this.PatientId);
            positions[InvolvedSessions] = 0;
            labels[InvolvedSessions] = "Promedio";
            var bar = plt.AddBar(values, positions);
            plt.XTicks(positions, labels);

            bar.ShowValuesAboveBars = true;
            plt.SetAxisLimits(yMin: 0);
            plt.Style(Style.Seaborn);
            plt.Title("Meters VS Sessions");

            plt.SaveFig("bar_labels1.png");
            pictureBox3.ImageLocation = "bar_labels1.png";
        }

        private void CoinsBarGraph()
        {
            var plt = new ScottPlot.Plot(560, 265);
            double[] values = new double[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                values[i] = TransactOperations.RecoverCoinsOfSession(this.SessionsIds.ElementAt(i));
            }
            double[] positions = new double[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                positions[i] = InvolvedSessions - i; // From Involved to 1
            }
            string[] labels = new string[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                labels[i] = ("Sesión " + this.SessionsIds.ElementAt(i));
            }
            values[InvolvedSessions] = TransactOperations.RecoverAverageCoins(this.PatientId);
            positions[InvolvedSessions] = 0;
            labels[InvolvedSessions] = "Promedio";
            var bar = plt.AddBar(values, positions);
            plt.XTicks(positions, labels);

            bar.ShowValuesAboveBars = true;
            plt.SetAxisLimits(yMin: 0);
            plt.Style(Style.Seaborn);
            plt.Title("Coins VS Sessions");

            plt.SaveFig("bar_labels2.png");
            pictureBox4.ImageLocation = "bar_labels2.png";
        }
        
        private void AnglesDataGrid()
        {

        }

    }

}

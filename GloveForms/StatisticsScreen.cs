
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
        private int InvolvedSessions;

        public StatisticsScreen(int patientId)
        {
            InitializeComponent();
            SetPatientId(patientId);
            SetSessionIds();
            PatientIdOut.Text = this.PatientId.ToString();
            MetersBarGraph();
            CoinsBarGraph();
            AnglesDataGrid();
        }

        private void SetPatientId(int patientId)
        {
            this.PatientId = patientId;
        }

        private int GetPatientId()
        {
            return this.PatientId;
        }

        private void SetInvolvedSessions(int involvedSessions)
        {
            this.InvolvedSessions = involvedSessions;
        }

        private void SetSessionIds()
        {
            List<int> l = TransactOperations.RecoverSesions(this.PatientId);
            for (int i = 0 ; i < l.Count ; i++)
            {
                SessionsIds.Add(l.ElementAt(i));
                this.IdsSessions.Items.Add(l.ElementAt(i));
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
            MetersBySession.ImageLocation = "bar_labels1.png";
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
            CoinsBySession.ImageLocation = "bar_labels2.png";
        }

        private void AnglesDataGrid()
        {
            List<string> fingers = new List<string> { "Thumb", "Index", "Middle", "Ring", "Pinky" };
            // dataGridView1.Columns.Add("AlAzar", "Al Azar");
            List<double> thumbAngles = AnglesByFinger(InvolvedSessions, 1);
            List<double> indexAngles = AnglesByFinger(InvolvedSessions, 2);
            List<double> middleAngles = AnglesByFinger(InvolvedSessions, 3);
            List<double> ringAngles = AnglesByFinger(InvolvedSessions, 4);
            List<double> pinkyAngles = AnglesByFinger(InvolvedSessions, 5);
            List<List<double>> fa = new List<List<double>> { thumbAngles, indexAngles, middleAngles, ringAngles, pinkyAngles };
            for (int i = 0; i < fingers.Count; i++)
            {
                AnglesTable.Rows.Add(fingers[i], fa[i][0], fa[i][1], fa[i][2], fa[i][3]);
            }
            AnglesTable.Rows.Add("Mean");
        }

        private List<double> AnglesByFinger(int involvedSession, int motionType)
        {
            List<double> angles = new List<double>();
            for (int i = 0; i < involvedSession; i++)
            {
                angles.Add(TransactOperations.RecoverAngleOfSession(SessionsIds.ElementAt(i), motionType));
            }
            return angles;
        }

    }

}

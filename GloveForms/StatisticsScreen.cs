
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
using static ScottPlot.Plottable.PopulationPlot;

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
            InitializeGraphs(0);
        }

        // Setters and Geters

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
            this.InvolvedSessions = (involvedSessions > 4 ? 4 : SessionsIds.Count);
        }

        private int GetInvolvedSession()
        {
            return this.InvolvedSessions;
        }

        // Recovering IDs from sessions and how many session we are going to analize
        private void SetSessionIds()
        {
            List<int> l = TransactOperations.RecoverSesions(this.PatientId);
            for (int i = 0 ; i < l.Count ; i++)
            {
                SessionsIds.Add(l.ElementAt(i));
                this.SessionComboBox.Items.Add("Session " + l.ElementAt(i));
            }
            SetInvolvedSessions(SessionsIds.Count);
        }

        private void MetersBarGraph(int sessionSelected)
        {
            // Initialize the ScottPlot Chart, values, positions (order) and labels of the Bar Graph
            var plt = new ScottPlot.Plot(560, 265);
            double[] values = new double[InvolvedSessions + 1];
            // Recovering Meters By Session of Patient
            for (int i = 0 ; i < InvolvedSessions ; i++)
            {
                values[i] = TransactOperations.RecoverMetersOfSession(this.SessionsIds.ElementAt(i + sessionSelected));
            }
            // Initialize Positions in a Desc Order so we would see the last session first
            double[] positions = new double[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                positions[i] = InvolvedSessions - i; // From Involved to 1
            }
            // Link the word Session with the IDs
            string[] labels = new string[InvolvedSessions + 1];
            for (int i = 0; i < InvolvedSessions; i++)
            {
                labels[i] = ("Session " + this.SessionsIds.ElementAt(i + sessionSelected));
            }
            // Adding a new label about average meters of the Patient
            values[InvolvedSessions] = TransactOperations.RecoverAverageMeters(this.PatientId);
            positions[InvolvedSessions] = 0;
            labels[InvolvedSessions] = "Promedio";
            // Giving attributes to the Plot Bar Chart
            var bar = plt.AddBar(values, positions);
            plt.XTicks(positions, labels);
            bar.ShowValuesAboveBars = true;
            plt.SetAxisLimits(yMin: 0);
            // plt.Style(Style.Seaborn);
            plt.Title("Meters VS Sessions");
            plt.SaveFig("bar_labels1.png");
            MetersBySession.ImageLocation = "bar_labels1.png";
        }

        private void CoinsBarGraph()
        {
            // Initialize the ScottPlot Chart, values, positions (order) and labels of the Bar Graph
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
            // plt.Style(Style.Seaborn);
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
            List<List<double>> angles = new List<List<double>> { thumbAngles, indexAngles, middleAngles, ringAngles, pinkyAngles };
            for (int i = 0; i < fingers.Count; i++)
            {
                AnglesTable.Rows.Add(fingers[i], angles[i][0], angles[i][1], angles[i][2], angles[i][3]);
            }
            AnglesTable.Rows.Add("Mean");
            AnglesLineGraph(angles);
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

        private void AnglesLineGraph(List<List<double>> anglesOfFingers)
        {
            var plt = new ScottPlot.Plot(625, 320);
            // sample data
            double[] xAxis = { 0, 1, 2, 3 };
            for (int i = 0; i < anglesOfFingers.Count; i++)
            {
                plt.AddScatter(xAxis, anglesOfFingers.ElementAt(i).ToArray());
            }
            // customize the axis labels
            plt.Title("ScottPlot Quickstart");
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.XAxis.Ticks(false);
            plt.Legend();
            plt.SaveFig("quickstart_scatter.png");
            AnglesLineChart.ImageLocation = "quickstart_scatter.png";
        }

        private void InitializeGraphs(int sessionSelected)
        {
            SetInvolvedSessions(SessionsIds.Count - sessionSelected);
            MetersBarGraph(sessionSelected);
            CoinsBarGraph();
            AnglesTable.Rows.Clear();
            AnglesDataGrid();
        }

        private void SessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeGraphs(SessionComboBox.SelectedIndex);
        }

    }

}

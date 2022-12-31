using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba2
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series DataSer_1;
        System.Windows.Forms.DataVisualization.Charting.Series DataSer_2;
        System.Windows.Forms.DataVisualization.Charting.Series DataSer_3;

        int K, phi;

        const int N = 1024;
        
        public MainForm()
        {
            InitializeComponent();
            BuildGraph();
        }

        private void BuildGraph()
        {
            Graphics.Series.Clear();

            DataSer_1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataSer_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            DataSer_1.Color = Color.Black;
            DataSer_1.BorderWidth = 3;

            DataSer_2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataSer_2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            DataSer_2.Color = Color.Red;
            DataSer_2.BorderWidth = 3;

            DataSer_3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataSer_3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            DataSer_3.Color = Color.Green;
            DataSer_3.BorderWidth = 3;

            KValue.Text = Convert.ToString(KTracker.Value);
            PhiValue.Text = Convert.ToString(PhiTracker.Value);

            K = KTracker.Value;
            phi = PhiTracker.Value;

            for (int M = K; M <= 2 * N; M++)
            {
                double rms_1 = 0, rms_2 = 0;
                double Re = 0, Im = 0;

                for (int n = 0; n <= M; n++)
                {
                    double t = Math.Sin(2 * Math.PI * n / N + (double)phi / 180 * Math.PI);

                    rms_1 += Math.Pow(t, 2);
                    rms_2 += t;

                    Re += t * Math.Cos(2 * Math.PI * n / M);
                    Im += t * Math.Sin(2 * Math.PI * n / M);
                }

                DataSer_1.Points.AddXY(M, 0.707 - Math.Sqrt(rms_1 / (M + 1)));
                DataSer_2.Points.AddXY(M, 0.707 - (Math.Sqrt(rms_1 / (M + 1) - Math.Pow(rms_2 / (M + 1), 2))));
                DataSer_3.Points.AddXY(M, 1 - Math.Sqrt(Math.Pow(2 * Re / M, 2) + Math.Pow(2 * Im / M, 2)));
            }               

            Graphics.ResetAutoValues();

            Graphics.Series.Add(DataSer_1);
            Graphics.Series.Add(DataSer_2);
            Graphics.Series.Add(DataSer_3);
        }

        private void Tracker_Scroll(object sender, EventArgs e)
        {
            BuildGraph();
        }
    }
}
